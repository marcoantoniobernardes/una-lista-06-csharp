/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program
{
    static void Main(string[] args)
    {
        string nome;
        int idade;
        bool cartaoV, sintomas, infectados, viagem;
        int ntentativas = 3;
        double porcentagem = 0;

        Console.WriteLine("Nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Idade:");
        idade = int.Parse(Console.ReadLine());

        cartaoV = Perguntas("Seu cartão de vacina está em dia?", ntentativas);
        sintomas = Perguntas("Teve algum dos sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe)", ntentativas);
        infectados = Perguntas("Teve contato com pessoas com sintomas gripais nos últimos dias?", ntentativas);
        viagem = Perguntas("Está retornando de viagem realizada no exterior?", ntentativas);

        if (!cartaoV)
            porcentagem += 0.1;
        if (sintomas)
            porcentagem += 0.3;
        if (infectados)
            porcentagem += 0.3;
        if (viagem)
            porcentagem += 0.3;

        string orientacaoFinal = OrientacaoF(porcentagem, viagem);

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cartão de vacina em dia: " + (cartaoV ? "Sim" : "Não"));
        Console.WriteLine("Teve sintomas recentemente: " + (sintomas ? "Sim" : "Não"));
        Console.WriteLine("Teve contato com pessoas infectadas: " + (infectados ? "Sim" : "Não"));
        Console.WriteLine("Está retornando de viagem: " + (viagem ? "Sim" : "Não"));
        Console.WriteLine("Porcentagem de risco: " + porcentagem*100 + "%");
        Console.WriteLine("Orientação final: " + orientacaoFinal);
        Console.ReadLine();
    }

    static bool Perguntas(string pergunta, int ntentativas)
    {
        int tentativas = 0;
        do
        {
            Console.WriteLine(pergunta);
            string resposta = Console.ReadLine().ToUpper();
            
            if (resposta == "SIM")
                return true;
            else if (resposta == "NAO")
                return false;

            tentativas++;
            Console.WriteLine("Resposta inválida. Responda com 'SIM' ou 'NAO'. Tentativas restantes: " + (ntentativas - tentativas));
        } while (tentativas < ntentativas);

        Console.WriteLine("Não foi possível realizar o diagnóstico.");
        Console.WriteLine("Gentileza procurar ajuda médica caso apareça algum sintoma.");
        Environment.Exit(0);
        return false;
    }

    static string OrientacaoF(double porcentagem, bool viagem)
    {
        if(porcentagem>0.9)
            return "Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado.";
        else if (porcentagem <= 0.89 && porcentagem > 0.6)
            return "Paciente com alto risco de estar infectado. Gentileza aguardar em lockdown por 05 dias para ser acompanhado.";
        else if (viagem == true)
            return "Você ficará sob observação por 05 dias.";
        else if (porcentagem <= 0.6 && porcentagem > 0.3)
            return "Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado.";
        else
            return "Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica.";
    }
}