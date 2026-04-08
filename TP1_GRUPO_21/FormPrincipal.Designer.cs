namespace TP1_GRUPO_21
{
    partial class FormPrincipal
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
            this.button1ej = new System.Windows.Forms.Button();
            this.button2ej = new System.Windows.Forms.Button();
            this.button3ej = new System.Windows.Forms.Button();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1ej
            // 
            this.button1ej.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1ej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1ej.Location = new System.Drawing.Point(12, 12);
            this.button1ej.Name = "button1ej";
            this.button1ej.Size = new System.Drawing.Size(163, 46);
            this.button1ej.TabIndex = 0;
            this.button1ej.Text = "EJERCICIO 1";
            this.button1ej.UseVisualStyleBackColor = true;
            this.button1ej.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2ej
            // 
            this.button2ej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2ej.Location = new System.Drawing.Point(181, 12);
            this.button2ej.Name = "button2ej";
            this.button2ej.Size = new System.Drawing.Size(163, 46);
            this.button2ej.TabIndex = 1;
            this.button2ej.Text = "EJERCICIO 2";
            this.button2ej.UseVisualStyleBackColor = true;
            this.button2ej.Click += new System.EventHandler(this.button2ej_Click);
            // 
            // button3ej
            // 
            this.button3ej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3ej.Location = new System.Drawing.Point(350, 12);
            this.button3ej.Name = "button3ej";
            this.button3ej.Size = new System.Drawing.Size(163, 46);
            this.button3ej.TabIndex = 2;
            this.button3ej.Text = "EJERCICIO 3";
            this.button3ej.UseVisualStyleBackColor = true;
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(12, 87);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(140, 162);
            this.lblIntegrantes.TabIndex = 3;
            this.lblIntegrantes.Text = "Integrantes:\r\n\r\n• Tomas Bottelli\r\n\r\n• Santiago Romero\r\n\r\n• Renato Canavesi\r\n\r\n• S" +
    "ebastian Fuentes";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 291);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.button3ej);
            this.Controls.Add(this.button2ej);
            this.Controls.Add(this.button1ej);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1ej;
        private System.Windows.Forms.Button button2ej;
        private System.Windows.Forms.Button button3ej;
        private System.Windows.Forms.Label lblIntegrantes;
    }
}

