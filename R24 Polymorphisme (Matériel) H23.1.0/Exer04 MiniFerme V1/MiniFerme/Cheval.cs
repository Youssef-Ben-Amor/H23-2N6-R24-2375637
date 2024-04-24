using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    public class Cheval:Animal
    {
        #region  Propriétés
        public decimal PrixLocation { get; set; }

        #endregion
        #region Méthodes
        public Cheval(string pNom,double pPoids,decimal pPrixLocation):base(pNom,pPoids) { PrixLocation = pPrixLocation; }
        public override string Infos { get { return base.Infos+"Prix de location : "+PrixLocation.ToString("C0")+"/h"; } }
        #endregion
    }
}
