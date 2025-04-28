using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public abstract class RepositorioBaseEmArquivo<T> where T : EntidadeBase<T>
    {
        public List<T> registros = new List<T>();
        private int contadorIds = 0;

        public void Inserir(T entidade)
        {
            entidade.Id = ++contadorIds;
            registros.Add(entidade);
        }

        public void Editar(int idRegistro, T registroEditado)
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
