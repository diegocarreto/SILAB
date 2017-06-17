using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using posb = PosBusiness;
using MetroFramework.Controls;
using System.IO;
using UtilitiesForm.Extensions;
using Utilities;
using System.Web.Script.Serialization;
using PosBusiness;

namespace WindowsFormsApplication1.Base
{
    public class BaseForm : MetroFramework.Forms.MetroForm
    {
        #region Members

        public int? Id;

        private const string TXT_TEXT = "txtText";

        private const string TXT_MONEY = "txtMoney";

        private const string TXT_NUMBER = "txtNumber";

        private ToolTip ToolTip;

        private System.ComponentModel.IContainer components;

        internal static string ASC = "asc";

        internal static string DESC = "desc";

        internal string Order = ASC;

        internal string SortName = "id";

        internal int Page = 1;

        internal int Rows = 15;

        #endregion

        #region Properties

        protected bool UpdateButton { get; set; }

        protected bool LoadComplete { get; set; }

        #endregion

        #region Builder

        public BaseForm()
            : base()
        {
            this.LoadComplete = false;
            this.Resizable = false;
        }

        #endregion

        #region Methods

        private void ConfigureRol()
        {
            try
            {
                using (var e = new PosBusiness.User())
                {
                    e.Rol();

                    this.UpdateButton = e.Update.Value;

                    var ctrlNew = this.Controls["btnNew"];

                    if (ctrlNew != null)
                    {
                        var btnNew = ctrlNew as Button;

                        btnNew.Enabled = e.New.Value;
                    }

                    var ctrlDelete = this.Controls["btnDelete"];

                    if (ctrlDelete != null)
                    {
                        var btnDelete = ctrlDelete as Button;

                        btnDelete.Enabled = e.Erase.Value;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void ConfigureTextBoxValidation()
        {
            foreach (Control p in this.Controls)
            {
                if (p is MetroTextBox)
                {
                    var txt = p as MetroTextBox;

                    if (txt.Tag != null)
                    {
                        var json = txt.Tag != null ? txt.Tag.ToString() : string.Empty;
                        var jss = new JavaScriptSerializer();
                        var tag = jss.Deserialize<Tag>(json);
                        var infoType = tag.InfoType;

                        if (!string.IsNullOrEmpty(infoType))
                        {
                            if (infoType.Equals(TXT_TEXT, StringComparison.InvariantCultureIgnoreCase))
                            {
                                txt.KeyPress += new KeyPressEventHandler(this.txt_KeyPressText);
                            }
                            else if (infoType.Equals(TXT_MONEY, StringComparison.InvariantCultureIgnoreCase))
                            {
                                txt.KeyPress += new KeyPressEventHandler(this.txt_KeyPressMoney);
                            }
                            else if (infoType.Equals(TXT_NUMBER, StringComparison.InvariantCultureIgnoreCase))
                            {
                                txt.KeyPress += new KeyPressEventHandler(this.txt_KeyPressNumber);
                            }
                        }
                    }
                }
            }

        }

        private void ConfigureToolTip()
        {
            var toolTip1 = new ToolTip();
            toolTip1.ToolTipTitle = "Validación incorrecta";
            toolTip1.AutoPopDelay = 6000;
            toolTip1.InitialDelay = 150;
            toolTip1.ReshowDelay = 150;
            toolTip1.IsBalloon = true;
            toolTip1.UseAnimation = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;

            var toolTip2 = new ToolTip();
            toolTip2.ToolTipTitle = "SICAP - Información";
            toolTip2.AutoPopDelay = 2000;
            toolTip2.InitialDelay = 2000;
            toolTip2.ReshowDelay = 1000;
            toolTip2.IsBalloon = true;
            toolTip2.UseAnimation = true;
            toolTip2.ToolTipIcon = ToolTipIcon.Warning;

            foreach (Control p in this.Controls)
            {
                if (p is PictureBox)
                {
                    if (p.Name.Equals("pbSICAP"))
                    {
                        if (p.Tag != null)
                        {
                            p.MouseHover += new EventHandler(delegate(Object o, EventArgs a)
                            {
                                toolTip2.SetToolTip(p, p.Tag.ToString());
                                p.Cursor = Cursors.Help;
                            });
                        }
                    }
                    else
                    {
                        p.MouseHover += new EventHandler(delegate(Object o, EventArgs a)
                        {
                            if (p.Tag != null)
                                toolTip1.SetToolTip(p, p.Tag.ToString());
                        });
                    }
                }
            }
        }

        protected bool ValidateForm()
        {
            var isCorrect = true;
            var message = new List<string>();

            foreach (Control p in this.Controls)
            {
                if (p is PictureBox)
                {
                    var name = (p as PictureBox).Name;
                    var parts = name.Split('_');

                    if (parts.Length.Equals(2))
                    {
                        var prefix = parts[0].ToString();

                        if (prefix.Equals("pbval", StringComparison.InvariantCultureIgnoreCase))
                        {
                            var controlValidate = parts[1];
                            var ctrl = this.Controls[controlValidate];
                            var isError = false;

                            if (ctrl is TextBox && ctrl.Enabled)
                            {
                                var txt = ctrl as TextBox;
                                isError = string.IsNullOrEmpty(txt.Text);
                            }
                            else if (ctrl is MetroTextBox && ctrl.Enabled)
                            {
                                var txt = ctrl as MetroTextBox;
                                isError = string.IsNullOrEmpty(txt.Text);
                            }
                            else if (ctrl is ComboBox)
                            {
                                var cmb = ctrl as ComboBox;
                                isError = cmb.SelectedIndex.Equals(0);
                            }

                            if (isError)
                            {
                                p.Visible = true;
                                isCorrect &= false;
                                ctrl.Focus();

                                message.Add(p.Tag.ToString());
                            }
                            else
                                p.Visible = false;
                        }
                    }
                }
            }

            if (!isCorrect)
            {
                var alert = new Alert(message);
                alert.ShowDialog();
            }

            return isCorrect;
        }

        protected void Print(int Id, int Type = 1)
        {
            var months = new List<string>
            {
                "ENERO",
                "FEBRERO",
                "MARZO",
                "ABRIL",
                "MAYO",
                "JUNIO",
                "JULIO",
                "AGOSTO",
                "SEPTIEMBRE",
                "OCTUBRE",
                "NOVIEMBRE",
                "DICIEMBRE"
            };

            var p = new PrintDocument();

            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                var line = string.Empty;
                for (int i = 0; i < 81; i++)
                    line += "_";

                var line2 = string.Empty;
                for (int i = 0; i < 125; i++)
                    line2 += " - ";

                var font = "Times New Roman";
                var brush = new SolidBrush(Color.Black);
                var brushTwo = new SolidBrush(Color.LightGray);

                var brushRed = new SolidBrush(Color.Red);

                Font titleFont = new Font(font, 18, FontStyle.Bold),
                     titleSubFont = new Font(font, 16, FontStyle.Bold),
                     f14 = new Font(font, 14, FontStyle.Bold),
                     f11 = new Font(font, 11),
                     f10 = new Font(font, 10),
                     f09 = new Font(font, 09),
                     f08 = new Font(font, 08),
                     f06 = new Font(font, 06);

                var pen = new Pen(Brushes.Black);
                pen.Width = 0.8F;

                var picture1 = new posb.Config().GetImage("Voucher", 1);
                var picture2 = new posb.Config().GetImage("Voucher", 2);
                var picture3 = new posb.Config().GetImage("Voucher", 3);
                var imageCom = new Bitmap(new MemoryStream(picture1));
                var image = new Bitmap(new MemoryStream(picture2));
                var sicap = new Bitmap(new MemoryStream(picture3));

                using (posb.Payment payment = new posb.Payment
                {
                    Id = Id
                }
                .Print())
                {
                    var total = new Numalet().Convert(String.Format("{0:0.00}", payment.Amount));

                    for (int i = 0; i <= 1; i++)
                    {
                        var copy = i * 530;

                        e1.Graphics.DrawImage(imageCom, 20, 7 + copy, 90, 110);

                        e1.Graphics.DrawString("COMITÉ DE AGUA POTABLE", titleFont, brush, 240, 40 + copy);
                        e1.Graphics.DrawString("SAN DIEGO TLAILOTLACAN", titleFont, brush, 240, 65 + copy);
                        e1.Graphics.DrawImage(image, 760, 37 + copy, 60, 80);

                        e1.Graphics.FillRectangle(brush, new Rectangle(20, 106 + copy, 795, 6));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 112 + copy, 795, 30));
                        e1.Graphics.DrawString("RECIBO OFICIAL DE INGRESOS", titleSubFont, brush, 30, 115 + copy);

                        e1.Graphics.DrawString("FOLIO", titleSubFont, brush, 550, 115 + copy);
                        e1.Graphics.DrawString("N° M-" + payment.Folio.PadLeft(10, '0'), titleSubFont, brushRed, 630, 115 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 795, 127));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 222, 127));

                        e1.Graphics.DrawString("RECIBI DEL(A) SR(A)", f14, brush, 30, 170 + copy);
                        e1.Graphics.DrawString(payment.Propietario, f14, brush, 250, 170 + copy);
                        //e1.Graphics.DrawString("Este recibo no proporciona derechos al arrendatario de la propiedad a la cual pertenece la toma de agua", f06, brush, 250, 182 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 170 + copy);

                        e1.Graphics.DrawString("CANTIDAD", f14, brush, 30, 200 + copy);
                        e1.Graphics.DrawString("$" + String.Format("{0:0.00}", payment.Amount) + "   " + total, f14, brush, 250, 200 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 200 + copy);

                        e1.Graphics.DrawString("CONCEPTO", f14, brush, 30, 230 + copy);
                        e1.Graphics.DrawString("Pago por extracción de agua potable", f14, brush, 250, 230 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 230 + copy);

                        e1.Graphics.DrawString("TOMA DE AGUA", f14, brush, 30, 260 + copy);
                        e1.Graphics.DrawString(payment.Direccion + "  [" + payment.Type + "]", f14, brush, 250, 260 + copy);

                        e1.Graphics.FillRectangle(brushTwo, new Rectangle(20, 299 + copy, 795, 27));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 299 + copy, 795, 27));

                        if (Type.Equals(1))
                        {
                            e1.Graphics.DrawString("PERIODO DE PAGO", titleSubFont, brush, 309, 300 + copy);

                            if (payment.StartDateName.Equals(payment.EndDateName))
                            {
                                e1.Graphics.DrawString(payment.EndDateName, titleSubFont, brush, 350, 326 + copy);
                            }
                            else if (payment.Year.Equals(payment.YearEnd) && payment.Month.Equals(1) && payment.MonthEnd.Equals(12))
                            {
                                e1.Graphics.DrawString("Año " + payment.Year + " completo", titleSubFont, brush, 320, 326 + copy);
                            }
                            else
                            {
                                e1.Graphics.DrawString("De " + payment.StartDateName.Replace(" ", " de ") + " a " + payment.EndDateName.Replace(" ", " de "), titleSubFont, brush, 255, 326 + copy);
                            }
                        }
                        else
                        {
                            e1.Graphics.DrawString("CONCEPTO DE PAGO", titleSubFont, brush, 300, 300 + copy);
                        }

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 326 + copy, 795, 27));
                        //e1.Graphics.DrawRectangle(pen, new Rectangle(418, 326 + copy, 397, 27));

                        e1.Graphics.DrawString("SAN DIEGO TEXCOCO ESTADO DE MEXICO A " + payment.CreationDate.Value.ToString("dd") + " DE " + months[int.Parse(payment.CreationDate.Value.ToString("MM")) - 1] + " DE " + payment.CreationDate.Value.ToString("yyyy"), f10, brush, 340, 360 + copy);


                        using (var addNames = new posb.Config())
                        {
                            var showNames = addNames.AltaAddNames();

                            if (showNames)
                            {

                                e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                                e1.Graphics.DrawString("TESORERO(A): " + payment.Tesorero, f08, brush, 100, 450 + copy);
                                //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                                e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                                e1.Graphics.DrawString("PRESIDENTE(A): " + payment.Presidente, f08, brush, 500, 450 + copy);
                                //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);
                            }
                            else
                            {
                                e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                                e1.Graphics.DrawString("TESORERO(A)", f08, brush, 170, 450 + copy);
                                //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                                e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                                e1.Graphics.DrawString("PRESIDENTE(A)", f08, brush, 565, 450 + copy);
                                //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);
                            }
                        }

                        e1.Graphics.DrawImage(sicap, 403, 430 + copy, 40, 50);

                        e1.Graphics.DrawString("SICAP V1.0.0", f06, brush, 397, 480 + copy);

                        e1.Graphics.DrawString("Impresión " + (i + 1) + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), f08, brush, 610, 495 + copy);

                        if (i.Equals(0))
                            e1.Graphics.DrawString(line2, f06, brush, 0, 525 + copy);
                    }
                }

                pen.Dispose();
            };

            try
            {
                using (var printer = new posb.Config())
                {
                    p.PrinterSettings.PrinterName = printer.Printer();
                }

                p.Print();
            }
            catch (Exception ex)
            {
                this.Alert("Ocurrió un error al intentar imprimir el ticket. Descripcion: " + ex.Message, eForm.TypeError.Error);
            }

            return;

        }

        protected void PrintFaena(int Id)
        {
            var months = new List<string>
            {
                "ENERO",
                "FEBRERO",
                "MARZO",
                "ABRIL",
                "MAYO",
                "JUNIO",
                "JULIO",
                "AGOSTO",
                "SEPTIEMBRE",
                "OCTUBRE",
                "NOVIEMBRE",
                "DICIEMBRE"
            };

            var p = new PrintDocument();

            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                var line = string.Empty;
                for (int i = 0; i < 81; i++)
                    line += "_";

                var line2 = string.Empty;
                for (int i = 0; i < 125; i++)
                    line2 += " - ";

                var font = "Times New Roman";
                var brush = new SolidBrush(Color.Black);
                var brushTwo = new SolidBrush(Color.LightGray);

                var brushRed = new SolidBrush(Color.Red);

                Font titleFont = new Font(font, 18, FontStyle.Bold),
                     titleSubFont = new Font(font, 16, FontStyle.Bold),
                     f14 = new Font(font, 14, FontStyle.Bold),
                     f11 = new Font(font, 11),
                     f10 = new Font(font, 10),
                     f09 = new Font(font, 09),
                     f08 = new Font(font, 08),
                     f06 = new Font(font, 06);

                var pen = new Pen(Brushes.Black);
                pen.Width = 0.8F;

                var picture1 = new posb.Config().GetImage("Voucher", 1);
                var picture2 = new posb.Config().GetImage("Voucher", 2);
                var picture3 = new posb.Config().GetImage("Voucher", 3);
                var imageCom = new Bitmap(new MemoryStream(picture1));
                var image = new Bitmap(new MemoryStream(picture2));
                var sicap = new Bitmap(new MemoryStream(picture3));

                using (posb.Payment payment = new posb.Payment
                {
                    Id = Id
                }
                .FaenaPrint())
                {
                    var total = new Numalet().Convert(String.Format("{0:0.00}", payment.Amount));

                    for (int i = 0; i <= 1; i++)
                    {
                        var copy = i * 530;

                        e1.Graphics.DrawImage(imageCom, 20, 7 + copy, 90, 110);

                        e1.Graphics.DrawString("COMITÉ DE AGUA POTABLE", titleFont, brush, 240, 40 + copy);
                        e1.Graphics.DrawString("SAN DIEGO TLAILOTLACAN", titleFont, brush, 240, 65 + copy);
                        e1.Graphics.DrawImage(image, 760, 37 + copy, 60, 80);

                        e1.Graphics.FillRectangle(brush, new Rectangle(20, 106 + copy, 795, 6));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 112 + copy, 795, 30));
                        e1.Graphics.DrawString("RECIBO OFICIAL DE INGRESOS", titleSubFont, brush, 30, 115 + copy);

                        e1.Graphics.DrawString("FOLIO", titleSubFont, brush, 550, 115 + copy);
                        e1.Graphics.DrawString("N° C-" + payment.Folio.PadLeft(10, '0'), titleSubFont, brushRed, 630, 115 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 795, 127));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 222, 127));

                        e1.Graphics.DrawString("RECIBI DEL(A) SR(A)", f14, brush, 30, 170 + copy);
                        e1.Graphics.DrawString(payment.Propietario, f14, brush, 250, 170 + copy);
                        //e1.Graphics.DrawString("Este recibo no proporciona derechos al arrendatario de la propiedad a la cual pertenece la toma de agua", f06, brush, 250, 182 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 170 + copy);

                        e1.Graphics.DrawString("CANTIDAD", f14, brush, 30, 200 + copy);
                        e1.Graphics.DrawString("$" + String.Format("{0:0.00}", payment.Amount) + "   " + total, f14, brush, 250, 200 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 200 + copy);

                        e1.Graphics.DrawString("CONCEPTO", f14, brush, 30, 230 + copy);
                        e1.Graphics.DrawString("Pago por cooperación " + payment.Concept, f14, brush, 250, 230 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 230 + copy);

                        e1.Graphics.DrawString("TOMA DE AGUA", f14, brush, 30, 260 + copy);
                        e1.Graphics.DrawString(payment.Direccion + "  [" + payment.Type + "]", f14, brush, 250, 260 + copy);

                        e1.Graphics.FillRectangle(brushTwo, new Rectangle(20, 299 + copy, 795, 27));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 299 + copy, 795, 27));

                        e1.Graphics.DrawString("DESCRIPCIÓN DE LA COOPERACIÓN", titleSubFont, brush, 240, 300 + copy);
                        e1.Graphics.DrawString(payment.Description, f10, brush, 25, 332 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 326 + copy, 795, 27));
                        //e1.Graphics.DrawRectangle(pen, new Rectangle(418, 326 + copy, 397, 27));

                        e1.Graphics.DrawString("SAN DIEGO TEXCOCO ESTADO DE MEXICO A " + payment.CreationDate.Value.ToString("dd") + " DE " + months[int.Parse(payment.CreationDate.Value.ToString("MM")) - 1] + " DE " + payment.CreationDate.Value.ToString("yyyy"), f10, brush, 340, 360 + copy);

                        using (var addNames = new posb.Config())
                        {
                            var showNames = addNames.AltaAddNames();

                            if (showNames)
                            {

                                e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                                e1.Graphics.DrawString("TESORERO(A): " + payment.Tesorero, f08, brush, 100, 450 + copy);
                                //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                                e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                                e1.Graphics.DrawString("PRESIDENTE(A): " + payment.Presidente, f08, brush, 500, 450 + copy);
                                //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);
                            }
                            else
                            {
                                e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                                e1.Graphics.DrawString("TESORERO(A)", f08, brush, 170, 450 + copy);
                                //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                                e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                                e1.Graphics.DrawString("PRESIDENTE(A)", f08, brush, 565, 450 + copy);
                                //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);
                            }
                        }

                        e1.Graphics.DrawImage(sicap, 403, 430 + copy, 40, 50);

                        e1.Graphics.DrawString("SICAP V1.0.0", f06, brush, 397, 480 + copy);

                        e1.Graphics.DrawString("Impresión " + (i + 1) + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), f08, brush, 610, 495 + copy);

                        if (i.Equals(0))
                            e1.Graphics.DrawString(line2, f06, brush, 0, 525 + copy);
                    }
                }

                pen.Dispose();
            };

            try
            {
                using (var printer = new posb.Config())
                {
                    p.PrinterSettings.PrinterName = printer.Printer();
                }

                p.Print();
            }
            catch (Exception ex)
            {
                this.Alert("Ocurrió un error al intentar imprimir el ticket. Descripcion: " + ex.Message, eForm.TypeError.Error);
            }

            return;

        }

        protected void PrintHabitant(int Id)
        {
            var months = new List<string>
            {
                "ENERO",
                "FEBRERO",
                "MARZO",
                "ABRIL",
                "MAYO",
                "JUNIO",
                "JULIO",
                "AGOSTO",
                "SEPTIEMBRE",
                "OCTUBRE",
                "NOVIEMBRE",
                "DICIEMBRE"
            };

            var p = new PrintDocument();

            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                var line = string.Empty;
                for (int i = 0; i < 81; i++)
                    line += "_";

                var line2 = string.Empty;
                for (int i = 0; i < 125; i++)
                    line2 += " - ";

                var font = "Times New Roman";
                var brush = new SolidBrush(Color.Black);
                var brushTwo = new SolidBrush(Color.LightGray);

                var brushRed = new SolidBrush(Color.Red);

                Font titleFont = new Font(font, 18, FontStyle.Bold),
                     titleSubFont = new Font(font, 16, FontStyle.Bold),
                     f14 = new Font(font, 14, FontStyle.Bold),
                     f11 = new Font(font, 11),
                     f10 = new Font(font, 10),
                     f09 = new Font(font, 09),
                     f08 = new Font(font, 08),
                     f06 = new Font(font, 06);

                var pen = new Pen(Brushes.Black);
                pen.Width = 0.8F;

                var picture1 = new posb.Config().GetImage("Voucher", 1);
                var picture2 = new posb.Config().GetImage("Voucher", 2);
                var picture3 = new posb.Config().GetImage("Voucher", 3);
                var imageCom = new Bitmap(new MemoryStream(picture1));
                var image = new Bitmap(new MemoryStream(picture2));
                var sicap = new Bitmap(new MemoryStream(picture3));

                using (posb.Payment payment = new posb.Payment
                {
                    Id = Id
                }
                .HabitantPrint())
                {
                    var total = new Numalet().Convert(String.Format("{0:0.00}", payment.Amount));

                    for (int i = 0; i <= 1; i++)
                    {
                        var copy = i * 530;

                        e1.Graphics.DrawImage(imageCom, 20, 7 + copy, 90, 110);

                        e1.Graphics.DrawString("COMITÉ DE AGUA POTABLE", titleFont, brush, 240, 40 + copy);
                        e1.Graphics.DrawString("SAN DIEGO TLAILOTLACAN", titleFont, brush, 240, 65 + copy);
                        e1.Graphics.DrawImage(image, 760, 37 + copy, 60, 80);

                        e1.Graphics.FillRectangle(brush, new Rectangle(20, 106 + copy, 795, 6));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 112 + copy, 795, 30));
                        e1.Graphics.DrawString("RECIBO OFICIAL DE INGRESOS", titleSubFont, brush, 30, 115 + copy);

                        e1.Graphics.DrawString("FOLIO", titleSubFont, brush, 550, 115 + copy);
                        e1.Graphics.DrawString("N° H-" + payment.Folio.PadLeft(10, '0'), titleSubFont, brushRed, 630, 115 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 795, 127));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 222, 127));

                        e1.Graphics.DrawString("RECIBI DEL(A) SR(A)", f14, brush, 30, 170 + copy);
                        e1.Graphics.DrawString(payment.Propietario, f14, brush, 250, 170 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 170 + copy);

                        e1.Graphics.DrawString("CANTIDAD", f14, brush, 30, 200 + copy);
                        e1.Graphics.DrawString("$" + String.Format("{0:0.00}", payment.Amount) + "   " + total, f14, brush, 250, 200 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 200 + copy);

                        e1.Graphics.DrawString("CONCEPTO", f14, brush, 30, 230 + copy);
                        e1.Graphics.DrawString("Pago por alta en la comunidad", f14, brush, 250, 230 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 230 + copy);

                        e1.Graphics.DrawString("DIRECCIÓN", f14, brush, 30, 260 + copy);
                        e1.Graphics.DrawString(payment.Direccion + "  [" + payment.Type + "]", f14, brush, 250, 260 + copy);

                        e1.Graphics.FillRectangle(brushTwo, new Rectangle(20, 299 + copy, 795, 27));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 299 + copy, 795, 27));

                        e1.Graphics.DrawString("DESCRIPCIÓN DEL PAGO", titleSubFont, brush, 280, 300 + copy);
                        e1.Graphics.DrawString("Pago por alta en la comunidad del habitante: " + payment.Propietario, f10, brush, 25, 332 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 326 + copy, 795, 27));

                        e1.Graphics.DrawString("SAN DIEGO TEXCOCO ESTADO DE MEXICO A " + payment.CreationDate.Value.ToString("dd") + " DE " + months[int.Parse(payment.CreationDate.Value.ToString("MM")) - 1] + " DE " + payment.CreationDate.Value.ToString("yyyy"), f10, brush, 340, 360 + copy);

                        using (var addNames = new posb.Config())
                        {
                            var showNames = addNames.AltaAddNames();

                            if (showNames)
                            {

                                e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                                e1.Graphics.DrawString("TESORERO(A): " + payment.Tesorero, f08, brush, 100, 450 + copy);
                                //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                                e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                                e1.Graphics.DrawString("PRESIDENTE(A): " + payment.Presidente, f08, brush, 500, 450 + copy);
                                //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);
                            }
                            else
                            {
                                e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                                e1.Graphics.DrawString("TESORERO(A)", f08, brush, 170, 450 + copy);
                                //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                                e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                                e1.Graphics.DrawString("PRESIDENTE(A)", f08, brush, 565, 450 + copy);
                                //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);
                            }
                        }

                        e1.Graphics.DrawImage(sicap, 403, 430 + copy, 40, 50);

                        e1.Graphics.DrawString("SICAP V1.0.0", f06, brush, 397, 480 + copy);

                        e1.Graphics.DrawString("Impresión " + (i + 1) + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), f08, brush, 610, 495 + copy);

                        if (i.Equals(0))
                            e1.Graphics.DrawString(line2, f06, brush, 0, 525 + copy);
                    }
                }

                pen.Dispose();
            };

            try
            {
                using (var printer = new posb.Config())
                {
                    p.PrinterSettings.PrinterName = printer.Printer();
                }

                p.Print();
            }
            catch (Exception ex)
            {
                this.Alert("Ocurrió un error al intentar imprimir el ticket. Descripcion: " + ex.Message, eForm.TypeError.Error);
            }

            return;

        }

        protected void PrintWaterIntake(int Id)
        {
            var months = new List<string>
            {
                "ENERO",
                "FEBRERO",
                "MARZO",
                "ABRIL",
                "MAYO",
                "JUNIO",
                "JULIO",
                "AGOSTO",
                "SEPTIEMBRE",
                "OCTUBRE",
                "NOVIEMBRE",
                "DICIEMBRE"
            };

            var p = new PrintDocument();

            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                var line = string.Empty;
                for (int i = 0; i < 81; i++)
                    line += "_";

                var line2 = string.Empty;
                for (int i = 0; i < 125; i++)
                    line2 += " - ";

                var font = "Times New Roman";
                var brush = new SolidBrush(Color.Black);
                var brushTwo = new SolidBrush(Color.LightGray);

                var brushRed = new SolidBrush(Color.Red);

                Font titleFont = new Font(font, 18, FontStyle.Bold),
                     titleSubFont = new Font(font, 16, FontStyle.Bold),
                     f14 = new Font(font, 14, FontStyle.Bold),
                     f11 = new Font(font, 11),
                     f10 = new Font(font, 10),
                     f09 = new Font(font, 09),
                     f08 = new Font(font, 08),
                     f06 = new Font(font, 06);

                var pen = new Pen(Brushes.Black);
                pen.Width = 0.8F;

                var picture1 = new posb.Config().GetImage("Voucher", 1);
                var picture2 = new posb.Config().GetImage("Voucher", 2);
                var picture3 = new posb.Config().GetImage("Voucher", 3);
                var imageCom = new Bitmap(new MemoryStream(picture1));
                var image = new Bitmap(new MemoryStream(picture2));
                var sicap = new Bitmap(new MemoryStream(picture3));

                using (posb.Payment payment = new posb.Payment
                {
                    Id = Id
                }
                .WaterIntakePrint())
                {
                    var total = new Numalet().Convert(String.Format("{0:0.00}", payment.Amount));

                    for (int i = 0; i <= 1; i++)
                    {
                        var copy = i * 530;

                        e1.Graphics.DrawImage(imageCom, 20, 7 + copy, 90, 110);

                        e1.Graphics.DrawString("COMITÉ DE AGUA POTABLE", titleFont, brush, 240, 40 + copy);
                        e1.Graphics.DrawString("SAN DIEGO TLAILOTLACAN", titleFont, brush, 240, 65 + copy);
                        e1.Graphics.DrawImage(image, 760, 37 + copy, 60, 80);

                        e1.Graphics.FillRectangle(brush, new Rectangle(20, 106 + copy, 795, 6));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 112 + copy, 795, 30));
                        e1.Graphics.DrawString("RECIBO OFICIAL DE INGRESOS", titleSubFont, brush, 30, 115 + copy);

                        e1.Graphics.DrawString("FOLIO", titleSubFont, brush, 550, 115 + copy);
                        e1.Graphics.DrawString("N° T-" + payment.Folio.PadLeft(10, '0'), titleSubFont, brushRed, 630, 115 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 795, 127));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 222, 127));

                        e1.Graphics.DrawString("RECIBI DEL(A) SR(A)", f14, brush, 30, 170 + copy);
                        e1.Graphics.DrawString(payment.Propietario, f14, brush, 250, 170 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 170 + copy);

                        e1.Graphics.DrawString("CANTIDAD", f14, brush, 30, 200 + copy);
                        e1.Graphics.DrawString("$" + String.Format("{0:0.00}", payment.Amount) + "   " + total, f14, brush, 250, 200 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 200 + copy);

                        e1.Graphics.DrawString("CONCEPTO", f14, brush, 30, 230 + copy);
                        e1.Graphics.DrawString("Pago por alta de toma de agua", f14, brush, 250, 230 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 230 + copy);

                        e1.Graphics.DrawString("DIRECCIÓN", f14, brush, 30, 260 + copy);
                        e1.Graphics.DrawString(payment.Direccion + "  [" + payment.Type + "]", f14, brush, 250, 260 + copy);

                        e1.Graphics.FillRectangle(brushTwo, new Rectangle(20, 299 + copy, 795, 27));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 299 + copy, 795, 27));

                        e1.Graphics.DrawString("DESCRIPCIÓN DEL PAGO", titleSubFont, brush, 280, 300 + copy);
                        e1.Graphics.DrawString("Pago por alta de toma de agua ubicada en:" + payment.Direccion, f10, brush, 25, 332 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 326 + copy, 795, 27));

                        e1.Graphics.DrawString("SAN DIEGO TEXCOCO ESTADO DE MEXICO A " + payment.CreationDate.Value.ToString("dd") + " DE " + months[int.Parse(payment.CreationDate.Value.ToString("MM")) - 1] + " DE " + payment.CreationDate.Value.ToString("yyyy"), f10, brush, 340, 360 + copy);

                        using (var addNames = new posb.Config())
                        {
                            var showNames = addNames.AltaAddNames();

                            if (showNames)
                            {

                                e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                                e1.Graphics.DrawString("TESORERO(A): " + payment.Tesorero, f08, brush, 100, 450 + copy);
                                //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                                e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                                e1.Graphics.DrawString("PRESIDENTE(A): " + payment.Presidente, f08, brush, 500, 450 + copy);
                                //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);
                            }
                            else
                            {
                                e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                                e1.Graphics.DrawString("TESORERO(A)", f08, brush, 170, 450 + copy);
                                //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                                e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                                e1.Graphics.DrawString("PRESIDENTE(A)", f08, brush, 565, 450 + copy);
                                //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);
                            }
                        }

                        e1.Graphics.DrawImage(sicap, 403, 430 + copy, 40, 50);

                        e1.Graphics.DrawString("SICAP V1.0.0", f06, brush, 397, 480 + copy);

                        e1.Graphics.DrawString("Impresión " + (i + 1) + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), f08, brush, 610, 495 + copy);

                        if (i.Equals(0))
                            e1.Graphics.DrawString(line2, f06, brush, 0, 525 + copy);
                    }
                }

                pen.Dispose();
            };

            try
            {
                using (var printer = new posb.Config())
                {
                    p.PrinterSettings.PrinterName = printer.Printer();
                }

                p.Print();
            }
            catch (Exception ex)
            {
                this.Alert("Ocurrió un error al intentar imprimir el ticket. Descripcion: " + ex.Message, eForm.TypeError.Error);
            }

            return;

        }

        public void ConfigureButtons()
        {
            var formName = this.Name;
            var buttons = new posb.User().GetButtonsRol(formName);

            if (!buttons.Any() && this.Tag != null)
            {
                formName = this.Tag.ToString();
                buttons = new posb.User().GetButtonsRol(formName);
            }

            if (buttons.Any())
            {
                foreach (var button in buttons)
                {
                    if (button.IsButton.Value)
                    {
                        var ctrl = this.Controls[button.Name];

                        if (ctrl != null)
                        {
                            ctrl.Enabled = button.Active.Value;
                        }
                    }
                    else
                    {
                        this.UpdateButton = button.Active.Value;
                    }
                }
            }
        }

        #endregion

        protected void txt_KeyPressText(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        protected void txt_KeyPressMoney(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = sender as MetroTextBox;

            if (txt.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        protected void txt_KeyPressNumber(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = sender as MetroTextBox;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach (var gv in this.Controls.OfType<DataGridView>())
            {
                gv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF");
            }

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.BackColor = ColorTranslator.FromHtml("#D4D0C8");
            }

            this.ConfigureTextBoxValidation();

            this.ConfigureRol();

            this.ConfigureToolTip();

            this.ConfigureButtons();

            base.OnLoad(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

    }
}
