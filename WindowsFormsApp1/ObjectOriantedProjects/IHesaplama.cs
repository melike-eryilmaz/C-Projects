using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantedProjects
{
    interface IHesaplama
    {
        void YakitHesapla(float sabitDegeri,string iklim,bool aracTipi);
        int KmHesapla(short km,string kasaTipi);
    }
}
