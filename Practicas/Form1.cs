using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Collections;


namespace Practicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Variables  
            string  parametros = Console.ReadLine();
            int maximo = Convert.ToInt32(parametros.Split(' ')[0]);
            int posicion = Convert.ToInt32(parametros.Split(' ')[1]);
            int[] pila = new int[maximo];

            Stack myStack = new Stack();

            Console.WriteLine(maximo);
            Console.WriteLine(posicion);        
       #endregion
       
       #region Llenado       
           for(int x = 0; x < maximo; x ++)
           {
                pila[x]= x+ 1;
                Console.WriteLine("| " + pila[x] + " | ");                       
                        
           }
           #endregion
           
            System.Console.WriteLine("-----");
        
          for(int x = 0; x < posicion; x++)
            {
              
                   for(int y = 0; y < maximo; y ++)
                   {
                       myStack.Push(pila[y] + x);  
                   }
       
                 Console.WriteLine("*");
       
             
            }
        
         foreach ( Object obj in myStack )
              {
                 
                    Console.Write( "    {0}", obj );
                 
                    Console.WriteLine();
              }
        
            
            
        }
    }
        
    
}
