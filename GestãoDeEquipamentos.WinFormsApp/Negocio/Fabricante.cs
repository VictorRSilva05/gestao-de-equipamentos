using GestãoDeEquipamentos.WinFormsApp.Dados;
using System.Net.Mail;

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

    public string ValidarEntrada()
    {
        string erros = default(string);

        if (string.IsNullOrEmpty(Nome))
            erros += "O campo nome é obrigatório.\n";

        if (Nome.Length < 3)
            erros += "O campo 'Nome' precisa conter ao menos 3 caracteres.\n";

        if (string.IsNullOrWhiteSpace(Email))
            erros += "O campo 'Email' é obrigatório.\n";

        if (!MailAddress.TryCreate(Email, out _))
            erros += "O campo 'Email' deve estar em um formato válido.\n";

        if (string.IsNullOrWhiteSpace(Telefone))
            erros += "O campo 'Telefone' é obrigatório.\n";

        if (Telefone.Length < 12)
            erros += "O campo 'Telefone' deve seguir o formato 00 0000-0000.";

        return erros;
    }
}

