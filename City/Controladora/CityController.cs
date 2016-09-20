using System;
using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace Controladora
{
    public class CityController
    {
        public void Add(City entity)
        {
            var context = SingletonContext.GetContext();
            context.Cities.Add(entity);
            context.SaveChanges();
        }

        public IList<City> GetAll()
        {
            var context = SingletonContext.GetContext();
            return context.Cities.ToList();
        }

        public IList<City> GetAllByName(string name)
        {
            var context = SingletonContext.GetContext();
            return context.Cities.Where(_ => _.Name.Contains(name)).ToList();
        }

        public void Remove(int idCity)
        {
            var context = SingletonContext.GetContext();
            var cityRemove = context.Cities.Find(idCity);
            context.Cities.Remove(cityRemove);
            context.SaveChanges();
        }
    }
}
