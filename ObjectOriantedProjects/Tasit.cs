using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantedProjects
{
    class Tasit
    {
        public int TasitId{ get; set; }
        public float YukMiktari { get; set; }
        public float YakitMiktari { get; set; }
        public float Agirlik { get; set; }
        public float Yukseklik { get; set; }
        public float Genislik { get; set; }
        public string Renk { get; set; }
    }
    class KaraTasiti : Tasit
    {
        public byte Tekerlek { get; set; }
        public string DireksiyonTipi { get; set; }
        public float CezaMiktari { get; set; }

    }
    class HavaTasiti : Tasit
    {
        public void Uc() { }

    }
    class DenizTasiti : Tasit
    {
        public int MyProperty { get; set; }
    }
    class Otomobil:KaraTasiti,IHesaplama
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public int KmHesapla(short km,string kasaTipi)
        {
            throw new NotImplementedException();
        }

        public void YakitHesapla(float sabitDegeri, string iklim, bool aracTipi)
        {
            throw new NotImplementedException();
        }
    }
   
    class Ucak : HavaTasiti
    {
        public string Tur { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

    }
    class Balon : HavaTasiti
    {
        public int MyProperty { get; set; }
    }
    class Helikopter : HavaTasiti
    {
        public int PervaneSayisi { get; set; }
    }
    class Yelkenli : DenizTasiti
    {
        public int Yelken { get; set; }

    }
}
