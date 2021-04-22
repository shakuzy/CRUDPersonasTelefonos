using System;
using Entidades;
using Negocio;
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
    public partial class CRUDPersonas : Form
    {
        PersonasNegocio o = new PersonasNegocio();
        public CRUDPersonas()
        {
            InitializeComponent();
        }

        private void CRUDPersonas_Load(object sender, EventArgs e)
        {
            ObtenerTodoslasPersonas();
        }

        private void ObtenerTodoslasPersonas()
        {
            var e = o.ObtenerPersonas();
            dataGridView1.DataSource = e;
            if (dataGridView1.Rows.Count == 0)
            {
                lblMensaje.Text = "";
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarForm agregarForm = new AgregarForm();
            agregarForm.ShowDialog();
            
        }

        

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           
            
               

            try
            {
                int personaid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                Personas p = o.Consultar(personaid);
                o.Eliminar(p);
                MessageBox.Show("La persona se ha eliminado con exito", "¡Baja exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerTodoslasPersonas();

            }
            catch (Exception)
            {

                MessageBox.Show("Necesitas elegir una persona para poder borrarla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            try
            {
                int personaid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Hide();
                TelefonosForms t = new TelefonosForms(personaid);

                t.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Necesitas elegir una persona para poder ver su/s telefono/s", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (validarFiltro())
            {
                var f = o.filtrarPersonas(txtNombre.Text.ToString());
                dataGridView1.DataSource = f;
                if (dataGridView1.Rows.Count == 0)
                {
                    lblMensaje.Text = "";
                }
            }
        }

        private bool validarFiltro()
        {
            
                if (txtNombre.Text == string.Empty)
                {
                MessageBox.Show("¡La caja de 'Nombre' esta vacia!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }
            try
            {
                string e = Convert.ToString(txtNombre.Text);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            ObtenerTodoslasPersonas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int personaid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                DateTime datetime = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value);
                decimal credito = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[3].Value);
                Hide();

                Editar editarForm = new Editar(personaid, nombre, datetime, credito);
                editarForm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Necesitas elegir una persona para poder editar", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
