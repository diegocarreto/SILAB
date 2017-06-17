using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PosBusiness.Extensions;

namespace PosBusiness
{
    [Serializable]
    public class Tag
    {
        #region Properties

        public string Entity { get; set; }

        public string InfoType { get; set; }

        #endregion
    }
}