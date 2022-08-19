using System;
namespace Pimc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura, peso, pesoatual, imc;
            char sexo;

            Console.WriteLine("Informe o sexo (M / F): ");
            sexo = char.Parse(Console.ReadLine());
            
            while(sexo != 'M' && sexo != 'm' && sexo != 'F' && sexo != 'f')
            {
                Console.WriteLine("Sexo invalido, informe a primeira letra (M / F): ");
                sexo = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe a sua altura");
            altura = float.Parse(Console.ReadLine());

            while(altura != 0.0)
            {
                Console.WriteLine("Entre com uma altura valida (0,00)");
                altura = float.Parse(Console.ReadLine());
            }

            if (sexo == 1)
                peso = 72.7f * altura - 58;
            else
                peso = 62.1f * altura - 44.7f;
            Console.WriteLine("Seu peso ideal é: " + peso + "kg");
            Console.WriteLine("Informe seu peso atual: ");
            pesoatual = float.Parse(Console.ReadLine());
            imc = pesoatual / (altura * altura);
            // imc < 18.5 -> magreza
            // imc >= 18.5 < 25 -> ideal
            // imc >= 25 < 30 -> sobrepeso
            // imc >= 30 < 40 -> obesidade
            // imc >= 40 -> obesidade grave
            if (imc < 18.5)
            {
                Console.WriteLine(imc);
                Console.WriteLine("Abaixo do peso.");
            }
            else
            {
                if (imc >= 18.5 && imc < 25)
                {
                    Console.WriteLine(imc);
                    Console.WriteLine("Peso ideal");
                }
                else if (imc >= 25 && imc < 30)
                {
                    Console.WriteLine(imc);
                    Console.WriteLine("Sobrepeso");
                }
                else if (imc >= 30 && imc < 40)
                {
                    Console.WriteLine(imc);
                    Console.WriteLine("Obesidade");
                }
                else
                {
                    Console.WriteLine(imc);
                    Console.WriteLine("Obesidade Grave");
                }
            }
        }
    }
}