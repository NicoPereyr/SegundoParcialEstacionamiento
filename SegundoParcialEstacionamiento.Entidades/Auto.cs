namespace SegundoParcialEstacionamiento.Entidades
{
    public class Auto : Vehiculo
    {
        private ConsoleColor color;
        public decimal valorHora;

        public ConsoleColor Color { get; set; }

        private Auto()
        {
            valorHora = 1800;
        }


        public Auto(string marca, string modelo, ConsoleColor color)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
        }


    }
}
