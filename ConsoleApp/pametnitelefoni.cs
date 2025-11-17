using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Lab1
{
    class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string os)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = os;
        }

        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalirana aplikacija: {nazivAplikacije}");
        }

        public override void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }
}
