using Negocio;
using Entidades;
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
    public partial class AgregarForm : Form
    {
        PersonasNegocio o = new PersonasNegocio();
        CRUDPersonas p = new CRUDPersonas();
        public AgregarForm()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Esconderse();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && Requerimientos())
            {
                if (existeNoExiste(Convert.ToInt32(txtPersonaID.Text)))
                {
                    Personas p = new Personas()
                    {
                        PersonaID = Convert.ToInt32(txtPersonaID.Text),
                        Nombre = Convert.ToString(txtNombre.Text),
                        CreditoMaximo = Convert.ToDecimal(txtCreditoMaximo.Text),
                        FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text)
                    };
                    o.AgregarPersona(p);
                    MessageBox.Show("La persona se ha agregado con exito", "¡Alta exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Esconderse();
                    txtCreditoMaximo.Text = "";
                    txtPersonaID.Text = "";
                    txtNombre.Text = "";
                    txtFechaNacimiento.Text = "";

                }
                else
                {
                    MessageBox.Show("Este 'PersonaID' esta siendo utilizado, por favor elija otro.", "¡Fracaso en el alta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
           
        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == string.Empty || txtPersonaID.Text == string.Empty || txtCreditoMaximo.Text == string.Empty || txtFechaNacimiento.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios", "¡Fracaso en el alta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void Esconderse()
        {

            Hide();

            p.ShowDialog();
        }

        private bool Requerimientos()
        {
            try
            {
                var a = Convert.ToInt32(txtPersonaID.Text);
                var b = Convert.ToString(txtNombre.Text);
                var c = Convert.ToDecimal(txtCreditoMaximo.Text);
                var d = Convert.ToDateTime(txtFechaNacimiento.Text);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("-En el campo 'PersonaID' se tiene que ingresar un entero." +
                    "              -En el campo 'Nombre' se tiene que ingresar un text." +
                    "              -En el campo 'FechaNacimiento' se tiene que ingresar una fecha con formato dd/mm/aaaa" +
                    "              -En el campo 'CreditoMaximo' se tiene que ingresar un decimal.", "¡Fracaso en el alta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private bool existeNoExiste(int id)
        {
            Personas p = o.Consultar(id);

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
