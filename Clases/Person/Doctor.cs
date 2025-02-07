namespace Person
{
    public class Doctor : Persona
    {
        private string _especialidad;
        private int _numColegiado;

        public Doctor(int edad, int id, double peso, string nombre, string especialidad, int numColegiado) : base(edad, id, peso, nombre)
        {
            _especialidad = especialidad;
            _numColegiado = numColegiado;
        }

        public string Especialidad
        {
            get => _especialidad;
            set => _especialidad = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int NumColegiado
        {
            get => _numColegiado;
            set => _numColegiado = value;
        }

        public string getDatos()
        {
            return ToString();
        }
    }
}