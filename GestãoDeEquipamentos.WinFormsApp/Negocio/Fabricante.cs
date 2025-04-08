using GestãoDeEquipamentos.WinFormsApp.Dados;

namespace GestãoDeEquipamentos.WinFormsApp.Negocio;

public class Fabricante
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public int QtdEquipamentos { get; set; }

    public Fabricante(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    public Fabricante()
    {
    }

    public void AtualizarQuantidadeEquipamentos(List<Equipamento> equipamentos)
    {
        QtdEquipamentos = equipamentos.Count(e => e.Fabricante == Nome);
    }
}

