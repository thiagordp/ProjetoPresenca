using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPresenca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegraNegocio.MontagemRegraNegocio montagem = new RegraNegocio.MontagemRegraNegocio();

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Conectar")
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o Arduino.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnConectar.Text = "Desconectar";
                    btnConectar.Image = ProjetoPresenca.Properties.Resources.ic_turn_off;
                }
            }
            else
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o Arduino.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnConectar.Text = "Conectar";
                    btnConectar.Image = ProjetoPresenca.Properties.Resources.ic_turn_on;
                }
            }
        }
    }
}
