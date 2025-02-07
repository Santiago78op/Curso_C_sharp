namespace UnsafeLinkedList.Models;

public class Estudiante
{
    private int _id;
    private String _nombre;
    private String _apellido;
    private String _correo;
    private String _contrasenia;

    /**
     * Constructor de la persona
     * @param id Identificador de la persona
     * @param nombre Nombre de la persona
     * @param apellido Apellido de la persona
     * @param correo Correo de la persona
     * @param contrasenia Contrasenia de la persona
     */
    public Estudiante(int id, string nombre, string apellido, string correo, string contrasenia)
    {
        _id = id;
        _nombre = nombre;
        _apellido = apellido;
        _correo = correo;
        _contrasenia = contrasenia;
    }

    /**
     * Getter y setter del identificador de la persona
     */
    public int Id
    {
        get => _id;
        set => _id = value;
    }

    /**
     * Getter y setter de los atributos de la persona
     */
    public string Nombre
    {
        get => _nombre;
        set => _nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    /**
     * Getter y setter de los atributos de la persona
     */
    public string Apellido
    {
        get => _apellido;
        set => _apellido = value ?? throw new ArgumentNullException(nameof(value));
    }

    /**
     * Getter y setter de los atributos de la persona
     */
    public string Correo
    {
        get => _correo;
        set => _correo = value ?? throw new ArgumentNullException(nameof(value));
    }

    /**
     * Getter y setter de los atributos de la persona
     */
    public string Contrasenia
    {
        get => _contrasenia;
        set => _contrasenia = value ?? throw new ArgumentNullException(nameof(value));
    }

    /**
     * Metodo para imprimir la informacion de la persona
     * @return Informacion de la persona
     */
    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Correo: {Correo}, Contrasenia: {Contrasenia}";
    }
}