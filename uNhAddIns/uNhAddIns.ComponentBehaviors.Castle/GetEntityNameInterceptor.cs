using Castle.Core;
using Castle.Core.Interceptor;
using uNhAddIns.NHibernateTypeResolver;

namespace uNhAddIns.ComponentBehaviors.Castle
{
    public class GetEntityNameInterceptor : IInterceptor
    {
        #region IInterceptor Members

        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.DeclaringType.Equals(typeof(IWellKnownProxy)) )
            {
                if(invocation.Method.Name == "get_EntityName")
                {
                    invocation.ReturnValue = invocation.Proxy.GetType().BaseType.FullName;    
                }
                else if(invocation.Method.Name == "get_EntityType")
                {
                    invocation.ReturnValue = invocation.Proxy.GetType().BaseType;                   
                }
            }
            else
            {
                invocation.Proceed();
            }
        }

        #endregion
    }
}