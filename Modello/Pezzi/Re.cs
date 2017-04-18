using System;

namespace Scacchi.Modello.Pezzi {
    public class Re : IPezzo
    {
        private readonly Colore colore;
        public Re(Colore colore) {
            this.colore = colore;
        }
        public Colore Colore{
            get {
                return colore;
            }
        }
        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo)
        {
            //se la differenza tra le traverse è 1, la differenza tra le colonne deve essere 0
            //e viceversa, allora puo muovere. mentre se si muove in diagonale deve valere
            //la stessa condizione per l'alfiere
            var differenzaColonne = Math.Abs(colonnaArrivo - colonnaPartenza);
            var differenzaTraverse = Math.Abs(traversaArrivo - traversaPartenza);
            if (differenzaColonne == 0 && differenzaTraverse == 0)
                return false;
            if (differenzaColonne == 0 && differenzaTraverse == 1 ||
                differenzaColonne == 1 && differenzaTraverse == 0)
                return true;
            else if (differenzaColonne == differenzaTraverse && differenzaColonne == 1 && differenzaTraverse == 1)
                return true;
            else
                return false;
        }
    }
}