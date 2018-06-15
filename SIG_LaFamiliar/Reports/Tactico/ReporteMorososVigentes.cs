using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace SIG_LaFamiliar.Reports.Tactico
{
    static class ReporteMorososVigentes
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\La Familiar\\";

        static void crearCarpeta()
        {
            if (!Directory.Exists(@path))
                Directory.CreateDirectory(@path);
        }

        //Imprimir o guardar como PDF o WORD
        public static void crearDocumento(string titulo) {
            crearCarpeta();
            
            object oMissing = System.Reflection.Missing.Value;

            object oTemplate = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"plantilla.docx";

            Word.Application oWord = new Word.Application();
            Word.Document oDoc = new Word.Document();
            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
            oDoc.Activate();

            foreach (Word.Field campo in oDoc.Fields) { 
            }

            oWord.Visible = true;
        }
    }
}
