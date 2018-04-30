namespace Proyecto_MT
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
            this.DgvCinta = new System.Windows.Forms.DataGridView();
            this.next = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCinta)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCinta
            // 
            this.DgvCinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCinta.ColumnHeadersVisible = false;
            this.DgvCinta.Location = new System.Drawing.Point(43, 52);
            this.DgvCinta.Name = "DgvCinta";
            this.DgvCinta.ReadOnly = true;
            this.DgvCinta.RowHeadersVisible = false;
            this.DgvCinta.Size = new System.Drawing.Size(933, 70);
            this.DgvCinta.TabIndex = 0;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(43, 180);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(64, 25);
            this.next.TabIndex = 1;
            this.next.Text = "button1";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maquina de Turing";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(43, 154);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(222, 20);
            this.tbEntrada.TabIndex = 4;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(272, 154);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 371);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.tbEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.DgvCinta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCinta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCinta;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Button btnCargar;
    }
}

