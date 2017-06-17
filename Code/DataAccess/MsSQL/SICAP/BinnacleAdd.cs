namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Binnacleadd.
	/// </summary>
	public partial class Binnacleadd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, String name = null, String tableName = null, int? idRowPk = null, String type = null, String previousValue = null, String currentValue = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@tableName", SqlDbType.VarChar, tableName, 30).Add("@idRowPk", SqlDbType.Int, idRowPk, null).Add("@type", SqlDbType.VarChar, type, 50).Add("@previousValue", SqlDbType.VarChar, previousValue, 4000).Add("@currentValue", SqlDbType.VarChar, currentValue, 4000);

        	return this.GetListBase<T>("SICAP", "BinnacleAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, String name = null, String tableName = null, int? idRowPk = null, String type = null, String previousValue = null, String currentValue = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@tableName", SqlDbType.VarChar, tableName, 30).Add("@idRowPk", SqlDbType.Int, idRowPk, null).Add("@type", SqlDbType.VarChar, type, 50).Add("@previousValue", SqlDbType.VarChar, previousValue, 4000).Add("@currentValue", SqlDbType.VarChar, currentValue, 4000);

        	return this.ExecuteScalar<T>("SICAP", "BinnacleAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, String name = null, String tableName = null, int? idRowPk = null, String type = null, String previousValue = null, String currentValue = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@tableName", SqlDbType.VarChar, tableName, 30).Add("@idRowPk", SqlDbType.Int, idRowPk, null).Add("@type", SqlDbType.VarChar, type, 50).Add("@previousValue", SqlDbType.VarChar, previousValue, 4000).Add("@currentValue", SqlDbType.VarChar, currentValue, 4000);

        	return this.ExecuteNonQuery("SICAP", "BinnacleAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, String name = null, String tableName = null, int? idRowPk = null, String type = null, String previousValue = null, String currentValue = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@tableName", SqlDbType.VarChar, tableName, 30).Add("@idRowPk", SqlDbType.Int, idRowPk, null).Add("@type", SqlDbType.VarChar, type, 50).Add("@previousValue", SqlDbType.VarChar, previousValue, 4000).Add("@currentValue", SqlDbType.VarChar, currentValue, 4000);

        	return this.GetReader("SICAP", "BinnacleAdd",parameters.ToArray());
        }

	#endregion
	}
}