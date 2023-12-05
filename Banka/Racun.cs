using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Racun : IComparable
    {

        private string id;
        private double stanjeRacuna;
        private Korisnik vlasnikRacuna;
        private double maksimalnoOgranicenje;
        private DateTime datumOtvaranja;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double StanjeRacuna
        {
            get { return stanjeRacuna; }
            set { stanjeRacuna = value; }
        }

        public Korisnik VlasnikRacuna
        {
            get { return vlasnikRacuna; }
            set { vlasnikRacuna = value; }
        }

        public double MaksimalnoOgranicenje
        {
            get { return maksimalnoOgranicenje; }
            set { maksimalnoOgranicenje = value; }
        }

        public DateTime DatumOtvaranja
        {
            get { return datumOtvaranja; }
            set { datumOtvaranja = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Racun)obj).id);
            if (rez == 0) rez = this.vlasnikRacuna.CompareTo(((Racun)obj).vlasnikRacuna);
            if (rez == 0) rez = this.stanjeRacuna.CompareTo(((Racun)obj).stanjeRacuna);
            return rez;
        }

        public override string ToString()

            => VlasnikRacuna + "," + StanjeRacuna + "->" + Id.ToString();
    }
}
