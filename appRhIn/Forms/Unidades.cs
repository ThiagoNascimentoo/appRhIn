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
    public partial class Unidades : Form
    {
        private MasterForm masterForm;
        public Unidades(MasterForm masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rHDataSet.Unidade'. Você pode movê-la ou removê-la conforme necessário.
            this.unidadeTableAdapter.Fill(this.rHDataSet.Unidade);

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            masterForm.abrirFormFilho(new CadastarUnidades(masterForm));
        }
    }
}
