﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Service;

namespace debugging
{
    public partial class SubSuvernir : Form
    {
        private readonly ServiceProduk serviceProduk;
        public SubSuvernir(ServiceProduk serviceProduk)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk;
            var produkSuvenir = serviceProduk.GetAllProduk().Where(p => p.id_kategori == 1).ToList();
        }

        private void SubSuvernir_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; 
        }
    }
}
