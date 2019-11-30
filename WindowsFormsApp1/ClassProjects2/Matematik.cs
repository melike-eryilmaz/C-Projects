using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjects2
{
    class Matematik
    {
    public String Topla(int sayi1,int sayi2)
        {

            return (sayi1 + sayi2).ToString();

        }
    public String Cikar(int sayi1, int sayi2)
        {

            return (sayi1-sayi2).ToString();

        }
    public String Bol(double sayi1, double sayi2)
        {

            return (sayi1 / sayi2).ToString();

        }
    public String Carp(int sayi1, int sayi2)
        {

            return (sayi1 * sayi2).ToString();

        }
    public String KareAl(int sayi1)
        {

            return (sayi1 *sayi1).ToString();

        }
    public String KupAl(int sayi1)
        {

            return (sayi1*sayi1*sayi1).ToString();

        }
    }
}
