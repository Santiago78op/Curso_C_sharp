namespace Person
{
    public class Persona
    {
        private int _edad;
        private int _id;
        private double _peso;
        private string _nombre;

        public Persona(int edad, int id, double peso, string nombre)
        {
            this._edad = edad;
            this._id = id;
            this._peso = peso;
            this._nombre = nombre;
        }

        public void Deconstruct(out int edad, out int id, out double peso, out string nombre)
        {
            edad = this._edad;
            id = this._id;
            peso = this._peso;
            nombre = this._nombre;
        }

        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public double Peso
        {
            get => _peso;
            set => _peso = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Peso: {Peso}, Id: {Id}";
        }
    }
}