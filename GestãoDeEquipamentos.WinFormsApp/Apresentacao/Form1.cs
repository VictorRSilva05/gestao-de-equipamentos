using GestãoDeEquipamentos.WinFormsApp.Negocio;
namespace GestãoDeEquipamentos.WinFormsApp
{
    public partial class Form1 : Form
    {
        List<Equipamento> equipamentos = new List<Equipamento>();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            CargaInicial();
            AtualizarDataGridView();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string fabricante = textBoxFabricante.Text;
            decimal precoAquisicao = Convert.ToDecimal(textBoxPreco.Text);
            DateOnly dataFabricacao = DateOnly.FromDateTime(dateTimePickerDataFabricacao.Value);
            Equipamento equipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);
            equipamento.Id = GeradorIds.GerarIdEquipamento();
            equipamentos.Add(equipamento);
            MessageBox.Show($"Equipamento {equipamento.Nome} adicionado com sucesso!");
            LimparCampos();
            AtualizarDataGridView();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxFabricante.Clear();
            textBoxPreco.Clear();
            dateTimePickerDataFabricacao.Value = DateTime.Now;
        }

        private void AtualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var equipamento in equipamentos)
            {
                dataGridView1.Rows.Add(equipamento.Id, equipamento.Nome, equipamento.Fabricante, equipamento.PrecoAquisicao, equipamento.DataFabricacao, equipamento.ObterNumeroSerie());
            }
        }
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Fabricante", "Fabricante");
            dataGridView1.Columns.Add("PrecoAquisicao", "Preço de Aquisição");
            dataGridView1.Columns.Add("DataFabricacao", "Data de Fabricação");
            dataGridView1.Columns.Add("Número de série", "Número de série");
        }

        private void PermitirSomenteNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.') ;
        }

        private void CargaInicial()
        {
            Equipamento equipamento1 = new Equipamento("Sidewinder", "Raytheon", 380069, new DateOnly(2022, 5, 1));
            equipamento1.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento2 = new Equipamento("Sparrow", "Raytheon", 125000, new DateOnly(2021, 8, 15));
            equipamento2.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento3 = new Equipamento("Tomahawk", "Raytheon", 1500000, new DateOnly(2020, 12, 20));
            equipamento3.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento4 = new Equipamento("Hellfire", "Lockheed Martin", 110000, new DateOnly(2023, 1, 10));
            equipamento4.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento5 = new Equipamento("Javelin", "Lockheed Martin", 178000, new DateOnly(2023, 2, 5));
            equipamento5.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento6 = new Equipamento("Stinger", "Raytheon", 38000, new DateOnly(2023, 3, 12));
            equipamento6.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento7 = new Equipamento("Patriot", "Raytheon", 10000000, new DateOnly(2023, 4, 18));
            equipamento7.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento8 = new Equipamento("AIM-120", "Raytheon", 500000, new DateOnly(2023, 5, 25));
            equipamento8.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento9 = new Equipamento("AIM-9", "Raytheon", 200000, new DateOnly(2023, 6, 30));
            equipamento9.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento10 = new Equipamento("AIM-7", "Raytheon", 300000, new DateOnly(2023, 7, 15));
            equipamento10.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento11 = new Equipamento("AGM-86", "Boeing", 2000000, new DateOnly(2023, 8, 20));
            equipamento11.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento12 = new Equipamento("AGM-114", "Lockheed Martin", 700000, new DateOnly(2023, 9, 25));
            equipamento12.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento13 = new Equipamento("AGM-158", "Lockheed Martin", 1200000, new DateOnly(2023, 10, 30));
            equipamento13.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento14 = new Equipamento("AGM-65", "Raytheon", 150000, new DateOnly(2023, 11, 5));
            equipamento14.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento15 = new Equipamento("AGM-88", "Raytheon", 200000, new DateOnly(2023, 12, 10));
            equipamento15.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento16 = new Equipamento("AGM-114R", "Lockheed Martin", 300000, new DateOnly(2024, 1, 15));
            equipamento16.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento17 = new Equipamento("AGM-176", "Raytheon", 500000, new DateOnly(2024, 2, 20));
            equipamento17.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento18 = new Equipamento("AGM-158B", "Lockheed Martin", 800000, new DateOnly(2024, 3, 25));
            equipamento18.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento19 = new Equipamento("AGM-158C", "Lockheed Martin", 1000000, new DateOnly(2024, 4, 30));
            equipamento19.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento20 = new Equipamento("AGM-158D", "Lockheed Martin", 1200000, new DateOnly(2024, 5, 5));
            equipamento20.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento48 = new Equipamento("AGM-164", "Lockheed Martin", 15000000, new DateOnly(2026, 9, 25));
            equipamento48.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento49 = new Equipamento("AGM-165", "Lockheed Martin", 15500000, new DateOnly(2026, 10, 30));
            equipamento49.Id = GeradorIds.GerarIdEquipamento();
            Equipamento equipamento50 = new Equipamento("AGM-166", "Lockheed Martin", 16000000, new DateOnly(2026, 11, 5));
            equipamento50.Id = GeradorIds.GerarIdEquipamento();
            equipamentos.Add(equipamento1);
            equipamentos.Add(equipamento2);
            equipamentos.Add(equipamento3);
            equipamentos.Add(equipamento4);
            equipamentos.Add(equipamento5);
            equipamentos.Add(equipamento6);
            equipamentos.Add(equipamento7);
            equipamentos.Add(equipamento8);
            equipamentos.Add(equipamento9);
            equipamentos.Add(equipamento10);
            equipamentos.Add(equipamento11);
            equipamentos.Add(equipamento12);
            equipamentos.Add(equipamento13);
            equipamentos.Add(equipamento14);
            equipamentos.Add(equipamento15);
            equipamentos.Add(equipamento16);
            equipamentos.Add(equipamento17);
            equipamentos.Add(equipamento18);
            equipamentos.Add(equipamento19);
            equipamentos.Add(equipamento20);
            equipamentos.Add(equipamento48);
            equipamentos.Add(equipamento49);
            equipamentos.Add(equipamento50);
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(e);
        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(e);
        }
    }
}
