namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Expenseupdate.
	/// </summary>
	public partial class Expenseupdate : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, int? id = null, String name = null, String description = null, Decimal? amount = null, int? type = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null).Add("@type", SqlDbType.TinyInt, type, null);

        	return this.GetListBase<T>("SICAP", "ExpenseUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, int? id = null, String name = null, String description = null, Decimal? amount = null, int? type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null).Add("@type", SqlDbType.TinyInt, type, null);

        	return this.ExecuteScalar<T>("SICAP", "ExpenseUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, int? id = null, String name = null, String description = null, Decimal? amount = null, int? type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null).Add("@type", SqlDbType.TinyInt, type, null);

        	return this.ExecuteNonQuery("SICAP", "ExpenseUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, int? id = null, String name = null, String description = null, Decimal? amount = null, int? type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null).Add("@type", SqlDbType.TinyInt, type, null);

        	return this.GetReader("SICAP", "ExpenseUpdate",parameters.ToArray());
        }

	#endregion
	}
}