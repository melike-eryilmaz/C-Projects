using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjects2
{
    class RandomExample
    {
        public ArrayList Sirala(ArrayList array)
        {
            int  gecici;
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i+1; j <array.Count ; j++)
                {
                    if (Convert.ToInt32(array[i]) > Convert.ToInt32(array[j]))
                    {
                        gecici = Convert.ToInt32(array[i]);
                        array[i] = array[j];                
                        array[j] = gecici;
                    }
                }
               
            }
            return array;
        }
    }
}
