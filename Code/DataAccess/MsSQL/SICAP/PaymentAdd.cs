namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Paymentadd.
	/// </summary>
	public partial class Paymentadd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, int? idHabitantOrRent = null, int? idWaterIntake = null, int? year = null, int? month = null, int? yearEnd = null, int? monthEnd = null, Decimal? amount = null, String observations = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitantOrRent", SqlDbType.Int, idHabitantOrRent, null).Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@yearEnd", SqlDbType.Int, yearEnd, null).Add("@monthEnd", SqlDbType.Int, monthEnd, null).Add("@amount", SqlDbType.Money, amount, null).Add("@observations", SqlDbType.VarChar, observations, 2000);

        	return this.GetListBase<T>("SICAP", "PaymentAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, int? idHabitantOrRent = null, int? idWaterIntake = null, int? year = null, int? month = null, int? yearEnd = null, int? monthEnd = null, Decimal? amount = null, String observations = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitantOrRent", SqlDbType.Int, idHabitantOrRent, null).Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@yearEnd", SqlDbType.Int, yearEnd, null).Add("@monthEnd", SqlDbType.Int, monthEnd, null).Add("@amount", SqlDbType.Money, amount, null).Add("@observations", SqlDbType.VarChar, observations, 2000);

        	return this.ExecuteScalar<T>("SICAP", "PaymentAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, int? idHabitantOrRent = null, int? idWaterIntake = null, int? year = null, int? month = null, int? yearEnd = null, int? monthEnd = null, Decimal? amount = null, String observations = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitantOrRent", SqlDbType.Int, idHabitantOrRent, null).Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@yearEnd", SqlDbType.Int, yearEnd, null).Add("@monthEnd", SqlDbType.Int, monthEnd, null).Add("@amount", SqlDbType.Money, amount, null).Add("@observations", SqlDbType.VarChar, observations, 2000);

        	return this.ExecuteNonQuery("SICAP", "PaymentAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, int? idHabitantOrRent = null, int? idWaterIntake = null, int? year = null, int? month = null, int? yearEnd = null, int? monthEnd = null, Decimal? amount = null, String observations = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitantOrRent", SqlDbType.Int, idHabitantOrRent, null).Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@yearEnd", SqlDbType.Int, yearEnd, null).Add("@monthEnd", SqlDbType.Int, monthEnd, null).Add("@amount", SqlDbType.Money, amount, null).Add("@observations", SqlDbType.VarChar, observations, 2000);

        	return this.GetReader("SICAP", "PaymentAdd",parameters.ToArray());
        }

	#endregion
	}
}