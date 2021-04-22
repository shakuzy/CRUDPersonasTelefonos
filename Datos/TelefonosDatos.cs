using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class TelefonosDatos
    {

        public List<Telefonos> todosLosTelefonos(int ID)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                return c.Telefonos.Where(p => p.PersonaID == ID).ToList();
            }


        }

        public void Agregar(Telefonos p)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                c.Telefonos.Add(p);
                c.SaveChanges();
            }
        }

        public Telefonos Consulta(int ID)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                return c.Telefonos.FirstOrDefault(p => p.TelefonoID == ID);
            }
        }

        public void Editar(Telefonos p)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                c.Entry(p).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
            }
        }

        public void Eliminar(Telefonos p)
        {
            using (EjercicioWinEntities1 c = new EjercicioWinEntities1())
            {
                c.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                c.SaveChanges();
            }
        }
    }
}
