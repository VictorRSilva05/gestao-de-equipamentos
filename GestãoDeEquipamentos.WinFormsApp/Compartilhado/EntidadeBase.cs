
namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public virtual string Validar()
        {
            return "";
        }

        public abstract void AtualizarRegistro(EntidadeBase registroEditado);
    }
}