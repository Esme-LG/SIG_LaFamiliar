using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace SIG_LaFamiliar.Reportes
{
    class Reportes
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\La Familiar\\";
        // Para obtener fecha de creación
        static DateTime now = DateTime.Now;
        static string fecha = now.Day + "-" + now.ToString("MM") + "-" + now.Year;

        static void crearCarpeta()
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        //Excel
        public static void ExcelDG(DataGridView grd, String nombreReporte)
        {
            crearCarpeta();

            Excel.Application aplicacion = new Excel.Application();
            Excel.Workbook librosTrabajo = aplicacion.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet hojaTrabajo = (Excel.Worksheet)librosTrabajo.Worksheets.get_Item(1);

            DateTime now = DateTime.Now;
            String fecha = now.Day + "-" + now.ToString("MMM") + "-" + now.Year;

            int iCol = 0;

            foreach (DataGridViewColumn column in grd.Columns)
                if (column.Visible)
                    hojaTrabajo.Cells[1, ++iCol] = column.HeaderText;
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    hojaTrabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                }
            }
            nombreReporte = fecha + " " + nombreReporte + ".xls";

            librosTrabajo.SaveAs(@path + nombreReporte, Excel.XlFileFormat.xlWorkbookNormal,
                                 System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false,
                                 Excel.XlSaveAsAccessMode.xlShared, false, false,
                                 System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);

            librosTrabajo.Close();
        }

        //Doc de e1,e2,e4 y e5
        public static void docGeneralEstrategico(DataGridView grd, string nombreReporte, string periodoRep, string usuarioCreador, double total, string opcion)
        {
            crearCarpeta();

            object oEndOfDoc = "\\endofdoc";
            object oTemplate = Application.StartupPath + @"\estrategicos\general.dotx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            // Titulo del documento
            object titulo = "titulo";
            Word.Range tituloDoc = oDoc.Bookmarks.get_Item(ref titulo).Range;
            tituloDoc.Text = nombreReporte;
            object rango1 = tituloDoc;
            oDoc.Bookmarks.Add("titulo", ref rango1);

            // Periodo de resultados
            object periodo = "periodo";
            Word.Range periodoDoc = oDoc.Bookmarks.get_Item(ref periodo).Range;
            periodoDoc.Text = periodoRep;
            object rango2 = periodoDoc;
            oDoc.Bookmarks.Add("periodo", ref rango2);

            // Nombre de usuario que crea al reporte
            object usuario = "usuario";
            Word.Range usuarioDoc = oDoc.Bookmarks.get_Item(ref usuario).Range;
            usuarioDoc.Text = usuarioCreador;
            object rango3 = usuarioDoc;
            oDoc.Bookmarks.Add("usuario", ref rango3);

            //Insertar una tabla de n x m , llenarla con datagrid y estilizar la primera línea
            //en negritas y cursivas.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, grd.RowCount, grd.ColumnCount, ref ObjMiss, ref ObjMiss);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;
            oTable.Borders.Enable = 1;
            int iCol = 0;
            foreach (DataGridViewColumn column in grd.Columns)
                if (column.Visible)
                    oTable.Cell(1, ++iCol).Range.Text = column.HeaderText;
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    oTable.Cell(i + 2, j + 1).Range.Text = grd.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Add some text after the table.
            Word.Paragraph oPara1;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara1.Range.InsertParagraphBefore();
            oPara1.Range.Text = "Total: $" + total;
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceBefore = 24;
            oPara1.Range.InsertParagraphAfter();

            switch (opcion)
            {
                case "word":
                    oDoc.SaveAs2(@path + nombreReporte + " " + @fecha, Word.WdSaveFormat.wdFormatDocumentDefault);
                    break;
                case "pdf":
                    oDoc.SaveAs2(@path + nombreReporte + " " + @fecha, Word.WdSaveFormat.wdFormatPDF);
                    Process.Start(@path + "\\" + nombreReporte + " " + @fecha + ".pdf");
                    break;
                case "print":
                    oDoc.PrintOut(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
                    break;
            }

            oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }

        //Doc de e3
        public static void docE3Estrategico(DataGridView grd, string periodoRep, string usuarioCreador, double total, string opcion)
        {
            crearCarpeta();

            object oEndOfDoc = "\\endofdoc";
            object oTemplate = Application.StartupPath + @"\estrategicos\perdidasasociado.dotx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            // Periodo de resultados
            object periodo = "periodo";
            Word.Range periodoDoc = oDoc.Bookmarks.get_Item(ref periodo).Range;
            periodoDoc.Text = periodoRep;
            object rango2 = periodoDoc;
            oDoc.Bookmarks.Add("periodo", ref rango2);

            // Nombre de usuario que crea al reporte
            object usuario = "usuario";
            Word.Range usuarioDoc = oDoc.Bookmarks.get_Item(ref usuario).Range;
            usuarioDoc.Text = usuarioCreador;
            object rango3 = usuarioDoc;
            oDoc.Bookmarks.Add("usuario", ref rango3);

            //Insertar una tabla de n x m , llenarla con datagrid y estilizar la primera línea
            //en negritas y cursivas.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, grd.RowCount, grd.ColumnCount, ref ObjMiss, ref ObjMiss);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;
            oTable.Borders.Enable = 1;
            int iCol = 0;
            foreach (DataGridViewColumn column in grd.Columns)
                if (column.Visible)
                    oTable.Cell(1, ++iCol).Range.Text = column.HeaderText;
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    oTable.Cell(i + 2, j + 1).Range.Text = grd.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Agregar total después de la tabla
            Word.Paragraph oPara1;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara1.Range.InsertParagraphBefore();
            oPara1.Range.Text = "Total: $" + total;
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceBefore = 24;
            oPara1.Range.InsertParagraphAfter();

            switch (opcion)
            {
                case "word":
                    oDoc.SaveAs2(@path + "Perdidas por asociados morosos " + @fecha, Word.WdSaveFormat.wdFormatDocumentDefault);
                    break;
                case "pdf":
                    oDoc.SaveAs2(@path + "Perdidas por asociados morosos " + @fecha, Word.WdSaveFormat.wdFormatPDF);
                    Process.Start(@path + "\\Perdidas por asociados morosos " + @fecha + ".pdf");
                    break;
                case "print":
                    oDoc.PrintOut(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
                    break;
            }

            oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }

        public static void morososVigentes(DataGridView grd, string periodoRep, string usuarioCreador, double total, string opcion,
            string idR, string nombreR, double minimoR, double maximoR, double moraminR, double moramaxR, string categoriaR)
        {
            crearCarpeta();

            object oEndOfDoc = "\\endofdoc";
            object oTemplate = Application.StartupPath + @"\tacticos\vigentes.dotx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            // Periodo de resultados
            object periodo = "periodo";
            Word.Range periodoDoc = oDoc.Bookmarks.get_Item(ref periodo).Range;
            periodoDoc.Text = periodoRep;
            object rango1 = periodoDoc;
            oDoc.Bookmarks.Add("periodo", ref rango1);

            // Nombre de usuario que crea al reporte
            object usuario = "usuario";
            Word.Range usuarioDoc = oDoc.Bookmarks.get_Item(ref usuario).Range;
            usuarioDoc.Text = usuarioCreador;
            object rango2 = usuarioDoc;
            oDoc.Bookmarks.Add("usuario", ref rango2);

            // Parametros
            object id = "id";
            Word.Range idDoc = oDoc.Bookmarks.get_Item(ref id).Range;
            idDoc.Text = idR;
            object rango3 = idDoc;
            oDoc.Bookmarks.Add("id", ref rango3);

            object nombre = "nombre";
            Word.Range nombreDoc = oDoc.Bookmarks.get_Item(ref nombre).Range;
            nombreDoc.Text = nombreR;
            object rango4 = nombreDoc;
            oDoc.Bookmarks.Add("nombre", ref rango4);

            object minimo = "minimo";
            Word.Range minimoDoc = oDoc.Bookmarks.get_Item(ref minimo).Range;
            minimoDoc.Text = minimoR + "";
            object rango5 = minimoDoc;
            oDoc.Bookmarks.Add("minimo", ref rango5);

            object maximo = "maximo";
            Word.Range maximoDoc = oDoc.Bookmarks.get_Item(ref maximo).Range;
            maximoDoc.Text = maximoR + "";
            object rango6 = maximoDoc;
            oDoc.Bookmarks.Add("maximo", ref rango6);

            object moramin = "moramin";
            Word.Range moraminDoc = oDoc.Bookmarks.get_Item(ref moramin).Range;
            moraminDoc.Text = moraminR + "";
            object rango7 = moraminDoc;
            oDoc.Bookmarks.Add("moramin", ref rango7);

            object moramax = "moramax";
            Word.Range moramaxDoc = oDoc.Bookmarks.get_Item(ref moramax).Range;
            moramaxDoc.Text = moramaxR + "";
            object rango8 = moramaxDoc;
            oDoc.Bookmarks.Add("moramax", ref rango8);

            object categoria = "categoria";
            Word.Range categoriaDoc = oDoc.Bookmarks.get_Item(ref categoria).Range;
            categoriaDoc.Text = categoriaR;
            object rango9 = categoriaDoc;
            oDoc.Bookmarks.Add("categoria", ref rango9);

            //Insertar una tabla de n x m , llenarla con datagrid y estilizar la primera línea
            //en negritas y cursivas.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, grd.RowCount, grd.ColumnCount, ref ObjMiss, ref ObjMiss);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;
            oTable.Borders.Enable = 1;
            int iCol = 0;
            foreach (DataGridViewColumn column in grd.Columns)
                if (column.Visible)
                    oTable.Cell(1, ++iCol).Range.Text = column.HeaderText;
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    oTable.Cell(i + 2, j + 1).Range.Text = grd.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Agregar total después de la tabla
            Word.Paragraph oPara1;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara1.Range.InsertParagraphBefore();
            oPara1.Range.Text = "Total: $" + total;
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceBefore = 24;
            oPara1.Range.InsertParagraphAfter();

            switch (opcion)
            {
                case "word":
                    oDoc.SaveAs2(@path + "Morosos Vigentes " + @fecha, Word.WdSaveFormat.wdFormatDocumentDefault);
                    break;
                case "pdf":
                    oDoc.SaveAs2(@path + "Morosos vigentes " + @fecha, Word.WdSaveFormat.wdFormatPDF);
                    Process.Start(@path + "\\Morosos vigentes " + @fecha + ".pdf");
                    break;
                case "print":
                    oDoc.PrintOut(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
                    break;
            }

            oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }

        public static void morososHistoricos(DataGridView grd, string periodoRep, string usuarioCreador, double total, string opcion, string estadoR)
        {
            crearCarpeta();

            object oEndOfDoc = "\\endofdoc";
            object oTemplate = Application.StartupPath + @"\tacticos\historicos.dotx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            // Periodo de resultados
            object periodo = "periodo";
            Word.Range periodoDoc = oDoc.Bookmarks.get_Item(ref periodo).Range;
            periodoDoc.Text = periodoRep;
            object rango1 = periodoDoc;
            oDoc.Bookmarks.Add("periodo", ref rango1);

            // Nombre de usuario que crea al reporte
            object usuario = "usuario";
            Word.Range usuarioDoc = oDoc.Bookmarks.get_Item(ref usuario).Range;
            usuarioDoc.Text = usuarioCreador;
            object rango2 = usuarioDoc;
            oDoc.Bookmarks.Add("usuario", ref rango2);

            // Parametros
            object estado = "estado";
            Word.Range estadoDoc = oDoc.Bookmarks.get_Item(ref estado).Range;
            estadoDoc.Text = estadoR;
            object rango9 = estadoDoc;
            oDoc.Bookmarks.Add("estado", ref rango1);

            //Insertar una tabla de n x m , llenarla con datagrid y estilizar la primera línea
            //en negritas y cursivas.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, grd.RowCount, grd.ColumnCount, ref ObjMiss, ref ObjMiss);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;
            oTable.Borders.Enable = 1;
            int iCol = 0;
            foreach (DataGridViewColumn column in grd.Columns)
                if (column.Visible)
                    oTable.Cell(1, ++iCol).Range.Text = column.HeaderText;
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    oTable.Cell(i + 2, j + 1).Range.Text = grd.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Agregar total después de la tabla
            Word.Paragraph oPara1;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara1.Range.InsertParagraphBefore();
            oPara1.Range.Text = "Total: $" + total;
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceBefore = 24;
            oPara1.Range.InsertParagraphAfter();

            switch (opcion)
            {
                case "word":
                    oDoc.SaveAs2(@path + "Morosos históricos " + @fecha, Word.WdSaveFormat.wdFormatDocumentDefault);
                    break;
                case "pdf":
                    oDoc.SaveAs2(@path + "Morosos históricos " + @fecha, Word.WdSaveFormat.wdFormatPDF);
                    Process.Start(@path + "\\" + "Morosos históricos " + @fecha + ".pdf");
                    break;
                case "print":
                    oDoc.PrintOut(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
                    break;
            }

            oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }

        public static void proyeccion(DataGridView grd, string periodoRep, string usuarioCreador, string opcion, string creditoR, string asociadoR,
            string idasociadoR, double moraR, double cuotapropuestaR, double plazopropuestoR, double cuotaactualR, double restanteactualR)
        {
            crearCarpeta();

            object oEndOfDoc = "\\endofdoc";
            object oTemplate = Application.StartupPath + @"\tacticos\proyeccion.dotx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            // Periodo de resultados
            object periodo = "periodo";
            Word.Range periodoDoc = oDoc.Bookmarks.get_Item(ref periodo).Range;
            periodoDoc.Text = periodoRep;
            object rango1 = periodoDoc;
            oDoc.Bookmarks.Add("periodo", ref rango1);

            // Nombre de usuario que crea al reporte
            object usuario = "usuario";
            Word.Range usuarioDoc = oDoc.Bookmarks.get_Item(ref usuario).Range;
            usuarioDoc.Text = usuarioCreador;
            object rango2 = usuarioDoc;
            oDoc.Bookmarks.Add("usuario", ref rango2);

            // Parametros
            object credito = "credito";
            Word.Range creditoDoc = oDoc.Bookmarks.get_Item(ref credito).Range;
            creditoDoc.Text = creditoR;
            object rango3 = creditoDoc;
            oDoc.Bookmarks.Add("credito", ref rango3);

            object asociado = "asociado";
            Word.Range asociadoDoc = oDoc.Bookmarks.get_Item(ref asociado).Range;
            asociadoDoc.Text = asociadoR;
            object rango4 = asociadoDoc;
            oDoc.Bookmarks.Add("asociado", ref rango4);

            object idasociado = "idasociado";
            Word.Range idasociadoDoc = oDoc.Bookmarks.get_Item(ref idasociado).Range;
            idasociadoDoc.Text = idasociadoR;
            object rango5 = idasociadoDoc;
            oDoc.Bookmarks.Add("idasociado", ref rango5);

            object mora = "mora";
            Word.Range moraDoc = oDoc.Bookmarks.get_Item(ref mora).Range;
            moraDoc.Text = moraR + "";
            object rango6 = moraDoc;
            oDoc.Bookmarks.Add("mora", ref rango6);

            object cuotapropuesta = "cuotapropuesta";
            Word.Range cuotapropuestaDoc = oDoc.Bookmarks.get_Item(ref cuotapropuesta).Range;
            cuotapropuestaDoc.Text = cuotapropuestaR + "";
            object rango7 = cuotapropuestaDoc;
            oDoc.Bookmarks.Add("cuotapropuesta", ref rango7);

            object plazopropuesto = "plazopropuesto";
            Word.Range plazopropuestoDoc = oDoc.Bookmarks.get_Item(ref plazopropuesto).Range;
            plazopropuestoDoc.Text = plazopropuestoR + "";
            object rango8 = plazopropuestoDoc;
            oDoc.Bookmarks.Add("plazopropuesto", ref rango8);

            object cuotaactual = "cuotaactual";
            Word.Range cuotaactualDoc = oDoc.Bookmarks.get_Item(ref cuotaactual).Range;
            cuotaactualDoc.Text = cuotaactualR + "";
            object rango9 = cuotaactualDoc;
            oDoc.Bookmarks.Add("cuotaactual", ref rango9);

            object restanteactual = "restanteactual";
            Word.Range restanteactualDoc = oDoc.Bookmarks.get_Item(ref restanteactual).Range;
            restanteactualDoc.Text = restanteactualR + "";
            object rango10 = restanteactualDoc;
            oDoc.Bookmarks.Add("restanteactual", ref rango10);

            switch (opcion)
            {
                case "word":
                    oDoc.SaveAs2(@path + "Proyección de pagos por cuotas " + @fecha, Word.WdSaveFormat.wdFormatDocumentDefault);
                    break;
                case "pdf":
                    oDoc.SaveAs2(@path + "Proyección de pagos por cuotas " + @fecha, Word.WdSaveFormat.wdFormatPDF);
                    Process.Start(@path + "\\Proyección de pagos por cuotas " + @fecha + ".pdf");
                    break;
                case "print":
                    oDoc.PrintOut(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
                    break;
            }

            oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }

        public static void morosidadTipo(DataGridView grd, string nombreReporte, string periodoRep, string usuarioCreador, double total, string opcion)
        {
            crearCarpeta();

            object oEndOfDoc = "\\endofdoc";
            object oTemplate = Application.StartupPath + @"\tacticos\general.dotx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            // Titulo del documento
            object titulo = "titulo";
            Word.Range tituloDoc = oDoc.Bookmarks.get_Item(ref titulo).Range;
            tituloDoc.Text = nombreReporte;
            object rango1 = tituloDoc;
            oDoc.Bookmarks.Add("titulo", ref rango1);

            // Periodo de resultados
            object periodo = "periodo";
            Word.Range periodoDoc = oDoc.Bookmarks.get_Item(ref periodo).Range;
            periodoDoc.Text = periodoRep;
            object rango2 = periodoDoc;
            oDoc.Bookmarks.Add("periodo", ref rango2);

            // Nombre de usuario que crea al reporte
            object usuario = "usuario";
            Word.Range usuarioDoc = oDoc.Bookmarks.get_Item(ref usuario).Range;
            usuarioDoc.Text = usuarioCreador;
            object rango3 = usuarioDoc;
            oDoc.Bookmarks.Add("usuario", ref rango3);

            //Insertar una tabla de n x m , llenarla con datagrid y estilizar la primera línea
            //en negritas y cursivas.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, grd.RowCount, grd.ColumnCount, ref ObjMiss, ref ObjMiss);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;
            oTable.Borders.Enable = 1;
            int iCol = 0;
            foreach (DataGridViewColumn column in grd.Columns)
                if (column.Visible)
                    oTable.Cell(1, ++iCol).Range.Text = column.HeaderText;
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    oTable.Cell(i + 2, j + 1).Range.Text = grd.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Add some text after the table.
            Word.Paragraph oPara1;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara1.Range.InsertParagraphBefore();
            oPara1.Range.Text = "Total: $" + total;
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceBefore = 24;
            oPara1.Range.InsertParagraphAfter();

            switch (opcion)
            {
                case "word":
                    oDoc.SaveAs2(@path + nombreReporte + " " + @fecha, Word.WdSaveFormat.wdFormatDocumentDefault);
                    break;
                case "pdf":
                    oDoc.SaveAs2(@path + nombreReporte + " " + @fecha, Word.WdSaveFormat.wdFormatPDF);
                    Process.Start(@path + "\\" + nombreReporte + " " + @fecha + ".pdf");
                    break;
                case "print":
                    oDoc.PrintOut(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
                    break;
            }

            oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }

        public static void asociadosCategoria(DataGridView grd, string periodoRep, string usuarioCreador, double total, string opcion, string idR, string nombreR, string categoriaR)
        {
            crearCarpeta();

            object oEndOfDoc = "\\endofdoc";
            object oTemplate = Application.StartupPath + @"\tacticos\asociados.dotx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            // Periodo de resultados
            object periodo = "periodo";
            Word.Range periodoDoc = oDoc.Bookmarks.get_Item(ref periodo).Range;
            periodoDoc.Text = periodoRep;
            object rango1 = periodoDoc;
            oDoc.Bookmarks.Add("periodo", ref rango1);

            // Nombre de usuario que crea al reporte
            object usuario = "usuario";
            Word.Range usuarioDoc = oDoc.Bookmarks.get_Item(ref usuario).Range;
            usuarioDoc.Text = usuarioCreador;
            object rango2 = usuarioDoc;
            oDoc.Bookmarks.Add("usuario", ref rango2);

            // Parametros
            object id = "id";
            Word.Range idDoc = oDoc.Bookmarks.get_Item(ref id).Range;
            idDoc.Text = idR;
            object rango3 = idDoc;
            oDoc.Bookmarks.Add("id", ref rango3);

            object nombre = "nombre";
            Word.Range nombreDoc = oDoc.Bookmarks.get_Item(ref nombre).Range;
            nombreDoc.Text = nombreR;
            object rango4 = nombreDoc;
            oDoc.Bookmarks.Add("nombre", ref rango4);

            object categoria = "categoria";
            Word.Range categoriaDoc = oDoc.Bookmarks.get_Item(ref categoria).Range;
            categoriaDoc.Text = categoriaR;
            object rango5 = categoriaDoc;
            oDoc.Bookmarks.Add("categoria", ref rango5);

            //Insertar una tabla de n x m , llenarla con datagrid y estilizar la primera línea
            //en negritas y cursivas.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, grd.RowCount, grd.ColumnCount, ref ObjMiss, ref ObjMiss);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;
            oTable.Borders.Enable = 1;
            int iCol = 0;
            foreach (DataGridViewColumn column in grd.Columns)
                if (column.Visible)
                    oTable.Cell(1, ++iCol).Range.Text = column.HeaderText;
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    oTable.Cell(i + 2, j + 1).Range.Text = grd.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Agregar total después de la tabla
            Word.Paragraph oPara1;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara1.Range.InsertParagraphBefore();
            oPara1.Range.Text = "Total: $" + total;
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceBefore = 24;
            oPara1.Range.InsertParagraphAfter();

            switch (opcion)
            {
                case "word":
                    oDoc.SaveAs2(@path + "Asociados por categoría " + @fecha, Word.WdSaveFormat.wdFormatDocumentDefault);
                    break;
                case "pdf":
                    oDoc.SaveAs2(@path + "Asociados por categoría " + @fecha, Word.WdSaveFormat.wdFormatPDF);
                    Process.Start(@path + "\\Asociados por categoría " + @fecha + ".pdf");
                    break;
                case "print":
                    oDoc.PrintOut(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
                    break;
            }

            oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }

        public static void morososCompletados(DataGridView grd, string periodoRep, string usuarioCreador, double total, string opcion, string incluirR)
        {
            crearCarpeta();

            object oEndOfDoc = "\\endofdoc";
            object oTemplate = Application.StartupPath + @"\tacticos\completos.dotx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            // Periodo de resultados
            object periodo = "periodo";
            Word.Range periodoDoc = oDoc.Bookmarks.get_Item(ref periodo).Range;
            periodoDoc.Text = periodoRep;
            object rango1 = periodoDoc;
            oDoc.Bookmarks.Add("periodo", ref rango1);

            // Nombre de usuario que crea al reporte
            object usuario = "usuario";
            Word.Range usuarioDoc = oDoc.Bookmarks.get_Item(ref usuario).Range;
            usuarioDoc.Text = usuarioCreador;
            object rango2 = usuarioDoc;
            oDoc.Bookmarks.Add("usuario", ref rango2);

            // Parametros
            object incluir = "incluir";
            Word.Range incluirDoc = oDoc.Bookmarks.get_Item(ref incluir).Range;
            incluirDoc.Text = incluirR;
            object rango9 = incluirDoc;
            oDoc.Bookmarks.Add("incluir", ref rango1);

            //Insertar una tabla de n x m , llenarla con datagrid y estilizar la primera línea
            //en negritas y cursivas.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, grd.RowCount, grd.ColumnCount, ref ObjMiss, ref ObjMiss);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;
            oTable.Borders.Enable = 1;
            int iCol = 0;
            foreach (DataGridViewColumn column in grd.Columns)
                if (column.Visible)
                    oTable.Cell(1, ++iCol).Range.Text = column.HeaderText;
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    oTable.Cell(i + 2, j + 1).Range.Text = grd.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Agregar total después de la tabla
            Word.Paragraph oPara1;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara1.Range.InsertParagraphBefore();
            oPara1.Range.Text = "Total: $" + total;
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceBefore = 24;
            oPara1.Range.InsertParagraphAfter();

            switch (opcion)
            {
                case "word":
                    oDoc.SaveAs2(@path + "Créditos morosos completados " + @fecha, Word.WdSaveFormat.wdFormatDocumentDefault);
                    break;
                case "pdf":
                    oDoc.SaveAs2(@path + "Créditos morosos completados " + @fecha, Word.WdSaveFormat.wdFormatPDF);
                    Process.Start(@path + "\\Créditos morosos completados " + @fecha + ".pdf");
                    break;
                case "print":
                    oDoc.PrintOut(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
                    break;
            }

            oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }
    }
}
