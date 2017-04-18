using System;

namespace Scacchi.Modello.Pezzi {
    public class Alfiere : IPezzo
    {
        private readonly Colore colore;
        public Alfiere (Colore colore) {
            this.colore = colore;
        }
        public Colore Colore{
            get {
                return colore;
            }
        }

        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo)
        {
            //se la differenza tra le traverse è uguale alla differenza tra le colonne
            //allora puo muovere
            var differenzaColonne = Math.Abs(colonnaArrivo - colonnaPartenza);
            var differenzaTraverse = Math.Abs(traversaArrivo - traversaPartenza);
            return (differenzaColonne != 0) == (differenzaTraverse != 0);
        }
    }
}