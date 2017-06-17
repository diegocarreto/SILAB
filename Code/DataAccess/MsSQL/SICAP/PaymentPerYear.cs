namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Paymentperyear.
	/// </summary>
	public partial class Paymentperyear : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? year = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@year", SqlDbType.Int, year, null);

        	return this.GetListBase<T>("SICAP", "PaymentPerYear",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? year = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@year", SqlDbType.Int, year, null);

        	return this.ExecuteScalar<T>("SICAP", "PaymentPerYear",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? year = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@year", SqlDbType.Int, year, null);

        	return this.ExecuteNonQuery("SICAP", "PaymentPerYear",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? year = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@year", SqlDbType.Int, year, null);

        	return this.GetReader("SICAP", "PaymentPerYear",parameters.ToArray());
        }

	#endregion
	}
}