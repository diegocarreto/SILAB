namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Getimage.
	/// </summary>
	public partial class Getimage : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? entityId = null, String entityName = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@entityId", SqlDbType.Int, entityId, null).Add("@entityName", SqlDbType.VarChar, entityName, 50);

        	return this.GetListBase<T>("SICAP", "GetImage",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? entityId = null, String entityName = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@entityId", SqlDbType.Int, entityId, null).Add("@entityName", SqlDbType.VarChar, entityName, 50);

        	return this.ExecuteScalar<T>("SICAP", "GetImage",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? entityId = null, String entityName = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@entityId", SqlDbType.Int, entityId, null).Add("@entityName", SqlDbType.VarChar, entityName, 50);

        	return this.ExecuteNonQuery("SICAP", "GetImage",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? entityId = null, String entityName = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@entityId", SqlDbType.Int, entityId, null).Add("@entityName", SqlDbType.VarChar, entityName, 50);

        	return this.GetReader("SICAP", "GetImage",parameters.ToArray());
        }

	#endregion
	}
}