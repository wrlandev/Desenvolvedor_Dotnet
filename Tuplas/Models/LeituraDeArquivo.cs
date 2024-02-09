﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas.Models
{
    internal class LeituraDeArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());
            }
            catch(Exception ex)
            {
                return (false, new string[0], 0);
            }

        }
    }
}
