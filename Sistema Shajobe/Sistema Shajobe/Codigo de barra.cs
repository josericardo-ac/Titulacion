using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxBARCODELib;
using System.Drawing.Printing;


namespace Sistema_Shajobe
{
    public partial class CodigoBarra : Form
    {
        public CodigoBarra()
        {
            InitializeComponent();
        }
        #region Declarando Controles de Impresion
        private Button btImprimir;
        private Button btVistaPrevia;
        private PrintDocument DocumentoParaImprimir = new PrintDocument();
        private PrintDialog Impresora = new PrintDialog();
        private PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();
        private Bitmap bmp;
        #endregion
        private void Codigo_de_barra_Load(object sender, EventArgs e)
        {
            this.btImprimir = new System.Windows.Forms.Button();
            this.btImprimir.Location = new System.Drawing.Point(20, 210);
            this.btImprimir.Size = new System.Drawing.Size(100, 30);
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.Controls.Add(this.btImprimir);

            this.btVistaPrevia = new System.Windows.Forms.Button();
            this.btVistaPrevia.Location = new System.Drawing.Point(360, 210);
            this.btVistaPrevia.Size = new System.Drawing.Size(100, 30);
            this.btVistaPrevia.Text = "Vista Previa";
            this.btVistaPrevia.Click += new System.EventHandler(this.btVistaPrevia_Click);
            this.Controls.Add(this.btVistaPrevia);

            DocumentoParaImprimir.PrintPage +=
                new PrintPageEventHandler(DocumentoParaImprimir_PrintPage);
        }
        private void txt_CodigoBarra_TextChanged(object sender, EventArgs e)
        {
            axBarcode_Shajobe.Text = txt_CodigoBarra.Text;
             
        }
        void DocumentoParaImprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
        }
        #region Funcion Imprimir y Vista Previa
        private void btImprimir_Click(object sender, EventArgs e)
        {
            CapturaFormulario();
            Impresora.Document = DocumentoParaImprimir;
            DialogResult Result = Impresora.ShowDialog();
            if (Result == DialogResult.OK)
            {
                DocumentoParaImprimir.DefaultPageSettings.Landscape = false;
                DocumentoParaImprimir.Print();
            }
        }
        private void btVistaPrevia_Click(object sender, EventArgs e)
        {
            CapturaFormulario();
            VistaPrevia.Document = DocumentoParaImprimir;
            VistaPrevia.ShowDialog();
        }
        #endregion
        #region Captura Formulacion
        private void CapturaFormulario()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size sz = this.ClientRectangle.Size;
            bmp = new Bitmap(sz.Width, sz.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                   this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);

            //bmp.Save("prueba.bmp", ImageFormat.Bmp);
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            int dwRop);
        #endregion
        private void txt_CodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        
    }
}
