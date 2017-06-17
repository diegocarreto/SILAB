namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Areaupdate.
	/// </summary>
	public partial class Areaupdate : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, int? id = null, int? idBranchOffice = null, String code = null, Boolean? active = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@idBranchOffice", SqlDbType.Int, idBranchOffice, null).Add("@code", SqlDbType.VarChar, code, 30).Add("@active", SqlDbType.Bit, active, null);

        	return this.GetListBase<T>("SICAP", "areaUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, int? id = null, int? idBranchOffice = null, String code = null, Boolean? active = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@idBranchOffice", SqlDbType.Int, idBranchOffice, null).Add("@code", SqlDbType.VarChar, code, 30).Add("@active", SqlDbType.Bit, active, null);

        	return this.ExecuteScalar<T>("SICAP", "areaUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, int? id = null, int? idBranchOffice = null, String code = null, Boolean? active = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@idBranchOffice", SqlDbType.Int, idBranchOffice, null).Add("@code", SqlDbType.VarChar, code, 30).Add("@active", SqlDbType.Bit, active, null);

        	return this.ExecuteNonQuery("SICAP", "areaUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, int? id = null, int? idBranchOffice = null, String code = null, Boolean? active = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@idBranchOffice", SqlDbType.Int, idBranchOffice, null).Add("@code", SqlDbType.VarChar, code, 30).Add("@active", SqlDbType.Bit, active, null);

        	return this.GetReader("SICAP", "areaUpdate",parameters.ToArray());
        }

	#endregion
	}
}