
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    public class Vache:Animal
    {
        #region  Propriétés
        public double Production { get; set; }

        #endregion
        #region Méthodes
        public Vache(string pNom, double pPoids, double pProduction) : base(pNom, pPoids) { Production = pProduction; }
        public override string Infos { get { return base.Infos + "Production : " + Production.ToString("F1") + " litres"; } }
        #endregion
    }
}
