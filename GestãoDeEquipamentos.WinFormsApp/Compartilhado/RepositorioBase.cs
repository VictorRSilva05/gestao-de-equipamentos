
using GestãoDeEquipamentos.WinFormsApp.Negocio;

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

        public void Editar(int idRegistro, EntidadeBase registroEditado)
        {
            foreach (var registro in registros)
            {
                if (registro.Id == idRegistro)
                {
                    registro.AtualizarRegistro(registroEditado);
                }
            }
        }

        public void Deletar(int idRegistro)
        {
            registros.RemoveAll(e => e.Id == idRegistro);
        }

        public EntidadeBase SelecionarPorId(int idRegistro)
        {
            foreach (var registro in registros)
            {
                if (registro.Id == idRegistro)
                    return registro;
            }
            return null;
        }
    }
}
