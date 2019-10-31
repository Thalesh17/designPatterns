﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
