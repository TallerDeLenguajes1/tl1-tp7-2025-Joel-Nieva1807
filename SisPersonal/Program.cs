// See https://aka.ms/new-console-template for more information
using EspacioEmpleados;

class Program
{

    static void Main()
    {
        Empleado[] Trabajador = new Empleado[3];
        double montoTtotalSalario = 0;
        int indice = 0, anios = 65;

        Trabajador[0] = new Empleado()
        {
            Nombre = "Juan",
            Apellido = "Perez",
            FechaIngreso = new DateTime(2010, 04, 8),
            FechNacimiento = new DateTime(2001, 08, 20),
            Cargo = Cargos.Ingeniero,
            EstadoCivil = 'c',
            SueldoBasico = 650000,



        };

        Trabajador[1] = new Empleado()
        {
            Nombre = "Maria",
            Apellido = "Lopez",
            FechaIngreso = new DateTime(2001, 9, 2),
            FechNacimiento = new DateTime(1986, 12, 3),
            Cargo = Cargos.Ingeniero,
            EstadoCivil = 's',
            SueldoBasico = 790000,


        };

        Trabajador[2] = new Empleado()
        {
            Nombre = "Luciano",
            Apellido = "Gomez",
            FechaIngreso = new DateTime(2019, 3, 7),
            FechNacimiento = new DateTime(1995, 11, 19),
            Cargo = Cargos.Ingeniero,
            EstadoCivil = 'c',
            SueldoBasico = 340000,

        };

        foreach (var emple in Trabajador)
        {
            int antiguedad = emple.Antiguedad();
            int edad = emple.Edad();
            int FaltaParaJubilarse = emple.Jubilacion();
            double Salario = emple.Salario();
            montoTtotalSalario += Salario;

            Console.WriteLine($"\nEmpleado: {emple.Nombre} {emple.Apellido}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Antigüedad: {antiguedad} años");
            Console.WriteLine($"Años para jubilarse: {FaltaParaJubilarse}");
            Console.WriteLine($"Salario total: ${Salario:N2}");

        }

        for (int i = 0; i < 3; i++)
        {
            
            if (Trabajador[i].Jubilacion() < anios)
            {
                indice = i;
                anios = Trabajador[i].Jubilacion();
            }
        }
        Console.WriteLine("-----------------------");
        Console.WriteLine("Datos del empleado mas proximo a jubilarse:");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Nombre: {Trabajador[indice].Nombre}");
        Console.WriteLine($"Apellido: {Trabajador[indice].Apellido}");
        Console.WriteLine($"Fecha de nacimiento: {Trabajador[indice].FechNacimiento}");
        Console.WriteLine($"Fecha de ingreso: {Trabajador[indice].FechaIngreso}");
        Console.WriteLine($"Cargo: {Trabajador[indice].Cargo}");
        Console.WriteLine($"Edad: {Trabajador[indice].Edad()} anios");
        Console.WriteLine($"Estado civil: {Trabajador[indice].EstadoCivil}");
        Console.WriteLine($"Antiguedad: {Trabajador[indice].Antiguedad()} anios");
        Console.WriteLine($"Falta para jubilarse: {Trabajador[indice].Jubilacion()} anios");
        Console.WriteLine($"Salario total : ${Trabajador[indice].Salario()}");


    }
}