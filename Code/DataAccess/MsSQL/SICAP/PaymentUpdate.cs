namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Paymentupdate.
	/// </summary>
	public partial class Paymentupdate : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, int? id = null, int? year = null, int? month = null, Decimal? amount = null, String observations = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@amount", SqlDbType.Money, amount, null).Add("@observations", SqlDbType.VarChar, observations, 2000);

        	return this.GetListBase<T>("SICAP", "PaymentUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, int? id = null, int? year = null, int? month = null, Decimal? amount = null, String observations = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@amount", SqlDbType.Money, amount, null).Add("@observations", SqlDbType.VarChar, observations, 2000);

        	return this.ExecuteScalar<T>("SICAP", "PaymentUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, int? id = null, int? year = null, int? month = null, Decimal? amount = null, String observations = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@amount", SqlDbType.Money, amount, null).Add("@observations", SqlDbType.VarChar, observations, 2000);

        	return this.ExecuteNonQuery("SICAP", "PaymentUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, int? id = null, int? year = null, int? month = null, Decimal? amount = null, String observations = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@amount", SqlDbType.Money, amount, null).Add("@observations", SqlDbType.VarChar, observations, 2000);

        	return this.GetReader("SICAP", "PaymentUpdate",parameters.ToArray());
        }

	#endregion
	}
}