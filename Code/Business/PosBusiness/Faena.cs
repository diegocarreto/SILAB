using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Faena : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Description { get; set; }

        public decimal? Amount { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public bool? Always { get; set; }

        public string MonthName { get; set; }

        public string HabitantName { get; set; }

        public string HabitantDate { get; set; }

        public string FaenaDate { get; set; }

        public string NameCombo { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int? IdHabitant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? IdFaena { get; set; }

        #endregion

        #region Builder

        public Faena()
        {
        }

        #endregion

        #region Methods

        public bool Get()
        {
            try
            {
                var e = this.List().First();

                this.Name = e.Name;
                this.Description = e.Description;
                this.Amount = e.Amount;
                this.Month = e.Month;
                this.Year = e.Year;
                this.Always = e.Always;
                this.Active = e.Active;

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Faena> List()
        {
            return this.AccessMsSql.Sicap.Faenalist.ExeList<Faena>(this.Id, this.StartDate, this.EndDate, this.Find, this.Year, this.Month, this.Page, this.Rows, this.SortName, this.Order);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Faena> ListByHabitant()
        {
            return this.AccessMsSql.Sicap.Habitantfaenalist.ExeList<Faena>(this.Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Faena> ListPaidOut()
        {
            return this.AccessMsSql.Sicap.Habitantfaenapaidoutlist.ExeList<Faena>(this.Find, this.StartDate, this.EndDate, this.Page, this.Rows, this.SortName, this.Order);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            try
            {
                if (this.Id.HasValue)
                {
                    this.AccessMsSql.Sicap.Faenaupdate.ExeNonQuery(this.UserId, this.Id, this.Name, this.Description, this.Amount, this.Month, this.Year, this.Always, this.Active);
                }
                else
                {
                    this.Id = this.AccessMsSql.Sicap.Faenaadd.ExeScalar<int>(this.UserId, this.Name, this.Description, this.Amount, this.Month, this.Year, this.Always, this.Active);
                }

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool SaveHabitantFaena()
        {
            try
            {
                this.Id = this.AccessMsSql.Sicap.Habitantfaenaadd.ExeScalar<int>(this.UserId, IdHabitant, IdFaena);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            try
            {
                this.AccessMsSql.Sicap.Faenadelete.ExeNonQuery(this.Id);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool DeleteListPaidOut()
        {
            try
            {
                this.AccessMsSql.Sicap.Habitantfaenapaidoutdelete.ExeNonQuery(this.Id);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }

        }

        #endregion
    }
}
