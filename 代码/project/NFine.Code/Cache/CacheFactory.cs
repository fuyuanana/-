


 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueGene.Code
{
    public class CacheFactory
    {
        public static ICache Cache()
        {
            return new Cache();
        }
    }
}
