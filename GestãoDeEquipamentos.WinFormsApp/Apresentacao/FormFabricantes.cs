
using GestãoDeEquipamentos.WinFormsApp.Dados;
using GestãoDeEquipamentos.WinFormsApp.Negocio;
using System.Windows.Forms;

namespace GestãoDeEquipamentos.WinFormsApp.Apresentacao;

public partial class FormFabricantes : Form
{
    RepositorioFabricantes repositorioFabricantes1;
    public FormFabricantes(RepositorioFabricantes repositorioFabricantes, RepositorioEquipamento repositorioEquipamento)
    {
        InitializeComponent();
        InicializarDataGridView();
        repositorioFabricantes1 = repositorioFabricantes;
        AtualizarDataGridView();
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

        Fabricante fabricante = new Fabricante(nome, telefone, email);

        string erros = fabricante.Validar();

        if (erros.Length > 0)
        {
            MessageBox.Show(erros);
            return;
        }

       
        fabricante.Id = GeradorIds.GerarIdFabricantes();
        repositorioFabricantes1.fabricantes.Add(fabricante);
        MessageBox.Show($"Fabricante {fabricante.Nome} adicionado com sucesso!");
        LimparCampos();
        AtualizarDataGridView();
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
            repositorioFabricantes1.fabricantes.RemoveAll(e => e.Id == Convert.ToInt32(textBoxId.Text));
        }
        MessageBox.Show($"Fabricante com ID {textBoxId.Text} removido com sucesso!");
        LimparCampos();
        AtualizarDataGridView();
    }

    private void buttonAtualizar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxId.Text))
        {
            MessageBox.Show("Por favor, insira um id válido.");
            return;
        }
        else
        {
            int id = Convert.ToInt32(textBoxId.Text);
            Fabricante fabricante = repositorioFabricantes1.fabricantes.FirstOrDefault(e => e.Id == id);
            if (fabricante != null)
            {
                fabricante.Nome = textBoxNome.Text;
                fabricante.Email = textBoxEmail.Text;
                fabricante.Telefone = maskedTextBoxTelefone.Text;
                MessageBox.Show($"Fabricante {fabricante.Nome} atualizado com sucesso!");
                LimparCampos();
                AtualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Fabricante não encontrado.");
            }
        }
    }

    private void InicializarDataGridView()
    {
        dataGridView1.Columns.Add("Id", "ID");
        dataGridView1.Columns.Add("Nome", "Nome");
        dataGridView1.Columns.Add("Telefone", "Telefone");
        dataGridView1.Columns.Add("Email", "Email");
        dataGridView1.Columns.Add("Qtd Equipamentos", "Qtd Equipamentos");
    }

    private void AtualizarDataGridView()
    {
        dataGridView1.Rows.Clear();
        foreach (var fabricante in repositorioFabricantes1.fabricantes)
        {
            dataGridView1.Rows.Add(fabricante.Id, fabricante.Nome, fabricante.Telefone, fabricante.Email, fabricante.QtdEquipamentos.ToString()); ;
        }
    }

    private void PopularControles(Fabricante fabricante)
    {
        textBoxId.Text = fabricante.Id.ToString();
        textBoxNome.Text = fabricante.Nome.ToString();
        textBoxEmail.Text = fabricante.Email.ToString();
        maskedTextBoxTelefone.Text = fabricante.Telefone.ToString();
        textBoxQtd.Text = fabricante.QtdEquipamentos.ToString();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        PopularControles(repositorioFabricantes1.fabricantes[e.RowIndex]);
    }


}