using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TelefonosNegocio
    {
        TelefonosDatos o = new TelefonosDatos();
        public IEnumerable<Telefonos> ObtenerTelefonos(int id)
        {
            IEnumerable<Telefonos> Lista = o.todosLosTelefonos(id);

            return Lista;
        }

        public void AgregarTelefono(Telefonos p)
        {
            o.Agregar(p);
        }

        public Telefonos Consultar(int id)
        {
                return o.Consulta(id);
        }

        public void Eliminar(Telefonos p)
        {
            o.Eliminar(p);
        }
        public void Editar(Telefonos p)
        {
            o.Editar(p);
        }
    }
}
