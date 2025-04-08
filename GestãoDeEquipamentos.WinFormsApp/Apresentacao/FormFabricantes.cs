
namespace GestãoDeEquipamentos.WinFormsApp.Apresentacao;

public partial class FormFabricantes : Form
{
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
        textBoxId.Clear();
        textBoxNome.Clear();
        textBoxQtd.Clear();
        maskedTextBoxTelefone.Clear();
        textBoxEmail.Clear();
    }

    private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
    {
        PermitirSomenteNumeros(e);
    }
}
