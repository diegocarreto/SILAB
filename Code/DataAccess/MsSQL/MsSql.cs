using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.MsSqlCommands;

namespace DataAccess.MSSQL
{
	public class MsSQL : IDisposable
	{
		#region Properties

		/// <summary>
		/// Controla la ejecucion de los procedimientos almacenados de la conexion Sicap.
		/// </summary>
		public DataAccess.MSSQL.Sicap.Sicap Sicap = new DataAccess.MSSQL.Sicap.Sicap();


		#endregion

		#region Methods

		public void Dispose()
		{
			if (this.Sicap != null)
				this.Sicap.Dispose();


		}

		#endregion
	}
}