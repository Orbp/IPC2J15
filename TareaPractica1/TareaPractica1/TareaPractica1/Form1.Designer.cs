namespace TareaPractica1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegistrarLibro = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnPrestamo = new System.Windows.Forms.Button();
            this.BtnRegistrarMiembro = new System.Windows.Forms.Button();
            this.BTLibrosprestados = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a la libreria Whizz Hard Books";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "A continuación seleccione una opción a realizar";
            this.label2.UseWaitCursor = true;
            // 
            // BtnRegistrarLibro
            // 
            this.BtnRegistrarLibro.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarLibro.Location = new System.Drawing.Point(30, 96);
            this.BtnRegistrarLibro.Name = "BtnRegistrarLibro";
            this.BtnRegistrarLibro.Size = new System.Drawing.Size(231, 41);
            this.BtnRegistrarLibro.TabIndex = 2;
            this.BtnRegistrarLibro.Text = "Registrar nuevo libro";
            this.BtnRegistrarLibro.UseVisualStyleBackColor = true;
            this.BtnRegistrarLibro.UseWaitCursor = true;
            this.BtnRegistrarLibro.Click += new System.EventHandler(this.BtnRegistrarLibro_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(302, 96);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(231, 41);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.Text = "Consultar libros";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.UseWaitCursor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnPrestamo
            // 
            this.BtnPrestamo.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrestamo.Location = new System.Drawing.Point(30, 161);
            this.BtnPrestamo.Name = "BtnPrestamo";
            this.BtnPrestamo.Size = new System.Drawing.Size(231, 59);
            this.BtnPrestamo.TabIndex = 4;
            this.BtnPrestamo.Text = "Préstamo, Reserva y Devolución";
            this.BtnPrestamo.UseVisualStyleBackColor = true;
            this.BtnPrestamo.UseWaitCursor = true;
            this.BtnPrestamo.Click += new System.EventHandler(this.BtnPrestamo_Click);
            // 
            // BtnRegistrarMiembro
            // 
            this.BtnRegistrarMiembro.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarMiembro.Location = new System.Drawing.Point(302, 161);
            this.BtnRegistrarMiembro.Name = "BtnRegistrarMiembro";
            this.BtnRegistrarMiembro.Size = new System.Drawing.Size(231, 59);
            this.BtnRegistrarMiembro.TabIndex = 5;
            this.BtnRegistrarMiembro.Text = "Registrar nuevo miembro";
            this.BtnRegistrarMiembro.UseVisualStyleBackColor = true;
            this.BtnRegistrarMiembro.UseWaitCursor = true;
            this.BtnRegistrarMiembro.Click += new System.EventHandler(this.BtnRegistrarMiembro_Click);
            // 
            // BTLibrosprestados
            // 
            this.BTLibrosprestados.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLibrosprestados.Location = new System.Drawing.Point(30, 238);
            this.BTLibrosprestados.Name = "BTLibrosprestados";
            this.BTLibrosprestados.Size = new System.Drawing.Size(231, 41);
            this.BTLibrosprestados.TabIndex = 6;
            this.BTLibrosprestados.Text = "Libros más prestados";
            this.BTLibrosprestados.UseVisualStyleBackColor = true;
            this.BTLibrosprestados.UseWaitCursor = true;
            this.BTLibrosprestados.Click += new System.EventHandler(this.BTLibrosprestados_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(302, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar Aplicación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTLibrosprestados);
            this.Controls.Add(this.BtnRegistrarMiembro);
            this.Controls.Add(this.BtnPrestamo);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnRegistrarLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Librería Whizz Hard Books - Inicio";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegistrarLibro;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnPrestamo;
        private System.Windows.Forms.Button BtnRegistrarMiembro;
        private System.Windows.Forms.Button BTLibrosprestados;
        private System.Windows.Forms.Button button2;
    }
}

