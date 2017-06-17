using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PosBusiness.Extensions;

namespace PosBusiness
{
    [Serializable]
    public class BranchOffice : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string IternalCode { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Manager { get; set; }

        #endregion

        #region Builder

        public BranchOffice()
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
                this.AccessMsSql.Sicap.Branchofficedelete.ExeNonQuery(this.UserId, this.Id);

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
        public List<BranchOffice> List(int Type = 1, bool IsDto = false)
        {
            var list = this.AccessMsSql.Sicap.Branchofficelist.ExeList<BranchOffice>(Type, this.Id, this.Find, this.Page, this.Rows, this.SortName, this.Order);

            if (IsDto)
                this.GetDto<BranchOffice>(list);

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
                    this.Id = this.AccessMsSql.Sicap.Branchofficeadd.ExeScalar<int>(this.UserId, this.IternalCode, this.Name, this.Address, this.Phone, this.Manager);
                }
                else
                {
                    this.AccessMsSql.Sicap.Branchofficeupdate.ExeNonQuery(this.UserId, this.Id, this.IternalCode, this.Name, this.Address, this.Phone, this.Manager, this.Active);
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