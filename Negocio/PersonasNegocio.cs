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
        TelefonosDatos t = new TelefonosDatos();
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
            List<Telefonos> telefono = t.todosLosTelefonos(p.PersonaID);

            o.Eliminar(p);
            t.EliminarTodoslosTelefoos(telefono);
        }

        public IEnumerable<Personas> filtrarPersonas(string s)
        {
            IEnumerable<Personas> Lista = o.FiltroPersonas(s);

            return Lista;
        }
    }
}
