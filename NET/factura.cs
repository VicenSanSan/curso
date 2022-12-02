namespace net1
{
    public class Factura
    {
        public int numero;
        public bool pagada;
        public double importe;
        public string concepto ="";
        public double ImporteconIVA() {
            return importe * 1.21;

        }
    }
    
    }



