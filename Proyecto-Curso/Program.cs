using Proyecto_Curso.XMLFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Curso
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            LeerXML l = new LeerXML(@"..\..\ArchivosXML\ArchivoXML.xml");
            l.cargaListado();
        }
    }
}
