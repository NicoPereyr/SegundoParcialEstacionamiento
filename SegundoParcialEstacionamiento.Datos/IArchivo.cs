using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialEstacionamiento.Datos
{
    public interface IArchivo<T> where T : class
    {
        List<T> Leer();
        void Guardar(List<T> entidades);
    }
}
