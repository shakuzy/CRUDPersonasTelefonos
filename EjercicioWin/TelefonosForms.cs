using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWin
{
    public partial class TelefonosForms : Form
    {
        TelefonosNegocio o = new TelefonosNegocio();
        public int identificador { get; set; }
        public TelefonosForms(int id)
        {
            InitializeComponent();
            obtenerTodosLosComentarios(id);
        }

        private void obtenerTodosLosComentarios(int id)
        {
            

            this.identificador = id;
            var e = o.ObtenerTelefonos(id);
            dataGridView1.DataSource = e;
            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarTelefonos a = new AgregarTelefonos(identificador);
            a.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            CRUDPersonas c = new CRUDPersonas();
            c.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int personaid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Telefonos p = o.Consultar(personaid);
                o.Eliminar(p);
                obtenerTodosLosComentarios(identificador);
                MessageBox.Show("El numero ha sido eliminado con exito", "¡Baja exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Necesitas elegir un telefono para poder borrarlo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonoid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int personaid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);

                int telefono = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                Hide();

                EditarTelefonos editartelefonos = new EditarTelefonos(telefonoid, personaid, telefono);
                editartelefonos.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Necesitas elegir un telefono para poder editarlo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
