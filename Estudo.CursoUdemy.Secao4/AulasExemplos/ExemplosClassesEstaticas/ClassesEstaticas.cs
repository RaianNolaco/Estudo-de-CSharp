using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.AulasExemplos.ExemplosClassesEstaticas
{
    public class ClassesEstaticas
    {
        static double PI = 3.14;

        public static void ExecultarAula47()
        {
            //nesse caso criamos uma classe estatica chamada calculadora para armazernar nossas funçoes, metodos e atributos
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferecia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + PI.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void ExecultarAula46()
        {
            //nesse exemplo estamos criando os metodos no mesmo lugar aonde iremos chama-los
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circunferecia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + PI.ToString("F2",CultureInfo.InvariantCulture));
        }

        static double Circunferecia(double r){
            return 2.0 * PI * r;
        }

        static double Volume(double r){
            return 4.0 / 3.0 * PI * r * r * r;
        } 
    }
}
