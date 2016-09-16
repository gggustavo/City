using System.Collections.Generic;

namespace Modelo
{
    public class State
    {
        public int IdState { get; set; }
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
