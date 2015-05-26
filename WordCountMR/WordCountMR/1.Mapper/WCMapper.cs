using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountMR.Mapper
{
    public class WCMapper: MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            Console.WriteLine("inputLine" + inputLine);
            var words = inputLine.Split(new char[]{' '}).ToList();                            
            words.ForEach((word)=> context.EmitKeyValue(word,"1"));
        }
        
    }
}
