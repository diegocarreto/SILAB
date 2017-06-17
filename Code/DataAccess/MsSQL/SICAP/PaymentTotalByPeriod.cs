namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Paymenttotalbyperiod.
	/// </summary>
	public partial class Paymenttotalbyperiod : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? type = null, DateTime? startDate = null, DateTime? endDate = null, int? month = null, int? year = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@endDate", SqlDbType.Date, endDate, null).Add("@month", SqlDbType.Int, month, null).Add("@year", SqlDbType.Int, year, null);

        	return this.GetListBase<T>("SICAP", "PaymentTotalByPeriod",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? type = null, DateTime? startDate = null, DateTime? endDate = null, int? month = null, int? year = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@endDate", SqlDbType.Date, endDate, null).Add("@month", SqlDbType.Int, month, null).Add("@year", SqlDbType.Int, year, null);

        	return this.ExecuteScalar<T>("SICAP", "PaymentTotalByPeriod",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? type = null, DateTime? startDate = null, DateTime? endDate = null, int? month = null, int? year = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@endDate", SqlDbType.Date, endDate, null).Add("@month", SqlDbType.Int, month, null).Add("@year", SqlDbType.Int, year, null);

        	return this.ExecuteNonQuery("SICAP", "PaymentTotalByPeriod",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? type = null, DateTime? startDate = null, DateTime? endDate = null, int? month = null, int? year = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@endDate", SqlDbType.Date, endDate, null).Add("@month", SqlDbType.Int, month, null).Add("@year", SqlDbType.Int, year, null);

        	return this.GetReader("SICAP", "PaymentTotalByPeriod",parameters.ToArray());
        }

	#endregion
	}
}