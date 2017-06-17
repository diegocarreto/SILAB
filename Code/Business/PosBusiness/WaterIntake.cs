using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class WaterIntake : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Type { get; set; }

        public string Printbtn { get; set; }

        public int? IdStreet { get; set; }

        public int? IdHabitant { get; set; }

        public int? IdRent { get; set; }

        public string RentName { get; set; }

        public string Street { get; set; }

        public string ExteriorNumber { get; set; }

        public string InteriorNumber { get; set; }

        public string Colony { get; set; }

        public decimal Total { get; set; }

        public bool? Principal { get; set; }

        public string PrincipalName { get; set; }

        #endregion

        #region Builder

        public WaterIntake()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Get()
        {
            try
            {
                var e = this.List().First();

                this.IdStreet = e.IdStreet;
                this.ExteriorNumber = e.ExteriorNumber;
                this.InteriorNumber = e.InteriorNumber;
                this.Colony = e.Colony;
                this.Active = e.Active;
                this.Total = e.Total;
                this.IdHabitant = e.IdHabitant;
                this.IdRent = e.IdRent;
                this.RentName = e.RentName;
                this.Principal = e.Principal;
                this.Type = e.Type;

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
        public List<WaterIntake> List(int Type = 2)
        {
            return this.AccessMsSql.Sicap.Waterintakelist.ExeList<WaterIntake>(this.IdHabitant, Type, this.Id);
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
                    this.Id = this.AccessMsSql.Sicap.Waterintakeadd.ExeScalar<int>(this.UserId, this.IdHabitant, this.IdRent, this.IdStreet, this.ExteriorNumber, this.InteriorNumber, this.Colony, this.Total, this.Principal, this.Type);
                }
                else
                {
                    this.AccessMsSql.Sicap.Waterintakeupdate.ExeNonQuery(this.UserId, this.IdHabitant, this.IdRent, this.Id, this.IdStreet, this.ExteriorNumber, this.InteriorNumber, this.Colony, this.Active, this.Total, this.Principal, this.Type);
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
                this.AccessMsSql.Sicap.Waterintakedelete.ExeNonQuery(this.UserId, this.Id);

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
