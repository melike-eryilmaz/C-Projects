using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjects2
{
    class İslemler
    {
        public int İslemYap(ArrayList list,ArrayList list2)
        {

            int sonuc = 0;
                if (Convert.ToBoolean(list2[0])==true)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        sonuc += Convert.ToInt32(list[i]);
                    }
                }
                if (Convert.ToBoolean(list2[1]) == true)
                {
                    int  sonuc1 = Convert.ToInt32(list[0]);
                    for (int i = 1; i < list.Count; i++)
                    {
                        sonuc1 -= Convert.ToInt32(list[i]);
                    }
                return sonuc1;

                }
                if (Convert.ToBoolean(list2[2]) == true)
                {
                    int sonuc2 = Convert.ToInt32(list[0]);
                    for (int i = 1; i < list.Count; i++)
                    {
                        
                        sonuc2 *= Convert.ToInt32(list[i]);
                        
                    }
                return sonuc2;
                }
                if (Convert.ToBoolean(list2[3]) == true)
                {
                     int sonuc3 = Convert.ToInt32(list[0]);
                    for (int i = 1; i < list.Count; i++)
                        {
                            sonuc3 /= Convert.ToInt32(list[i]);
                            return sonuc3;
                        }

                }

            
            return sonuc;
        }
    }
}
