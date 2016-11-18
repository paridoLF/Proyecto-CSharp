using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XmlConfiguration;
using System.Xml.Serialization;
using System.IO;

namespace Proyecto_Curso.XMLFiles
{
    class CreateXMLConfiguracionFile
    {

      
        public void CreateFile()

        {

            string Ruta;
            Ruta = @"F:\Proyecto-Curso\Proyecto-Curso\ArchivoXML\ArchivoXML.xml";
            StreamWriter sw = new StreamWriter(Ruta);
                       

            using (XmlTextWriter Writer = new XmlTextWriter(sw))
            {
                Writer.WriteStartDocument();
                Writer.Formatting = Formatting.Indented;
                Writer.Indentation = 5;

                //Escribimos el nodo principal.​
                Writer.WriteStartElement("Configuraciones");

                Writer.WriteStartElement("Configuracion");
                //Escribimos cada uno de los elementos del nodo empleado.​
                Writer.WriteElementString("Nombre", "Principiante");
                Writer.WriteElementString("NumFila", "8");
                Writer.WriteElementString("NumColumna", "8");
                Writer.WriteElementString("NumMinas", "10");
                Writer.WriteEndElement();

                Writer.WriteStartElement("Configuracion");
                //Escribimos cada uno de los elementos del nodo empleado.​
                Writer.WriteElementString("Nombre", "Intermedio");
                Writer.WriteElementString("NumFila", "10");
                Writer.WriteElementString("NumColumna", "10");
                Writer.WriteElementString("NumMinas", "25");
                Writer.WriteEndElement();

                Writer.WriteStartElement("Configuracion");
                //Escribimos cada uno de los elementos del nodo empleado.​
                Writer.WriteElementString("Nombre", "Avanzado");
                Writer.WriteElementString("NumFila", "15");
                Writer.WriteElementString("NumColumna", "15");
                Writer.WriteElementString("NumMinas", "120");
                Writer.WriteEndElement();

                //Cerramos el nodo y el documento.​
                Writer.WriteEndElement();               
                Writer.WriteEndDocument();
                Writer.Flush();
                }

        }

        public void LeerFile()
        {
            string Ruta = @"F:\Proyecto-Curso\Proyecto-Curso\ArchivoXML\ArchivoXML.xml";
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(Ruta);
            string contents = "";

            while (reader.Read()) 
            {
                reader.MoveToContent();

                switch (reader.NodeType)    
                { 
 
                //case XmlNodeType.Element: // The node is an element. 
                    //Console.Write("<" + reader.Name);       Console.WriteLine(">");     break;
                case XmlNodeType.Text: //Display the text in each element.
                    Console.WriteLine (reader.Value);    
                    break;
                    //case XmlNodeType. EndElement: //Display the end of the element.
                    //Console.Write("</" + reader.Name);
                    //Console.WriteLine(">"); break;

                }

            }
            reader.Close();
            }

        

        
    }
}
