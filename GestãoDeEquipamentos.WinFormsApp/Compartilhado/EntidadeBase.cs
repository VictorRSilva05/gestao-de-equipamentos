namespace GestãoDeEquipamentos.WinFormsApp.Compartilhado
{
    public class EntidadeBase
    {
        public int Id { get; set; }
        public virtual string Validar()
        {
            return "";
        }
    }
}