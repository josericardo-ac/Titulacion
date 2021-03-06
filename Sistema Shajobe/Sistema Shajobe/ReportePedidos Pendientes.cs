﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//LIBRERIAS DE REPORTES
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Sistema_Shajobe.Properties;//Nos permite tener acceso y control sobre las propiedades del proyecto en este caso la direccion del appconfig y entre otros

namespace Sistema_Shajobe
{
    public partial class ReportePedidos_Pendientes : Form
    {
        public ReportePedidos_Pendientes()
        {
            InitializeComponent();
        }

        private void ReportePedidos_Pendientes_Load(object sender, EventArgs e)
        {
            //Diseño de la ventana
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Pedidos_ICO;
            crystalReportViewer1.ReportSource = RPedidosPendientes1;
        }

        private void ReportePedidos_Pendientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //-------------------------------------------------------------
            //-------------------AL CERRAR LA VENTANA----------------------
            //-------------------------------------------------------------
            Dispose();
            Application.OpenForms["Menu_principal"].Activate();
        }
    }
}
