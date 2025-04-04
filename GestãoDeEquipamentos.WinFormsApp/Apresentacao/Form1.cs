using GestãoDeEquipamentos.WinFormsApp.Negocio;
namespace GestãoDeEquipamentos.WinFormsApp
{
    public partial class Form1 : Form
    {
        List<Equipamento> equipamentos = new List<Equipamento>();
        List<Chamado> chamados = new List<Chamado>();
        public Form1()
        {
            InitializeComponent();
            InicializarDataGridViewEquipamentos();
            InicializarDataGridViewChamados();
            InicializarComboBox();
            CargaInicialEquipamento();
            AtualizarDataGridViewEquipamentos();
            AtualizarDataGridViewChamados();
        }

        private void InicializarComboBox()
        {
            comboBoxTipoChamado.Items.AddRange(Enum.GetNames(typeof(TipoChamadoEnum)));
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string fabricante = textBoxFabricante.Text;
            string auxPrecoAquisicao = textBoxPreco.Text;
            DateOnly dataFabricacao = DateOnly.FromDateTime(dateTimePickerDataFabricacao.Value);

            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxFabricante.Text) || string.IsNullOrEmpty(textBoxPreco.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            decimal precoAquisicao = decimal.Parse(auxPrecoAquisicao);

            Equipamento equipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);
            equipamento.Id = GeradorIds.GerarIdEquipamento();
            equipamentos.Add(equipamento);
            MessageBox.Show($"Equipamento {equipamento.Nome} adicionado com sucesso!");
            LimparCamposEquipamento();
            AtualizarDataGridViewEquipamentos();
        }

        private void buttonSalvarChamado_Click(object sender, EventArgs e)
        {
            TipoChamadoEnum tipoChamadoEnum = (TipoChamadoEnum)Enum.Parse(typeof(TipoChamadoEnum), comboBoxTipoChamado.SelectedItem.ToString());
            Equipamento equipamento = equipamentos.Find(e => e.Id == Convert.ToInt32(textBoxIdEquipamentoChamado.Text));
            if (equipamento is null)
                return;

            DateOnly aberturaChamado = DateOnly.FromDateTime(dateTimePickerChamado.Value);
            string descricaoChamado = richTextBoxChamado.Text;

            Chamado chamado = new Chamado
            {
                TituloChamado = tipoChamadoEnum,
                DescricaoChamado = descricaoChamado,
                Equipamento = equipamento,
                DataAbertura = aberturaChamado
            };

            chamado.Id = GeradorIds.GerarIdChamado();
            chamados.Add(chamado);
            MessageBox.Show($"Chamado aberto para: {chamado.Equipamento.Nome}");
            LimparCamposChamado();
            AtualizarDataGridViewChamados();
        }


        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                chamados.RemoveAll(e => e.Id == Convert.ToInt32(textBoxId.Text));
            }
            MessageBox.Show($"Equipamento com ID {textBoxId.Text} removido com sucesso!");
            LimparCamposEquipamento();
            AtualizarDataGridViewEquipamentos();
        }

        private void buttonDeletarChamado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdChamado.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                chamados.RemoveAll(e => e.Id == Convert.ToInt32(textBoxIdChamado.Text));
            }
            MessageBox.Show($"Chamado com ID {textBoxIdChamado.Text} removido com sucesso!");
            LimparCamposChamado();
            AtualizarDataGridViewChamados();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                int id = Convert.ToInt32(textBoxId.Text);
                Equipamento equipamento = equipamentos.FirstOrDefault(e => e.Id == id);
                if (equipamento != null)
                {
                    equipamento.Nome = textBoxNome.Text;
                    equipamento.Fabricante = textBoxFabricante.Text;
                    equipamento.PrecoAquisicao = Convert.ToDecimal(textBoxPreco.Text);
                    equipamento.DataFabricacao = DateOnly.FromDateTime(dateTimePickerDataFabricacao.Value);
                    MessageBox.Show($"Equipamento {equipamento.Nome} atualizado com sucesso!");
                    LimparCamposEquipamento();
                    AtualizarDataGridViewEquipamentos();
                }
                else
                {
                    MessageBox.Show("Equipamento não encontrado.");
                }
            }
        }

        private void buttonAtualizarChamado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdChamado.Text))
            {
                MessageBox.Show("Por favor insira um ID válido.");
                return;
            }
            else
            {
                int id = Convert.ToInt32(textBoxIdChamado.Text);
                Chamado chamado = chamados.FirstOrDefault(e => e.Id == id);
                if (chamado != null)
                {
                    TipoChamadoEnum tipoChamadoEnum = (TipoChamadoEnum)Enum.Parse(typeof(TipoChamadoEnum), comboBoxTipoChamado.SelectedItem.ToString());
                    chamado.TituloChamado = tipoChamadoEnum;
                    DateOnly aberturaChamado = DateOnly.FromDateTime(dateTimePickerChamado.Value);
                    chamado.DataAbertura = aberturaChamado;
                    string descricaoChamado = richTextBoxChamado.Text;
                    chamado.DescricaoChamado = descricaoChamado;
                    MessageBox.Show($"Chamado: {chamado.Id} atualizado com sucesso!");
                    LimparCamposChamado();
                    AtualizarDataGridViewChamados();
                }
                else
                {
                    MessageBox.Show("Chamado não encontrado");
                }
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposEquipamento();
        }

        private void buttonLimparChamado_Click(object sender, EventArgs e)
        {
            LimparCamposChamado();
        }
        private void LimparCamposChamado()
        {
            textBoxIdChamado.Clear();
            comboBoxTipoChamado.SelectedIndex = -1;
            textBoxIdEquipamentoChamado.Clear();
            dateTimePickerChamado.Value = DateTime.Now;
            richTextBoxChamado.Clear();
        }
        private void LimparCamposEquipamento()
        {
            textBoxId.Clear();
            textBoxNome.Clear();
            textBoxFabricante.Clear();
            textBoxPreco.Clear();
            dateTimePickerDataFabricacao.Value = DateTime.Now;
        }

        private void PopularControlesEquipamento(Equipamento equipamento)
        {
            textBoxId.Text = equipamento.Id.ToString();
            textBoxNome.Text = equipamento.Nome;
            textBoxFabricante.Text = equipamento.Fabricante;
            textBoxPreco.Text = equipamento.PrecoAquisicao.ToString();
        }

        private void PopularControlesChamado(Chamado chamado)
        {
            textBoxIdChamado.Text = chamado.Id.ToString();
            comboBoxTipoChamado.Text = chamado.TituloChamado.ToString();
            textBoxIdEquipamentoChamado.Text = chamado.Equipamento.Id.ToString();
            richTextBoxChamado.Text = chamado.DescricaoChamado.ToString();
        }

        private void AtualizarDataGridViewEquipamentos()
        {
            dataGridView1.Rows.Clear();
            foreach (var equipamento in equipamentos)
            {
                dataGridView1.Rows.Add(equipamento.Id, equipamento.Nome, equipamento.Fabricante, equipamento.PrecoAquisicao, equipamento.DataFabricacao, equipamento.ObterNumeroSerie());
            }
        }

        private void AtualizarDataGridViewChamados()
        {
            dataGridView2.Rows.Clear();
            foreach (var chamado in chamados)
            {
                var dataAtual = DateTime.Now.Subtract(chamado.DataAbertura.ToDateTime(TimeOnly.MinValue));
                dataGridView2.Rows.Add(chamado.Id, chamado.TituloChamado, chamado.Equipamento.Id, chamado.DescricaoChamado, chamado.DataAbertura, dataAtual.TotalDays.ToString("F0"));
            }
        }
        private void InicializarDataGridViewEquipamentos()
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Fabricante", "Fabricante");
            dataGridView1.Columns.Add("PrecoAquisicao", "Preço de Aquisição");
            dataGridView1.Columns.Add("DataFabricacao", "Data de Fabricação");
            dataGridView1.Columns.Add("Número de série", "Número de série");
        }

        private void InicializarDataGridViewChamados()
        {
            dataGridView2.Columns.Add("Id", "ID");
            dataGridView2.Columns.Add("TituloChamado", "Título do Chamado");
            dataGridView2.Columns.Add("DescricaoChamado", "Descrição do Chamado");
            dataGridView2.Columns.Add("Equipamento", "Equipamento");
            dataGridView2.Columns.Add("DataAbertura", "Data de Abertura");
            dataGridView2.Columns.Add("Dias aberto", "Dias aberto");
        }

        private void PermitirSomenteNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.') ;
        }

        private void CargaInicialEquipamento()
        {
            Equipamento equipamento1 = new("Sidewinder", "Raytheon", 380069, new DateOnly(2022, 5, 1)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento2 = new("Sparrow", "Raytheon", 125000, new DateOnly(2021, 8, 15)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento3 = new("Tomahawk", "Raytheon", 1500000, new DateOnly(2020, 12, 20)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento4 = new("Hellfire", "Lockheed Martin", 110000, new DateOnly(2023, 1, 10)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento5 = new("Javelin", "Lockheed Martin", 178000, new DateOnly(2023, 2, 5)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento6 = new("Stinger", "Raytheon", 38000, new DateOnly(2023, 3, 12)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento7 = new("Patriot", "Raytheon", 10000000, new DateOnly(2023, 4, 18)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento8 = new("AIM-120", "Raytheon", 500000, new DateOnly(2023, 5, 25)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento9 = new("AIM-9", "Raytheon", 200000, new DateOnly(2023, 6, 30)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento10 = new("AIM-7", "Raytheon", 300000, new DateOnly(2023, 7, 15)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento11 = new("AGM-86", "Boeing", 2000000, new DateOnly(2023, 8, 20)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento12 = new("AGM-114", "Lockheed Martin", 700000, new DateOnly(2023, 9, 25)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento13 = new("AGM-158", "Lockheed Martin", 1200000, new DateOnly(2023, 10, 30)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento14 = new("AGM-65", "Raytheon", 150000, new DateOnly(2023, 11, 5)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento15 = new("AGM-88", "Raytheon", 200000, new DateOnly(2023, 12, 10)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento16 = new("AGM-114R", "Lockheed Martin", 300000, new DateOnly(2024, 1, 15)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento17 = new("AGM-176", "Raytheon", 500000, new DateOnly(2024, 2, 20)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento18 = new("AGM-158B", "Lockheed Martin", 800000, new DateOnly(2024, 3, 25)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento19 = new("AGM-158C", "Lockheed Martin", 1000000, new DateOnly(2024, 4, 30)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento20 = new("AGM-158D", "Lockheed Martin", 1200000, new DateOnly(2024, 5, 5)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento48 = new("AGM-164", "Lockheed Martin", 15000000, new DateOnly(2026, 9, 25)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento49 = new("AGM-165", "Lockheed Martin", 15500000, new DateOnly(2026, 10, 30)) { Id = GeradorIds.GerarIdEquipamento() };
            Equipamento equipamento50 = new("AGM-166", "Lockheed Martin", 16000000, new DateOnly(2026, 11, 5)) { Id = GeradorIds.GerarIdEquipamento() };
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesEquipamento(equipamentos[e.RowIndex]);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesChamado(chamados[e.RowIndex]);
        }
    }
}
