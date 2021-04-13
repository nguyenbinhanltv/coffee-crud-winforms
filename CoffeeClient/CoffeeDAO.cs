using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CoffeeClient
{
    public class CoffeeDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<Coffee> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<Coffee> coffees = db.Coffees.ToList();
            return coffees;
        }

        public Coffee SelectByCode(int code)
        {
            Coffee coffee = db.Coffees.SingleOrDefault(b => b.Code == code);
            return coffee;
        }

        public List<Coffee> SelectByKeyword(String keyword)
        {
            List<Coffee> coffees = db.Coffees.Where(b => b.Name.Contains(keyword)).ToList();
            return coffees;
        }

        public bool Insert(Coffee newCoffee)
        {
            try
            {
                db.Coffees.InsertOnSubmit(newCoffee);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Coffee newCoffee)
        {
            Coffee dbCoffee = db.Coffees.SingleOrDefault(b => b.Code == newCoffee.Code);
            if (dbCoffee != null)
            {
                try
                {
                    dbCoffee.Name = newCoffee.Name;
                    dbCoffee.Description = newCoffee.Description;
                    dbCoffee.Price = newCoffee.Price;
                    dbCoffee.Exp = newCoffee.Exp;
                    dbCoffee.Mfg = newCoffee.Mfg;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        public bool Delete(int code)
        {
            Coffee dbCoffee = db.Coffees.SingleOrDefault(b => b.Code == code);
            if (dbCoffee != null)
            {
                try
                {
                    db.Coffees.DeleteOnSubmit(dbCoffee);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }
    }
}