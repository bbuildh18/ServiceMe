using DataAccess.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DataAccessClass
    {
        public string TestDataAccess(string name)
        {
            return name+" via data access layer";
        }

        public string DbRead(BuildHomeDBContext c)
        {
            c.Add(new Item() { ItemName = "Pragiya"});
            c.SaveChanges();
            return "this is from database";
        }
    }
}
