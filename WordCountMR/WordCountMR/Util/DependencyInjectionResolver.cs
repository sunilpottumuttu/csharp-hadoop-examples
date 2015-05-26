using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace WordCountMR.Util
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
