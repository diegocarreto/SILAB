using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Expense : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Description { get; set; }

        public decimal? Amount { get; set; }

        public int? Type { get; set; }

        public string Picture { get; set; }

        #endregion

        #region Builder

        public Expense()
        {
        }

        #endregion

        #region Methods

        public bool Get()
        {
            try
            {
                this.Rows = 1;
                this.Page = 1;

                var e = this.List().First();

                this.Name = e.Name;
                this.Description = e.Description;
                this.Amount = e.Amount;
                this.Type = e.Type;

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
        public List<Expense> List()
        {
            return this.AccessMsSql.Sicap.Expenselist.ExeList<Expense>(this.Id, this.StartDate, this.EndDate, this.Find, this.Type, this.Page, this.Rows, this.SortName, this.Order);
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
                    this.AccessMsSql.Sicap.Expenseupdate.ExeNonQuery(this.UserId, this.Id, this.Name, this.Description, this.Amount, this.Type);
                }
                else
                {
                    this.Id = this.AccessMsSql.Sicap.Expenseadd.ExeScalar<int>(this.UserId, this.Name, this.Description, this.Amount, this.Type);
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
        public bool Delete()
        {
            try
            {
                this.AccessMsSql.Sicap.Expensedelete.ExeNonQuery(this.Id);

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
