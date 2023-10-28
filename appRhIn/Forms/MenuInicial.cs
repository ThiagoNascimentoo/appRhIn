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
    public partial class MenuInicial : Form
    {
        private MasterForm masterForm;
        public MenuInicial(MasterForm masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {

            masterForm.abrirFormFilho(new Funcionarios(masterForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masterForm.abrirFormFilho(new Financeiro(masterForm));
        }
    }
}
