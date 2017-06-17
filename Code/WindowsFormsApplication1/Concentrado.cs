using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using UtilitiesForm.Extensions;
using posb = PosBusiness;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using Utilities.Extensions;

namespace WindowsFormsApplication1
{
    public partial class Concentrado : BaseForm
    {
        #region Memebers

        #endregion

        #region Builder

        public Concentrado()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void ConfigureDateTimePicker()
        {
            dtpDate1.Format = DateTimePickerFormat.Custom;
            dtpDate1.CustomFormat = "dd/MM/yyyy";
            dtpDate1.Value = DateTime.Now.AddDays(-30);

            dtpDate2.Format = DateTimePickerFormat.Custom;
            dtpDate2.CustomFormat = "dd/MM/yyyy";
            dtpDate2.Value = DateTime.Now;
        }

        private void ConfigureDialogs()
        {
            svdReportStock.Filter = "Archivo de Excel(*.xlsx)|*.xlsx";
            svdReportStock.FilterIndex = 0;
            svdReportStock.Title = "Guardar como";
            svdReportStock.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {
            this.ConfigureDateTimePicker();

            this.ConfigureDialogs();

            this.cmbType.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            svdReportStock.FileName = "Concentrado_" + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";

            if (svdReportStock.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                string type = null;

                if (this.cmbType.SelectedIndex > 0)
                    type = this.cmbType.Text;

                var lConcentrated = new posb.Reports().Concentrated(type, this.dtpDate1.Value, this.dtpDate2.Value);

                if (lConcentrated.Count < 1)
                {
                    this.Alert("No se encontraron registros con las fechas indicadas");
                    return;
                }

                int index = 3;

                Microsoft.Office.Interop.Excel.Application xlApp = null;
                Workbook xlWorkBook = null;
                Worksheet xlWorkSheetItems = null;
                var cc = new ColorConverter();

                object misValue = System.Reflection.Missing.Value;

                try
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();

                    xlApp.Visible = false;
                    xlApp.DisplayAlerts = false;
                    xlApp.EnableEvents = false;

                    xlWorkBook = xlApp.Workbooks.Open(this.GetPath() + "\\Templates\\" + this.AppSet<string>("ConcentratedReport"), Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                                                                                    Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, Type.Missing,
                                                                                                                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                                                                                    Type.Missing, Microsoft.Office.Interop.Excel.XlCorruptLoad.xlNormalLoad);

                    //Agrega la hoja de items
                    xlWorkSheetItems = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    foreach (var concentrated in lConcentrated)
                    {
                        xlWorkSheetItems.Cells[index, 1] = concentrated.Type;

                        (xlWorkSheetItems.Cells[index, 2] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 2] = concentrated.Id.ToString().PadLeft(10, '0');

                        (xlWorkSheetItems.Cells[index, 3] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 3] = concentrated.Name;

                        (xlWorkSheetItems.Cells[index, 4] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 4] = concentrated.Description;

                        (xlWorkSheetItems.Cells[index, 5] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "$###,##";
                        xlWorkSheetItems.Cells[index, 5] = concentrated.Amount;

                        (xlWorkSheetItems.Cells[index, 6] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 6] = concentrated.CreatedDate.Value.ToString("dd/MM/yyyy");

                        index++;
                    }

                    xlWorkSheetItems.Cells[index + 2, 4].Font.Size = 13;
                    xlWorkSheetItems.Cells[index + 2, 4].Font.Bold = true;
                    xlWorkSheetItems.Cells[index + 2, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheetItems.Cells[index + 2, 4] = "Total:";


                    (xlWorkSheetItems.Cells[index + 2, 5] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "$###,##";
                    xlWorkSheetItems.Cells[index + 2, 5].Font.Size = 14;
                    xlWorkSheetItems.Cells[index + 2, 5].Font.Bold = true;
                    xlWorkSheetItems.Cells[index + 2, 5].Formula = string.Format("=SUBTOTAL(9,E2:E{0})", index);

                    //Mantiene el encabezado fijo
                    xlWorkSheetItems.Application.ActiveWindow.SplitRow = 2;
                    xlWorkSheetItems.Application.ActiveWindow.FreezePanes = true;

                    //Agrega autofiltros
                    Microsoft.Office.Interop.Excel.Range firstRow = (Microsoft.Office.Interop.Excel.Range)xlWorkSheetItems.Rows[2];
                    firstRow.Activate();
                    firstRow.Select();
                    firstRow.AutoFilter(2,
                                        Type.Missing,
                                        Microsoft.Office.Interop.Excel.XlAutoFilterOperator.xlAnd,
                                        Type.Missing,
                                        true);

                    xlWorkSheetItems.Cells[2, 1].Select();

                    //Ajusta el ancho de las columnas a su contenido
                    Microsoft.Office.Interop.Excel.Range aRange = xlWorkSheetItems.get_Range("A1", "ZZ1000000");
                    aRange.EntireColumn.AutoFit();

                    xlApp.EnableEvents = true;

                    xlWorkBook.SaveAs(svdReportStock.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing,
                                                                                                                                                     Type.Missing, Type.Missing,
                                                                                                                                                     Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                                                                                                                                     Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing, Type.Missing, false);

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Application.Quit();
                    xlApp.Quit();

                    if (this.Confirm("¿Deseas abrir el reporte?"))
                        Process.Start(svdReportStock.FileName);
                }
                catch (Exception ex)
                {
                    this.Alert("Error: " + ex.Message);
                }
                finally
                {
                    this.ReleasingObjects(xlWorkSheetItems, xlWorkBook, xlApp);
                }
            }
        }
    }
}
