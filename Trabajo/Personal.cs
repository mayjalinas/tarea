public class Personal : Persona
{
    private string universidad;
    private double salario;

    public Personal(string nombre, string direccion, string universidad, double salario)
        : base(nombre, direccion)
    {
        this.universidad = universidad;
        this.salario = salario;
    }

    public string ObtenerUniversidad()
    {
        return universidad;
    }

    public double ObtenerSalario()
    {
        return salario;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nUniversidad: {universidad}\nSalario: {salario}";
    }
}