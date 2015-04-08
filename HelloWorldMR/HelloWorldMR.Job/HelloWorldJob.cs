using HelloWorldMR.Mapper;
using HelloWorldMR.Reducer;
using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldMR.Job
{
    public class HelloWorldJob : HadoopJob<HelloWorldMapper, HelloWorldReducer>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            var jobConf = new HadoopJobConfiguration()
            {
                InputPath = "/in",
                OutputFolder = "/out",
            };
            return jobConf;
        } 
    }
}
