using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PosBusiness.Extensions;

namespace PosBusiness
{
    [Serializable]
    public class Area : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public int IdBranchOffice { get; set; }

        public string Code { get; set; }

        #endregion

        #region Builder

        public Area()
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
                this.AccessMsSql.Sicap.Areadelete.ExeNonQuery(this.UserId, this.Id);

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
            var list = this.AccessMsSql.Sicap.Arealist.ExeList<BranchOffice>(Type, this.Id, this.Find, this.Page, this.Rows, this.SortName, this.Order);

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
                    this.Id = this.AccessMsSql.Sicap.Areaadd.ExeScalar<int>(this.UserId, this.IdBranchOffice, this.Code, this.Active);
                }
                else
                {
                    this.AccessMsSql.Sicap.Areaupdate.ExeNonQuery(this.UserId, this.Id, this.IdBranchOffice, this.Code, this.Active);
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