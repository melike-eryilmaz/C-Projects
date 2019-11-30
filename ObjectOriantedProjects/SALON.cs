using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantedProjects
{
    class SALON
    {
        public int koltukSayısı { get; set; }
        public int bakiye{ get; set; }
        public int bosKoltukSalon{ get; set; }
        public string SalonOlustur(string salonadi,string koltuk)
        {
            koltukSayısı = Convert.ToInt32(koltuk);
            bosKoltukSalon = Convert.ToInt32(koltuk);

            return salonadi +" adında ve "+koltuk+" koltuklu salon oluşturuldu.";
        }
        public string KoltukSat(bool indirim)

        {
            bosKoltukSalon--;

            if (indirim==true)
            {
                bakiye = bakiye + 10;
            }
            else
            {
            bakiye = bakiye + 20;

            }
            return "koltuk satıldı "+" Bakiye: "+bakiye;
        }
        public string Koltukİptal()
        {
            bosKoltukSalon++;
            bakiye = bakiye -20;
            return "koltuk iptal edildi"+ "Bakiye: " + bakiye;
        }
        public string BosKoltukGoruntule()
        {
            return bosKoltukSalon+" adet boş koltuk kaldı.";
        }
        public string Guncel()
        {
            return "Güncel Bakiye:"+bakiye+"\n"+ "Kalan koltuk:"+bosKoltukSalon;
        }
    }
}
