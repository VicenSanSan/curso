namespace net1
{
    public class Persona
    {
        private  int edad;
        public int Edad {
            get {
                return this.edad;
            }
            set{
                if (value<120)
                this.edad=value;
                else this.edad=120;
            }
        }
        public string Nombre {get;set;}
        public bool EstaJubilado() {
            return edad>65;
        }
    }
}



