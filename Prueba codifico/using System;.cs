using System;

namespace CalculoAreas
{
    abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
    }

    class Circulo : FiguraGeometrica
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }

    class Rectangulo : FiguraGeometrica
    {
        private double baseRectangulo;
        private double altura;

        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return baseRectangulo * altura;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("Seleccione una figura:");
                Console.WriteLine("1 - Círculo");
                Console.WriteLine("2 - Rectángulo");
                Console.WriteLine("0 - Salir");

                string opcionFigura = Console.ReadLine();

                switch (opcionFigura)
                {
                    case "1":
                        Console.Write("Introduzca el radio del círculo: ");
                        double radio = double.Parse(Console.ReadLine());
                        Circulo circulo = new Circulo(radio);
                        Console.WriteLine("El área del círculo es: " + circulo.CalcularArea());
                        break;

                    case "2":
                        Console.Write("Introduzca la base del rectángulo: ");
                        double baseRectangulo = double.Parse(Console.ReadLine());
                        Console.Write("Introduzca la altura del rectángulo: ");
                        double altura = double.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new Rectangulo(baseRectangulo, altura);
                        Console.WriteLine("El área del rectángulo es: " + rectangulo.CalcularArea());
                        break;

                    case "0":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                        break;
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (!salir);
        }
    }
}
