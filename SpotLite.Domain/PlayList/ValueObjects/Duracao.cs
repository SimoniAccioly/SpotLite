﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Domain.PlayList.ValueObjects
{
    public record Duracao
    {
        public int Valor { get; set; }
        public Duracao(int valor)
        {
            if (valor < 0)
                throw new ArgumentException("Duracao da musica nao pode ser negativa");
                     this.Valor = valor;
        }

        public String Formatado()
        {
            int minutos = Valor / 60;
            int segundos = Valor % 60;

            return $"{minutos.ToString().PadLeft(1, '0')}:{segundos.ToString().PadLeft(1, '0')}";

        }

        public static implicit operator int (Duracao d) => d.Valor;
        public static implicit operator Duracao (int valor) => new Duracao(valor);

    }
}
