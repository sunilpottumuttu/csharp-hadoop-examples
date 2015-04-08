using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldMR.Mapper
{
    public class HelloWorldMapper :MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            //example input: Hello, Andy
            if (!inputLine.StartsWith("Hello, ")) return;

            var key = inputLine.Substring(7);
            if (key.EndsWith(".")) key = key.Trim('.');

            context.EmitKeyValue(key, "1");//we are going to count instances, the value is irrelevant
        } 
    }
}
