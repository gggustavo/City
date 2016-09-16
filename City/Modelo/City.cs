namespace Modelo
{
    public class City
    {
        public int IdCity { get; set; }
        public string Name { get; set; }

        public int IdState { get; set; }
        public State State { get; set; }
    }
}
