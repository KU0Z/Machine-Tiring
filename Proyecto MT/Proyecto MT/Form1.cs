using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MT
{
    public partial class Form1 : Form
    {
        private int pasos = 0;
        public Form1()
        { 
            InitializeComponent();
            InitializeGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DgvCinta.ColumnCount++;
            //DgvCinta.Columns[DgvCinta.ColumnCount-1].Width = 50;
            //DgvCinta.CurrentCell = DgvCinta[15, 0];
            ////DgvCinta.CurrentCell.Style.SelectionBackColor = Color.Green;
            //DgvCinta.Rows[0].Cells[15].Value = "1";
            //DgvCinta.Font = new Font("Tahoma", 15);
            timer1.Enabled = true;

        }
        private void InitializeGrid()
        {
            DgvCinta.ColumnCount = 0;
            DgvCinta.RowCount = 1;
            DgvCinta.ColumnCount = 20;

            for (int i = 0; i < 20; i++)
            {
                
                DgvCinta.Columns[i].Width = 50;
            }
            DgvCinta.Rows[0].Height = 50;
            DgvCinta.CurrentCell = DgvCinta[0, 0];
            DgvCinta.CurrentCell.Style.SelectionBackColor = Color.Green;
            DgvCinta.Font = new Font("Tahoma", 15);

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            InitializeGrid();
            int tamañoCinta = DgvCinta.ColumnCount;
            string entrada = tbEntrada.Text;
            if(tamañoCinta<= entrada.Length)
            {
                for (int i = 0; i < entrada.Length; i++)
                {
                    DgvCinta.ColumnCount++;
                    DgvCinta.Columns[DgvCinta.ColumnCount - 1].Width = 50;
                }
            }
            for (int i = 0; i < entrada.Length; i++)
            {
                DgvCinta.Rows[0].Cells[i].Value = entrada.Substring(i,1);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pasos++;
            DgvCinta.CurrentCell = DgvCinta[pasos, 0];
            DgvCinta.CurrentCell.Style.SelectionBackColor = Color.Green;

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void tbVelocidad_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tbVelocidad.Value;
        }
    }
}
