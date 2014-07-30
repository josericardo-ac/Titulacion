using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Se agregan librerias para uso de video
using AForge.Video;
using AForge.Video.DirectShow;
//Uso de directorios

namespace Sistema_Shajobe
{
    public partial class Captura_Foto : Form
    {
        private bool existenDispositivos = false;
        private bool fotografiaHecha = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;
        public Captura_Foto()
        {
            InitializeComponent();
            BuscarDispositivos();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.Button btn_capturar;
        private System.Windows.Forms.PictureBox pctbox_webcam;
        private System.Windows.Forms.PictureBox pctbox_imagen;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_NombreImagen;
        private System.Windows.Forms.Label lbl_NombreImagen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            components = new System.ComponentModel.Container();
            btn_capturar = new System.Windows.Forms.Button();
            pctbox_webcam = new System.Windows.Forms.PictureBox();
            pctbox_imagen = new System.Windows.Forms.PictureBox();
            btn_guardar = new System.Windows.Forms.Button();
            txt_NombreImagen = new System.Windows.Forms.TextBox();
            lbl_NombreImagen = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pctbox_webcam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pctbox_imagen)).BeginInit();
            SuspendLayout();
            #endregion
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_capturar
            // 
            btn_capturar.Location = new System.Drawing.Point(327, 330);
            btn_capturar.Name = "btn_capturar";
            btn_capturar.Size = new System.Drawing.Size(100, 35);
            btn_capturar.TabIndex = 1;
            btn_capturar.Text = "Capturar";
            btn_capturar.UseVisualStyleBackColor = true;
            btn_capturar.Click += new System.EventHandler(btn_capturar_Click);
            // 
            // pctbox_webcam
            // 
            pctbox_webcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pctbox_webcam.Location = new System.Drawing.Point(12, 12);
            pctbox_webcam.Name = "pctbox_webcam";
            pctbox_webcam.Size = new System.Drawing.Size(300, 300);
            pctbox_webcam.TabIndex = 2;
            pctbox_webcam.TabStop = false;
            // 
            // pctbox_imagen
            // 
            pctbox_imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pctbox_imagen.Location = new System.Drawing.Point(327, 12);
            pctbox_imagen.Name = "pctbox_imagen";
            pctbox_imagen.Size = new System.Drawing.Size(300, 300);
            pctbox_imagen.TabIndex = 3;
            pctbox_imagen.TabStop = false;
            // 
            // txt_NombreImagen
            // 
            txt_NombreImagen.Location = new System.Drawing.Point(12, 348);
            txt_NombreImagen.Name = "txt_NombreImagen";
            txt_NombreImagen.Size = new System.Drawing.Size(300, 20);
            txt_NombreImagen.TabIndex = 4;
            // 
            // lbl_NombreImagen
            // 
            lbl_NombreImagen.AutoSize = true;
            lbl_NombreImagen.Location = new System.Drawing.Point(17, 332);
            lbl_NombreImagen.Name = "lbl_NombreImagen";
            lbl_NombreImagen.Size = new System.Drawing.Size(85, 13);
            lbl_NombreImagen.TabIndex = 5;
            lbl_NombreImagen.Text = "Nombre de la imagen:";
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new System.Drawing.Point(433, 330);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new System.Drawing.Size(100, 35);
            btn_guardar.TabIndex = 6;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += new System.EventHandler(btn_guardar_Click);
            // 
            // Frm_Index
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(639, 410);
            Controls.Add(btn_guardar);
            Controls.Add(this.lbl_NombreImagen);
            Controls.Add(this.txt_NombreImagen);
            Controls.Add(pctbox_imagen);
            Controls.Add(pctbox_webcam);
            Controls.Add(btn_capturar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximumSize = new System.Drawing.Size(639, 410);
            MinimumSize = new System.Drawing.Size(639, 410);
            MaximizeBox = false;
            Name = "Frm_Index";
            Text = "Proyecto - Captura por Webcam";
            Load += new System.EventHandler(Frm_Index_Load);
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(Frm_Index_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(pctbox_webcam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pctbox_imagen)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        /*
         *  Carga del formulario
         */
        private void Frm_Index_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
            if (existenDispositivos)
            {
                fuenteDeVideo = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);
                fuenteDeVideo.NewFrame += new NewFrameEventHandler(MostrarImagen);
                fuenteDeVideo.Start();
            }
            else
            {
                MessageBox.Show("No se encuentra ningún dispositivo de vídeo en el sistema", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CerrarFormulario();
            }
        }
        /*
         *  Cerrando el formulario (evento)
         */
        private void Frm_Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            CerrarFormulario();
        }
        /*
         *  Cerrar el formulario
         */
        private void CerrarFormulario()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }
            Dispose();
            Close();
            Application.OpenForms["Menu_principal"].Activate();
        }
        /*
         *  Botón de Capturar
         */
        private void btn_capturar_Click(object sender, EventArgs e)
        {
            Capturar();
            fotografiaHecha = true;
        }
        /*
         *  Botón de Guardar
         */
        public void CrearDirectorioImagenes()
        {
            //Indico la direccion donde quiero generar mi carpeta
            string Nombre_Carpeta = @"C:\Shajobe";
            //Creo mi carpeta y una subcarpeta dentro
            string DireccionString = System.IO.Path.Combine(Nombre_Carpeta, "Imagenes");
            System.IO.Directory.CreateDirectory(DireccionString);

        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_NombreImagen.Text.Trim()=="")
            {
                MessageBox.Show("Escribe el nombre de la imagen", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txt_NombreImagen, "No puedes dejar el campo vacio");
            }
            else
            {
                if (fotografiaHecha)
                {
                    // Recorto la imagen conforme lo mostrado (Size del pctbox_webcam)
                    Rectangle formaRecorte = new Rectangle(0, 0, 300, 300);
                    Bitmap imagenOrigen = (Bitmap)pctbox_imagen.Image;
                    Bitmap imagen = imagenOrigen.Clone(formaRecorte, imagenOrigen.PixelFormat);

                    // Y la guardo
                    try
                    {
                        string ruta = @"C:\Shajobe\Imagenes";

                        if (System.IO.Directory.Exists(ruta))
                        {
                            //String ruta = txt_NombreImagen.Text.Trim();
                            if (!ruta.Substring(ruta.Length - 1).Equals("\\"))
                                ruta += "\\";
                            ruta =ruta+txt_NombreImagen.Text+".jpg";
                            imagen.Save(ruta);
                            MessageBox.Show("Fotografía almacenada", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_NombreImagen.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Carpeta no existe se va a generar el directorio presione aceptar y vuelva a intentarlo", "La carpeta no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            CrearDirectorioImagenes();
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Para guardar la fotografía, use en primer lugar el botón de Captura", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        /*
         *  Identifica los dispositivos disponibles
         */
        private void BuscarDispositivos()
        {
            dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosDeVideo.Count == 0)
                existenDispositivos = false;
            else
                existenDispositivos = true;
        }
        /*
         *  Muestra imagen en el PictureBox
         */
        private void MostrarImagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pctbox_webcam.Image = imagen;
        }
        /*
         *  Deja de capturar imágenes, obteniendo la última capturada
         */
        private void Capturar()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    pctbox_imagen.Image = pctbox_webcam.Image;
                }
            }
        }
    }
}
