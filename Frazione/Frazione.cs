using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Frazione
    {
        public int nom { get; set; }
        public int dom { get; set; }

        public Frazione(int n,int d)
        { nom = n; 
          dom = d; 
          Semplifica(ref n, ref d);
        }
        private void Semplifica(ref int Nom, ref int Dom)
        {
            int mcd=1;
            int i;
            for (i = 1; i <= Nom && i <= Dom; i++)
            {
                if (Nom % i == 0 && Dom % i == 0)
                {
                    mcd = i;
                }
            }
            Nom = Nom / mcd;
            Dom = Dom / mcd;
           
        }
        public override string ToString()
        {
            
            return string.Format("{0}/{1}",nom,dom);
        }

        public static Frazione Parse(string frazione)
        {
           string[] parts=frazione.Split('/');
            int nom = int.Parse(parts[0]);
            int dom = int.Parse(parts[1]);
            Frazione f = new Frazione(nom, dom);
            return f;

        }
        public Frazione Somma(Frazione f2)
        {
            return new Frazione(this.dom * f2.nom+ this.nom*f2.dom,this.dom*f2.dom);
        }
    }
}
