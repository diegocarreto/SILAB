namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Backupdb.
	/// </summary>
	public partial class Backupdb : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(String path = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@path", SqlDbType.VarChar, path, 5000);

        	return this.GetListBase<T>("SICAP", "backupdb",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(String path = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@path", SqlDbType.VarChar, path, 5000);

        	return this.ExecuteScalar<T>("SICAP", "backupdb",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(String path = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@path", SqlDbType.VarChar, path, 5000);

        	return this.ExecuteNonQuery("SICAP", "backupdb",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(String path = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@path", SqlDbType.VarChar, path, 5000);

        	return this.GetReader("SICAP", "backupdb",parameters.ToArray());
        }

	#endregion
	}
}