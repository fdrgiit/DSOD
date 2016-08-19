using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public int c2f(int c)
    {
        return (int)(c * 1.8 + 32.0);
    }

    public int f2c(int f)
    {
        return (int)((f - 32) / 1.8);
    }
}
