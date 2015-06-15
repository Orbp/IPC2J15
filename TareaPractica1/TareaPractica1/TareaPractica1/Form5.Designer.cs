namespace TareaPractica1
{
    partial class Form5
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
            this.BTPrestar = new System.Windows.Forms.Button();
            this.BTReservar = new System.Windows.Forms.Button();
            this.BTDevolver = new System.Windows.Forms.Button();
            this.BTRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la operación que desea realizar";
            // 
            // BTPrestar
            // 
            this.BTPrestar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPrestar.Location = new System.Drawing.Point(120, 50);
            this.BTPrestar.Name = "BTPrestar";
            this.BTPrestar.Size = new System.Drawing.Size(137, 29);
            this.BTPrestar.TabIndex = 1;
            this.BTPrestar.Text = "Prestar Libro";
            this.BTPrestar.UseVisualStyleBackColor = true;
            this.BTPrestar.Click += new System.EventHandler(this.BTPrestar_Click);
            // 
            // BTReservar
            // 
            this.BTReservar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTReservar.Location = new System.Drawing.Point(120, 99);
            this.BTReservar.Name = "BTReservar";
            this.BTReservar.Size = new System.Drawing.Size(137, 29);
            this.BTReservar.TabIndex = 2;
            this.BTReservar.Text = "Reservar Libro";
            this.BTReservar.UseVisualStyleBackColor = true;
            this.BTReservar.Click += new System.EventHandler(this.BTReservar_Click);
            // 
            // BTDevolver
            // 
            this.BTDevolver.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDevolver.Location = new System.Drawing.Point(120, 148);
            this.BTDevolver.Name = "BTDevolver";
            this.BTDevolver.Size = new System.Drawing.Size(137, 29);
            this.BTDevolver.TabIndex = 3;
            this.BTDevolver.Text = "Devolver Libro";
            this.BTDevolver.UseVisualStyleBackColor = true;
            this.BTDevolver.Click += new System.EventHandler(this.BTDevolver_Click);
            // 
            // BTRegresar
            // 
            this.BTRegresar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegresar.Location = new System.Drawing.Point(120, 192);
            this.BTRegresar.Name = "BTRegresar";
            this.BTRegresar.Size = new System.Drawing.Size(137, 29);
            this.BTRegresar.TabIndex = 4;
            this.BTRegresar.Text = "Regresar";
            this.BTRegresar.UseVisualStyleBackColor = true;
            this.BTRegresar.Click += new System.EventHandler(this.BTRegresar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 242);
            this.Controls.Add(this.BTRegresar);
            this.Controls.Add(this.BTDevolver);
            this.Controls.Add(this.BTReservar);
            this.Controls.Add(this.BTPrestar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTPrestar;
        private System.Windows.Forms.Button BTReservar;
        private System.Windows.Forms.Button BTDevolver;
        private System.Windows.Forms.Button BTRegresar;
    }
}