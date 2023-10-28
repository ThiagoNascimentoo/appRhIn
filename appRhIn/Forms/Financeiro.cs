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
    public partial class Financeiro : Form
    {
        private MasterForm masterForm;
        public Financeiro(MasterForm masterForm)
        {
            InitializeComponent();  
            this.masterForm = masterForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masterForm.abrirFormFilho(new Holerite(masterForm));
        }
    }
}
