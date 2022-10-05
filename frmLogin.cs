using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP01_EjercicioPorResolver_MaximoLuna
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void IniciofrmBienvenida()
        {
            this.Hide();
            frmBienvenido frmBienvenido = new frmBienvenido();
            frmBienvenido.ShowDialog();
        }
        Int16 VarEntradasFallidas;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a" && (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA"))
            {
                IniciofrmBienvenida();
            }
            else
            {
                if (txtUsuario.Text == "John" && txtContraseña.Text == "*2b" && lstModulo.Text == "SIST")
                {
                    IniciofrmBienvenida();
                }
                else
                {
                    if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c" && (lstModulo.Text == "ADM" || lstModulo.Text == "VTA"))
                    {
                        IniciofrmBienvenida();
                    }
                    else
                            {
                        if (txtUsuario.Text == "God" && txtContraseña.Text == "*@#4d")
                        {
                            IniciofrmBienvenida();
                        }
                        else
                        {
                            VarEntradasFallidas += 1;
                            MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado", "Advertencia " + VarEntradasFallidas + "/2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (VarEntradasFallidas == 2)
                            {
                                MessageBox.Show("Límite de fallas alcanzado, cerrando programa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                            }
                        }
                    }

                }
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
