using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class User : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Alias { get; set; }

        public string Modal { get; set; }

        public string Image { get; set; }

        public string FormName { get; set; }

        public string RolName { get; set; }

        public string Password { get; set; }

        public bool? Menu_Opciones { get; set; }

        public bool? Menu_Habitantes { get; set; }

        public bool? Menu_Pagos { get; set; }

        public bool? Menu_IngresosEgresos { get; set; }

        public bool? Menu_Concentrado { get; set; }

        public bool? Menu_Cooperaciones { get; set; }

        public bool? Menu_PagosCooperaciones { get; set; }

        public bool? Menu_Calles { get; set; }

        public bool? New { get; set; }

        public bool? Update { get; set; }

        public bool? Erase { get; set; }

        public int? IdRol { get; set; }

        public bool? menu_Usuarios { get; set; }

        public bool? menu_Contrasena { get; set; }

        public bool? menu_UsuariosEdit { get; set; }

        public bool? menu_Conexion { get; set; }

        public bool? menu_Reporte_Pagos { get; set; }

        public bool? menu_Reporte_Binnacle { get; set; }

        public bool? IsButton { get; set; }

        public bool? UsePassword { get; set; }

        public bool? UseBiometric { get; set; }

        #endregion

        #region Builder

        public User()
        {
        }

        #endregion

        #region Methods

        public List<Finger> GetFingers()
        {
            return this.AccessMsSql.Sicap.Usergetfingers.ExeList<Finger>(this.Id);
        
        }

        public bool Get()
        {
            try
            {
                var e = this.List(1).First();

                this.Name = e.Name;
                this.Alias = e.Alias;
                this.IdRol = e.IdRol;
                this.Password = e.Password;
                this.Id = e.Id;
                this.Active = e.Active;
                this.UseBiometric = e.UseBiometric;
                this.UsePassword = e.UsePassword;

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        public void Rol()
        {
            var e = this.AccessMsSql.Sicap.Rolget.ExeList<User>(this.UserId).First();

            this.Menu_Habitantes = e.Menu_Habitantes;
            this.Menu_Opciones = e.Menu_Opciones;
            this.Menu_Pagos = e.Menu_Pagos;
            this.Menu_IngresosEgresos = e.Menu_IngresosEgresos;
            this.Menu_Concentrado = e.Menu_Concentrado;
            this.Menu_Cooperaciones = e.Menu_Cooperaciones;
            this.Menu_PagosCooperaciones = e.Menu_PagosCooperaciones;
            this.Update = e.Update;
            this.New = e.New;
            this.Erase = e.Erase;
            this.Menu_Calles = e.Menu_Calles;
            this.menu_Usuarios = e.menu_Usuarios;
            this.menu_Contrasena = e.menu_Contrasena;
            this.menu_UsuariosEdit = e.menu_UsuariosEdit;
            this.menu_Conexion = e.menu_Conexion;
            this.menu_Reporte_Pagos = e.menu_Reporte_Pagos;
            this.menu_Reporte_Binnacle = e.menu_Reporte_Binnacle;
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Login()
        {
            try
            {
                var lst = this.AccessMsSql.Sicap.Userlogin.ExeList<User>(this.Alias, this.Password);

                if (lst.Count > 0)
                {
                    var usr = lst.First();

                    if (usr != null)
                    {
                        this.UserId = usr.Id;
                        this.UserName = usr.Name;

                        return (usr.Alias.Equals(this.Alias) && usr.Password.Equals(this.Password));
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        public bool ChangePassword(int Id, string Password)
        {
            try
            {
                this.AccessMsSql.Sicap.Changepassword.ExeNonQuery(Id, Password);

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
        public List<User> List(int Type = 2)
        {
            return this.AccessMsSql.Sicap.Userlist.ExeList<User>(Type, this.Id, this.Find, this.Page, this.Rows, this.SortName, this.Order, this.UserId);
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<User> RolList(int Type = 2)
        {
            return this.AccessMsSql.Sicap.Rollist.ExeList<User>();
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool UpdateRoleMenuDelete(int IdRole)
        {
            try
            {
                this.AccessMsSql.Sicap.Updaterolemenudelete.ExeNonQuery(IdRole);

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
        public bool UpdateRoleMenu(int IdRole, int IdMenu)
        {
            try
            {
                this.AccessMsSql.Sicap.Updaterolemenu.ExeNonQuery(IdRole, IdMenu);

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
        public List<User> GetButtonsRol(string FormName)
        {
            return this.AccessMsSql.Sicap.Getbuttonsrol.ExeList<User>(this.UserId, FormName);
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<User> MenuList(int IdRole)
        {
            return this.AccessMsSql.Sicap.Menulist.ExeList<User>(IdRole);
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<User> MenuPrincipalList()
        {
            return this.AccessMsSql.Sicap.Menuprincipallist.ExeList<User>();
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<User> MenuSecondaryList(int Id, int IdRole)
        {
            return this.AccessMsSql.Sicap.Menusecondaryllist.ExeList<User>(IdRole, Id);
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<User> MenuSecondaryByUserList(int IdParent)
        {
            return this.AccessMsSql.Sicap.Menusecondarybyuserlist.ExeList<User>(this.UserId, IdParent);
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Delete()
        {
            try
            {
                this.AccessMsSql.Sicap.Userdelete.ExeNonQuery(this.UserId, this.Id);

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
        public bool DeleteRole()
        {
            try
            {
                this.AccessMsSql.Sicap.Roledelete.ExeNonQuery(this.UserId, this.IdRol);

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
                    this.Id = this.AccessMsSql.Sicap.Useradd.ExeScalar<int>(this.UserId, this.IdRol, this.Name, this.Alias, this.Password, this.Active, this.UsePassword, this.UseBiometric);
                }
                else
                {
                    this.AccessMsSql.Sicap.Userupdate.ExeNonQuery(this.UserId, this.Id, this.IdRol, this.Name, this.Alias, this.Active, this.UsePassword, this.UseBiometric);
                }

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
        public bool SaveRole()
        {
            try
            {
                if (!this.Id.HasValue)
                {
                    this.Id = this.AccessMsSql.Sicap.Roleadd.ExeScalar<int>(this.UserId, this.Name);
                }
                else
                {
                    this.AccessMsSql.Sicap.Roleupdate.ExeNonQuery(this.UserId, this.Id, this.Name);
                }

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }


        }

        public bool CheckRestoreUser()
        {
            return this.AccessMsSql.Sicap.Checkrrestoreuser.ExeScalar<bool>(this.UserId);
        }

        public bool RestoreUser()
        {
            try
            {
                this.AccessMsSql.Sicap.Userrestore.ExeNonQuery(this.Id);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
