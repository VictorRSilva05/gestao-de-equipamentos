using GestãoDeEquipamentos.WinFormsApp.Compartilhado;
using GestãoDeEquipamentos.WinFormsApp.Negocio;

namespace GestãoDeEquipamentos.WinFormsApp.Dados
{
    public class RepositorioEquipamentoEmArquivo : RepositorioBaseEmArquivo<Equipamento>, IRepositorioEquipamento
    {
        public RepositorioEquipamentoEmArquivo() : base("equipamentos.json")
        {
        }
    }
}
