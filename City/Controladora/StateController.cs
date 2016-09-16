using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace Controladora
{
    public class StateController
    {
        public void Add(State entity)
        {
            var context = SingletonContext.GetContext();
            context.States.Add(entity);
            context.SaveChanges();
        }

        public IList<State> GetAll()
        {
            var context = SingletonContext.GetContext();
            return context.States.ToList();
        }
    }
}
