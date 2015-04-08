using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldMR.Mapper;
using HelloWorldMR.Reducer;
using HelloWorldMR.Job;

namespace HelloWorldMR.Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            IHadoop hadoop = Hadoop.Connect();
            hadoop.MapReduceJob.ExecuteJob<HelloWorldJob>();
            Console.Read();
        }
    }
}
