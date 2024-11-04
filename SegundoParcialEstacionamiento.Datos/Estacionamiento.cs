using SegundoParcialEstacionamiento.Entidades;

namespace SegundoParcialEstacionamiento.Datos
{
    public class Estacionamiento
    {
        private int capacidad;
        private ManejadorArchivoSecuencial manejadorSecuencial;
        private List<Movimiento> movimientos;
        private string nombre;
        private SerializadorXml serializadorXml;
        private Dictionary<string, Vehiculo> vehiculos;

        public int Capacidad { get; set; }
        public List<Movimiento> Movimientos { get; set; }
        public string Nombre { get; set; }
        public Dictionary<string, Vehiculo> Vehiculos { get; set; }

        public void AgregarVehiculo(Vehiculo v)
        {

        }

        private Estacionamiento()
        {

        }

        public Estacionamiento(string nombre)
        {

        }

        public Estacionamiento(string nombre, int capacidad)
        {
            this.nombre = nombre;
            this.capacidad = capacidad;
        }

        public bool ExisteVehiculo(Vehiculo v)
        {
            return false;
        }

        public void GuardarDatos()
        {

        }

        public bool HayLugaresDisponibles()
        {
            return false;
        }

        public int IngresarVehiculo(Vehiculo vehiculo)
        {
            return 0;
        }

        private Dictionary<string, Vehiculo> LeerDatos()
        {
            return new Dictionary<string, Vehiculo>();
        }

        public void RetirarVehiculo(string patente)
        {
            this.nombre = patente;
        }
    }
}
