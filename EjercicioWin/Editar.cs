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
    public partial class Editar : Form
    {
        PersonasNegocio o = new PersonasNegocio();
        CRUDPersonas p = new CRUDPersonas();

        public int identificador { get; set; }
        public Editar( int personaid ,  string nombre, DateTime  date, decimal credito)
        {
            InitializeComponent();
            this.identificador = Convert.ToInt32(personaid);
            txtNombre.Text = nombre.ToString();
            txtFechaNacimiento.Text = date.ToString();
            txtCreditoMaximo.Text = credito.ToString();
        }

        

        private void Esconderse()
        {

            Hide();

            p.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Esconderse();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && Requerimientos())
            {

                Personas p = new Personas()
                {
                    PersonaID = this.identificador,
                        Nombre = Convert.ToString(txtNombre.Text),
                        CreditoMaximo = Convert.ToDecimal(txtCreditoMaximo.Text),
                        FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text)
                    };
                    o.Editar(p);
                    MessageBox.Show("La persona se ha editado con exito", "¡Edicion exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Esconderse();
                    txtCreditoMaximo.Text = "";
                    txtNombre.Text = "";
                    txtFechaNacimiento.Text = "";

                

            }


        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == string.Empty || txtCreditoMaximo.Text == string.Empty || txtFechaNacimiento.Text == string.Empty)
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
                var b = Convert.ToString(txtNombre.Text);
                var c = Convert.ToDecimal(txtCreditoMaximo.Text);
                var d = Convert.ToDateTime(txtFechaNacimiento.Text);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("              -En el campo 'Nombre' se tiene que ingresar un text." +
                    "              -En el campo 'FechaNacimiento' se tiene que ingresar una fecha con formato dd/mm/aaaa" +
                    "              -En el campo 'CreditoMaximo' se tiene que ingresar un decimal.", "¡Fracaso en el alta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        
    }
}
