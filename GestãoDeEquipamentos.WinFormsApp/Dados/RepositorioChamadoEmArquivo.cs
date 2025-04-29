using GestãoDeEquipamentos.WinFormsApp.Compartilhado;
using GestãoDeEquipamentos.WinFormsApp.Negocio;
using System;

namespace GestãoDeEquipamentos.WinFormsApp.Dados
{
    public class RepositorioChamadoEmArquivo : RepositorioBaseEmArquivo<Chamado>, IRepositorioChamado
    {
        public RepositorioChamadoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Chamado> ObterRegistros()
        {
            return contexto.Chamados;
        }
    }
}
