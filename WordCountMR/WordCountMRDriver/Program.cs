using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCountMR.Interfaces;
using WordCountMR.Util;

namespace WordCountMRDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = DependencyInjectionResolver.Resolve<IDriver>();
            driver.Run();
        }
    }
}
