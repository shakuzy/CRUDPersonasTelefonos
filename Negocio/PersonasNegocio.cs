using System;
using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class PersonasNegocio
    {
        PersonasDatos o = new PersonasDatos();
        public IEnumerable<Personas> ObtenerPersonas()
        {
           IEnumerable<Personas> Lista = o.ConsultarPersonas();

            return Lista;
        }

        public void AgregarPersona(Personas p)
        {
            o.Agregar(p);
        }

        public Personas Consultar(int id)
        {
           return o.consulta(id);
        }

        public void Editar(Personas p)
        {
             o.Editar(p);
        }

        public void Eliminar(Personas p)
        {
            o.Eliminar(p);
        }

        public IEnumerable<Personas> filtrarPersonas(string s)
        {
            IEnumerable<Personas> Lista = o.FiltroPersonas(s);

            return Lista;
        }
    }
}
