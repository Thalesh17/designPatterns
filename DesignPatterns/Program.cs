﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULADOR DE IMPOSTO
            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();

            //Orcamento orcamento = new Orcamento(500.0);

            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCalculo(orcamento, iss);

            //CALCULADOR DE DESCONTO
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500);

            orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("LAPIS", 500));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
