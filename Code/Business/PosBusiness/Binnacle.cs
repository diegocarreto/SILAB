using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Binnacle : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Usuario { get; set; }

        public string Accion { get; set; }

        public string Tipo { get; set; }

        public string Identificador { get; set; }

        public string ValorPrevio { get; set; }

        public string ValorActual { get; set; }

        public DateTime? Fecha { get; set; }

        #endregion

        #region Builder

        public Binnacle()
        {
        }

        #endregion

        #region Methods

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<Binnacle> List(int Type = 2)
        {
            return this.AccessMsSql.Sicap.Binnaclelist.ExeList<Binnacle>(Type, this.Find, this.Page, this.Rows, this.SortName, this.Order);
        }

        #endregion
    }
}
