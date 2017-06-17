namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Catalogadd.
	/// </summary>
	public partial class Catalogadd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, String name = null, String type = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@type", SqlDbType.VarChar, type, 50);

        	return this.GetListBase<T>("SICAP", "CatalogAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, String name = null, String type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@type", SqlDbType.VarChar, type, 50);

        	return this.ExecuteScalar<T>("SICAP", "CatalogAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, String name = null, String type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@type", SqlDbType.VarChar, type, 50);

        	return this.ExecuteNonQuery("SICAP", "CatalogAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, String name = null, String type = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@type", SqlDbType.VarChar, type, 50);

        	return this.GetReader("SICAP", "CatalogAdd",parameters.ToArray());
        }

	#endregion
	}
}