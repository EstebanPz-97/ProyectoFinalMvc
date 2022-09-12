namespace WebApplication2.Models
{
    public class Equipo : Entity
    {
        public string Name { get; private set; }
        public string Ciudad { get; private set; }
        public string Duenio { get; private set; }
        private Equipo() : base()
        {

        }
        private Equipo (Guid id, string name, string ciudad, string duenio):base(id)
        {
            Name = name;
            Ciudad = ciudad;
            Duenio = duenio;
        }
        public static Equipo Build(Guid id, string name, string ciudad, string duenio)
        {
            return new Equipo (id, name, ciudad, duenio);
        }
    }
}
