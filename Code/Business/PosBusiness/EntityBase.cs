using DataAccess.MSSQL;
using PosBusiness.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Utilities;

namespace PosBusiness
{
    [Serializable]
    public abstract class EntityBase : IDisposable
    {
        #region Members

        /// <summary>
        /// Miembro de acceso Microsoft SQL.
        /// </summary>
        [NonSerialized]
        private MsSQL accessMsSql;

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? updateDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? RemovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Aux { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Aux2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Aux3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsCorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Find { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SortName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// Gestiona la comunicación entre la aplicación y Microsoft SQL Server.
        /// </summary>
        public MsSQL AccessMsSql
        {
            get
            {
                if (accessMsSql == null)
                    accessMsSql = new MsSQL();

                return accessMsSql;
            }
            set
            {
                accessMsSql = value;
            }
        }

        #endregion

        #region Builder

        public EntityBase()
        {
            var nameFile = System.AppDomain.CurrentDomain.BaseDirectory + "Cookie.dll";

            var cookie = string.Empty;

            if (File.Exists(nameFile))
            {
                cookie = TxtHandler.Read(nameFile);
            }
            else
            {
                cookie = "0|0|0";
            }

            var parts = cookie.Split('|');

            this.UserId = int.Parse(parts[0]);
            this.UserName = parts[1];
            this.UserAlias = parts[2];
        }

        #endregion

        #region Methods

        protected void GetDto<T>(List<T> Lst)
        {
            var e = Lst.First();

            this.CopyProperties(e);

            this.IsCorrect = true;
        }

        protected void SetError(string ErrorMessage = "")
        {
            this.ErrorMessage = ErrorMessage;

            IsCorrect = string.IsNullOrEmpty(this.ErrorMessage);
        }

        protected void SetError(Exception Ex = null)
        {
            if (Ex != null)
                this.SetError(Ex.Message);
        }

        public void Dispose()
        {
            if (this.AccessMsSql != null)
                this.AccessMsSql.Dispose();
        }

        #endregion
    }
}