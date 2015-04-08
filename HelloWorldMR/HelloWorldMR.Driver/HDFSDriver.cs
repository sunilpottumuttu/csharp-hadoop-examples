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
    public class HDFSDriver:IDriver
    {
        public void Run()
        {
            IHadoop hadoop = Hadoop.Connect();
            hadoop.MapReduceJob.ExecuteJob<HelloWorldJob>();
            Console.Read();

        }

        
    }
}
