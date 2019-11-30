using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjects2
{
    class YazKampi

    {
        public YazKampi()
        {

        }
        ~YazKampi()
        {
            GC.Collect();//GARBAGE COOLECTOR İNSTANCE TEMİZLER
        }
    }
}
