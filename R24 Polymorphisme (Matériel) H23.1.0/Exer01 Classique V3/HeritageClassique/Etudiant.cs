using System;

namespace HeritageClassique
{
    public class Etudiant : Personne
    {
        public int Matricule { get; set; }

        public Etudiant(string pNom, DateTime pDateDeNaissance, int pMatricule)
            :base(pNom,pDateDeNaissance)
        {
            Matricule = pMatricule;
        }

        public override string Obtenirinfos()
        {
            string troisièmeLigne = "Matricule : " + Matricule;

            return base.Obtenirinfos() + troisièmeLigne;
        }
    }
}
