﻿using System;
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
        private Maquina maquina;
        public Form1()
        { 
            InitializeComponent();
            InitializeGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            //DgvCinta.ColumnCount++;
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
                DgvCinta.Rows[0].Cells[i].Value = "";
            }
            DgvCinta.Rows[0].Height = 50;
            DgvCinta.CurrentCell = DgvCinta[1, 0];
   
            DgvCinta.Font = new Font("Tahoma", 15);

        }
        private void InitializeGridtraciones()
        {
            dgvTranciciones.RowCount = maquina.tabla.GetLength(0);
            dgvTranciciones.ColumnCount = maquina.tabla.GetLength(1);

            for (int i = 0; i < dgvTranciciones.ColumnCount; i++)
            {
                dgvTranciciones.Columns[i].Width = 60;
                string[] x = maquina.simbolosCinta[i].Split(',');
                dgvTranciciones.Columns[i].HeaderText = x[0];
            }
            for (int i = 0; i < dgvTranciciones.RowCount; i++)
            {
                dgvTranciciones.Rows[i].Height = 25;
                dgvTranciciones.Rows[i].HeaderCell.Value = "q"+i;
                
            }
            dgvTranciciones.RowHeadersWidth = 50;
            for (int i = 0; i < dgvTranciciones.ColumnCount; i++)
            {
                for (int j = 0; j < dgvTranciciones.RowCount; j++)
                {
                   dgvTranciciones.Rows[j].Cells[i].Value = maquina.tabla[j, i] ;
                }
            }
            dgvTranciciones.Font = new Font("Tahoma", 7);

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            pasos = 0;
            timer1.Enabled = false;
            panel1.Enabled = true;
            InitializeGrid();
            inicializarmaquina();
            lbEstado.ForeColor = System.Drawing.Color.Black;
            int tamañoCinta = DgvCinta.ColumnCount;
            string entrada = tbEntrada.Text;
            if(tamañoCinta<= entrada.Length)
            {
                for (int i = 0; i < entrada.Length; i++)
                {
                    DgvCinta.ColumnCount++;
                    DgvCinta.Columns[DgvCinta.ColumnCount - 1].Width = 50;
                    DgvCinta.Rows[0].Cells[DgvCinta.ColumnCount - 1].Value = "";
                }
            }
            for (int i = 0; i < entrada.Length; i++)
            {
                DgvCinta.Rows[0].Cells[i+1].Value = entrada.Substring(i,1);
            }
            lbEstado.Text = maquina.estadoActal;
            lbpasos.Text= pasos.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int tamañoCinta = DgvCinta.ColumnCount;
            int ncabeza = DgvCinta.CurrentCell.ColumnIndex;
            if (tamañoCinta-2 == ncabeza)
            {
                DgvCinta.ColumnCount++;
                DgvCinta.Columns[DgvCinta.ColumnCount - 1].Width = 50;
                DgvCinta.Rows[0].Cells[DgvCinta.ColumnCount - 1].Value = "";
            }

            leerCinta(DgvCinta.CurrentCell.Value.ToString());

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void tbVelocidad_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tbVelocidad.Value;
        }
        private void leerCinta(string valorcinta)
        {
            int columnat=0;
            int filat=0;
            string trancision;
            bool simbolocorrecto = false;
            for (int i = 0; i < maquina.simbolosCinta.Length; i++)
            {
                string[] columnaParse = maquina.simbolosCinta[i].Split(',');
                if(columnaParse[0]== valorcinta)
                {
                    columnat = Convert.ToInt32(columnaParse[1]);
                    simbolocorrecto = true;
                }
            }
            if(simbolocorrecto)
            {
                string[] filaParse = maquina.estadoActal.Split('q');
                filat = Convert.ToInt32(filaParse[1]);
                trancision = maquina.tabla[filat, columnat];
                dgvTranciciones.CurrentCell = dgvTranciciones[columnat, filat];
                if (trancision == "")
                {
                    lbEstado.Text = "Error cadena rechazada";
                    lbEstado.ForeColor = System.Drawing.Color.Red;
                    timer1.Enabled = false;
                    panel1.Enabled = false;
                }
                else
                {
                    string[] funcion = trancision.Split(',');
                    maquina.estadoActal = funcion[0];
                    DgvCinta.CurrentCell.Value = funcion[1];
                    if (funcion[2] == "R")
                    {
                        DgvCinta.CurrentCell = DgvCinta[DgvCinta.CurrentCell.ColumnIndex + 1, 0];
                    }
                    else
                    {
                        DgvCinta.CurrentCell = DgvCinta[DgvCinta.CurrentCell.ColumnIndex - 1, 0];
                    }
                    pasos++;
                    lbEstado.Text = maquina.estadoActal;
                    lbpasos.Text = pasos.ToString();
                    for (int i = 0; i < maquina.estadosAceptacion.Length; i++)
                    {
                        if (maquina.estadosAceptacion[i] == maquina.estadoActal)
                        {
                            lbEstado.Text = maquina.estadoActal + " es un estado de aceptacion";
                            lbEstado.ForeColor = System.Drawing.Color.YellowGreen;
                            timer1.Enabled = false;
                            panel1.Enabled = false;
                        }
                    }
                }
                

            }
            else
            {
                lbEstado.Text = "Simbolo no aceptado";
                timer1.Enabled = false;
            }
            



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCargar.Enabled = true;
            panel1.Enabled = false;
            inicializarmaquina();

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            leerCinta(DgvCinta.CurrentCell.Value.ToString());
        }
        public void inicializarmaquina()
        {
            int numeromaquina = comboBox1.SelectedIndex;
            if (numeromaquina == 0)
            {
                maquina = new Maquina(new string[,] { { "q1,,R", "q2,,R","q3,,R", "q4,,R" },
                                                    { "q1,a,R", "q1,b,R","q1,c,R", "q5,,L" },
                                                    { "q2,a,R", "q2,b,R","q2,c,R", "q6,,L" },
                                                    { "q3,a,R", "q3,b,R","q3,c,R", "q7,,L" },
                                                    { "", "","", "" },
                                                    { "q8,,L", "","", "q4,,R" },
                                                    { "", "q8,,L","", "q4,,R" },
                                                    { "", "","q8,,L", "q4,,R"},
                                                    { "q9,,L", "q10,,L","q11,,L", "q4,,R" },
                                                    { "q9,a,L", "q9,b,L","q9,c,L", "q12,,R" },
                                                    { "q10,a,L", "q10,b,L","q10,c,L", "q13,,R" },
                                                    { "q11,a,L", "q11,b,L","q11,c,L", "q14,,R" },
                                                    { "q0,,R", "","", "q4,,R" },
                                                    { "", "q0,,R","", "q4,,R" },
                                                    { "", "","q0,,R", "q4,,R"}},
                                                   new string[] { "a", "b", "c" }, new string[] { "a,0", "b,1", "c,2", ",3" }, "q0", new string[] { "q4" });
                InitializeGridtraciones();
            }
            else if (numeromaquina == 1)
            {
                maquina = new Maquina(new string[,] { { "q1,x,R", "q2,y,R","q3,z,R", "", "","","q7,,L" },
                                                    { "q1,a,R", "q1,b,R","q1,c,R", "q1,x,R", "q1,y,R","q1,z,R","q4,x,L"  },
                                                    { "q2,a,R", "q2,b,R","q2,c,R", "q2,x,R", "q2,y,R","q2,z,R","q4,y,L" },
                                                    { "q3,a,R", "q3,b,R","q3,c,R", "q3,x,R", "q3,y,R","q3,z,R","q4,z,L"},
                                                    {"q5,a,L", "q5,b,L","q5,c,L", "q4,x,L", "q4,y,L","q4,z,L","q6,,R"},
                                                    { "q5,a,L", "q5,b,L","q5,c,L","q0,x,R", "q0,y,R","q0,z,R", "q6,,R"},
                                                    { "", "","","q6,a,R", "q6,b,R","q6,c,R", "q7,,L"},
                                                    { "", "","", "","", "",""}},
                                                  new string[] { "a", "b", "c" }, new string[] { "a,0", "b,1", "c,2", "x,3", "y,4", "z,5", ",6" }, "q0", new string[] { "q7" });

                InitializeGridtraciones();
            }
            else if (numeromaquina == 2)
            {
                maquina = new Maquina(new string[,] {{ "q0,|,R", "q0,*,R","", "", "q1,=,L" },
                                                    { "q1,|,L", "q1,*,L","q1,=,L", "", "q2,,R" },
                                                    { "q2,|,R", "q3,*,R","", "", "" },
                                                    { "q4,x,L", "","q9,=,L","q3,x,R","" },
                                                    { "q4,x,L", "q4,*,L","", "q4,x,L","q5,,R" },
                                                    { "", "q1,*,L","", "q6,|,R","" },
                                                    { "q6,|,R", "q6,*,R","q6,=,R", "q6,x,R","q7,|,L" },
                                                    { "q7,|,L", "q8,*,L","q7,=,L","q7,x,L","q2,*,R" },
                                                    { "q5,|,R", "q8,*,L","q8,=,L", "q8,x,L","q9,,R" },
                                                    { "q9,|,L", "q10,*,R","", "q9,|,L","" },
                                                    { "", "","", "",""}},
                                                     new string[] { "|", "*" }, new string[] { "|,0", "*,1", "=,2", "x,3", ",4" }, "q0", new string[] { "q10" });

                InitializeGridtraciones();
            }
            else if (numeromaquina == 3)
            {
                maquina = new Maquina(new string[,] {{ "q0,|,R", "q0,+,R","", "", "q1,=,L" },
                                                    { "q1,|,L", "q1,+,L","q1,=,L", "", "q2,,R" },
                                                    { "q3,x,R", "q2,+,R","q2,=,R", "q2,x,L", "q4,x,L" },
                                                    { "q3,|,R", "q3,+,R","q3,=,R","q3,x,R","q4,x,L" },
                                                    { "q5,|,L", "q4,+,L","q4,=,L", "q4,x,L","q6,,R" },
                                                    { "q5,|,L", "q5,+,L","", "q2,x,R","q6,,L" },
                                                    { "", "q6,+,R","q6,=,R", "q6,|,R","q7,,R" },
                                                    { "", "","", "",""}},
                                                     new string[] { "|", "+" }, new string[] { "|,0", "+,1", "=,2", "x,3",",4" }, "q0", new string[] { "q7" });

                InitializeGridtraciones();
            }
            else if (numeromaquina == 4)
            {
                maquina = new Maquina(new string[,] {{ "q0,|,R", "q0,-,R","", "", "q1,=,L" },
                                                    { "q1,|,L", "q1,-,L","q1,=,L", "", "q2,,R" },
                                                    { "q3,x,R", "q5,-,R","q2,=,R", "q2,x,R", "q8,,L" },
                                                    { "q3,|,R", "q3,-,R","q3,=,R","q3,x,R","q4,x,L" },
                                                    { "q4,|,L", "q4,-,L","q4,=,L", "q4,x,L","q2,,R" },
                                                    { "q6,x,R", "q6,-,R","q8,=,L", "q5,x,R","q6,,L" },
                                                    { "q6,|,R", "q6,-,R","q6,=,R", "q6,x,R","q7,,L" },
                                                    { "q11,|,R", "q11,-,R","q7,=,R","q4,,L","q7,-,L" },
                                                    { "q8,|,L", "q8,-,L","q8,=,L", "q8,x,L","q9,,R" },
                                                    { "q9,|,R", "q9,-,R","q9,=,R", "q9,|,R","q10,,R" },
                                                    { "", "","", "",""},
                                                    { "", "","", "","q4,|,L"}},
                                                     new string[] { "|", "-" }, new string[] { "|,0", "-,1", "=,2", "x,3", ",4" }, "q0", new string[] { "q10" });

                InitializeGridtraciones();
            }
        }
    }
}
