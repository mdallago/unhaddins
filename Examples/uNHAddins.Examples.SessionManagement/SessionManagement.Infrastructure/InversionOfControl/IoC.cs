﻿using System;

namespace SessionManagement.Infrastructure.InversionOfControl
{
	// Simple IoC implementation to serve the purposes of the Example only
	public static class IoC
	{
		private static IDependencyResolver resolver;

		public static void RegisterResolver(IDependencyResolver dependencyResolver)
		{
			resolver = dependencyResolver;
		}

		public static T Resolve<T>()
		{
			return resolver.Resolve<T>();
		}

		public static void RegisterImplementationOf(string id, Type service, Type implementation, LifeStyle lifeStyle)
		{
			resolver.RegisterImplementationOf(id, service, implementation, lifeStyle);
		}

		public static void RegisterImplementationOf(string id, Type service, Type implementation)
		{
			resolver.RegisterImplementationOf(id, service, implementation);
		}
	}
}