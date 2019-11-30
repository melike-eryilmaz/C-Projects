using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjects2
{
    class Operation
    {
        public string İslemYap(string ifade)
        {
            double sonuc=0;
            if (ifade.Contains('+'))
            {
                string[] dizi = ifade.Split('+');
                foreach (var item in dizi)
                {
                    sonuc = sonuc+ Convert.ToInt32(item);

                }

            }
           else  if (ifade.Contains('-'))
            {
                string[] dizi = ifade.Split('-');
                sonuc = Convert.ToSingle(dizi[0]);
                for (int i = 1; i < dizi.Count(); i++)              
                {
                    sonuc = sonuc - Convert.ToInt32(dizi[i]);

                }
            }
           else  if (ifade.Contains('/'))
            {
                string[] dizi = ifade.Split('/');
                sonuc = Convert.ToSingle(dizi[0]);
                int sayi = 1;
                while(sayi< dizi.Count()){
                    sonuc /= Convert.ToInt32(dizi[sayi]);
                    sayi++;
                }
                //for (int i = 1; i < dizi.Count(); i++)
                //{
                //    sonuc = sonuc / Convert.ToInt32(dizi[i]);

                //}

            }
            else  if (ifade.Contains('*'))
            {
                string[] dizi = ifade.Split('*');

                sonuc= Convert.ToSingle(dizi[0]);
                //for (int i = 1; i < dizi.Count(); i++)
                //{
                //    sonuc = sonuc *Convert.ToInt32(dizi[i]);

                //}
                int sayi = 1;
                do
                {
                    sonuc = sonuc*Convert.ToInt32(dizi[sayi]);
                    sayi++;

                } while (sayi<dizi.Count());

            }
            else
            {
                return "yanlış değer girdiniz";
            }          
            return sonuc.ToString();
        }
    }
}
