using System.Collections.Generic;

namespace Modelo
{
    public class Country
    {
        public int IdCountry { get; set; }
        public string Name { get; set; }

        public ICollection<State> States { get; set; }
    }
}
