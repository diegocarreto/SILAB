namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Userupdate.
	/// </summary>
	public partial class Userupdate : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, int? id = null, int? IdRol = null, String name = null, String alias = null, Boolean? active = null, Boolean? usePassword = null, Boolean? useBiometric = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@IdRol", SqlDbType.Int, IdRol, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@alias", SqlDbType.VarChar, alias, 20).Add("@active", SqlDbType.Bit, active, null).Add("@usePassword", SqlDbType.Bit, usePassword, null).Add("@useBiometric", SqlDbType.Bit, useBiometric, null);

        	return this.GetListBase<T>("SICAP", "UserUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, int? id = null, int? IdRol = null, String name = null, String alias = null, Boolean? active = null, Boolean? usePassword = null, Boolean? useBiometric = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@IdRol", SqlDbType.Int, IdRol, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@alias", SqlDbType.VarChar, alias, 20).Add("@active", SqlDbType.Bit, active, null).Add("@usePassword", SqlDbType.Bit, usePassword, null).Add("@useBiometric", SqlDbType.Bit, useBiometric, null);

        	return this.ExecuteScalar<T>("SICAP", "UserUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, int? id = null, int? IdRol = null, String name = null, String alias = null, Boolean? active = null, Boolean? usePassword = null, Boolean? useBiometric = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@IdRol", SqlDbType.Int, IdRol, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@alias", SqlDbType.VarChar, alias, 20).Add("@active", SqlDbType.Bit, active, null).Add("@usePassword", SqlDbType.Bit, usePassword, null).Add("@useBiometric", SqlDbType.Bit, useBiometric, null);

        	return this.ExecuteNonQuery("SICAP", "UserUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, int? id = null, int? IdRol = null, String name = null, String alias = null, Boolean? active = null, Boolean? usePassword = null, Boolean? useBiometric = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@IdRol", SqlDbType.Int, IdRol, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@alias", SqlDbType.VarChar, alias, 20).Add("@active", SqlDbType.Bit, active, null).Add("@usePassword", SqlDbType.Bit, usePassword, null).Add("@useBiometric", SqlDbType.Bit, useBiometric, null);

        	return this.GetReader("SICAP", "UserUpdate",parameters.ToArray());
        }

	#endregion
	}
}