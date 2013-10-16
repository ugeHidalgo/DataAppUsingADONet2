using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAppUsingADONet
{
    class Utilities
    {
        //Retrieve the conn string.
        internal static string GetConnString()
        {
            string value = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DataAppUsingADONet.Properties.Settings.TrainITConnectionString"];
            if (settings != null)
                value = settings.ConnectionString;
            return value;
        }
    }
}
