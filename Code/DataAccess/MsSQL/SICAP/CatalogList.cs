namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Cataloglist.
	/// </summary>
	public partial class Cataloglist : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? typeQuery = null, String type = null, int? id = null, String find = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@typeQuery", SqlDbType.Int, typeQuery, null).Add("@type", SqlDbType.VarChar, type, 50).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 10).Add("@Order", SqlDbType.VarChar, Order, 4);

        	return this.GetListBase<T>("SICAP", "CatalogList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? typeQuery = null, String type = null, int? id = null, String find = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@typeQuery", SqlDbType.Int, typeQuery, null).Add("@type", SqlDbType.VarChar, type, 50).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 10).Add("@Order", SqlDbType.VarChar, Order, 4);

        	return this.ExecuteScalar<T>("SICAP", "CatalogList",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? typeQuery = null, String type = null, int? id = null, String find = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@typeQuery", SqlDbType.Int, typeQuery, null).Add("@type", SqlDbType.VarChar, type, 50).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 10).Add("@Order", SqlDbType.VarChar, Order, 4);

        	return this.ExecuteNonQuery("SICAP", "CatalogList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? typeQuery = null, String type = null, int? id = null, String find = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@typeQuery", SqlDbType.Int, typeQuery, null).Add("@type", SqlDbType.VarChar, type, 50).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 10).Add("@Order", SqlDbType.VarChar, Order, 4);

        	return this.GetReader("SICAP", "CatalogList",parameters.ToArray());
        }

	#endregion
	}
}