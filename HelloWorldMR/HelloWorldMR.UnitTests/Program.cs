using HelloWorldMR.Mapper;
using HelloWorldMR.Reducer;
using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldMR.UnitTests
{
    class Program
    {
        static void Main(string[] args)
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
            var output = StreamingUnit.Execute<HelloWorldMapper,HelloWorldReducer>(inputArray);

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
