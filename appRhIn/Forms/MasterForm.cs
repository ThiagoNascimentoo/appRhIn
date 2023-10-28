using appRhIn.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appRhIn.Forms
{
    public partial class MasterForm : Form
    {
        private Form formAtivo;
        public MasterForm()
        {
            InitializeComponent();
            labelUser.Text = UsuarioLogado.Instancia.Nome;
            if (formAtivo == null) { iniciarMenu(); }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelLateral.Width == 0) { panelLateral.Width = 200; } else { panelLateral.Width = 0; }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            UsuarioLogado.Instancia.Deslogar();
            this.Close();
            formAtivo.Close();

            Login login = new Login();
            login.Show();
        }

        public void iniciarMenu()
        {
            if (formAtivo == null)
            {
                MenuInicial menu = new MenuInicial(this);
                formAtivo = menu;
                formAtivo.TopLevel = false;
                panelCentral.Controls.Add(formAtivo);
                formAtivo.BringToFront();
                formAtivo.Show();
            }
        }

        public void abrirFormFilho(Form form)
        {
            //fechar formulario atual
            if (formAtivo != null) formAtivo.Close();
            // setar novo formulário
            formAtivo = form;
            //form não será exibido como janela
            form.TopLevel = false;
            panelCentral.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new Funcionarios(this));
        }

        private void appClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new MenuInicial(this));
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new Financeiro(this));
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new Unidades(this));
        }

        private void btnFerias_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new Ferias(this));
        }
    }
}
