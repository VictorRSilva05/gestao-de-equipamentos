
using GestãoDeEquipamentos.WinFormsApp.Negocio;
using System.Windows.Forms;

namespace GestãoDeEquipamentos.WinFormsApp.Apresentacao;

public partial class FormFabricantes : Form
{
    List<Fabricante> fabricantes = new List<Fabricante>();

    public FormFabricantes()
    {
        InitializeComponent();
        CargaInicial();
        InicializarDataGridView();
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
            fabricantes.RemoveAll(e => e.Id == Convert.ToInt32(textBoxId.Text));
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
            Fabricante fabricante = fabricantes.FirstOrDefault(e => e.Id == id);
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
        foreach (var fabricante in fabricantes)
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
        PopularControles(fabricantes[e.RowIndex]);
    }

    private void CargaInicial()
    {
        Fabricante fabricante1 = new("Raytheon", "69696", "raytheondefence@raytheon.com") { Id = GeradorIds.GerarIdFabricantes() };
        Fabricante fabricante2 = new("Lockheed Martin", "420420", "lockheedmartin@lockheedmartin.com") { Id = GeradorIds.GerarIdFabricantes() };
        Fabricante fabricante3 = new("Boeing", "24242", "boeingindustries@boeing.com") { Id = GeradorIds.GerarIdFabricantes() };
        fabricantes.Add(fabricante1);
        fabricantes.Add(fabricante2);
        fabricantes.Add(fabricante3);
    }
}