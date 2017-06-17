namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Waterintakeadd.
	/// </summary>
	public partial class Waterintakeadd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, int? idHabitant = null, int? idRent = null, int? idStreet = null, String exteriorNumber = null, String interiorNumber = null, String colony = null, Decimal? total = null, Boolean? principal = null, String type = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idRent", SqlDbType.Int, idRent, null).Add("@idStreet", SqlDbType.Int, idStreet, null).Add("@exteriorNumber", SqlDbType.VarChar, exteriorNumber, 10).Add("@interiorNumber", SqlDbType.VarChar, interiorNumber, 10).Add("@colony", SqlDbType.VarChar, colony, 50).Add("@total", SqlDbType.Money, total, null).Add("@principal", SqlDbType.Bit, principal, null).Add("@type", SqlDbType.VarChar, type, 50);

        	return this.GetListBase<T>("SICAP", "WaterIntakeAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, int? idHabitant = null, int? idRent = null, int? idStreet = null, String exteriorNumber = null, String interiorNumber = null, String colony = null, Decimal? total = null, Boolean? principal = null, String type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idRent", SqlDbType.Int, idRent, null).Add("@idStreet", SqlDbType.Int, idStreet, null).Add("@exteriorNumber", SqlDbType.VarChar, exteriorNumber, 10).Add("@interiorNumber", SqlDbType.VarChar, interiorNumber, 10).Add("@colony", SqlDbType.VarChar, colony, 50).Add("@total", SqlDbType.Money, total, null).Add("@principal", SqlDbType.Bit, principal, null).Add("@type", SqlDbType.VarChar, type, 50);

        	return this.ExecuteScalar<T>("SICAP", "WaterIntakeAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, int? idHabitant = null, int? idRent = null, int? idStreet = null, String exteriorNumber = null, String interiorNumber = null, String colony = null, Decimal? total = null, Boolean? principal = null, String type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idRent", SqlDbType.Int, idRent, null).Add("@idStreet", SqlDbType.Int, idStreet, null).Add("@exteriorNumber", SqlDbType.VarChar, exteriorNumber, 10).Add("@interiorNumber", SqlDbType.VarChar, interiorNumber, 10).Add("@colony", SqlDbType.VarChar, colony, 50).Add("@total", SqlDbType.Money, total, null).Add("@principal", SqlDbType.Bit, principal, null).Add("@type", SqlDbType.VarChar, type, 50);

        	return this.ExecuteNonQuery("SICAP", "WaterIntakeAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, int? idHabitant = null, int? idRent = null, int? idStreet = null, String exteriorNumber = null, String interiorNumber = null, String colony = null, Decimal? total = null, Boolean? principal = null, String type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idRent", SqlDbType.Int, idRent, null).Add("@idStreet", SqlDbType.Int, idStreet, null).Add("@exteriorNumber", SqlDbType.VarChar, exteriorNumber, 10).Add("@interiorNumber", SqlDbType.VarChar, interiorNumber, 10).Add("@colony", SqlDbType.VarChar, colony, 50).Add("@total", SqlDbType.Money, total, null).Add("@principal", SqlDbType.Bit, principal, null).Add("@type", SqlDbType.VarChar, type, 50);

        	return this.GetReader("SICAP", "WaterIntakeAdd",parameters.ToArray());
        }

	#endregion
	}
}