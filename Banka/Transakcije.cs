using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Banka
{
    public class Transakcije : IComparable
    {

        private string id;
        private DateTime datumTransakcije;
        private double iznos;
        private Racun izRacuna;
        private Racun naRacun;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DatumTransakcije
        {
            get { return datumTransakcije; }
            set { datumTransakcije = value; }
        }

        public double Iznos
        {
            get { return iznos; }
            set { iznos = value; }
        }

        public Racun IzRacuna
        {
            get { return izRacuna; }
            set { izRacuna = value; }
        }

        public Racun NaRacun
        {
            get { return naRacun; }
            set { naRacun = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Transakcije)obj).id);
            if (rez == 0) rez = this.datumTransakcije.CompareTo(((Transakcije)obj).datumTransakcije);
            if (rez == 0) rez = this.iznos.CompareTo(((Transakcije)obj).iznos);
            return rez;
        }

        public override string ToString()

            => DatumTransakcije + "," + Iznos + "->" + Id.ToString();
    }
}
