// See https://aka.ms/new-console-template for more information
using EspacioEmpleados;

class Program
{

    static void Main()
    {
        Empleado Trabajador = new Empleado();

        string nombre = "Juan";
        string apellido = "Perez";
        DateTime ingreso = new DateTime(2010, 04, 8);
        DateTime nacimiento = new DateTime(2001, 08, 20);
        Trabajador.Cargo = Cargos.Ingeniero;
        char EstadoCivil = 'c';
        double SueldoBasico = 650000;

        int antigued = Trabajador.Antiguedad(ingreso);
        int edad = Trabajador.Edad(nacimiento);
        int FaltaParaJubilarse = Trabajador.Jubilacion(ingreso);
        double Salario = Trabajador.Salario(antigued, Trabajador.Cargo, EstadoCivil, SueldoBasico);





        Console.WriteLine($"Los datos son: antiguedad tiene {antigued} anios, su edad {edad} anios y le faltan para jubilarse {FaltaParaJubilarse} anios");
        Console.WriteLine($"El sueldo total es: ${Salario}");


    }
}