using System;

namespace Scacchi.Modello.Pezzi {
    public class Cavallo : IPezzo
    {
        private readonly Colore colore;
        public Cavallo(Colore colore) {
            this.colore = colore;
        }
        public Colore Colore{
            get {
                return colore;
            }
        }

        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo)
        {
            //se la differenza tra le traverse è 1 e la differenza tra le colonne è 2
            //o viceversa ma mai la stessa per entrambe allora puo muovere
            var differenzaColonne = Math.Abs(colonnaArrivo - colonnaPartenza);
            var differenzaTraverse = Math.Abs(traversaArrivo - traversaPartenza);
            if (differenzaColonne == 0 && differenzaTraverse == 0)
                return false;
            if (differenzaColonne == 2 && differenzaTraverse == 1)
                return true;
            else if (differenzaTraverse == 2 && differenzaColonne == 1)
                return true;
            else
                return false;
        }
    }
}