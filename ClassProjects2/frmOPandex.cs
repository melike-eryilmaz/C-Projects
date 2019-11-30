using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjects2
{
    class frmOPandex
    {
        
        public ArrayList İslemYap(ArrayList array)
        {
            ArrayList list = new ArrayList();
            double sonuc = 0;

            for (int i = 0; i <array.Count ; i++)
            {
                string ifade = Convert.ToString(array[i]);
                if (ifade.Contains('+'))
                {
                    string[] dizi = ifade.Split('+');
                    sonuc = Convert.ToSingle(dizi[0]);
                    for (int j = 1; j < dizi.Count(); j++)
                    {
                        sonuc = sonuc +Convert.ToInt32(dizi[j]);
                    }
                    list.Add(sonuc);


                }
                else if (ifade.Contains('-'))
                {
                    string[] dizi = ifade.Split('-');
                    sonuc = Convert.ToSingle(dizi[0]);
                    for (int j =1; j < dizi.Count(); j++)
                    {
                        sonuc = sonuc - Convert.ToInt32(dizi[j]);
                    }
                    list.Add(sonuc);


                }
                else if (ifade.Contains('/'))
                {
                    string[] dizi = ifade.Split('/');
                    sonuc = Convert.ToSingle(dizi[0]);
                    for (int k = 1; k < dizi.Count(); k++)
                    {
                        sonuc = sonuc / Convert.ToInt32(dizi[k]);
                    }
                    list.Add(sonuc);


                }
                else if (ifade.Contains('*'))
                {
                    string[] dizi = ifade.Split('*');
                    sonuc = Convert.ToSingle(dizi[0]);
                    for (int l = 1; l < dizi.Count(); l++)
                    {
                        sonuc = sonuc * Convert.ToInt32(dizi[l]);
                    }
                    list.Add(sonuc);


                }
                else
                {

                }


            }

            return list;


        }
    }
}
