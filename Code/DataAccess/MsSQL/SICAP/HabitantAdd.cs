namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Habitantadd.
	/// </summary>
	public partial class Habitantadd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, String nombre = null, String paterno = null, String materno = null, String observations = null, int? year = null, int? month = null, Boolean? active = null, Decimal? total = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@nombre", SqlDbType.VarChar, nombre, 100).Add("@paterno", SqlDbType.VarChar, paterno, 50).Add("@materno", SqlDbType.VarChar, materno, 50).Add("@observations", SqlDbType.VarChar, observations, 2000).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@active", SqlDbType.Bit, active, null).Add("@total", SqlDbType.Money, total, null);

        	return this.GetListBase<T>("SICAP", "HabitantAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, String nombre = null, String paterno = null, String materno = null, String observations = null, int? year = null, int? month = null, Boolean? active = null, Decimal? total = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@nombre", SqlDbType.VarChar, nombre, 100).Add("@paterno", SqlDbType.VarChar, paterno, 50).Add("@materno", SqlDbType.VarChar, materno, 50).Add("@observations", SqlDbType.VarChar, observations, 2000).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@active", SqlDbType.Bit, active, null).Add("@total", SqlDbType.Money, total, null);

        	return this.ExecuteScalar<T>("SICAP", "HabitantAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, String nombre = null, String paterno = null, String materno = null, String observations = null, int? year = null, int? month = null, Boolean? active = null, Decimal? total = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@nombre", SqlDbType.VarChar, nombre, 100).Add("@paterno", SqlDbType.VarChar, paterno, 50).Add("@materno", SqlDbType.VarChar, materno, 50).Add("@observations", SqlDbType.VarChar, observations, 2000).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@active", SqlDbType.Bit, active, null).Add("@total", SqlDbType.Money, total, null);

        	return this.ExecuteNonQuery("SICAP", "HabitantAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, String nombre = null, String paterno = null, String materno = null, String observations = null, int? year = null, int? month = null, Boolean? active = null, Decimal? total = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@nombre", SqlDbType.VarChar, nombre, 100).Add("@paterno", SqlDbType.VarChar, paterno, 50).Add("@materno", SqlDbType.VarChar, materno, 50).Add("@observations", SqlDbType.VarChar, observations, 2000).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null).Add("@active", SqlDbType.Bit, active, null).Add("@total", SqlDbType.Money, total, null);

        	return this.GetReader("SICAP", "HabitantAdd",parameters.ToArray());
        }

	#endregion
	}
}