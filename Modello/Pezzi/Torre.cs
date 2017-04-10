using System;

namespace Scacchi.Modello.Pezzi {
    public class Torre : IPezzo
    {
        private readonly Colore colore;
        public Torre(Colore colore) {
            this.colore = colore;
        }
        public Colore Colore{
            get {
                return colore;
            }
        }

        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo)
        {
            //non puo valere la condizione dell'alfiere ma la differenza di una delle
            //due tra colonne e traverse puo essere di n, mai contemporaneamente
            var differenzaColonne = Math.Abs(colonnaArrivo - colonnaPartenza);
            var differenzaTraverse = Math.Abs(traversaArrivo - traversaPartenza);
            if (differenzaColonne == 0 && differenzaTraverse >= 1 ||
                differenzaTraverse == 0 && differenzaColonne >= 1)
                    return true;
            else
                return false;
        }
    }
}