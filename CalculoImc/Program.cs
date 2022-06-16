using System;

namespace CalculoImc
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu gênero (Masculino ou Feminino):");
            string genero = Console.ReadLine();
            Console.WriteLine("Digite sua Idade: ");
            int idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sua altura: ");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Seu Peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Você é Adulto, Idoso, Juvenil ou Infatil: ");
            string categoria = Console.ReadLine();

            Console.WriteLine("\r\n DIAGNÓSTICO PRÉVIO");
            Console.WriteLine($"\r\n Nome: {nome}");
            Console.WriteLine($" Gênero: {genero}");
            Console.WriteLine($" Idade: {idade}");
            Console.WriteLine($" Altura: {altura}");
            Console.WriteLine($" Peso: {peso}");
            Console.WriteLine($" Categoria: {categoria}");
            decimal calculoImc = (decimal)(peso / (altura * altura));
            Console.WriteLine("\r\n\n IMC desejável: entre 20 e 24");
            Console.WriteLine($"\r\n Resultado IMC: {calculoImc:F}");
            if (calculoImc < 20)
            {
                Console.WriteLine("\r\n Riscos: Muitas complicações de saúde como doenças \n pulmonares e cardiovasculares podem estar associadas ao baixo peso.");
                Console.WriteLine("\r\n Recomendação inicial: Inclua carboidratos simples \n em sua dieta, além de proteínas - indispensáveis para ganho de \n massa magra. Procure um profissional.");
            }
            if (calculoImc >= 20 && calculoImc <= 24)
            {
                Console.WriteLine("\r\n Riscos: Seu peso está ideal para suas referências.");
                Console.WriteLine("\r\n Recomendação Inicial: Mantenha uma dieta saudável \n e faça seus exames periódicos.");
            }
            if (calculoImc >= 25 && calculoImc <= 29)
            {
                Console.WriteLine("\r\n Riscos: Aumento de peso apresenta risco moderado para \n outras doenças crônicas e cardiovasculares.");
                Console.WriteLine("\r\n Recomendação Inicial: Adote um tratamento baseado em \n dieta balanceada, exercício físico e medicação. \n A ajuda de um profissional pode ser interessante");
            }
            if (calculoImc >= 30 && calculoImc <= 35)
            {
                Console.WriteLine("\r\n Riscos: Aumento de peso apresenta risco moderado para \n outras doenças crônicas e cardiovasculares.");
                Console.WriteLine("\r\n Recomendação Inicial: Adote uma dieta alimentar rigorosa,\n  com o acompanhamento de um nutricionista e um \n médico especialista (endócrino).");
            }
            if (calculoImc > 35)
            {
                Console.WriteLine("\r\n Riscos: O obeso mórbido vive menos, tem alto risco de \n mortalidade geral por diversas causas.");
                Console.WriteLine("\r\n Recomendações: Procure com urgência o acompanhamento de \n um nutricionista para realizar reeducação alimentar, \n um psicólogo e um médico especialista (endócrino).");
            }
        }
    }