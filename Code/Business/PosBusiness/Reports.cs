using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Reports : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Type { get; set; }

        public DateTime? CreatedDate { get; set; }

        public double? Amount { get; set; }

        public string Description { get; set; }

        #endregion

        #region Builder

        public Reports()
        {
        }

        #endregion

        #region Methods

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<Reports> Concentrated(string Type = null, DateTime? StartDate = null, DateTime? EndDate = null)
        {
            return this.AccessMsSql.Sicap.Reportconcentrated.ExeList<Reports>(Type, StartDate, EndDate);
        }

        #endregion
    }
}
