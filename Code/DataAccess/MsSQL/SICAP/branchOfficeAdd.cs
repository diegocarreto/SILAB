namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Branchofficeadd.
	/// </summary>
	public partial class Branchofficeadd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, String iternalCode = null, String name = null, String address = null, String phone = null, String manager = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@iternalCode", SqlDbType.VarChar, iternalCode, 50).Add("@name", SqlDbType.VarChar, name, 100).Add("@address", SqlDbType.VarChar, address, 500).Add("@phone", SqlDbType.VarChar, phone, 20).Add("@manager", SqlDbType.VarChar, manager, 100);

        	return this.GetListBase<T>("SICAP", "branchOfficeAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, String iternalCode = null, String name = null, String address = null, String phone = null, String manager = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@iternalCode", SqlDbType.VarChar, iternalCode, 50).Add("@name", SqlDbType.VarChar, name, 100).Add("@address", SqlDbType.VarChar, address, 500).Add("@phone", SqlDbType.VarChar, phone, 20).Add("@manager", SqlDbType.VarChar, manager, 100);

        	return this.ExecuteScalar<T>("SICAP", "branchOfficeAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, String iternalCode = null, String name = null, String address = null, String phone = null, String manager = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@iternalCode", SqlDbType.VarChar, iternalCode, 50).Add("@name", SqlDbType.VarChar, name, 100).Add("@address", SqlDbType.VarChar, address, 500).Add("@phone", SqlDbType.VarChar, phone, 20).Add("@manager", SqlDbType.VarChar, manager, 100);

        	return this.ExecuteNonQuery("SICAP", "branchOfficeAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, String iternalCode = null, String name = null, String address = null, String phone = null, String manager = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@iternalCode", SqlDbType.VarChar, iternalCode, 50).Add("@name", SqlDbType.VarChar, name, 100).Add("@address", SqlDbType.VarChar, address, 500).Add("@phone", SqlDbType.VarChar, phone, 20).Add("@manager", SqlDbType.VarChar, manager, 100);

        	return this.GetReader("SICAP", "branchOfficeAdd",parameters.ToArray());
        }

	#endregion
	}
}