using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Payment : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Tesorero { get; set; }

        public string Presidente { get; set; }

        public string Printbtn { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? IdHabitantOrRent { get; set; }

        public int? IdWaterIntake { get; set; }

        public string Observations { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public int? YearEnd { get; set; }

        public int? MonthEnd { get; set; }

        public string MonthName { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Total { get; set; }

        public string Propietario { get; set; }

        public string Folio { get; set; }

        public string Direccion { get; set; }

        public string RentName { get; set; }

        public DateTime? CreationDateTotal { get; set; }

        public string StartDateName { get; set; }

        public string EndDateName { get; set; }

        public string Concept { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        #endregion

        #region Builder

        public Payment()
        {
        }

        #endregion

        #region Methods

        public bool Exist()
        {
            try
            {
                return this.AccessMsSql.Sicap.Paymentexist.ExeScalar<int>(this.IdWaterIntake, this.Year, this.Month).Equals(1);
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<Payment> List()
        {
            return this.AccessMsSql.Sicap.Paymentlist.ExeList<Payment>(this.Find, this.IdHabitantOrRent, this.IdWaterIntake, this.Month, this.Year, this.StartDate, this.EndDate, this.Page, this.Rows, this.SortName, this.Order);
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public Payment Print()
        {
            return this.AccessMsSql.Sicap.Paymentprint.ExeList<Payment>(this.Id).First();
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public Payment FaenaPrint()
        {
            return this.AccessMsSql.Sicap.Faenaprint.ExeList<Payment>(this.Id).First();
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public Payment HabitantPrint()
        {
            return this.AccessMsSql.Sicap.Habitantprint.ExeList<Payment>(this.Id).First();
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public Payment WaterIntakePrint()
        {
            return this.AccessMsSql.Sicap.Waterintakeprint.ExeList<Payment>(this.Id).First();
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Save()
        {
            try
            {
                if (!this.Id.HasValue)
                {
                    this.Id = this.AccessMsSql.Sicap.Paymentadd.ExeScalar<int>(this.UserId, this.IdHabitantOrRent, this.IdWaterIntake, this.Year, this.Month, this.YearEnd, this.MonthEnd, this.Amount, this.Observations);
                }
                else
                {
                    //this.Id = this.AccessMsSql.Sicap.Waterintakeupdate.ExeScalar<int>(this.UserId, this.Id, this.IdStreet, this.ExteriorNumber, this.InteriorNumber, this.Colony, this.Active, this.Total);
                }

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Delete()
        {
            try
            {
                this.AccessMsSql.Sicap.Paymentdelete.ExeNonQuery(this.UserId, this.Id);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        public bool FindByAP()
        {
            try
            {
                var e = this.AccessMsSql.Sicap.Waterintakefindbyap.ExeList<Payment>(this.Id).First();

                this.IdHabitantOrRent = e.IdHabitantOrRent;
                this.IdWaterIntake = e.IdWaterIntake;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
