using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjects2
{
    class İslem
    {
        //public string İslemYap(int sayi)
        //{
        //    if (sayi%2==0)
        //    {
        //        if (sayi>0)
        //        {
        //            return " sayi çift ve pozitif";

        //        }
        //        else
        //        {
        //            return " sayi çift ve negatif";

        //        }


        //    }
        //    else
        //    {
        //        if (sayi > 0)
        //        {
        //            return " sayi tek ve pozitif";

        //        }
        //        else
        //        {
        //            return " sayi tek ve negatif";

        //        }
        //    }
        //}
        //public string İslem1( string sayi)
        //{
        //    return tekCift(sayi) +" ve "+ İsaret(sayi);
        //}
        //private string tekCift(string sayi)
        //{
        //    if (Convert.ToInt32(sayi)%2==0)
        //    {
        //        return "çift";
        //    }
        //    else
        //    {
        //        return "tek";
        //    }
        //}
        //private string İsaret(string sayi)
        //{
        //    if (Convert.ToInt32(sayi) > 0)
        //    {
        //        return "pozitif";
        //    }
        //    else
        //    {
        //        rturn "negatif";
        //    }
        //}
        //public string Kontrol(string ifade1,string ifade2,string ifade3)
        // {
        //     int baslangic = Convert.ToInt32(ifade1);
        //     int bitis = Convert.ToInt32(ifade2);
        //     int sayi = Convert.ToInt32(ifade3);
        //     if (sayi>=baslangic && sayi<=bitis)
        //     {
        //         return "sayi " + ifade1 + "-" + ifade2 + " aralığındadır";
        //     }
        //     else
        //     {
        //         return "sayi aralık dışındadır";
        //     }



        // }
        ////public string Salak()
        //{
        //    //int count = 0;
        //    //for (int i = sayi1; i <= sayi2; i++)
        //    //{
        //    //    count++;
        //    //    if (i == sayi3)
        //    //    {
        //    //        return "arasında" + count + ". sıradadır";
        //    //    }
        //    //    return "arasında değil";
        //    //}
        
        public String Control(ArrayList array,int sayi)
        {
            int count = 0;
            for (int i = Convert.ToInt32(array[0]); i <= array.Count; i++)
            {
                count++;
                if (i == sayi)
                {
                    return "arasında" + count + ". sıradadır";
                }
            }

            return "arasında değil";

        }
    }

        
    }

