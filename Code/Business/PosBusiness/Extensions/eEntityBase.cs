using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PosBusiness.Extensions
{
    public static class eEntityBase
    {
        public static EntityBase CopyProperties(this EntityBase destination, object source)
        {
            PropertyInfo[] destinationProperties = destination.GetType().GetProperties();

            foreach (PropertyInfo destinationPi in destinationProperties)
            {
                PropertyInfo sourcePi = source.GetType().GetProperty(destinationPi.Name);
                destinationPi.SetValue(destination, sourcePi.GetValue(source, null), null);
            }

            return destination;
        }
    }
}
