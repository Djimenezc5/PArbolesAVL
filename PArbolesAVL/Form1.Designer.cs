namespace PArbolesAVL
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxPP = new System.Windows.Forms.ComboBox();
            this.comboBoxDP = new System.Windows.Forms.ComboBox();
            this.listarBtt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.agregarPBtt = new System.Windows.Forms.Button();
            this.montoPTextBox = new System.Windows.Forms.TextBox();
            this.nomPTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 267);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(407, 105);
            this.textBox1.TabIndex = 36;
            // 
            // comboBoxPP
            // 
            this.comboBoxPP.FormattingEnabled = true;
            this.comboBoxPP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxPP.Location = new System.Drawing.Point(250, 8);
            this.comboBoxPP.Name = "comboBoxPP";
            this.comboBoxPP.Size = new System.Drawing.Size(172, 21);
            this.comboBoxPP.TabIndex = 33;
            // 
            // comboBoxDP
            // 
            this.comboBoxDP.FormattingEnabled = true;
            this.comboBoxDP.Items.AddRange(new object[] {
            "Alta Verapaz",
            "Baja Verapaz",
            "Chimaltenago",
            "Chiquimula",
            "Guatemala",
            "El Progreso",
            "Escuintla",
            "Huehuetenango",
            "Izabal",
            "Jalapa",
            "Jutiapa",
            "Petén",
            "Quetzaltenango",
            "Quiché",
            "Retalhuleu",
            "Sacatepequez",
            "San Marcos",
            "Santa Rosa",
            "Sololá",
            "Suchitepequez",
            "Totonicapán",
            "Zacapa"});
            this.comboBoxDP.Location = new System.Drawing.Point(250, 47);
            this.comboBoxDP.Name = "comboBoxDP";
            this.comboBoxDP.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDP.TabIndex = 32;
            // 
            // listarBtt
            // 
            this.listarBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarBtt.Location = new System.Drawing.Point(342, 237);
            this.listarBtt.Name = "listarBtt";
            this.listarBtt.Size = new System.Drawing.Size(81, 20);
            this.listarBtt.TabIndex = 31;
            this.listarBtt.Text = "Listar";
            this.listarBtt.UseVisualStyleBackColor = true;
            this.listarBtt.Click += new System.EventHandler(this.listarBtt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Listar todos los proyectos:";
            // 
            // agregarPBtt
            // 
            this.agregarPBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarPBtt.Location = new System.Drawing.Point(250, 156);
            this.agregarPBtt.Name = "agregarPBtt";
            this.agregarPBtt.Size = new System.Drawing.Size(172, 42);
            this.agregarPBtt.TabIndex = 28;
            this.agregarPBtt.Text = "Agregar un Proyecto";
            this.agregarPBtt.UseVisualStyleBackColor = true;
            this.agregarPBtt.Click += new System.EventHandler(this.agregarPBtt_Click);
            // 
            // montoPTextBox
            // 
            this.montoPTextBox.Location = new System.Drawing.Point(250, 122);
            this.montoPTextBox.Name = "montoPTextBox";
            this.montoPTextBox.Size = new System.Drawing.Size(172, 20);
            this.montoPTextBox.TabIndex = 27;
            // 
            // nomPTextBox
            // 
            this.nomPTextBox.Location = new System.Drawing.Point(250, 81);
            this.nomPTextBox.Name = "nomPTextBox";
            this.nomPTextBox.Size = new System.Drawing.Size(172, 20);
            this.nomPTextBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Monto del proyecto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Departamento del proyecto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Prioridad del proyecto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre del proyecto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 383);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxPP);
            this.Controls.Add(this.comboBoxDP);
            this.Controls.Add(this.listarBtt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agregarPBtt);
            this.Controls.Add(this.montoPTextBox);
            this.Controls.Add(this.nomPTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxPP;
        private System.Windows.Forms.ComboBox comboBoxDP;
        private System.Windows.Forms.Button listarBtt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button agregarPBtt;
        private System.Windows.Forms.TextBox montoPTextBox;
        private System.Windows.Forms.TextBox nomPTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

