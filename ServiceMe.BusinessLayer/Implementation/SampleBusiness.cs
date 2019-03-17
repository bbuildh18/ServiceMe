using BusinessLayer.Interfaces;
using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
//

namespace BusinessLayer.Implementation
{
    public class SampleBusiness : ISampleBusiness
    {
        public string TestBusinessMethod(string test,BuildHomeDBContext buildHomeDBContext)
        {
            (new DataAccessClass()).DbRead(buildHomeDBContext);
            return "This is from business.";
        }
    }
}
