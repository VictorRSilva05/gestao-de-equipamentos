﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.WinFormsApp.Negocio
{
    public class Equipamento
    {
        public int Id;
        public string Nome;
        public string Fabricante;
        public decimal PrecoAquisicao;
        public DateOnly DataFabricacao;
        public Equipamento()
        {
        }
        public Equipamento(string nome, string fabricante, decimal precoAquisicao, DateOnly dataFabricacao)
        {
            Nome = nome;
            Fabricante = fabricante;
            PrecoAquisicao = precoAquisicao;
            DataFabricacao = dataFabricacao;
        }

        public string ObterNumeroSerie()
        {
            string tresPrimeirosCaracteres = Nome.Substring(0, 3).ToUpper();

            return $"{tresPrimeirosCaracteres}-{Id}";
        }

        public string Validar()
        {
            string erros = "";

            if (string.IsNullOrEmpty(Nome))
                erros += "O campo nome é obrigatório.\n";

            if (string.IsNullOrEmpty(Fabricante))
                erros += "O campo fabricante é obrigatório.\n";

            if (PrecoAquisicao == 0)
                erros += "O campo preço é obrigatório.";

            return erros;
        }
    }
}
