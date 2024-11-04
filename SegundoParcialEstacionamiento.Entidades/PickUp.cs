namespace SegundoParcialEstacionamiento.Entidades
{
    public class PickUp : Vehiculo
    {
        private int carga;
        public decimal valorHora;

        public int Carga { get; set; }

        private PickUp()
        {
            valorHora = 2000;
        }

        public PickUp(string patente, string marca, string modelo, int carga)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Carga = carga;
        }
    }
}
