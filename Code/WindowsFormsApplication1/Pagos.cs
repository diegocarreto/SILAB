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
    public partial class Pagos : BaseForm
    {
        #region Memebers

        #endregion

        #region Builder

        public Pagos()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void ConfigureDialogs()
        {
            svdReportStock.Filter = "Archivo de Excel(*.xlsx)|*.xlsx";
            svdReportStock.FilterIndex = 0;
            svdReportStock.Title = "Guardar como";
            svdReportStock.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void FillYears()
        {
            this.cmbYear.Items.Add("Seleccionar...");

            for (int i = 1995; i < 2050; i++)
            {
                this.cmbYear.Items.Add(i);
            }

            var year = DateTime.Now.Year.ToString();

            this.cmbYear.Text = year;
        }

        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {
            this.ConfigureDialogs();
            this.FillYears();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.svdReportStock.FileName = "PagosPorAño_" + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";

                if (svdReportStock.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    string type = null;

                    var lConcentrated = new posb.PaymentPerYear().Report(int.Parse(this.cmbYear.Text));

                    if (lConcentrated.Count < 1)
                    {
                        this.Alert("No se encontraron registros en el año indicado");
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

                        xlWorkBook = xlApp.Workbooks.Open(this.GetPath() + "\\Templates\\" + this.AppSet<string>("PaymentYearReport"), Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                                                                                        Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, Type.Missing,
                                                                                                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                                                                                        Type.Missing, Microsoft.Office.Interop.Excel.XlCorruptLoad.xlNormalLoad);

                        //Agrega la hoja de items
                        xlWorkSheetItems = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                        foreach (var concentrated in lConcentrated)
                        {
                            (xlWorkSheetItems.Cells[index, 1] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                            xlWorkSheetItems.Cells[index, 1] = concentrated.AP.ToString().PadLeft(10, '0');

                            (xlWorkSheetItems.Cells[index, 2] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                            xlWorkSheetItems.Cells[index, 2] = concentrated.Name;

                            (xlWorkSheetItems.Cells[index, 3] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                            xlWorkSheetItems.Cells[index, 3] = concentrated.IdWaterIntake.ToString().PadLeft(10, '0');

                            (xlWorkSheetItems.Cells[index, 4] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                            xlWorkSheetItems.Cells[index, 4] = concentrated.NameWaterIntake;

                            WriteMonth(xlWorkSheetItems, index, 5, concentrated.Enero);
                            WriteMonth(xlWorkSheetItems, index, 6, concentrated.Febrero);
                            WriteMonth(xlWorkSheetItems, index, 7, concentrated.Marzo);
                            WriteMonth(xlWorkSheetItems, index, 8, concentrated.Abril);
                            WriteMonth(xlWorkSheetItems, index, 9, concentrated.Mayo);
                            WriteMonth(xlWorkSheetItems, index, 10, concentrated.Julio);
                            WriteMonth(xlWorkSheetItems, index, 11, concentrated.Julio);
                            WriteMonth(xlWorkSheetItems, index, 12, concentrated.Agosto);
                            WriteMonth(xlWorkSheetItems, index, 13, concentrated.Septiembre);
                            WriteMonth(xlWorkSheetItems, index, 14, concentrated.Octubre);
                            WriteMonth(xlWorkSheetItems, index, 15, concentrated.Noviembre);
                            WriteMonth(xlWorkSheetItems, index, 16, concentrated.Diciembre);

                            index++;
                        }

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

        private static void WriteMonth(Worksheet xlWorkSheetItems, int Row, int Column, int Month)
        {
            var cell = (xlWorkSheetItems.Cells[Row, Column] as Microsoft.Office.Interop.Excel.Range);

            cell.NumberFormat = "@";
            cell.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            cell.Cells.Font.Bold = true;

            if (Month.Equals(1))
            {
                xlWorkSheetItems.Cells[Row, Column] = "Si";
                cell.Interior.Color = XlRgbColor.rgbLightGreen;
            }
            else
            {
                xlWorkSheetItems.Cells[Row, Column] = "No";
                cell.Interior.Color = XlRgbColor.rgbRed;
                cell.Font.Color = XlRgbColor.rgbWhite;
            }
        }
    }
}
