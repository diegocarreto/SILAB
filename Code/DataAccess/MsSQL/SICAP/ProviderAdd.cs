namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Provideradd.
	/// </summary>
	public partial class Provideradd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, String name = null, String contact1 = null, String position1 = null, String contact2 = null, String position2 = null, String street = null, String colony = null, String municipality = null, String city = null, String code = null, String phone1 = null, String phone2 = null, String email1 = null, String email2 = null, String rubric = null, String paymentTerms = null, String paymentConditions = null, Boolean? active = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@contact1", SqlDbType.VarChar, contact1, 100).Add("@position1", SqlDbType.VarChar, position1, 100).Add("@contact2", SqlDbType.VarChar, contact2, 100).Add("@position2", SqlDbType.VarChar, position2, 100).Add("@street", SqlDbType.VarChar, street, 200).Add("@colony", SqlDbType.VarChar, colony, 200).Add("@municipality", SqlDbType.VarChar, municipality, 200).Add("@city", SqlDbType.VarChar, city, 200).Add("@code", SqlDbType.VarChar, code, 7).Add("@phone1", SqlDbType.VarChar, phone1, 20).Add("@phone2", SqlDbType.VarChar, phone2, 20).Add("@email1", SqlDbType.VarChar, email1, 100).Add("@email2", SqlDbType.VarChar, email2, 100).Add("@rubric", SqlDbType.VarChar, rubric, 500).Add("@paymentTerms", SqlDbType.VarChar, paymentTerms, 1000).Add("@paymentConditions", SqlDbType.VarChar, paymentConditions, 1000).Add("@active", SqlDbType.Bit, active, null);

        	return this.GetListBase<T>("SICAP", "ProviderAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, String name = null, String contact1 = null, String position1 = null, String contact2 = null, String position2 = null, String street = null, String colony = null, String municipality = null, String city = null, String code = null, String phone1 = null, String phone2 = null, String email1 = null, String email2 = null, String rubric = null, String paymentTerms = null, String paymentConditions = null, Boolean? active = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@contact1", SqlDbType.VarChar, contact1, 100).Add("@position1", SqlDbType.VarChar, position1, 100).Add("@contact2", SqlDbType.VarChar, contact2, 100).Add("@position2", SqlDbType.VarChar, position2, 100).Add("@street", SqlDbType.VarChar, street, 200).Add("@colony", SqlDbType.VarChar, colony, 200).Add("@municipality", SqlDbType.VarChar, municipality, 200).Add("@city", SqlDbType.VarChar, city, 200).Add("@code", SqlDbType.VarChar, code, 7).Add("@phone1", SqlDbType.VarChar, phone1, 20).Add("@phone2", SqlDbType.VarChar, phone2, 20).Add("@email1", SqlDbType.VarChar, email1, 100).Add("@email2", SqlDbType.VarChar, email2, 100).Add("@rubric", SqlDbType.VarChar, rubric, 500).Add("@paymentTerms", SqlDbType.VarChar, paymentTerms, 1000).Add("@paymentConditions", SqlDbType.VarChar, paymentConditions, 1000).Add("@active", SqlDbType.Bit, active, null);

        	return this.ExecuteScalar<T>("SICAP", "ProviderAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, String name = null, String contact1 = null, String position1 = null, String contact2 = null, String position2 = null, String street = null, String colony = null, String municipality = null, String city = null, String code = null, String phone1 = null, String phone2 = null, String email1 = null, String email2 = null, String rubric = null, String paymentTerms = null, String paymentConditions = null, Boolean? active = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@contact1", SqlDbType.VarChar, contact1, 100).Add("@position1", SqlDbType.VarChar, position1, 100).Add("@contact2", SqlDbType.VarChar, contact2, 100).Add("@position2", SqlDbType.VarChar, position2, 100).Add("@street", SqlDbType.VarChar, street, 200).Add("@colony", SqlDbType.VarChar, colony, 200).Add("@municipality", SqlDbType.VarChar, municipality, 200).Add("@city", SqlDbType.VarChar, city, 200).Add("@code", SqlDbType.VarChar, code, 7).Add("@phone1", SqlDbType.VarChar, phone1, 20).Add("@phone2", SqlDbType.VarChar, phone2, 20).Add("@email1", SqlDbType.VarChar, email1, 100).Add("@email2", SqlDbType.VarChar, email2, 100).Add("@rubric", SqlDbType.VarChar, rubric, 500).Add("@paymentTerms", SqlDbType.VarChar, paymentTerms, 1000).Add("@paymentConditions", SqlDbType.VarChar, paymentConditions, 1000).Add("@active", SqlDbType.Bit, active, null);

        	return this.ExecuteNonQuery("SICAP", "ProviderAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, String name = null, String contact1 = null, String position1 = null, String contact2 = null, String position2 = null, String street = null, String colony = null, String municipality = null, String city = null, String code = null, String phone1 = null, String phone2 = null, String email1 = null, String email2 = null, String rubric = null, String paymentTerms = null, String paymentConditions = null, Boolean? active = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@contact1", SqlDbType.VarChar, contact1, 100).Add("@position1", SqlDbType.VarChar, position1, 100).Add("@contact2", SqlDbType.VarChar, contact2, 100).Add("@position2", SqlDbType.VarChar, position2, 100).Add("@street", SqlDbType.VarChar, street, 200).Add("@colony", SqlDbType.VarChar, colony, 200).Add("@municipality", SqlDbType.VarChar, municipality, 200).Add("@city", SqlDbType.VarChar, city, 200).Add("@code", SqlDbType.VarChar, code, 7).Add("@phone1", SqlDbType.VarChar, phone1, 20).Add("@phone2", SqlDbType.VarChar, phone2, 20).Add("@email1", SqlDbType.VarChar, email1, 100).Add("@email2", SqlDbType.VarChar, email2, 100).Add("@rubric", SqlDbType.VarChar, rubric, 500).Add("@paymentTerms", SqlDbType.VarChar, paymentTerms, 1000).Add("@paymentConditions", SqlDbType.VarChar, paymentConditions, 1000).Add("@active", SqlDbType.Bit, active, null);

        	return this.GetReader("SICAP", "ProviderAdd",parameters.ToArray());
        }

	#endregion
	}
}