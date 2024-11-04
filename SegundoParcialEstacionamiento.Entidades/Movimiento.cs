namespace SegundoParcialEstacionamiento.Entidades
{
    public class Movimiento
    {
        public Vehiculo Vehiculo { get; set; }
        public Decimal? Costo { get; set; }
        public int? Estadia { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSalida { get; set; }
        public int CalcularEstadia()
        {
            if (!HoraSalida.HasValue)
            {
                throw new InvalidOperationException("No se ha registrado la hora de salida.");
            }

            TimeSpan estadia = HoraSalida.Value - HoraEntrada;
            return (int)estadia.TotalHours; // Convertimos a horas y retornamos
        }

        public Movimiento(Vehiculo vehiculo)
        {
            HoraEntrada=DateTime.Now.AddHours(3);
        }

    }
}
