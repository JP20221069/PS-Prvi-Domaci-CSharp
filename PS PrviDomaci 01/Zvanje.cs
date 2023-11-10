using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPrviDomaci
{
    public class Zvanje
    {
        int id;
        string naziv;

        public int ID { get{return this.id;} set{ this.id = value;} }
        public string Naziv { get { return this.naziv; } set { this.naziv = value; } }

        public Zvanje()
        {
            
        }

        public Zvanje(int id,string naziv)
        {
            this.id = id;
            this.naziv = naziv;
        }

        public override string ToString()
        {
            return this.naziv;
        }
    }
}
