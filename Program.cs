using System.Security.Cryptography.X509Certificates;

public class Practica_7
{
    static void Main(string[] args)
    {
        CalculadoraModular calculadoraModular = new CalculadoraModular();
        Console.WriteLine(calculadoraModular.Sumar(12,12));
        Console.WriteLine(calculadoraModular.Restar(12,12));
        Console.WriteLine(calculadoraModular.Multiplicar(12,12));
        Console.WriteLine(calculadoraModular.Dividir(12,0));

        ValidadorAcceso validadorAcceso = new ValidadorAcceso();
        validadorAcceso.ValidarEdad(19);

        FormularioFlexible formularioFlexible = new FormularioFlexible();
        formularioFlexible.CrearPerfil("Aurel");
        formularioFlexible.CrearPerfil("Zabdiel", "Jugar videojuegos");
    }
    
}
public class CalculadoraModular
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
        public int Restar(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int? Dividir(int a, int b)
        {
            if (b==0)
        {
            Console.WriteLine("No se puede dividir entre 0");
            return null;
        }
            return a / b;
        }
    }
    public class ValidadorAcceso
    {
        public void ValidarEdad(int edad)
        {
            if (edad <18)
            {
                Console.WriteLine("Acceso Denegado.");
            }
            else
            {
                Console.WriteLine("Bienvenido.");
            }
        }
    }
    public class FormularioFlexible
    {
        public void CrearPerfil (string nombre, string hobby = "Dormir")
        {
            Console.WriteLine("Su nombre es: "+nombre);
            Console.WriteLine("Su hobby es: "+hobby);
        }
    }
