using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Banka
{
    public class Korisnik: IComparable{

        private string id;
        private string ime;
        private string prezime;
        private int brMob;
        private DateTime godRodj;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public int BrMob
        {
            get { return brMob; }
            set { brMob = value; }
        }

        public DateTime GodRodj
        {
            get { return godRodj; }
            set { godRodj = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Korisnik)obj).id);
            if (rez == 0) rez = this.prezime.CompareTo(((Korisnik)obj).prezime);
            if (rez == 0) rez = this.ime.CompareTo(((Korisnik)obj).ime);
            return rez;
        }

        public override string ToString()

            => Prezime + "," + Ime + "->" + Id.ToString();

    }
}
