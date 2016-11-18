using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Curso.Configuraciones
{
    class Configuracion
    {
        private int id;

        //Atributos
        public string NombreNivel { get; set; }
        public int NumFilas { get; set; }
        public int NumColumnas { get; set; }
        public int NumMinas { get; set; }

        public int contador { get; set; }
        //Constructor
        public Configuracion()
        {
        }

        public Configuracion(string nivel, int filas, int columnas, int minas)
        {
            this.NombreNivel = nivel;
            this.NumFilas = filas;
            this.NumColumnas = columnas;
            this.NumMinas = minas;
            this.contador = contador;
        }

        public Configuracion(int id, string nombreNivel, int numFilas, int numColumnas, int numMinas)
        {
            this.id = id;
            NombreNivel = nombreNivel;
            NumFilas = numFilas;
            NumColumnas = numColumnas;
            NumMinas = numMinas;
            contador = contador;
        }
    }
}


    


