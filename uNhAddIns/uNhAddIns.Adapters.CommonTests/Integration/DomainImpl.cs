using System;
using System.Collections.Generic;
using Microsoft.Practices.ServiceLocation;
using NHibernate;

namespace uNhAddIns.Adapters.CommonTests.Integration
{
	public class DaoFactory : IDaoFactory
	{
		private readonly IServiceLocator sc;

		public DaoFactory(IServiceLocator serviceLocator)
		{
			sc = serviceLocator;
		}

		public TDao GetDao<TDao>()
		{
			return sc.GetInstance<TDao>();
		}
	}

	public class SillyDao : ISillyDao
	{
		private readonly ISessionFactory factory;

		public SillyDao(ISessionFactory factory)
		{
			this.factory = factory;
		}

		public Silly Get(int id)
		{
			return factory.GetCurrentSession().Get<Silly>(id);
		}

		public IList<Silly> GetAll()
		{
			return factory.GetCurrentSession().CreateQuery("from Silly").List<Silly>();
		}

		public Silly MakePersistent(Silly entity)
		{
			factory.GetCurrentSession().SaveOrUpdate(entity);
			return entity;
		}

		public void MakeTransient(Silly entity)
		{
			factory.GetCurrentSession().Delete(entity);
		}
	}

	[PersistenceConversational]
	public class SillyCrudModel : ISillyCrudModel
	{
		private readonly IDaoFactory factory;

		public SillyCrudModel(IDaoFactory factory)
		{
			if (factory == null)
			{
				throw new ArgumentNullException("factory");
			}
			this.factory = factory;
		}

		protected ISillyDao EntityDao
		{
			get { return factory.GetDao<ISillyDao>(); }
		}

		#region Implementation of ISillyCrudModel
		[PersistenceConversation]
		public virtual IList<Silly> GetEntirelyList()
		{
			return EntityDao.GetAll();
		}

		[PersistenceConversation]
		public virtual Silly GetIfAvailable(int id)
		{
			return EntityDao.Get(id);
		}

		[PersistenceConversation]
		public virtual Silly Save(Silly entity)
		{
			return EntityDao.MakePersistent(entity);
		}

		[PersistenceConversation]
		public virtual void Delete(Silly entity)
		{
			EntityDao.MakeTransient(entity);
			entity.Id = 0;
		}

		[PersistenceConversation(ConversationEndMode = EndMode.CommitAndContinue)]
		public virtual void ImmediateDelete(Silly entity)
		{
			EntityDao.MakeTransient(entity);
			entity.Id = 0;
		}

		[PersistenceConversation(ConversationEndMode = EndMode.End)]
		public virtual void AcceptAll()
		{
			// method for use-case End
		}

		[PersistenceConversation(ConversationEndMode = EndMode.Abort)]
		public virtual void Abort()
		{
			// method for use-case Abort
		}

		#endregion
	}


}