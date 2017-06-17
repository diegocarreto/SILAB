using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PosBusiness.Extensions;

namespace PosBusiness
{
    [Serializable]
    public class Provider : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Contact1 { get; set; }

        public string Position1 { get; set; }

        public string Contact2 { get; set; }

        public string Position2 { get; set; }

        public string Street { get; set; }

        public string Colony { get; set; }

        public string Municipality { get; set; }

        public string City { get; set; }

        public string Code { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Email1 { get; set; }

        public string Email2 { get; set; }

        public string Rubric { get; set; }

        public string PaymentTerms { get; set; }

        public string PaymentConditions { get; set; }

        #endregion

        #region Builder

        public Provider()
        {
        }

        #endregion

        #region Methods

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Delete()
        {
            try
            {
                this.AccessMsSql.Sicap.Providerdelete.ExeNonQuery(this.UserId, this.Id);

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
        public List<Provider> List(int Type = 1, bool IsDto = false)
        {
            var list = this.AccessMsSql.Sicap.Providerlist.ExeList<Provider>(Type, this.Id, this.Find, this.Page, this.Rows, this.SortName, this.Order);

            if (IsDto)
                this.GetDto<Provider>(list);

            return list;
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
                    this.Id = this.AccessMsSql.Sicap.Provideradd.ExeScalar<int>(this.UserId, this.Name, this.Contact1, this.Position1, this.Contact2, this.Position2, this.Street, this.Colony, this.Municipality, this.City, this.Code, this.Phone1, this.Phone2, this.Email1, this.Email2, this.Rubric, this.PaymentTerms, this.PaymentConditions, this.Active);
                }
                else
                {
                    this.AccessMsSql.Sicap.Providerupdate.ExeNonQuery(this.UserId, this.Id, this.Name, this.Contact1, this.Position1, this.Contact2, this.Position2, this.Street, this.Colony, this.Municipality, this.City, this.Code, this.Phone1, this.Phone2, this.Email1, this.Email2, this.Rubric, this.PaymentTerms, this.PaymentConditions, this.Active);
                }

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