
using System.Security.Cryptography.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public abstract class RepositorioBaseEmArquivo<T> where T : EntidadeBase<T>
    {
        public List<T> registros = new List<T>();
        private int contadorIds = 0;

        protected ContextoDados contexto;
       
        protected RepositorioBaseEmArquivo(ContextoDados contexto)
        {
            this.contexto = contexto;
            registros = ObterRegistros();
            
            int maiorId = 0;

            foreach (var registro in registros)
            {
                if (registro.Id > maiorId)
                    maiorId = registro.Id;
            }

            contadorIds = maiorId;
        }

        protected abstract List<T> ObterRegistros();
        public void Inserir(T entidade)
        {
            entidade.Id = ++contadorIds;
            registros.Add(entidade);

            contexto.Salvar();
        }

        public void Editar(int idRegistro, T registroEditado)
        {
            foreach (var registro in registros)
            {
                if (registro.Id == idRegistro)
                {
                    registro.AtualizarRegistro(registroEditado);

                    contexto.Salvar();
                }
            }
        }

        public void Deletar(int idRegistro)
        {
            registros.RemoveAll(e => e.Id == idRegistro);

            contexto.Salvar();
        }

        public T SelecionarPorId(int idRegistro)
        {
            foreach (var registro in registros)
            {
                if (registro.Id == idRegistro)
                    return registro;
            }
            return null;
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }


    }
}
