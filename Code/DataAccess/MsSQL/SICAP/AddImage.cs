namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Addimage.
	/// </summary>
	public partial class Addimage : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? entityId = null, String entityName = null, Byte[] image = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@entityId", SqlDbType.Int, entityId, null).Add("@entityName", SqlDbType.VarChar, entityName, 50).Add("@image", SqlDbType.Image, image, 2147483647);

        	return this.GetListBase<T>("SICAP", "AddImage",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? entityId = null, String entityName = null, Byte[] image = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@entityId", SqlDbType.Int, entityId, null).Add("@entityName", SqlDbType.VarChar, entityName, 50).Add("@image", SqlDbType.Image, image, 2147483647);

        	return this.ExecuteScalar<T>("SICAP", "AddImage",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? entityId = null, String entityName = null, Byte[] image = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@entityId", SqlDbType.Int, entityId, null).Add("@entityName", SqlDbType.VarChar, entityName, 50).Add("@image", SqlDbType.Image, image, 2147483647);

        	return this.ExecuteNonQuery("SICAP", "AddImage",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? entityId = null, String entityName = null, Byte[] image = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@entityId", SqlDbType.Int, entityId, null).Add("@entityName", SqlDbType.VarChar, entityName, 50).Add("@image", SqlDbType.Image, image, 2147483647);

        	return this.GetReader("SICAP", "AddImage",parameters.ToArray());
        }

	#endregion
	}
}