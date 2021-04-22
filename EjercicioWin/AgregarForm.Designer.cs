
namespace EjercicioWin
{
    partial class AgregarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPersonaID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCreditoMaximo = new System.Windows.Forms.Label();
            this.txtPersonaID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtCreditoMaximo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPersonaID
            // 
            this.lblPersonaID.AutoSize = true;
            this.lblPersonaID.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonaID.Location = new System.Drawing.Point(63, 113);
            this.lblPersonaID.Name = "lblPersonaID";
            this.lblPersonaID.Size = new System.Drawing.Size(82, 17);
            this.lblPersonaID.TabIndex = 1;
            this.lblPersonaID.Text = "PersonaID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(81, 156);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(14, 197);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(131, 17);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "FechaNacimiento";
            // 
            // lblCreditoMaximo
            // 
            this.lblCreditoMaximo.AutoSize = true;
            this.lblCreditoMaximo.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditoMaximo.Location = new System.Drawing.Point(30, 245);
            this.lblCreditoMaximo.Name = "lblCreditoMaximo";
            this.lblCreditoMaximo.Size = new System.Drawing.Size(115, 17);
            this.lblCreditoMaximo.TabIndex = 4;
            this.lblCreditoMaximo.Text = "CreditoMaximo";
            // 
            // txtPersonaID
            // 
            this.txtPersonaID.Location = new System.Drawing.Point(158, 113);
            this.txtPersonaID.Name = "txtPersonaID";
            this.txtPersonaID.Size = new System.Drawing.Size(292, 20);
            this.txtPersonaID.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 156);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(292, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(158, 197);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(292, 20);
            this.txtFechaNacimiento.TabIndex = 7;
            // 
            // txtCreditoMaximo
            // 
            this.txtCreditoMaximo.Location = new System.Drawing.Point(158, 245);
            this.txtCreditoMaximo.Name = "txtCreditoMaximo";
            this.txtCreditoMaximo.Size = new System.Drawing.Size(292, 20);
            this.txtCreditoMaximo.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(158, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 32);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(271, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 32);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(209, 41);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 11;
            // 
            // AgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 349);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCreditoMaximo);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPersonaID);
            this.Controls.Add(this.lblCreditoMaximo);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPersonaID);
            this.Name = "AgregarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonaID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCreditoMaximo;
        private System.Windows.Forms.TextBox txtPersonaID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtCreditoMaximo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMensaje;
    }
}