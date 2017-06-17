namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Reportpaymentyear1.
	/// </summary>
	public partial class Reportpaymentyear1 : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>() where T : new()
        {
        	return this.GetListBase<T>("SICAP", "ReportPaymentYear1");
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>()
        {
        	return this.ExecuteScalar<T>("SICAP", "ReportPaymentYear1");
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery()
        {
        	return this.ExecuteNonQuery("SICAP", "ReportPaymentYear1");
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader()
        {
        	return this.GetReader("SICAP", "ReportPaymentYear1");
        }

	#endregion
	}
}