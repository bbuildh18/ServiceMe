using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface ISampleBusiness
    {
        string TestBusinessMethod(string test, BuildHomeDBContext buildHomeDBContext);
    }
}
