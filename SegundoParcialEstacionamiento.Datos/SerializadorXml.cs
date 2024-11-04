using System.Xml.Serialization;
using SegundoParcialEstacionamiento.Entidades;


namespace SegundoParcialEstacionamiento.Datos
{
    public class SerializadorXml : IArchivo<Movimiento>
    {
        private string path = Environment.CurrentDirectory;
        private string archivo = "Movimiento.Xml";

        private string nombreArchivo;
        public SerializadorXml()
        {
            nombreArchivo = Path.Combine(path, archivo);
        }

        public void Guardar(List<Movimiento> entidades)
        {
            using (var escritor = new StreamWriter(nombreArchivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Movimiento>));
                serializer.Serialize(escritor, entidades);
            }
        }

        public List<Movimiento> Leer()
        {
            if (File.Exists(nombreArchivo))
            {
                using (var lector = new StreamReader(nombreArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Movimiento>));
                    return serializer.Deserialize(lector) as List<Movimiento>;
                }

            }
            return new List<Movimiento>();
        }

    }
}
