using SegundoParcialEstacionamiento.Entidades;

namespace SegundoParcialEstacionamiento.Datos
{
    public class ManejadorArchivoSecuencial : IArchivo<Vehiculo>
    {
        private string path = Environment.CurrentDirectory;
        private string archivo = "Vehiculos.txt";

        //private string nombreArchivo;
        //public ManejadorArchivoSecuencial()
        //{
        //    nombreArchivo = Path.Combine(path, archivo);
        //}
        //public void Guardar(List<Vehiculo> vehiculos)
        //{
        //    using (var escritor = new StreamWriter(nombreArchivo))
        //    {
        //        foreach (var item in vehiculos)
        //        {
        //            string linea = ConstruirLinea(item);
        //            escritor.WriteLine(linea);
        //        }
        //    }
        //}

    //    private string ConstruirLinea(Vehiculo item)
    //    {
    //        string linea = $"{item.Marca}|{item.Modelo}|{item.Patente}";
    //        if (item.GetType() == typeof(Moto))
    //        {
    //            return linea + $"|{(Moto)item}";
    //        }
    //        return linea;
    //    }



    //    public List<Vehiculo> Leer()
    //    {
    //        List<Vehiculo> lista = new List<Vehiculo>();
    //        if (File.Exists(nombreArchivo))
    //        {
    //            using (var lector = new StreamReader(nombreArchivo))
    //            {
    //                while (!lector.EndOfStream)
    //                {
    //                    var lineaLeida = lector.ReadLine();
    //                    Vehiculo vehiculo = ConstruirVehiculo(lineaLeida);
    //                    lista.Add(vehiculo);
    //                }
    //            }
    //        }
    //        return lista;
    //    }

    //    private Vehiculo ConstruirVehiculo(string? lineaLeida)
    //    {
    //        var campos = lineaLeida.Split('|');
    //        var marca = campos[0];
    //        var valorHora = (campos[1]);
    //        var cilindrada = (campos[2]);
    //        if (campos.Length > 3)
    //        {
    //            return new Moto(marca, valorHora, cilindrada);

    //        }
    //        return new PickUp(marca, valorHora, carga);
    //    }
    }
}
