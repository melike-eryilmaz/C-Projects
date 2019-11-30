using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjects2
{
    class Karsilastirma
    { 
        public ArrayList Karsilastir(ArrayList array,ArrayList array1)
        {
            ArrayList yeni = new ArrayList();
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array1.Count; j++)
                {
                    if (Convert.ToInt32(array1[i]) == Convert.ToInt32(array1[j]))
                    {
                        yeni.Add(array1[j]);
                    }
                    
                }
            }
            return yeni;

        }
    }
}
