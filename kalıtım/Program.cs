using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    public class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    public class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Ogretmen ogr = new Ogretmen
            {
                Ad = "Ahmet",
                Soyad = "Öz",
                Brans = "Matematik"
            };
           

            OkulPersoneli per = ogr; // !!!
            Console.WriteLine(per.Ad);
        }
    }
  
            
}
    
