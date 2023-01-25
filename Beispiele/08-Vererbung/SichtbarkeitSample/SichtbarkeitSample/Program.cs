using DiverseKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SichtbarkeitSample
{
    class Klasse2
    {
        static void MeineMethode()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrivateKlasse privateKlasse = new PrivateKlasse();
            InternalKlasse internalKlasse = new InternalKlasse();




            PublicKlasse publicKlasse = new PublicKlasse();
            publicKlasse.MeinePublicMethode();

   
        }



        private class PrivateKlasse
        {
            public void MeinePublicMethode()
            {

            }
        }
    }

    

    
}
