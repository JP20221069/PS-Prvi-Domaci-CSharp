using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPrviDomaci
{
    public class Nastavnik
    {
        int id;
        string ime;
        string prezime;
        Zvanje zvanje;
        public int ID { get { return this.id; } set { this.id = value; } }
        public string Ime { get { return this.ime; } set { this.ime = value; } }
        public string Prezime { get { return this.prezime; } set { this.prezime = value; } }
        public Zvanje Zvanje { get { return this.zvanje; } set { this.zvanje = value; } }

        public Nastavnik()
        {
            
        }

        public Nastavnik(int id, string ime,string prezime, Zvanje zvanje)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.zvanje = zvanje;
        }

    }
}
