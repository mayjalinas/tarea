public class Estudiante : Persona
{
    private string carrera;
    private int año;

    public Estudiante(string nombre, string direccion, string carrera, int año)
        : base(nombre, direccion)
    {
        this.carrera = carrera;
        this.año = año;
    }

    public string ObtenerCarrera()
    {
        return carrera;
    }

    public int ObtenerAño()
    {
        return año;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nCarrera: {carrera}\nAño: {año}";
    }
}