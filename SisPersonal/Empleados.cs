namespace EspacioEmpleados;

public enum Cargos
{
    Auxialiar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    private string nombre;
    private string apellido;
    public string Nombre
    {

        get { return nombre; }
        set{ nombre = value; }

    }
    
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public DateTime FechNacimiento { get; set;}
    public char EstadoCivil { get; set;}
    public DateTime FechaIngreso { get; set;}
    public double SueldoBasico { get; set;}

    public Cargos Cargo { get; set;}


}