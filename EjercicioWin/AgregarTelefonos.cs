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
    public partial class AgregarTelefonos : Form
    {
        TelefonosNegocio t = new TelefonosNegocio();
        public int identificador { get; set; }

        public AgregarTelefonos(int id)
        {
            identificador = id;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Esconderse();
        }

        private void Esconderse()
        {

            Hide();
            TelefonosForms m = new TelefonosForms(identificador);

            m.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && Requerimientos())
            {
                if (existeNoExiste(Convert.ToInt32(txtTelefonoID.Text)))
                {
                    Telefonos p = new Telefonos()
                    {
                        TelefonoID = Convert.ToInt32(txtTelefonoID.Text),
                        PersonaID = identificador,
                        Telefono = txtTelefono.Text
                    };
                    t.AgregarTelefono(p);
                    MessageBox.Show("El telefono se ha agregado con exito", "¡Alta exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Esconderse();
                    txtTelefonoID.Text = "";
                    txtTelefono.Text = "";

                }
                else
                {
                    MessageBox.Show("Este 'TelefonoID' esta siendo utilizado, por favor elija otro.", "¡Fracaso en el alta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private bool ValidarCampos()
        {
            if (txtTelefono.Text == string.Empty || txtTelefonoID.Text == string.Empty)
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
                var a = Convert.ToInt32(txtTelefono.Text);
                var b = Convert.ToInt32(txtTelefonoID.Text);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("-En el campo 'TelefonoID' se tiene que ingresar un entero." +
                    "              -En el campo 'Telefono' se tiene que ingresar un entero." , "¡Fracaso en el alta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private bool existeNoExiste(int id)
        {
            Telefonos p = t.Consultar(id);

            if (p == null)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
