namespace SegundoParcialEstacionamiento.Entidades
{
    public abstract class Vehiculo
    {
        private string marca;
        private string modelo;
        private string patente;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        //public override string ToString(string patente)
        //{
        //    patente = string.Empty;
        //}
        //public bool ValidarPatente(string value)
        //{

        //}

        public Vehiculo()
        {

        }
        public Vehiculo(string patente, string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
        }
    }
}
