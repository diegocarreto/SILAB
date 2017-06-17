using DataAccess.MSSQL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Config : EntityBase
    {
        #region Members

        private const string WATERINTAKEHABITANTS = "tomasHabitantes";

        private const string ADD_NAMES = "agregarNombres";

        private const string COSTH = "altaHabitante";

        private const string COST = "alta";

        private const string COSTNEG = "altaNegocio";

        private const string MENSUALIDAD = "mensualidad";

        private const string MENSUALIDADNEGOCIO = "mensualidadNegocio";

        private const string PRINTER = "printer";

        private const string TESORERO = "tesorero";

        private const string PRESIDENTE = "presidente";

        private const string KEY = "key";

        private const string PUBLIC_KEY = "publicKey";

        #endregion

        #region Properties

        public string Key { get; set; }

        public string Value { get; set; }

        public byte[] Image { get; set; }

        #endregion

        #region Builder

        public Config()
        {
        }

        #endregion

        #region Methods


        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool AltaAddNames(bool? Value = null)
        {
            if (!Value.HasValue)
            {
                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(ADD_NAMES);

                return bool.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(ADD_NAMES, Value.ToString());

                return true;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public decimal AltaH(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(COSTH);

                return decimal.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(COSTH, Value);

                return 0;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public int WaterIntakeHabitants(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {
                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(WATERINTAKEHABITANTS);

                return int.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(WATERINTAKEHABITANTS, Value);

                return 0;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public decimal Alta(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(COST);

                return decimal.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(COST, Value);

                return 0;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public decimal AltaNegocio(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(COSTNEG);

                return decimal.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(COSTNEG, Value);

                return 0;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public string KeyDate()
        {
            var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(KEY);

            return value;
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public string PublicKey()
        {
            var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(PUBLIC_KEY);

            return value;
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public decimal Mensualidad(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(MENSUALIDAD);

                return decimal.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(MENSUALIDAD, Value);

                return 0;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public decimal MensualidadNegocio(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(MENSUALIDADNEGOCIO);

                return decimal.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(MENSUALIDADNEGOCIO, Value);

                return 0;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public string Printer(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(PRINTER);

                return value;
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(PRINTER, Value);

                return string.Empty;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public string Tesorero(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(TESORERO);

                return value;
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(TESORERO, Value);

                return string.Empty;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public string Presidente(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(PRESIDENTE);

                return value;
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(PRESIDENTE, Value);

                return string.Empty;
            }
        }

        public bool BackUp(string Path)
        {
            try
            {
                this.AccessMsSql.Sicap.Backupdb.ExeNonQuery(Path);

                return true;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;

                return false;
            }
        }

        public bool Restore(string Path, bool Restore = false)
        {
            try
            {
                var msSql = new AccessMsSQL();

                var errorMessage = string.Empty;

                var result = msSql.RestoreDataBase(Path, out errorMessage, Restore);

                this.ErrorMessage = errorMessage;

                return result;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;

                return false;
            }
        }

        public bool ExistDataBase(string Name)
        {
            try
            {
                var msSql = new AccessMsSQL();

                return msSql.CheckDataBase(Name);
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;

                return false;
            }
        }

        public bool CheckConnection(out string ErrorMessage, out int ErrorNumber, string Server = "", string User = "", string Password = "", int? Port = null, string DataBase = "")
        {
            try
            {
                var msSql = new AccessMsSQL();

                return msSql.CheckConnection(out ErrorMessage, out ErrorNumber, Server, User, Password, Port, DataBase);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                ErrorNumber = 0;

                return false;
            }
        }

        public void GetConnectionParameters(out string Server, out int Port, out string DataBase, out string User, out string Password)
        {
            var msSql = new AccessMsSQL();

            msSql.GetConnectionParameters(out  Server, out  Port, out  DataBase, out  User, out  Password);
        }

        public bool Save(string Server, int Port, string DataBase, string User, string Password)
        {
            var msSql = new AccessMsSQL();

            return msSql.Save(Server, Port, DataBase, User, Password);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Image"></param>
        /// <returns></returns>
        public bool SaveImage(string EntityName, int EntityId, byte[] Image)
        {
            this.AccessMsSql.Sicap.Addimage.ExeNonQuery(EntityId, EntityName, Image);

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Image"></param>
        /// <returns></returns>
        public byte[] GetImage(string EntityName, int EntityId)
        {
            var list = this.AccessMsSql.Sicap.Getimage.ExeList<Config>(EntityId, EntityName);

            if (list.Count > 0)
                return list.First().Image;
            else
                return null;
        }

        #endregion
    }
}
