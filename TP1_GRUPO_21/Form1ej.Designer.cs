namespace TP1_GRUPO_21
{
    partial class Form1ej
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
            this.lblIngrese = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbIzquierda = new System.Windows.Forms.ListBox();
            this.lbPersonas2 = new System.Windows.Forms.ListBox();
            this.btnPasar = new System.Windows.Forms.Button();
            this.btnPasarTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIngrese.Location = new System.Drawing.Point(92, 41);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(165, 20);
            this.lblIngrese.TabIndex = 1;
            this.lblIngrese.Text = "Ingrese un nombre:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(280, 41);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(240, 20);
            this.txtNombres.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(565, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbIzquierda
            // 
            this.lbIzquierda.FormattingEnabled = true;
            this.lbIzquierda.Location = new System.Drawing.Point(96, 109);
            this.lbIzquierda.Name = "lbIzquierda";
            this.lbIzquierda.Size = new System.Drawing.Size(208, 264);
            this.lbIzquierda.TabIndex = 4;
            // 
            // lbPersonas2
            // 
            this.lbPersonas2.FormattingEnabled = true;
            this.lbPersonas2.Location = new System.Drawing.Point(508, 109);
            this.lbPersonas2.Name = "lbPersonas2";
            this.lbPersonas2.Size = new System.Drawing.Size(208, 264);
            this.lbPersonas2.TabIndex = 5;
            // 
            // btnPasar
            // 
            this.btnPasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasar.Location = new System.Drawing.Point(376, 169);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(60, 31);
            this.btnPasar.TabIndex = 6;
            this.btnPasar.Text = ">";
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);
            // 
            // btnPasarTodo
            // 
            this.btnPasarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodo.Location = new System.Drawing.Point(376, 231);
            this.btnPasarTodo.Name = "btnPasarTodo";
            this.btnPasarTodo.Size = new System.Drawing.Size(60, 31);
            this.btnPasarTodo.TabIndex = 7;
            this.btnPasarTodo.Text = ">>";
            this.btnPasarTodo.UseVisualStyleBackColor = true;
            this.btnPasarTodo.Click += new System.EventHandler(this.btnPasarTodo_Click);
            // 
            // Nombres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPasarTodo);
            this.Controls.Add(this.btnPasar);
            this.Controls.Add(this.lbPersonas2);
            this.Controls.Add(this.lbIzquierda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblIngrese);
            this.Name = "Nombres";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1ej_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbIzquierda;
        private System.Windows.Forms.ListBox lbPersonas2;
        private System.Windows.Forms.Button btnPasar;
        private System.Windows.Forms.Button btnPasarTodo;
    }
}