using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCountMR.Interfaces;
using WordCountMR.JobConf;

namespace WordCountMR.Driver
{
    public class WCDriver:IDriver
    {
        public void Run()
        {
            Uri uri = new Uri(@"https://10.0.0.4");
            //IHadoop hdp = Hadoop.Connect(uri,"cloudera","cloudera");
            IHadoop hdp = Hadoop.Connect();
            hdp.MapReduceJob.ExecuteJob<WCJobConf>();
            Console.Read();
        }
    }
}
