using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IFaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace UI
{
    public static class BLLGetter
    {
        public static IBLL GetBLL()
        {
            return new UnityContainer().LoadConfiguration().Resolve<IBLL>();
        }

    }
}