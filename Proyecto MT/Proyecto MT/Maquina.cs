using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MT
{
    public class Maquina
    {
        public string[,] tabla;
        public string[] simboloEntrada;
        public string[] simbolosCinta;
        public string estadoActal;
        public string[] estadosAceptacion;
        public Maquina(string[,] untabla, string[] unsimboloEntrada, string[] unsimbolosCinta, string unestadoInicial, string[] unestadosAceptacion)
        {
            tabla = untabla;
            simboloEntrada = unsimboloEntrada;
            simbolosCinta = unsimbolosCinta;
            estadoActal = unestadoInicial;
            estadosAceptacion = unestadosAceptacion;
        }

    }
}
