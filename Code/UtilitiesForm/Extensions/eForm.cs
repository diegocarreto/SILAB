using MetroFramework.Controls;
using PosBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace UtilitiesForm.Extensions
{
    public static class eForm
    {
        public static Form Alert(this Form Frm, string Message, TypeError Type = TypeError.Exclamation)
        {
            if (Type.Equals(TypeError.Exclamation))
                MessageBox.Show(Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return Frm;
        }

        public static bool Confirm(this Form Frm, string Message)
        {
            return MessageBox.Show(Message, "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation).Equals(System.Windows.Forms.DialogResult.Yes);
        }

        public static string GetPath(this Form Frm)
        {
            return System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        }

        /// <summary>
        /// Libera los recursos de los objetos indicados.
        /// </summary>
        /// <param name="Objs">Arreglo de objetos.</param>
        public static void ReleasingObjects(this Form Frm, params Object[] Objs)
        {
            for (int i = 0; i < Objs.Length; i++)
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(Objs[i]);
                }
                catch
                {
                    Objs[i] = null;
                }
                finally
                {
                    GC.Collect();
                }
            }

            Objs = null;
            GC.Collect();
        }

        public enum TypeError
        {
            Exclamation,
            Error
        }

        public static void SetControlValue(this MetroFramework.Forms.MetroForm frm, object Obj)
        {
            var list = GetAllControlsInForm(frm);

            foreach (var ctr in list)
            {
                var json = ctr.Tag != null ? ctr.Tag.ToString() : string.Empty;
                var jss = new JavaScriptSerializer();
                var tag = jss.Deserialize<Tag>(json);
                var propertyName = tag.Entity;

                if (!string.IsNullOrEmpty(propertyName))
                {
                    var prop = Obj.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty
                        | BindingFlags.IgnoreCase);

                    if (prop != null)
                    {
                        var obj = prop.GetValue(Obj, null);

                        if (obj != null)
                        {
                            if (ctr is MetroTextBox)
                            {
                                (ctr as MetroTextBox).Text = obj.ToString();
                            }
                            else if (ctr is CheckBox)
                            {
                                var str = obj.ToString();
                                var value = false;

                                if (bool.TryParse(str, out value))
                                {
                                    (ctr as CheckBox).Checked = value;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void LoadEntity(this MetroFramework.Forms.MetroForm frm, object Obj)
        {
            var entity = Obj;

            // where T : new()
            //if (entity == null)
            //{
            //    entity = new T();
            //}

            var list = GetAllControlsInForm(frm);

            foreach (var ctr in list)
            {
                var json = ctr.Tag != null ? ctr.Tag.ToString() : string.Empty;

                if (!string.IsNullOrEmpty(json))
                {
                    var jss = new JavaScriptSerializer();
                    var tag = jss.Deserialize<Tag>(json);
                    var propertyName = tag.Entity;

                    if (!string.IsNullOrEmpty(propertyName))
                    {
                        if (ctr is MetroTextBox)
                        {
                            var value = (ctr as MetroTextBox).Text;

                            SetValue(entity, propertyName, value);
                        }
                        else if (ctr is CheckBox)
                        {
                            var value = (ctr as CheckBox).Checked;

                            SetValue(entity, propertyName, value);
                        }
                    }
                }

            }

            //return (T)entity;
        }

        private static void SetValue(Object Entity, string PropertyName, object Value)
        {
            var type = Entity.GetType();
            var prop = type.GetProperty(PropertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty | BindingFlags.IgnoreCase);

            if (prop != null)
            {
                var t = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                var safeValue = (Value == null) ? null : Convert.ChangeType(Value, t);

                prop.SetValue(Entity, safeValue, null);
            }
        }

        private static IEnumerable<Control> GetAllControlsInForm(Control container)
        {
            var controlList = new List<Control>();

            foreach (Control c in container.Controls)
            {
                controlList.AddRange(GetAllControlsInForm(c));

                if (c is MetroTextBox || c is CheckBox)
                {
                    controlList.Add(c);
                }
            }

            return controlList;
        }
    }
}