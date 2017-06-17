namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Habitantfaenaadd.
	/// </summary>
	public partial class Habitantfaenaadd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, int? idHabitant = null, int? idFaena = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idFaena", SqlDbType.Int, idFaena, null);

        	return this.GetListBase<T>("SICAP", "habitantFaenaAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, int? idHabitant = null, int? idFaena = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idFaena", SqlDbType.Int, idFaena, null);

        	return this.ExecuteScalar<T>("SICAP", "habitantFaenaAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, int? idHabitant = null, int? idFaena = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idFaena", SqlDbType.Int, idFaena, null);

        	return this.ExecuteNonQuery("SICAP", "habitantFaenaAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, int? idHabitant = null, int? idFaena = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idFaena", SqlDbType.Int, idFaena, null);

        	return this.GetReader("SICAP", "habitantFaenaAdd",parameters.ToArray());
        }

	#endregion
	}
}