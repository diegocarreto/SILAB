namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Checkrrestoreuser.
	/// </summary>
	public partial class Checkrrestoreuser : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? IdUser = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@IdUser", SqlDbType.Int, IdUser, null);

        	return this.GetListBase<T>("SICAP", "CheckrRestoreUser",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? IdUser = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@IdUser", SqlDbType.Int, IdUser, null);

        	return this.ExecuteScalar<T>("SICAP", "CheckrRestoreUser",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? IdUser = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@IdUser", SqlDbType.Int, IdUser, null);

        	return this.ExecuteNonQuery("SICAP", "CheckrRestoreUser",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? IdUser = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@IdUser", SqlDbType.Int, IdUser, null);

        	return this.GetReader("SICAP", "CheckrRestoreUser",parameters.ToArray());
        }

	#endregion
	}
}