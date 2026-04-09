namespace TP1_GRUPO_21
{
    partial class Form3ej
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
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.cblOpciones = new System.Windows.Forms.CheckedListBox();
            this.btnSelecciones = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
=======
            this.cblOpciones = new System.Windows.Forms.CheckedListBox();
            this.btnSelecciones = new System.Windows.Forms.Button();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
>>>>>>> 72f6da85ccc1ff8fa0bd23d2089f91a60e17d3d2
            this.gbSexo.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(12, 58);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(124, 100);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 44);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
<<<<<<< HEAD
            this.rbFemenino.Checked = true;
=======
>>>>>>> 72f6da85ccc1ff8fa0bd23d2089f91a60e17d3d2
            this.rbFemenino.Location = new System.Drawing.Point(7, 20);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Location = new System.Drawing.Point(310, 58);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(134, 100);
            this.gbEstadoCivil.TabIndex = 1;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
<<<<<<< HEAD
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(18, 20);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(18, 44);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 0;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // cblOpciones
            // 
            this.cblOpciones.FormattingEnabled = true;
            this.cblOpciones.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
=======
            // cblOpciones
            // 
            this.cblOpciones.FormattingEnabled = true;
>>>>>>> 72f6da85ccc1ff8fa0bd23d2089f91a60e17d3d2
            this.cblOpciones.Location = new System.Drawing.Point(165, 176);
            this.cblOpciones.Name = "cblOpciones";
            this.cblOpciones.Size = new System.Drawing.Size(120, 94);
            this.cblOpciones.TabIndex = 2;
            // 
            // btnSelecciones
            // 
            this.btnSelecciones.Location = new System.Drawing.Point(137, 294);
            this.btnSelecciones.Name = "btnSelecciones";
            this.btnSelecciones.Size = new System.Drawing.Size(182, 23);
            this.btnSelecciones.TabIndex = 3;
            this.btnSelecciones.Text = "Mostrar lo que se seleccionó";
            this.btnSelecciones.UseVisualStyleBackColor = true;
            this.btnSelecciones.Click += new System.EventHandler(this.btnSelecciones_Click);
            // 
<<<<<<< HEAD
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(91, 331);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 4;
=======
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(18, 20);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 0;
            this.rbSoltero.TabStop = true;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(18, 44);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
>>>>>>> 72f6da85ccc1ff8fa0bd23d2089f91a60e17d3d2
            // 
            // Form3ej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
<<<<<<< HEAD
            this.Controls.Add(this.lblResultado);
=======
>>>>>>> 72f6da85ccc1ff8fa0bd23d2089f91a60e17d3d2
            this.Controls.Add(this.btnSelecciones);
            this.Controls.Add(this.cblOpciones);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.gbSexo);
            this.Name = "Form3ej";
            this.Text = "Form3ej";
<<<<<<< HEAD
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3ej_FormClosed);
=======
>>>>>>> 72f6da85ccc1ff8fa0bd23d2089f91a60e17d3d2
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
<<<<<<< HEAD
            this.PerformLayout();
=======
>>>>>>> 72f6da85ccc1ff8fa0bd23d2089f91a60e17d3d2

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.CheckedListBox cblOpciones;
        private System.Windows.Forms.Button btnSelecciones;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSoltero;
<<<<<<< HEAD
        private System.Windows.Forms.Label lblResultado;
=======
>>>>>>> 72f6da85ccc1ff8fa0bd23d2089f91a60e17d3d2
    }
}