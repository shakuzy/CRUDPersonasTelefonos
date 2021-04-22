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
    public partial class EditarTelefonos : Form
    {
        TelefonosNegocio t = new TelefonosNegocio();
        public int identificador { get; set; }
        public int identificadorpersonas { get; set; }

        public EditarTelefonos(int id, int pid, int t)
        {
            InitializeComponent();
            identificador = id;
            identificadorpersonas = pid;
            txtTelefono.Text = t.ToString();
        }

        private void Esconderse()
        {

            Close();
            TelefonosForms a = new TelefonosForms(identificadorpersonas);

            a.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && Requerimientos())
            {

                Telefonos p = new Telefonos()
                {
                    TelefonoID = identificador,
                    PersonaID = identificadorpersonas,
                    Telefono = txtTelefono.Text
                };

                t.Editar(p);
                MessageBox.Show("El numero ha sido editado con exito", "¡Edicion exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Esconderse();
                txtTelefono.Text = "";



            }
        }

        private bool ValidarCampos()
        {
            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios", "¡Fracaso en el alta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool Requerimientos()
        {
            try
            {
                var b = Convert.ToInt32(txtTelefono.Text);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("-En el campo 'Telefono' se tiene que ingresar un numero", "¡Fracaso en el alta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Esconderse();
        }
    }
}
