namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Getbuttonsrol.
	/// </summary>
	public partial class Getbuttonsrol : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, String formName = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@formName", SqlDbType.VarChar, formName, 50);

        	return this.GetListBase<T>("SICAP", "GetButtonsRol",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, String formName = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@formName", SqlDbType.VarChar, formName, 50);

        	return this.ExecuteScalar<T>("SICAP", "GetButtonsRol",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, String formName = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@formName", SqlDbType.VarChar, formName, 50);

        	return this.ExecuteNonQuery("SICAP", "GetButtonsRol",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, String formName = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@formName", SqlDbType.VarChar, formName, 50);

        	return this.GetReader("SICAP", "GetButtonsRol",parameters.ToArray());
        }

	#endregion
	}
}