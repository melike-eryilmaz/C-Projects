using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantedProjects
{
    class İslem
    {
        private string islem { get; set; }
        public string Islem {
                    get
                {
                    return islem;
                
                }
                set {
                double islem2 = 0;
                if (value.Contains('+'))
                {
                    string[] dizi = value.Split('+');
                    foreach (var item in dizi)
                    {
                        islem2 = islem2 + Convert.ToInt32(item);

                    }
                    islem = islem2.ToString();
                }
                else if (value.Contains('-'))
                {
                    string[] dizi = value.Split('-');
                    islem2 = Convert.ToSingle(dizi[0]);
                    for (int i = 1; i < dizi.Count(); i++)
                    {
                        islem2 = islem2 - Convert.ToInt32(dizi[i]);

                    }
                    islem = islem2.ToString();

                }
                else if (value.Contains('/'))
                {
                    string[] dizi = value.Split('/');
                    islem2 = Convert.ToSingle(dizi[0]);
                    int sayi = 1;
                    while (sayi < dizi.Count())
                    {
                        islem2/= Convert.ToInt32(dizi[sayi]);
                        sayi++;
                    }
                    islem = islem2.ToString();



                }
                else if (value.Contains('*'))
                {
                    string[] dizi = value.Split('*');

                    islem2 = Convert.ToSingle(dizi[0]);                 
                    int sayi = 1;
                    do
                    {
                        islem2 = islem2 * Convert.ToInt32(dizi[sayi]);
                        sayi++;

                    } while (sayi < dizi.Count());
                    islem = islem2.ToString();


                }


            } }
    }
}
