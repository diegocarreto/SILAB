using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Catalogs : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Name { get; set; }

        public string Type { get; set; }

        #endregion

        #region Builder

        public Catalogs()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Get()
        {
            try
            {
                var e = this.List("Calle").First();

                this.Name = e.Name;

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<Catalogs> List(string Type, int TypeQuery = 1)
        {
            return this.AccessMsSql.Sicap.Cataloglist.ExeList<Catalogs>(TypeQuery, Type, this.Id, this.Find, this.Page, this.Rows, this.SortName, this.Order);
        }


        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Delete()
        {
            try
            {
                this.AccessMsSql.Sicap.Catalogdelete.ExeNonQuery(this.UserId, this.Id);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Save()
        {
            try
            {
                if (!this.Id.HasValue)
                {
                    this.Id = this.AccessMsSql.Sicap.Catalogadd.ExeScalar<int>(this.UserId, this.Name, this.Type);
                }
                else
                {
                    this.AccessMsSql.Sicap.Catalogupdate.ExeNonQuery(this.UserId, this.Id, this.Name);
                }

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        #endregion
    }
}
