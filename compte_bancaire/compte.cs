using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire
{
    class compte
    {private int num;
     private static int nbcompte;
     private string prt;
     private string typeprt;
     private double solde;
     private double decmax;
     private double debmax;

     public int Num
     {
         get
         {
             return num;
         }
     }

     public static int Nbcompte
     {
         get { return nbcompte; }
     }


     public string Prt
     {
         get { return prt; }
     }



     public string Typeprt
     {
         get { return typeprt; }
         set { typeprt = value; }

     }

        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public double Decouvmax
        {
            get { return decmax; }
            set { decmax = value; }

        }

        public double Debmax
        {
            get { return debmax; }
            set { debmax = value; }
        }


        public compte(int a , int b, string c,string d , double e, double f,double j)
        {
            num = a;
            nbcompte = b;
            prt = c;
            typeprt = d;
            solde = e;
            do
            {
                decmax = f;
            } while (f <= solde);
            debmax = j;
        }
        
        public double decouvert()
        {
            if (this.solde >= 0)
            {
             
                return (0);
            }
            
            
                return(-solde);
            
        }


        public double crediter(double s)
        {
            do { solde = solde + s; }
            while (s > 0);
            return (solde);
        }
        public double debuter(double s)
        {
            do
            {
                solde = solde - s;
            } while (solde >= decmax);
            return (solde);
        }

    }
}
