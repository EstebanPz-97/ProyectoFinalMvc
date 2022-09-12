namespace WebApplication2.Models
{
    public class Jugador : Entity
    {
        public string Name { get; private set; }
        public string Posicion { get; private set; }
        public string Numero { get; private set; }
        public Guid EquipoId { get; private set; }
        public Equipo Equipo { get; private set; }

        private Jugador() : base()
        {

        }
        private Jugador(Guid id,string name,string posicion,string numero, Guid equipoId ):base(id) 
        {
            Name = name;
            Posicion = posicion;    
            Numero = numero;
            EquipoId = equipoId;
        }
        public static Jugador Build(Guid id, string name, string posicion, string numero, Guid equipoId)
        { 
            return new Jugador(id, name, posicion, numero, equipoId);
        }


    }
}
