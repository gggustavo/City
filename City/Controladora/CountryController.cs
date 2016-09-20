using System;
using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace Controladora
{
    public class CountryController
    {
        public void Add(Country entity)
        {
            var context = SingletonContext.GetContext();
            context.Countries.Add(entity);
            context.SaveChanges();
        }

        public IList<Country> GetAll()
        {
            var context = SingletonContext.GetContext();
            return context.Countries.ToList();
        }

        public void Remove(int idCountry)
        {
            var context = SingletonContext.GetContext();
            var countryRemove = context.Countries.Find(idCountry);
            context.Countries.Remove(countryRemove);
            context.SaveChanges();
        }
    }
}
