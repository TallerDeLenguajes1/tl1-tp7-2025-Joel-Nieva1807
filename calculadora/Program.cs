// See https://aka.ms/new-console-template for more information
using EspacioCalculadora; //debe ir antes que todo
class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        string num=" ", opcion;
        int numero=0;

        do
        {
            Console.WriteLine("Ingrese la opcion que desee: 1)Sumar, 2)Restar, 3)Multiplicar, 4)Divir, 5)limpiar la calculaddora 0)salir del menu");
            opcion = Console.ReadLine();
            if (opcion != "0" && opcion!= "5")
            {
                Console.WriteLine("Ingrese un numero para realizarle la operacion elegida");
                num = Console.ReadLine();
                int.TryParse(num, out numero);
            }

            switch (opcion)
            {
                case "1":
                    calc.Sumar(numero);
                     Console.WriteLine("Resultado: " + calc.Resultado);
                    break;

                case "2":
                    calc.Restar(numero);
                     Console.WriteLine("Resultado: " + calc.Resultado);
                    break;

                case "3":
                    calc.Multiplicar(numero);
                     Console.WriteLine("Resultado: " + calc.Resultado);
                    break;

                case "4":
                    if (numero == 0)
                    {
                        Console.WriteLine("La division por cero no esta disponible.");

                    }
                    else
                    {
                        calc.Dividir(numero);
                        Console.WriteLine("Resultado: " + calc.Resultado);
                        
                    }
                    
                    break;

                case "5":
                    calc.Limpiar();
                    Console.WriteLine($"El resultado luego de limpiar es: {calc.Resultado}");
                    break;

                case "0":
                    Console.WriteLine("Usted esta saliendo del menu.");

                    break;


                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

        } while (opcion!="0");

        calc.Limpiar();
    }
}

