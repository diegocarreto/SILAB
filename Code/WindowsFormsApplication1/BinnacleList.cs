using System;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using WindowsFormsApplication1.Base;
using System.Linq;
using posb = PosBusiness;
using System.Diagnostics;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using UtilitiesForm.Extensions;
using Utilities.Extensions;

namespace WindowsFormsApplication1
{
    public partial class BinnacleList : BaseForm
    {
        #region Memebers

        private string EntityName
        {
            get
            {
                return gvList[1, this.SelectRowIndex].Value.ToString() + " " + gvList[2, this.SelectRowIndex].Value.ToString();
            }
        }

        private int EntityId
        {
            get
            {
                return int.Parse(gvList[0, this.SelectRowIndex].Value.ToString());
            }
        }

        private int SelectRowIndex
        {
            get
            {
                return gvList.CurrentRow.Index;
            }
        }

        #endregion

        #region Properties

        private posb.Binnacle Entity { get; set; }

        #endregion #endregion

        #region Builder

        public BinnacleList()
        {
            this.Entity = new posb.Binnacle();

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void FillGridView()
        {
            this.Entity.Page = this.Page;
            this.Entity.Rows = this.Rows;
            this.Entity.SortName = this.SortName;
            this.Entity.Order = this.Order;

            Entity.Find = this.txtFind.Text;

            this.gvList.AutoGenerateColumns = false;
            this.gvList.AllowUserToResizeColumns = false;

            var list = Entity.List();

            this.gvList.DataSource = list;

            if (list.Any())
                this.pageList.SetTotal(list.First().Pages);
        }

        private void ConfigureDialogs()
        {
            svdReportStock.Filter = "Archivo de Excel(*.xlsx)|*.xlsx";
            svdReportStock.FilterIndex = 0;
            svdReportStock.Title = "Guardar como";
            svdReportStock.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        #endregion

        private void Result(bool IsCorrect, String Message)
        {
            this.FillGridView();
        }

        private void HabitantList_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtFind;

            this.ConfigureDialogs();

            this.pageList.Result += delegate(int Page, int Rows)
            {
                this.Page = Page;
                this.Rows = Rows;

                this.FillGridView();
            };

            this.FillGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void gvList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gvList.Columns[e.ColumnIndex].SortMode != DataGridViewColumnSortMode.NotSortable)
            {
                this.SortName = gvList.Columns[e.ColumnIndex].Name;

                if (this.Order == ASC)
                    this.Order = DESC;
                else
                    this.Order = ASC;

                this.FillGridView();
            }
        }

        private void txtFind_KeyUp_1(object sender, KeyEventArgs e)
        {
            this.FillGridView();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            svdReportStock.FileName = "Bitacora_" + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";

            if (svdReportStock.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                string type = null;

                var lBinnacle = new posb.Binnacle().List(1);

                if (lBinnacle.Count < 1)
                {
                    this.Alert("No se encontraron registros");
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

                    xlWorkBook = xlApp.Workbooks.Open(this.GetPath() + "\\Templates\\" + this.AppSet<string>("BinnalceReport"), Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                                                                                    Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, Type.Missing,
                                                                                                                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                                                                                    Type.Missing, Microsoft.Office.Interop.Excel.XlCorruptLoad.xlNormalLoad);

                    //Agrega la hoja de items
                    xlWorkSheetItems = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    foreach (var binnacle in lBinnacle)
                    {
                        (xlWorkSheetItems.Cells[index, 1] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 1] = binnacle.Id.ToString().PadLeft(10, '0');

                        xlWorkSheetItems.Cells[index, 2] = binnacle.Usuario;

                        xlWorkSheetItems.Cells[index, 3] = binnacle.Accion;

                        xlWorkSheetItems.Cells[index, 4] = binnacle.Tipo;

                        (xlWorkSheetItems.Cells[index, 5] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 5] = binnacle.Identificador.ToString().PadLeft(10, '0');

                        (xlWorkSheetItems.Cells[index, 6] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 6] = binnacle.ValorPrevio;

                        (xlWorkSheetItems.Cells[index, 7] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 7] = binnacle.ValorActual;

                        (xlWorkSheetItems.Cells[index, 8] as Microsoft.Office.Interop.Excel.Range).NumberFormat = "@";
                        xlWorkSheetItems.Cells[index, 8] = binnacle.Fecha;

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

                    if (this.Confirm("¿Deseas abrir la bitácora?"))
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
