namespace Sistema_Shajobe
{
    partial class CodigoBarra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigoBarra));
            this.txt_CodigoBarra = new System.Windows.Forms.TextBox();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.axBarcode_Shajobe = new AxBARCODELib.AxBarcode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_NombreEmpresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axBarcode_Shajobe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_CodigoBarra
            // 
            this.txt_CodigoBarra.Location = new System.Drawing.Point(190, 202);
            this.txt_CodigoBarra.MaximumSize = new System.Drawing.Size(100, 20);
            this.txt_CodigoBarra.MaxLength = 13;
            this.txt_CodigoBarra.MinimumSize = new System.Drawing.Size(100, 20);
            this.txt_CodigoBarra.Name = "txt_CodigoBarra";
            this.txt_CodigoBarra.Size = new System.Drawing.Size(100, 20);
            this.txt_CodigoBarra.TabIndex = 2;
            this.txt_CodigoBarra.TextChanged += new System.EventHandler(this.txt_CodigoBarra_TextChanged);
            this.txt_CodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoBarra_KeyPress);
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Location = new System.Drawing.Point(97, 186);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(281, 13);
            this.lbl_Cod.TabIndex = 4;
            this.lbl_Cod.Text = "Tecle una numeración para convertirla en codigo de barra";
            // 
            // axBarcode_Shajobe
            // 
            this.axBarcode_Shajobe.Enabled = true;
            this.axBarcode_Shajobe.Location = new System.Drawing.Point(35, 22);
            this.axBarcode_Shajobe.Name = "axBarcode_Shajobe";
            this.axBarcode_Shajobe.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axBarcode_Shajobe.OcxState")));
            this.axBarcode_Shajobe.Size = new System.Drawing.Size(400, 150);
            this.axBarcode_Shajobe.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_NombreEmpresa);
            this.panel1.Location = new System.Drawing.Point(65, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 25);
            this.panel1.TabIndex = 6;
            // 
            // lbl_NombreEmpresa
            // 
            this.lbl_NombreEmpresa.AutoSize = true;
            this.lbl_NombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreEmpresa.Location = new System.Drawing.Point(45, 4);
            this.lbl_NombreEmpresa.Name = "lbl_NombreEmpresa";
            this.lbl_NombreEmpresa.Size = new System.Drawing.Size(245, 15);
            this.lbl_NombreEmpresa.TabIndex = 0;
            this.lbl_NombreEmpresa.Text = "NUEZ FINA DE LA LAGUNA SHAJOBE";
            // 
            // CodigoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 252);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axBarcode_Shajobe);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.txt_CodigoBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodigoBarra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo de barra";
            this.Load += new System.EventHandler(this.Codigo_de_barra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axBarcode_Shajobe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CodigoBarra;
        private System.Windows.Forms.Label lbl_Cod;
        private AxBARCODELib.AxBarcode axBarcode_Shajobe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_NombreEmpresa;

    }
}