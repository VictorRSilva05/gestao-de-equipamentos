using GestãoDeEquipamentos.WinFormsApp.Compartilhado;
using GestãoDeEquipamentos.WinFormsApp.Negocio;
using System;

namespace GestãoDeEquipamentos.WinFormsApp.Dados
{
    public class RepositorioChamadoEmArquivo : RepositorioBaseEmArquivo<Chamado>, IRepositorioChamado
    {
        public RepositorioChamadoEmArquivo(string nomeArquivo) : base(nomeArquivo)
        {
        }
    }
}
