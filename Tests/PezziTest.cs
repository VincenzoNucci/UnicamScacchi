using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class PezziTest
    {

        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Seconda,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Terza);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Sesta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlCavalloNeroPuoMuovereAllaSuaSinistraVersoLAltoInSensoVerticale()
        {
        //Given
        IPezzo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.D,
            traversaPartenza : Traversa.Quinta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloNeroPuoMuovereAllaSuaDestraVersoLAltoInSensoVerticale()
        {
        //Given
        IPezzo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloNeroPuoMuovereAllaSuaSinistraVersoIlBassoInSensoVerticale()
        {
        //Given
        IPezzo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.D,
            traversaPartenza : Traversa.Quinta,
            colonnaArrivo : Colonna.C,
            traversaArrivo : Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloNeroPuoMuovereAllaSuaDestraVersoIlBassoInSensoVerticale()
        {
        IPezzo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloNeroPuoMuovereAllaSuaSinistraVersoLAltoInSensoOrizzontale()
        {
        IPezzo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.D,
            traversaPartenza : Traversa.Quinta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quarta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloNeroPuoMuovereAllaSuaSinistraVersoIlBassoInSensoOrizzontale()
        {
        IPezzo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.C,
            traversaArrivo : Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloNeroPuoMuovereAllaSuaDestraVersoLAltoInSensoOrizzontale()
        {
        IPezzo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.G,
            traversaArrivo : Traversa.Quarta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloNeroPuoMuovereAllaSuaDestraVersoIlBassoInSensoOrizzontale()
        {
        IPezzo cavallo = new Cavallo(Colore.Nero);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.C,
            traversaArrivo : Traversa.Quarta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereAllaSuaSinistraVersoLAltoInSensoVerticale()
        {
        //Given
        IPezzo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.D,
            traversaPartenza : Traversa.Quinta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereAllaSuaDestraVersoLAltoInSensoVerticale()
        {
        //Given
        IPezzo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereAllaSuaSinistraVersoIlBassoInSensoVerticale()
        {
        //Given
        IPezzo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.D,
            traversaPartenza : Traversa.Quinta,
            colonnaArrivo : Colonna.C,
            traversaArrivo : Traversa.Terza);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereAllaSuaDestraVersoIlBassoInSensoVerticale()
        {
        IPezzo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereAllaSuaSinistraVersoLAltoInSensoOrizzontale()
        {
        IPezzo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.D,
            traversaPartenza : Traversa.Quinta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quarta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereAllaSuaSinistraVersoIlBassoInSensoOrizzontale()
        {
        IPezzo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.C,
            traversaArrivo : Traversa.Seconda);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereAllaSuaDestraVersoLAltoInSensoOrizzontale()
        {
        IPezzo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.G,
            traversaArrivo : Traversa.Quarta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereAllaSuaDestraVersoIlBassoInSensoOrizzontale()
        {
        IPezzo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.C,
            traversaArrivo : Traversa.Quarta);
        //Then
        Assert.True(esito);
        }

        

        [Fact]
        public void AlfiereNeroPuoMuovereDiagonalmenteVersoLAltoADestra()
        {
        //Given
        IPezzo alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza : Colonna.C,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void AlfiereNeroPuoMuovereDiagonalmenteVersoIlBassoADestra()
        {
        //Given
        IPezzo alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza : Colonna.C,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.B,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void AlfiereNeroPuoMuovereDiagonalmenteVersoIlBassoASinistra()
        {
        //Given
        IPezzo alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza : Colonna.F,
            traversaPartenza : Traversa.Sesta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void AlfiereNeroPuoMuovereDiagonalmenteVersoLAltoASinistra()
        {
        //Given
        IPezzo alfiere = new Alfiere(Colore.Nero);
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza : Colonna.B,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Seconda
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void AlfiereBiancoPuoMuovereDiagonalmenteVersoLAltoADestra()
        {
        //Given
        IPezzo alfiere = new Alfiere(Colore.Bianco);
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza : Colonna.C,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void AlfiereBiancoPuoMuovereDiagonalmenteVersoIlBassoADestra()
        {
        //Given
        IPezzo alfiere = new Alfiere(Colore.Bianco);
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza : Colonna.C,
            traversaPartenza : Traversa.Terza,
            colonnaArrivo : Colonna.B,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void AlfiereBiancoPuoMuovereDiagonalmenteVersoIlBassoASinistra()
        {
        //Given
        IPezzo alfiere = new Alfiere(Colore.Bianco);
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza : Colonna.F,
            traversaPartenza : Traversa.Sesta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void AlfiereBiancoPuoMuovereDiagonalmenteVersoLAltoASinistra()
        {
        //Given
        IPezzo alfiere = new Alfiere(Colore.Bianco);
        //When
        bool esito = alfiere.PuòMuovere(
            colonnaPartenza : Colonna.B,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Seconda
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReNeroPuoMuovereDiagonalmenteVersoLAltoASinistra()
        {
        //Given
        IPezzo re = new Re(Colore.Nero);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Terza
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReNeroPuoMuovereDiagonalmenteVersoIlBassoASinistra()
        {
        //Given
        IPezzo re = new Re(Colore.Nero);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Terza
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReNeroPuoMuovereDiagonalmenteVersoIlBassoADestra()
        {
        //Given
        IPezzo re = new Re(Colore.Nero);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReNeroPuoMuovereDiagonalmenteVersoLAltoADestra()
        {
        //Given
        IPezzo re = new Re(Colore.Nero);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReNeroPuoMuovereOrizzontalmenteVersoDestra()
        {
        //Given
        IPezzo re = new Re(Colore.Nero);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReNeroPuoMuovereOrizzontalmenteVersoSinistra()
        {
        //Given
        IPezzo re = new Re(Colore.Nero);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Terza
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReNeroPuoMuovereVerticalmenteVersoLAlto()
        {
        //Given
        IPezzo re = new Re(Colore.Nero);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReNeroPuoMuovereVerticalmenteVersoIlBasso()
        {
        //Given
        IPezzo re = new Re(Colore.Nero);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReBiancoPuoMuovereDiagonalmenteVersoLAltoASinistra()
        {
        //Given
        IPezzo re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Terza
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReBiancoPuoMuovereDiagonalmenteVersoIlBassoASinistra()
        {
        //Given
        IPezzo re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Terza
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReBiancoPuoMuovereDiagonalmenteVersoIlBassoADestra()
        {
        //Given
        IPezzo re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReBiancoPuoMuovereDiagonalmenteVersoLAltoADestra()
        {
        //Given
        IPezzo re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReBiancoPuoMuovereOrizzontalmenteVersoDestra()
        {
        //Given
        IPezzo re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReBiancoPuoMuovereOrizzontalmenteVersoSinistra()
        {
        //Given
        IPezzo re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Terza
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReBiancoPuoMuovereVerticalmenteVersoLAlto()
        {
        //Given
        IPezzo re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ReBiancoPuoMuovereVerticalmenteVersoIlBasso()
        {
        //Given
        IPezzo re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        



        [Fact]
        public void TorreBiancaPuoMuovereOrizzontalmenteVersoDestra()
        {
        //Given
        IPezzo torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void TorreBiancaPuoMuovereOrizzontalmenteVersoSinistra()
        {
        //Given
        IPezzo torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Terza
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void TorreBiancaPuoMuovereVerticalmenteVersoLAlto()
        {
        //Given
        IPezzo torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void TorreBiancaPuoMuovereVerticalmenteVersoIlBasso()
        {
        //Given
        IPezzo torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void TorreNeraPuoMuovereOrizzontalmenteVersoDestra()
        {
        //Given
        IPezzo torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Quinta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void TorreNeraPuoMuovereOrizzontalmenteVersoSinistra()
        {
        //Given
        IPezzo torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.E,
            traversaArrivo : Traversa.Terza
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void TorreNeraPuoMuovereVerticalmenteVersoLAlto()
        {
        //Given
        IPezzo torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.F,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void TorreNeraPuoMuovereVerticalmenteVersoIlBasso()
        {
        //Given
        IPezzo torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
            colonnaPartenza : Colonna.E,
            traversaPartenza : Traversa.Quarta,
            colonnaArrivo : Colonna.D,
            traversaArrivo : Traversa.Quarta
        );
        //Then
        Assert.True(esito);
        }
    }
}