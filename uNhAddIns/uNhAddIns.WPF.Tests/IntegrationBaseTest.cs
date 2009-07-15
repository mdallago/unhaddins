﻿using Castle.Windsor;
using NHibernate.Cfg;
using NHibernate.Engine;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using uNhAddIns.CastleAdapters.EnhancedBytecodeProvider;
using uNhAddIns.WPF.EntityNameResolver;

namespace uNhAddIns.WPF.Tests
{
    public class IntegrationBaseTest
    {
        protected WindsorContainer container;
        protected Configuration cfg;
        protected ISessionFactoryImplementor sessions;

        //static IntegrationBaseTest()
        //{
           
        //}


        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            container = new WindsorContainer();
            ConfigureWindsorContainer();

            Environment.UseReflectionOptimizer = true;
            Environment.BytecodeProvider = new EnhancedBytecode(container);

            cfg = new Configuration();
            cfg.RegisterEntityNameResolver();
            cfg.AddAssembly(typeof(IntegrationBaseTest).Assembly);
            cfg.Configure();
            
            new SchemaExport(cfg).Create(false, true);
            sessions = (ISessionFactoryImplementor)cfg.BuildSessionFactory();
        }

        protected virtual void ConfigureWindsorContainer()
        {}

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            new SchemaExport(cfg).Drop(false, true);
            sessions.Close();
            sessions = null;
            cfg = null;
        }
    }
}