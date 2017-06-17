namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Waterintakefindbyap.
	/// </summary>
	public partial class Waterintakefindbyap : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idWaterIntake = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null);

        	return this.GetListBase<T>("SICAP", "WaterIntakeFindByAp",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idWaterIntake = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null);

        	return this.ExecuteScalar<T>("SICAP", "WaterIntakeFindByAp",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idWaterIntake = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null);

        	return this.ExecuteNonQuery("SICAP", "WaterIntakeFindByAp",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idWaterIntake = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null);

        	return this.GetReader("SICAP", "WaterIntakeFindByAp",parameters.ToArray());
        }

	#endregion
	}
}