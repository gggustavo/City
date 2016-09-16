﻿using System.Collections.Generic;
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
    }
}
