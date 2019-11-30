using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantedProjects
{
    class Sahip
    {
        public int sure { get; set; }
        public int maliyet { get; set; }
        public Sahip()
        {
            sure = 4;
            maliyet = 2;

        }
        public void MSAzalt(int birim,int birim2)
        {
            maliyet = maliyet - birim;
            sure = sure - birim2;
        }
        public string Sorgula(int sure, int maliyet, int mide, int mutluluk)
        {
            if (sure <= 0 || maliyet <= 0 || mide >= 100 || mutluluk >= 100)
            {
                return "Bu işlemi gerçekleştiremezsiniz";
            }
            return "";
        }
    }
}
