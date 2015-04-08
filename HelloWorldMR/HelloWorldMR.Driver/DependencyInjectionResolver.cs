using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace HelloWorldMR.Driver
{
    public class DependencyInjectionResolver
    {
        static DependencyInjectionResolver()
        {
            Container = new UnityContainer().LoadConfiguration();
        }

        public static IUnityContainer Container { get; private set; }

        public static T Resolve<T>()
        {
            if (!Container.IsRegistered(typeof(T)))
            {
                throw new InvalidOperationException(
                    string.Format(
                        "Unable to resolve a class for interface type {0}. Registration settings might be missing in the application configuration file for this type.", typeof(T).FullName));
            }

            return Container.Resolve<T>();
        }
    }
}