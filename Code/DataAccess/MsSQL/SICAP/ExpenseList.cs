namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Expenselist.
	/// </summary>
	public partial class Expenselist : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? id = null, DateTime? startDate = null, DateTime? finishDate = null, String name = null, int? type = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@id", SqlDbType.Int, id, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@finishDate", SqlDbType.Date, finishDate, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@type", SqlDbType.TinyInt, type, null).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 100).Add("@Order", SqlDbType.VarChar, Order, 4);

        	return this.GetListBase<T>("SICAP", "ExpenseList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? id = null, DateTime? startDate = null, DateTime? finishDate = null, String name = null, int? type = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@id", SqlDbType.Int, id, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@finishDate", SqlDbType.Date, finishDate, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@type", SqlDbType.TinyInt, type, null).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 100).Add("@Order", SqlDbType.VarChar, Order, 4);

        	return this.ExecuteScalar<T>("SICAP", "ExpenseList",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? id = null, DateTime? startDate = null, DateTime? finishDate = null, String name = null, int? type = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@id", SqlDbType.Int, id, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@finishDate", SqlDbType.Date, finishDate, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@type", SqlDbType.TinyInt, type, null).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 100).Add("@Order", SqlDbType.VarChar, Order, 4);

        	return this.ExecuteNonQuery("SICAP", "ExpenseList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? id = null, DateTime? startDate = null, DateTime? finishDate = null, String name = null, int? type = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@id", SqlDbType.Int, id, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@finishDate", SqlDbType.Date, finishDate, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@type", SqlDbType.TinyInt, type, null).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 100).Add("@Order", SqlDbType.VarChar, Order, 4);

        	return this.GetReader("SICAP", "ExpenseList",parameters.ToArray());
        }

	#endregion
	}
}