﻿using System;
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
    public partial class Ferias : Form
    {
        private MasterForm masterForm;
        public Ferias(MasterForm masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }
    }
}
