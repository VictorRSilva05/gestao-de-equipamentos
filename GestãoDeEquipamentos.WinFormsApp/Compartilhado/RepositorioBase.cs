
namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public abstract class RepositorioBase
    {
        public List<EntidadeBase> registros = new List<EntidadeBase>();
        private int contadorIds = 0;

        public void Inserir(EntidadeBase entidade)
        {
            entidade.Id = ++contadorIds;
            registros.Add(entidade);
        }
    }
}
