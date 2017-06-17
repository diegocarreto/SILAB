using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class PaymentPerYear : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public int IdWaterIntake { get; set; }

        public string Name { get; set; }

        public int AP { get; set; }

        public string NameWaterIntake { get; set; }

        public int Enero { get; set; }

        public int Febrero { get; set; }

        public int Marzo { get; set; }

        public int Abril { get; set; }

        public int Mayo { get; set; }

        public int Junio { get; set; }

        public int Julio { get; set; }

        public int Agosto { get; set; }

        public int Septiembre { get; set; }

        public int Octubre { get; set; }

        public int Noviembre { get; set; }

        public int Diciembre { get; set; }       

        #endregion

        #region Builder

        public PaymentPerYear()
        {
        }

        #endregion

        #region Methods

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<PaymentPerYear> Report(int Year)
        {
            return this.AccessMsSql.Sicap.Paymentperyear.ExeList<PaymentPerYear>(Year);
        }

        #endregion
    }
}
