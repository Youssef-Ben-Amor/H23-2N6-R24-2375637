

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    internal class Chien : Animal
    {
        #region  Propriétés
        public enuStyleDeChien StyleDeChien { get; set; }
        #endregion
        #region Méthodes
        public Chien(string pNom, double pPoids, enuStyleDeChien pEnuStyleDeChien) : base(pNom, pPoids) { StyleDeChien = pEnuStyleDeChien; }
        public override string Infos { get { return base.Infos + "Style de chien : " + StyleDeChien ; } }
        #endregion
    }
}
