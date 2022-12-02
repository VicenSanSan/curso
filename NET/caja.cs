namespace net1
{
    public class Caja
    {
        public int ancho;
        public int alto;
        public int profundo;

        public Caja(int ancho,int alto, int profundo){
            this.ancho=ancho;
            this.alto=alto;
            this.profundo=profundo;
        }
        public double calculaVolumen() {
            return ancho*alto*profundo;
        }
    }
}



