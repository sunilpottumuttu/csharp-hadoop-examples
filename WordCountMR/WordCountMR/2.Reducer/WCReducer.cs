using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Hadoop.MapReduce;

namespace WordCountMR.Reducer
{
    public class WCReducer:ReducerCombinerBase
    {
        public override void Reduce(string key, IEnumerable<string> values, ReducerCombinerContext context)
        {
            Console.WriteLine("Starting Reducer");
            context.EmitKeyValue(key, values.Count().ToString());
            Console.WriteLine("Completed Reducer");
        }
    }
}
