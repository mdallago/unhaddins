using System;
using System.Collections.Generic;
using Castle.Core;

namespace uNhAddIns.ComponentBehaviors.Castle.Configuration
{
    public class ProxyInformation
    {
        public ProxyInformation(ICollection<Type> additionalInterfaces,
								ICollection<Type> interceptorReferences)
        {
            AdditionalInterfaces = additionalInterfaces;
            Interceptors = interceptorReferences;
        }

        public ICollection<Type> AdditionalInterfaces { get; private set; }
        public ICollection<Type> Interceptors { get; private set; }
    }
}