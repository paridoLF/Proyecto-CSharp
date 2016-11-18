using Proyecto_Curso.Clases;
using Proyecto_Curso.XMLFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Curso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateXMLConfiguracionFile xml = new CreateXMLConfiguracionFile();
            xml.CreateFile();


            //LeerXML leer = new LeerXML(@"F:\Proyecto-Curso\Proyecto-Curso\ArchivoXML\ArchivoXML.xml");
            //leer.imprimirXML();

            LeerXML lista = new LeerXML(@"F:\Proyecto-Curso\Proyecto-Curso\ArchivoXML\ArchivoXML.xml");
            lista.cargaListado();
            
                       
            lista.listadoMenu.ToList();
               
            ///PONE EL NOMBRE DEL MENÚ****
            var item = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "Game",
                Text = "Game"
            };

            foreach (Object obj in lista.listadoMenu.ToList())
            {
                ToolStripItem subItem = new ToolStripMenuItem("Game");
              //SE AGREGAN LAS OPCIONES EN EL MENU 1
                var item2 = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name =  (((Proyecto_Curso.Configuraciones.Configuracion)obj).NombreNivel),
                    Text =  (((Proyecto_Curso.Configuraciones.Configuracion)obj).NombreNivel)
                };
                item.DropDownItems.Add(item2);
                menuStrip1.Items.Add(item);
            }

        }

        //private void facílToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //    Tablero a = new Tablero(8, 8, 10);
            
        //}

        //private void toolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //}
    }
}



