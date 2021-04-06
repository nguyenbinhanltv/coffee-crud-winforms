using System;
using System.Collections.Generic;

namespace CoffeeClient
{
    public class CoffeeBUS
    {
        public List<Coffee> GetAll()
        {
            List<Coffee> coffees = new CoffeeDAO().SelectAll();
            return coffees;
        }

        public Coffee GetDetails(int code)
        {
            Coffee coffee = new CoffeeDAO().SelectByCode(code);
            return coffee;
        }

        public List<Coffee> Search(String keyword)
        {
            List<Coffee> coffees = new CoffeeDAO().SelectByKeyword(keyword);
            return coffees;
        }

        public bool AddNew(Coffee newCoffee)
        {
            bool result = new CoffeeDAO().Insert(newCoffee);
            return result;
        }

        public bool Update(Coffee newCoffee)
        {
            bool result = new CoffeeDAO().Update(newCoffee);
            return result;
        }

        public bool Delete(int code)
        {
            bool result = new CoffeeDAO().Delete(code);
            return result;
        }
    }
}