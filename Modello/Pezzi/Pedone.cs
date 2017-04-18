using System;

namespace Scacchi.Modello.Pezzi {
    public class Pedone : IPezzo
    {
        private readonly Colore colore;
        public Pedone(Colore colore)
        {
            this.colore = colore;    
        }
        public Colore Colore {
            get {
                return colore;
            }
        }
        public bool PuòMuovere(
            Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo)
        {
            var stessaColonna = colonnaPartenza == colonnaArrivo;
            var distanzaTraLeTraverse = (int) traversaArrivo - (int) traversaPartenza;
            var distanzaColonne = colonnaArrivo - colonnaPartenza; //siccome i pedoni hanno un verso per colore, in questo controllo serve vedere il segno perchè non possono tornare indietro
            if (distanzaColonne == 0 && distanzaTraLeTraverse == 0)
                return false;
            if (traversaPartenza == Traversa.Seconda && Colore == Colore.Bianco &&
                Math.Abs(distanzaTraLeTraverse) <= 2 && distanzaTraLeTraverse > 0)
                return true;
            if (traversaPartenza == Traversa.Settima && Colore == Colore.Nero &&
                Math.Abs(distanzaTraLeTraverse) <= 2 && distanzaTraLeTraverse < 0)
                return true;
            if (stessaColonna && Math.Abs(distanzaTraLeTraverse) == 1){
                return true;
            } else {
                return false;
            }

        }
    }
}