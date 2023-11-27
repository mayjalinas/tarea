public class Persona
{
    private string nombre;
    private string direccion;

    public Persona(string nombre, string direccion)
    {
        this.nombre = nombre;
        this.direccion = direccion;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }

    public string ObtenerDireccion()
    {
        return direccion;
    }

    public override string ToString()
    {
        return $"Nombre: {nombre}\nDirección: {direccion}";
    }
}

