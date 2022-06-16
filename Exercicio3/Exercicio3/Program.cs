﻿using static System.Console;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IMontadora instancia = null;
                WriteLine("Selecione a Montadora (para sair digite S)");
                WriteLine("(C)hevrolet (F)ord (H)onda ");
                var opcao = ReadLine().ToUpper();

                if (opcao.Equals("S"))
                    break;

                instancia = MontadoraFactory.GetVeiculo(opcao);
                if (instancia != null)
                    WriteLine($"\n{instancia.Modelo()} - {instancia.Cor}\n");
                else
                    WriteLine("Não encontrado!");
            }
        }
    }
}
