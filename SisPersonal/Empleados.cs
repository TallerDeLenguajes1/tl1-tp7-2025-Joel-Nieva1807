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
        set { nombre = value; }

    }

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public DateTime FechNacimiento { get; set; }
    public char EstadoCivil { get; set; }
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }

    public Cargos Cargo { get; set; }

    public int Antiguedad()
    {
        DateTime Hoy = DateTime.Now; // tomo la fecha de hoy

        int antigued = Hoy.Year - FechaIngreso.Year;

        return antigued;


    }

    public int Edad()
    {
        int Anios = DateTime.Now.Year - FechNacimiento.Year;
        return Anios;

    }

    public int Jubilacion()
    {
        int jubi = 65 - Antiguedad();
        

        if (jubi <= 0) //por si ya se jubilo
        {
            jubi = 0;
        }
        return jubi;
    }

    public double Salario()
    {
        double adicional=0;

        if (Antiguedad() > 20)
        {
            adicional = adicional + (SueldoBasico * 0.25);

        }
        else
        {
            adicional = adicional + (SueldoBasico * (Antiguedad() / 100.0));
            double i = adicional;
             double ii = Antiguedad();
        }

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional = adicional * 1.50;
        }
        
        if (EstadoCivil == 'c')
        {
            adicional += 150000;
        }
        return SueldoBasico+adicional;
    }
}