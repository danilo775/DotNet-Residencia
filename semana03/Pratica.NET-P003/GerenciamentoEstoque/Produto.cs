﻿using System;

namespace GerenciamentoEstoque
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}