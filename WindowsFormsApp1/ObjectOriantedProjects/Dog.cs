using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantedProjects
{
    class Dog
    {
        public string name { get; set; }
        public int Mide{ get; set; }
        public int mutluluk{ get; set; }

        public Dog()
        {
            Mide = 80;
            mutluluk = 80;
        }
       
        public void MamaVer() {
            Mide += 20;
        }
        public void EtVer() {
            Mide += 30;
        }
        public void Gezdir() {
            mutluluk +=20;
        }
        public void Sev() {
            mutluluk += 5;
        }
        public void Nextday(int m1,int m2)
        {
            Mide = m1 - 30;
            mutluluk = m2 - 20;
        }
    }
}
