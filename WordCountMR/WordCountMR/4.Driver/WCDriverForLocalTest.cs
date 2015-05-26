using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCountMR.Interfaces;
using WordCountMR.Mapper;
using WordCountMR.Reducer;

namespace WordCountMR.Driver
{
    public class WCDriverForLocalTest:IDriver
    {
        void IDriver.Run()
        {
            var inputArray = new[]
            {
                "Hello, Andy",
                "Hello, andy",
                "Hello, why doesn't this work!",
                "Hello, Andy",
                "Hello, chickenface",
                "Hello, Andy"
            };
            var output = StreamingUnit.Execute<WCMapper, WCReducer>(inputArray);

            Console.WriteLine("Mapper Result");
            foreach (var mapperResult in output.MapperResult)
            {
                Console.WriteLine(mapperResult);
            }
            Console.WriteLine("************************");

            Console.WriteLine("Reducer Result");
            foreach (var reducerResult in output.ReducerResult)
            {
                Console.WriteLine(reducerResult);
            }
            Console.WriteLine("************************");

            Console.ReadLine();
        }
    }
}
