using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Curso.Clases
{
   public class Tablero
    {
        //ATRIBUTOS
        private int[,] tablero;
        private int fila;
        private int columna;
        private int minas;

       //*******************************************************************************************
       //CONSTRUCTOR
        public Tablero(int fila, int columna, int minas)
        {
            this.fila = fila;
            this.columna = columna;
            this.minas = minas;
            tablero = new int[fila, columna];
            this.llenarCeros();
            this.imprimeMatriz();
            this.llenar_random();
            this.imprimeMatriz();
        }

       //*******************************************************************************************
        //LLENADO
        private void llenarCeros ( )
        {
            for (int F = 0; F < fila; F++)
            {
                for (int C = 0; C < columna; C++)
                {

                    tablero[F, C] = 0;
                }

            }            
        }

        //*******************************************************************************************
        private void imprimeMatriz()
        {
            int columnas = 1;

            Console.Write("\n\n\n");

            foreach (int elemento in this.tablero)
            {
                if (elemento < 0)
                    Console.Write(elemento + " ");
                else
                    Console.Write(" " + elemento + " ");

                if (columnas % this.columna == 0)
                    Console.Write("\n");
                columnas++;
            }
        }

        //*******************************************************************************************
        //RANDOM
        private void llenar_random()
        {
            Random Ramdom = new Random();
            int aux;
            aux = 1;
            Boolean paso;
            paso = false;
            //int elemento;
        
            Random randMina = new Random();
            int minas = 0, filSigMina, colSigMina;

            while (minas < this.minas)
            {
                //Obtiene la posición de la siguiente mina
                filSigMina = randMina.Next(0, (this.fila - 1));
                colSigMina = randMina.Next(0, (this.columna - 1));

                if (this.tablero[filSigMina, colSigMina] != -1)
                {
                    this.tablero[filSigMina, colSigMina] = -1;
                    minas++;
                }
            }            
        }

       private void menu (string titulo, string filas, string columnas, string minas)
        {
          

        }


    }
}
