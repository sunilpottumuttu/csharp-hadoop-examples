using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldMR.Mapper;
using HelloWorldMR.Reducer;
using HelloWorldMR.Job;
using HelloWorldMR.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace HelloWorldMR.Driver
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
