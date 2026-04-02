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
            this.lblIngrese.Location = new System.Drawing.Point(123, 50);
            this.lblIngrese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(199, 25);
            this.lblIngrese.TabIndex = 1;
            this.lblIngrese.Text = "Ingrese un nombre:";
            this.lblIngrese.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(373, 50);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(319, 22);
            this.txtNombres.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(753, 44);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbIzquierda
            // 
            this.lbIzquierda.FormattingEnabled = true;
            this.lbIzquierda.ItemHeight = 16;
            this.lbIzquierda.Location = new System.Drawing.Point(128, 134);
            this.lbIzquierda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbIzquierda.Name = "lbIzquierda";
            this.lbIzquierda.Size = new System.Drawing.Size(276, 324);
            this.lbIzquierda.TabIndex = 4;
            this.lbIzquierda.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbPersonas2
            // 
            this.lbPersonas2.FormattingEnabled = true;
            this.lbPersonas2.ItemHeight = 16;
            this.lbPersonas2.Location = new System.Drawing.Point(677, 134);
            this.lbPersonas2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPersonas2.Name = "lbPersonas2";
            this.lbPersonas2.Size = new System.Drawing.Size(276, 324);
            this.lbPersonas2.TabIndex = 5;
            this.lbPersonas2.SelectedIndexChanged += new System.EventHandler(this.lbPersonas2_SelectedIndexChanged);
            // 
            // btnPasar
            // 
            this.btnPasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasar.Location = new System.Drawing.Point(501, 208);
            this.btnPasar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(80, 38);
            this.btnPasar.TabIndex = 6;
            this.btnPasar.Text = ">";
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);

            // 
            // btnPasarTodo
            // 
            this.btnPasarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodo.Location = new System.Drawing.Point(501, 284);
            this.btnPasarTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasarTodo.Name = "btnPasarTodo";
            this.btnPasarTodo.Size = new System.Drawing.Size(80, 38);
            this.btnPasarTodo.TabIndex = 7;
            this.btnPasarTodo.Text = ">>";
            this.btnPasarTodo.UseVisualStyleBackColor = true;
            this.btnPasarTodo.Click += new System.EventHandler(this.btnPasarTodo_Click);

            // 
            // Form1ej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPasarTodo);
            this.Controls.Add(this.btnPasar);
            this.Controls.Add(this.lbPersonas2);
            this.Controls.Add(this.lbIzquierda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblIngrese);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1ej";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1ej";
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