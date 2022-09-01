
namespace semana5_formularioMDI
{
    partial class Carreras
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
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(159)))));
            this.label3.ImageKey = "(ninguno)";
            this.label3.Location = new System.Drawing.Point(89, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "CARRERAS PRECENCIALES ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(135)))), ((int)(((byte)(203)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(423, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 39);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cerrar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(135)))), ((int)(((byte)(203)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(146, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Enviar ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(159)))));
            this.label2.Location = new System.Drawing.Point(406, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "CARRERAS SEMIPRECENSIALES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(159)))));
            this.label1.Location = new System.Drawing.Point(91, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "CARRERAS VIRTUALES";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "(VACIO)",
            "ARQUITECTURA",
            "INGENIERIA EN MANEJO Y GESTION DE DATOS ",
            "INGENIERIA EN SISTEMAS Y REDES INFORMATICAS"});
            this.listBox1.Location = new System.Drawing.Point(71, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 17);
            this.listBox1.TabIndex = 25;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "(VACIO)",
            "TECNICO BILINGUE INGLES-ESPAÑOL",
            "LICENCIATURA EN ADMINISTRACION DE EMPRESAS",
            "LICENCIATURA EN ADMINISTRACION DE EMPRESAS",
            "INGIENERIA EN SISTEMAS Y REDES INFORMATICAS",
            "MAESTRIA EN DIRECCION ESTRATEGICA DE EMPRESAS "});
            this.listBox2.Location = new System.Drawing.Point(71, 256);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(254, 17);
            this.listBox2.TabIndex = 27;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "(VACIO)",
            "INGENIERIA EN SISTEMAS Y REDES INFORMATICAS"});
            this.listBox3.Location = new System.Drawing.Point(389, 89);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(283, 17);
            this.listBox3.TabIndex = 28;
            // 
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Carreras";
            this.Text = "Docente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}