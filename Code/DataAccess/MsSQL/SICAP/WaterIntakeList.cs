namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Waterintakelist.
	/// </summary>
	public partial class Waterintakelist : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idHabitant = null, int? type = null, int? id = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null);

        	return this.GetListBase<T>("SICAP", "WaterIntakeList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idHabitant = null, int? type = null, int? id = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null);

        	return this.ExecuteScalar<T>("SICAP", "WaterIntakeList",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idHabitant = null, int? type = null, int? id = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null);

        	return this.ExecuteNonQuery("SICAP", "WaterIntakeList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idHabitant = null, int? type = null, int? id = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null);

        	return this.GetReader("SICAP", "WaterIntakeList",parameters.ToArray());
        }

	#endregion
	}
}