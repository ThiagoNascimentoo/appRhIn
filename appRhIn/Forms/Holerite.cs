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
    public partial class Holerite : Form
    {
        private MasterForm masterForm;
        public Holerite(MasterForm masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }

        private void Holerite_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rHDataSet.Holerite'. Você pode movê-la ou removê-la conforme necessário.
            this.holeriteTableAdapter.Fill(this.rHDataSet.Holerite);

        }
    }
}
