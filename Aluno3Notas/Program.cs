/*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no 
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam 
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver 
este problema*/
using Aluno3Notas;
using System.Globalization;

namespace MyNamespace {
    class MyClass {

        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Digite Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a Primeira Nota do Aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a Segunda  Nota do Aluno: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a Terceira Nota do Aluno: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine( );
            Console.WriteLine("Nota Final= " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO ");
            }
            else {
                Console.WriteLine( "REPROVADO ");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture) + " PONTOS ");

            }
        }
    }
}
