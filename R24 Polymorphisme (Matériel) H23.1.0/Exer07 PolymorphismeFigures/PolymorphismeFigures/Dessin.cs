using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeFigures
{
    public class Dessin
    {
        private List<Figure> m_colFIgures;
        public int count { get { return m_colFIgures.Count; } }
        public Dessin() { m_colFIgures = new List<Figure>(); }
        public void Dessiner(Graphics pobGraphique) { foreach (Figure figure in m_colFIgures) figure.Dessiner(pobGraphique); }
        public void Agrandir(int pFacteur) { foreach (Figure figure in m_colFIgures) figure.Agrandir(pFacteur); }
        public void Deplacer(int pDeplacementX, int pDeplacementY) { foreach (Figure figure in m_colFIgures) figure.Deplacer(pDeplacementX,pDeplacementY); }
        public void Ajouter(Figure pobjFigure) { m_colFIgures.Add(pobjFigure); }
        public void SupprimerDerniereFigure() {if(m_colFIgures.Count>0)m_colFIgures.RemoveAt(m_colFIgures.Count-1); } 
        
    }
}
