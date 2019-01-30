using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire
{
    class Program
    {
        static void Main(string[] args)
        {

            compte c = new compte(25,7,"dhjy","M",700,200,100);
           
            
                Console.WriteLine("1-decouvert");
                Console.WriteLine("2-debuter");
                Console.WriteLine("3-crediter");
                Console.WriteLine("donner votre choix");
                int i =int.Parse(Console.ReadLine());
                switch(i){
                    case 1:c.decouvert();
                        break;
                        case 2:c.debuter(2.5);
                        break;
                        case 3:c.crediter(6.5);break;
                        default:Console.WriteLine("erreur");break;
                         }





     

        }
    }
}
