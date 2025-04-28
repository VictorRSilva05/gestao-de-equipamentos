using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public interface IRepositorio<T> where T : EntidadeBase<T>
    {
        void Inserir(T entidade);
        void Editar(int idRegistro, T registroEditado);
        void Deletar(int idRegistro);
        T SelecionarPorId(int idRegistro);
        List<T> SelecionarTodos();
    } 
}
