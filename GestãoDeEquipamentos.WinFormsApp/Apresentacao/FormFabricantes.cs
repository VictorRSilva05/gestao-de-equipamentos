
using GestãoDeEquipamentos.WinFormsApp.Negocio;

namespace GestãoDeEquipamentos.WinFormsApp.Apresentacao;

public partial class FormFabricantes : Form
{
    List<Fabricante> fabricantes = new List<Fabricante>();

    public FormFabricantes()
    {
        InitializeComponent();
    }

    private static void PermitirSomenteNumeros(KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }

        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.') ;
    }


    private void buttonLimpar_Click(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
    {
        PermitirSomenteNumeros(e);
    }

    private void buttonSalvar_Click(object sender, EventArgs e)
    {
        string nome = textBoxNome.Text;
        string telefone = textBoxQtd.Text;
        string email = textBoxEmail.Text;

        if (string.IsNullOrEmpty(textBoxNome.Text) || (string.IsNullOrEmpty(maskedTextBoxTelefone.Text) || (string.IsNullOrEmpty(textBoxEmail.Text))))
        {
            MessageBox.Show("Preencha todos os campos");
            return;
        }

        Fabricante fabricante = new Fabricante(nome, telefone, email);
        fabricante.Id = GeradorIds.GerarIdFabricantes();
        fabricantes.Add(fabricante);
        MessageBox.Show($"Fabricante {fabricante.Nome} adicionado com sucesso!");
        LimparCampos();
    }

    private void LimparCampos()
    {
        textBoxId.Clear();
        textBoxNome.Clear();
        textBoxQtd.Clear();
        maskedTextBoxTelefone.Clear();
        textBoxEmail.Clear();
    }

    private void buttonDeletar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxId.Text))
        {
            MessageBox.Show("Por favor, insira um id válido.");
            return;
        }
        else
        {
            fabricantes.RemoveAll(e => e.Id == Convert.ToInt32(textBoxId.Text));
        }
        MessageBox.Show($"Fabricante com ID {textBoxId.Text} removido com sucesso!");
        LimparCampos();
    }
}
