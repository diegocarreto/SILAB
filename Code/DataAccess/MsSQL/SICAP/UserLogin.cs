namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Userlogin.
	/// </summary>
	public partial class Userlogin : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(String alias = null, String password = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@alias", SqlDbType.VarChar, alias, 20).Add("@password", SqlDbType.VarChar, password, 12);

        	return this.GetListBase<T>("SICAP", "UserLogin",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(String alias = null, String password = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@alias", SqlDbType.VarChar, alias, 20).Add("@password", SqlDbType.VarChar, password, 12);

        	return this.ExecuteScalar<T>("SICAP", "UserLogin",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(String alias = null, String password = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@alias", SqlDbType.VarChar, alias, 20).Add("@password", SqlDbType.VarChar, password, 12);

        	return this.ExecuteNonQuery("SICAP", "UserLogin",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(String alias = null, String password = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@alias", SqlDbType.VarChar, alias, 20).Add("@password", SqlDbType.VarChar, password, 12);

        	return this.GetReader("SICAP", "UserLogin",parameters.ToArray());
        }

	#endregion
	}
}