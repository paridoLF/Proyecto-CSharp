using Proyecto_Curso.Configuraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Proyecto_Curso.XMLFiles
{
    class LeerXML
    {
        //Atributos
        private string rutaArchivo { get; set; }
       
        public List<Configuracion> listadoMenu { get; set; }

        //Constructor
        public LeerXML(string ruta)
        {
            this.rutaArchivo = ruta;
            listadoMenu = new List<Configuracion>();
        }

        //Métodos
        public void cargaListado()
        {
            XmlTextReader reader = new XmlTextReader(rutaArchivo);
            Configuracion opcionMenu;
            string opcion = "";
            string nombreNivel = "";
            int numFilas = 0, numColumnas = 0, numMinas = 0, contador = 1;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.               
                        // Console.WriteLine(reader.Name);
                        if (reader.Name == "Nombre")
                            opcion = "Nombre";
                        if (reader.Name == "NumFila")
                            opcion = "NumFila";
                        if (reader.Name == "NumColumna")
                            opcion = "NumColumna";
                        if (reader.Name == "NumMinas")
                            opcion = "NumMinas";
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        if (opcion == "Nombre")
                            nombreNivel = Convert.ToString(reader.Value);
                        if (opcion == "NumFila")
                            numFilas = Convert.ToInt32(reader.Value);
                        if (opcion == "NumColumna")
                            numColumnas = Convert.ToInt32(reader.Value);
                        if (opcion == "NumMinas")
                            numMinas = Convert.ToInt32(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        opcion = "";
                        Console.Write(reader.Name);
                        if (reader.Name == "NumMinas")
                        {
                            opcionMenu = new Configuracion(contador, nombreNivel, numFilas, numColumnas, numMinas);
                            this.listadoMenu.Add(opcionMenu);
                            contador++;
                        }
                        
                        break;
                }

                //contador++;
            }
        }

        public void imprimirXML()
        {
            XmlTextReader reader = new XmlTextReader(rutaArchivo);

            while (reader.Read())
            {
                reader.MoveToContent();

                switch (reader.NodeType)
                {

                    //case XmlNodeType.Element: // The node is an element. 
                    //Console.Write("<" + reader.Name);       Console.WriteLine(">");     break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    //case XmlNodeType. EndElement: //Display the end of the element.
                    //Console.Write("</" + reader.Name);
                    //Console.WriteLine(">"); break;

                }

            }
        }
    }
}





