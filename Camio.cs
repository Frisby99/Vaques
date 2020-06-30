using System.Collections.Generic;
using System.Linq;

namespace Vaques.Model
{
    public class Camio
    {
        public Camio(double pesMax)
        {
            PesMaxim = pesMax;
            _PesActual = 0;
            Vaques = new List<Vaca>();
        }

        public double PesMaxim { get; }
        public double PesActual { get => _PesActual; }
        public List<Vaca> Vaques { get; }

        public double Litres;
        public double _PesActual;
        public double GetLitres() => Vaques.Sum(x => x.GetLitres());

        public bool EntraVaca(Vaca vaca)
        {
            if (PesActual + vaca.Pes > PesMaxim)
            {
                return false;
            }

            Vaques.Add(vaca);
            _PesActual += vaca.Pes;
            return true;
        }

        public bool TreuVaca(Vaca vaca)
        {
            var resultat = Vaques.Remove(vaca);
            if (resultat) { _PesActual -= vaca.Pes; }
            return resultat;
        }

        public override string ToString() => $"Camio max:{PesMaxim} ({PesActual}) - vaques: {Vaques.Count}";
    }
}
