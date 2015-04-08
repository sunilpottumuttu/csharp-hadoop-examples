using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldMR.Mapper;
using HelloWorldMR.Reducer;
using HelloWorldMR.Job;
using Microsoft.Hadoop.MapReduce;
using HelloWorldMR.Interfaces;

namespace HelloWorldMR.Driver
{
    public class LocalFSDriver:IDriver
    {
        public void Run()
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
            var output = StreamingUnit.Execute<HelloWorldMapper, HelloWorldReducer>(inputArray);

            Console.WriteLine("Map");
            foreach (var mapperResult in output.MapperResult)
            {
                Console.WriteLine(mapperResult);
            }

            Console.WriteLine("Reduce");
            foreach (var reducerResult in output.ReducerResult)
            {
                Console.WriteLine(reducerResult);
            }

            Console.ReadLine();
        }
    }
}
