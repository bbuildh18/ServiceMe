using System;

namespace BusinessLayer
{
    public class BusinessClass
    {
        public string layerTest(string a)
        {
            return new DataAccess.DataAccessClass().TestDataAccess(a);
        }
    }
}
