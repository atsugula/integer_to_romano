namespace app
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 196);
            this.panel1.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConvert.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(41, 80);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(145, 48);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "CONVERTIR";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el número a convertir:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(41, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 48);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "LIMPIAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(41, 42);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(145, 20);
            this.txtNumber.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 193);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio en clase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

