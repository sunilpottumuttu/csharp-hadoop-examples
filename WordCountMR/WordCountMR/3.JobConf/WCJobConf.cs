using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Hadoop.MapReduce;
using WordCountMR.Mapper;
using WordCountMR.Reducer;


namespace WordCountMR.JobConf
{
    public class WCJobConf:HadoopJob<WCMapper,WCReducer>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            var jobConf = new HadoopJobConfiguration() 
            { 
                InputPath = "/in", 
                OutputFolder = "/out" ,
            };
            return jobConf;
        }

    }
}
