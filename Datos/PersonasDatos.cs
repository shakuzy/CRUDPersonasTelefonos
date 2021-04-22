using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PersonasDatos
    {
        public IEnumerable<Personas> ConsultarPersonas()
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                return c.Personas.AsNoTracking().ToList();
            }
        }

        public void Agregar(Personas p)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                c.Personas.Add(p);
                c.SaveChanges();
            }
        }

        public Personas consulta(int ID)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                return c.Personas.FirstOrDefault(p => p.PersonaID == ID);
            }
        }

        public void Editar(Personas p)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                c.Entry(p).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
            }
        }

        public void Eliminar(Personas p)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                c.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                c.SaveChanges();
            }
        }

        public List<Personas> FiltroPersonas(string n)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                return c.Personas.Where(p => p.Nombre == n).ToList();
            }
        }
    }
}
