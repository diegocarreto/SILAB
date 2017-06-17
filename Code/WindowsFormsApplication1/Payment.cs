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
using posb = PosBusiness;
using UtilitiesForm.Extensions;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class Payment : BaseForm
    {
        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        private int? StartYear = null;

        private int? StartMonth = null;

        private int? idWaterIntake = null;

        private bool ChangeHabitant = true;

        public Payment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtAP;

            this.SetCostPerMonth();
            this.FillYears();
            this.FillYearsEnd();
            this.FillMonth();
            this.FillMonthEnd();
            this.FillHabitant();

            this.LoadComplete = true;
        }

        private void FillHabitant()
        {
            using (var habitant = new posb.Habitant())
            {
                this.cmbHabitant.Fill(habitant.List());
            }
        }

        private void SetCostPerMonth()
        {
            using (var e = new posb.Config())
            {
                this.txtAmount.Text = String.Format("{0:0.00}", e.Mensualidad());
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.LoadComplete)
                this.CalculateTotal();
        }

        private void CalculateTotal()
        {
            var totalMonths = 0;
            var startYear = 0;
            var endYear = 0;
            var startMonth = 0;
            var endMonth = 0;

            if (this.cmbYear.SelectedIndex > 0)
                startYear = int.Parse(this.cmbYear.SelectedItem.ToString());

            if (this.cmbYearEnd.SelectedIndex > 0)
                endYear = int.Parse(this.cmbYearEnd.SelectedItem.ToString());

            if (this.cmbMonth.SelectedIndex > 0)
                startMonth = this.cmbMonth.SelectedIndex;

            if (this.cmbMonthEnd.SelectedIndex > 0)
                endMonth = this.cmbMonthEnd.SelectedIndex;

            if (startYear > endYear)
            {
                this.txtTotal.Text = String.Format("{0:0.00}", 0);
                return;
                //this.Alert("El año final no puede ser superior al año inicial");
            }

            if (startYear.Equals(endYear))
            {
                if (startMonth > endMonth)
                {
                    this.txtTotal.Text = String.Format("{0:0.00}", 0);
                    return;
                    //this.Alert("El mes final no puede ser superior al mes inicial");
                }
            }

            if (startYear.Equals(endYear))
            {
                if (startMonth.Equals(endMonth))
                {
                    totalMonths = 1;
                }
                else
                {
                    totalMonths = endMonth - startMonth;
                    totalMonths++;
                }
            }
            else
            {
                for (int i = startYear + 1; i < endYear; i++)
                {
                    totalMonths += 12;
                }

                totalMonths += (13 - startMonth);
                totalMonths += endMonth;
            }

            this.txtTotal.Text = String.Format("{0:0.00}", totalMonths * decimal.Parse(this.txtAmount.Text));
        }

        private void FillYears(int? StartYear = null)
        {
            this.cmbYear.Items.Clear();

            this.cmbYear.Items.Add("Seleccionar...");
            this.cmbMonth.Items.Add("Seleccionar...");

            if (StartYear.HasValue)
            {
                for (int i = StartYear.Value; i < 2050; i++)
                {
                    this.cmbYear.Items.Add(i);
                }

                var currentYear = DateTime.Now.Year.ToString();

                this.cmbYear.Text = currentYear;
            }
            else
            {
                this.cmbYear.SelectedIndex = 0;
            }
        }

        private void FillYearsEnd(int? StartYear = null)
        {
            this.cmbYearEnd.Items.Clear();

            this.cmbYearEnd.Items.Add("Seleccionar...");

            if (StartYear.HasValue)
            {
                for (int i = StartYear.Value; i < 2050; i++)
                {
                    this.cmbYearEnd.Items.Add(i);
                }

                var currentYear = DateTime.Now.Year.ToString();

                this.cmbYearEnd.Text = currentYear;
            }
            else
            {
                this.cmbYearEnd.SelectedIndex = 0;
            }
        }

        private void FillMonth(int? StartYear = null, int? StartMonth = null)
        {
            string[] months = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                              "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            this.cmbMonth.Items.Clear();

            this.cmbMonth.Items.Add("Seleccionar...");

            if (StartMonth.HasValue)
            {
                var year = 0;

                if (this.cmbYear.SelectedIndex > 0)
                {
                    year = int.Parse(this.cmbYear.Text);
                }

                var startMonth = 0;

                if (this.StartYear.Value.Equals(year))
                {
                    startMonth = StartMonth.Value - 1;
                }

                for (int i = startMonth; i < months.Length; i++)
                {
                    this.cmbMonth.Items.Add(months[i]);
                }

                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                if (year.Equals(currentYear))
                {
                    this.cmbMonth.SelectedIndex = currentMonth;
                }
                else
                {
                    this.cmbMonth.SelectedIndex = 0;
                }
            }
            else
            {
                this.cmbMonth.SelectedIndex = 0;
            }
        }

        private void FillMonthEnd(int? StartYear = null, int? StartMonth = null)
        {
            string[] months = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                              "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            this.cmbMonthEnd.Items.Clear();

            this.cmbMonthEnd.Items.Add("Seleccionar...");

            if (StartMonth.HasValue)
            {
                var year = 0;

                if (this.cmbYearEnd.SelectedIndex > 0)
                {
                    year = int.Parse(this.cmbYearEnd.Text);
                }

                var startMonth = 0;

                if (this.StartYear.Value.Equals(year))
                {
                    startMonth = StartMonth.Value - 1;
                }

                for (int i = startMonth; i < months.Length; i++)
                {
                    this.cmbMonthEnd.Items.Add(months[i]);
                }

                var currentMonth = DateTime.Now.Month;
                var currentYear = DateTime.Now.Year;

                if (year.Equals(currentYear))
                {
                    this.cmbMonthEnd.SelectedIndex = currentMonth;
                }
                else
                {
                    this.cmbMonthEnd.SelectedIndex = 0;
                }
            }
            else
            {
                this.cmbMonthEnd.SelectedIndex = 0;
            }
        }

        private void FillWaterIntake(int IdHabitant)
        {
            using (var waterIntake = new posb.WaterIntake
            {
                IdHabitant = IdHabitant
            })
            {
                var waterIntakeList = waterIntake.List(4);

                if (waterIntakeList.Count.Equals(0))
                {
                    waterIntakeList = waterIntake.List(3);
                }

                this.cmbWaterIntake.Fill(waterIntakeList);

                if (this.cmbWaterIntake.Items.Count.Equals(2))
                    this.cmbWaterIntake.SelectedIndex = 1;

                if (this.idWaterIntake.HasValue)
                {
                    this.cmbWaterIntake.SelectedValue = this.idWaterIntake;
                    this.idWaterIntake = null;
                }
            }

            using (var habitant = new posb.Habitant
            {
                Id = this.cmbHabitant.GetVal<int>()
            })
            {
                habitant.Get();

                this.StartYear = habitant.Year;
                this.StartMonth = habitant.Month;

                this.FillYears(this.StartYear);
                this.FillYearsEnd(this.StartYear);
            }
        }

        private void cmbHabitant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbHabitant.SelectedIndex > 0 && this.ChangeHabitant)
            {
                this.FillWaterIntake(this.cmbHabitant.GetVal<int>());
            }
            else
            {
                this.cmbWaterIntake.Fill(new List<posb.WaterIntake>());
                this.FillYears();
                this.FillMonth();

                this.StartYear = null;
                this.StartMonth = null;
            }

            this.txtAP.Clear();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillMonth(this.StartYear, this.StartMonth);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (this.Confirm("¿Realmente desea realizar el cobro por el monto de " + this.txtTotal.Text + " ?"))
                {
                    using (var payment = new posb.Payment
                    {
                        IdHabitantOrRent = this.cmbHabitant.GetVal<int>(),
                        IdWaterIntake = this.cmbWaterIntake.GetVal<int>(),
                        Year = int.Parse(this.cmbYear.Text),
                        Month = this.cmbMonth.SelectedIndex,
                        YearEnd = int.Parse(this.cmbYearEnd.Text),
                        MonthEnd = this.cmbMonthEnd.SelectedIndex,
                        Amount = decimal.Parse(this.txtTotal.Text),
                        Observations = this.txtObservations.Text
                    })
                    {
                        if (!payment.Exist())
                        {
                            payment.Save();

                            if (this.Confirm("¿Deseas imprimir el recibo?"))
                            {
                                this.Print(payment.Id.Value);
                            }

                            this.Result(true, "Success!!");

                            this.Close();
                        }
                        else
                        {
                            this.Alert("Ya se realizo el pago de la toma de agua en el periodo indicado");
                            this.cmbMonth.Focus();
                        }
                    }
                }
            }
        }

        private void cmbYearEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillMonthEnd(this.StartYear, this.StartMonth);
        }

        private void cmbMonthEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.LoadComplete)
                this.CalculateTotal();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var p = new posb.Payment 
            {
                Id = int.Parse(this.txtAP.Text)
            };

            p.FindByAP();

            if (p.IdWaterIntake.HasValue && p.IdHabitantOrRent.HasValue)
            {
                this.ChangeHabitant = false;

                this.idWaterIntake = p.IdWaterIntake;
                this.cmbHabitant.SelectedValue = p.IdHabitantOrRent;
                this.FillWaterIntake(p.IdHabitantOrRent.Value);

                this.ChangeHabitant = true;
            }
            else
                this.Alert("No se encontraron datos para el AP: " + this.txtAP.Text);
        }

        private void cmbWaterIntake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
