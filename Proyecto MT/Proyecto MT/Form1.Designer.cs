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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvCinta = new System.Windows.Forms.DataGridView();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDetener = new System.Windows.Forms.Button();
            this.tbVelocidad = new System.Windows.Forms.TrackBar();
            this.dgvTranciciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranciciones)).BeginInit();
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
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(43, 180);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(64, 25);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "button1";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.Palíndromos",
            "2.Copia de patrones",
            "3.Multiplicación en código unario",
            "4.Suma en código unario",
            "5.Resta en código unario"});
            this.comboBox1.Location = new System.Drawing.Point(43, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(200, 180);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 6;
            this.btnDetener.Text = "button1";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // tbVelocidad
            // 
            this.tbVelocidad.LargeChange = 100;
            this.tbVelocidad.Location = new System.Drawing.Point(43, 211);
            this.tbVelocidad.Maximum = 1000;
            this.tbVelocidad.Minimum = 100;
            this.tbVelocidad.Name = "tbVelocidad";
            this.tbVelocidad.Size = new System.Drawing.Size(194, 45);
            this.tbVelocidad.TabIndex = 7;
            this.tbVelocidad.Value = 500;
            this.tbVelocidad.Scroll += new System.EventHandler(this.tbVelocidad_Scroll);
            // 
            // dgvTranciciones
            // 
            this.dgvTranciciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTranciciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTranciciones.Location = new System.Drawing.Point(466, 138);
            this.dgvTranciciones.Name = "dgvTranciciones";
            this.dgvTranciciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTranciciones.Size = new System.Drawing.Size(510, 157);
            this.dgvTranciciones.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 371);
            this.Controls.Add(this.dgvTranciciones);
            this.Controls.Add(this.tbVelocidad);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.tbEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.DgvCinta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranciciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCinta;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.TrackBar tbVelocidad;
        private System.Windows.Forms.DataGridView dgvTranciciones;
    }
}

