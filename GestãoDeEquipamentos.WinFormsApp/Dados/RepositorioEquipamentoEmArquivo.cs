﻿using GestãoDeEquipamentos.WinFormsApp.Compartilhado;
using GestãoDeEquipamentos.WinFormsApp.Negocio;

namespace GestãoDeEquipamentos.WinFormsApp.Dados
{
    public class RepositorioEquipamentoEmArquivo : RepositorioBaseEmArquivo<Equipamento>, IRepositorioEquipamento
    {
        public RepositorioEquipamentoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Equipamento> ObterRegistros()
        {
            return contexto.Equipamentos;
        }
    }
}
