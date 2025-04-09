using GestãoDeEquipamentos.WinFormsApp.Apresentacao;
using GestãoDeEquipamentos.WinFormsApp.Dados;
using GestãoDeEquipamentos.WinFormsApp.Negocio;
namespace GestãoDeEquipamentos.WinFormsApp
{
    public partial class Form1 : Form
    {
        public RepositorioChamado repositorioChamado = new RepositorioChamado();
        public RepositorioEquipamento repositorioEquipamento = new RepositorioEquipamento();
        public RepositorioFabricantes repositorioFabricantes = new RepositorioFabricantes();
        public Form1()
        {
            InitializeComponent();
            InicializarDataGridViewEquipamentos();
            InicializarDataGridViewChamados();
            CargaInicialEquipamento();
            CargaInicialFabricantes();
            AtualizarQuantidadeEquipamentosFabricantes();
            InicializarComboBoxChamado();
            InicializarComboBoxFabricantes();
            AtualizarDataGridViewEquipamentos();
            AtualizarDataGridViewChamados();
        }

        private void InicializarComboBoxChamado()
        {
            comboBoxTipoChamado.Items.AddRange(Enum.GetNames(typeof(TipoChamadoEnum)));
        }

        private void InicializarComboBoxFabricantes()
        {
            comboBoxFabricante.Items.Clear();
            comboBoxFabricante.Items.AddRange(repositorioFabricantes.fabricantes.Select(f => f.Nome).ToArray());
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string fabricante = comboBoxFabricante.Text;
            string auxPrecoAquisicao = textBoxPreco.Text;
            DateOnly dataFabricacao = DateOnly.FromDateTime(dateTimePickerDataFabricacao.Value);

            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(comboBoxFabricante.Text) || string.IsNullOrEmpty(textBoxPreco.Text) || nome.Length < 6)
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            decimal precoAquisicao = decimal.Parse(auxPrecoAquisicao);

            Equipamento equipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);
            equipamento.Id = GeradorIds.GerarIdEquipamento();
            repositorioEquipamento.equipamentos.Add(equipamento);
            MessageBox.Show($"Equipamento {equipamento.Nome} adicionado com sucesso!");
            LimparCamposEquipamento();
            AtualizarQuantidadeEquipamentosFabricantes();
            AtualizarDataGridViewEquipamentos();
        }

        private void buttonSalvarChamado_Click(object sender, EventArgs e)
        {
            TipoChamadoEnum tipoChamadoEnum = (TipoChamadoEnum)Enum.Parse(typeof(TipoChamadoEnum), comboBoxTipoChamado.SelectedItem.ToString());
            Equipamento equipamento = repositorioEquipamento.equipamentos.Find(e => e.Id == Convert.ToInt32(textBoxIdEquipamentoChamado.Text));
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
            repositorioChamado.chamados.Add(chamado);
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
                repositorioEquipamento.equipamentos.RemoveAll(e => e.Id == Convert.ToInt32(textBoxId.Text));
            }
            MessageBox.Show($"Equipamento com ID {textBoxId.Text} removido com sucesso!");
            LimparCamposEquipamento();
            AtualizarQuantidadeEquipamentosFabricantes();
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
                repositorioChamado.chamados.RemoveAll(e => e.Id == Convert.ToInt32(textBoxIdChamado.Text));
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
                Equipamento equipamento = repositorioEquipamento.equipamentos.FirstOrDefault(e => e.Id == id);
                if (equipamento != null)
                {
                    equipamento.Nome = textBoxNome.Text;
                    equipamento.Fabricante = comboBoxFabricante.Text;
                    equipamento.PrecoAquisicao = Convert.ToDecimal(textBoxPreco.Text);
                    equipamento.DataFabricacao = DateOnly.FromDateTime(dateTimePickerDataFabricacao.Value);
                    MessageBox.Show($"Equipamento {equipamento.Nome} atualizado com sucesso!");
                    LimparCamposEquipamento();
                    AtualizarQuantidadeEquipamentosFabricantes();
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
                Chamado chamado = repositorioChamado.chamados.FirstOrDefault(e => e.Id == id);
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
            comboBoxFabricante.SelectedIndex = -1;
            textBoxPreco.Clear();
            dateTimePickerDataFabricacao.Value = DateTime.Now;
        }

        private void PopularControlesEquipamento(Equipamento equipamento)
        {
            textBoxId.Text = equipamento.Id.ToString();
            textBoxIdEquipamentoChamado.Text = equipamento.Id.ToString();
            textBoxNome.Text = equipamento.Nome;
            comboBoxFabricante.Text = equipamento.Fabricante;
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
            foreach (var equipamento in repositorioEquipamento.equipamentos)
            {
                dataGridView1.Rows.Add(equipamento.Id, equipamento.Nome, equipamento.Fabricante, equipamento.PrecoAquisicao, equipamento.DataFabricacao, equipamento.ObterNumeroSerie());
            }
        }

        private void AtualizarDataGridViewChamados()
        {
            dataGridView2.Rows.Clear();
            foreach (var chamado in repositorioChamado.chamados)
            {
                var dataAtual = DateTime.Now.Subtract(chamado.DataAbertura.ToDateTime(TimeOnly.MinValue));
                dataGridView2.Rows.Add(chamado.Id, chamado.TituloChamado, chamado.Equipamento.Id, chamado.DescricaoChamado, chamado.DataAbertura, dataAtual.TotalDays.ToString("F0"));
            }
        }
        private void InicializarDataGridViewEquipamentos()
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Fabricante", "Fabricante");
            dataGridView1.Columns.Add("PrecoAquisicao", "Preço de Aquisição");
            dataGridView1.Columns.Add("DataFabricacao", "Data de Fabricação");
            dataGridView1.Columns.Add("Número de série", "Número de série");
        }

        private void InicializarDataGridViewChamados()
        {
            dataGridView2.Columns.Add("Id", "ID");
            dataGridView2.Columns[0].Width = 40;
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
            repositorioEquipamento.equipamentos.Add(equipamento1);
            repositorioEquipamento.equipamentos.Add(equipamento2);
            repositorioEquipamento.equipamentos.Add(equipamento3);
            repositorioEquipamento.equipamentos.Add(equipamento4);
            repositorioEquipamento.equipamentos.Add(equipamento5);
            repositorioEquipamento.equipamentos.Add(equipamento6);
            repositorioEquipamento.equipamentos.Add(equipamento7);
            repositorioEquipamento.equipamentos.Add(equipamento8);
            repositorioEquipamento.equipamentos.Add(equipamento9);
            repositorioEquipamento.equipamentos.Add(equipamento10);
            repositorioEquipamento.equipamentos.Add(equipamento11);
            repositorioEquipamento.equipamentos.Add(equipamento12);
            repositorioEquipamento.equipamentos.Add(equipamento13);
            repositorioEquipamento.equipamentos.Add(equipamento14);
            repositorioEquipamento.equipamentos.Add(equipamento15);
            repositorioEquipamento.equipamentos.Add(equipamento16);
            repositorioEquipamento.equipamentos.Add(equipamento17);
            repositorioEquipamento.equipamentos.Add(equipamento18);
            repositorioEquipamento.equipamentos.Add(equipamento19);
            repositorioEquipamento.equipamentos.Add(equipamento20);
            repositorioEquipamento.equipamentos.Add(equipamento48);
            repositorioEquipamento.equipamentos.Add(equipamento49);
            repositorioEquipamento.equipamentos.Add(equipamento50);
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
            PopularControlesEquipamento(repositorioEquipamento.equipamentos[e.RowIndex]);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesChamado(repositorioChamado.chamados[e.RowIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormFabricantes(repositorioFabricantes, repositorioEquipamento).ShowDialog();
        }

        private void CargaInicialFabricantes()
        {
            Fabricante fabricante1 = new("Raytheon", "69696", "raytheondefence@raytheon.com") { Id = GeradorIds.GerarIdFabricantes() };
            Fabricante fabricante2 = new("Lockheed Martin", "420420", "lockheedmartin@lockheedmartin.com") { Id = GeradorIds.GerarIdFabricantes() };
            Fabricante fabricante3 = new("Boeing", "24242", "boeingindustries@boeing.com") { Id = GeradorIds.GerarIdFabricantes() };
            repositorioFabricantes.fabricantes.Add(fabricante1);
            repositorioFabricantes.fabricantes.Add(fabricante2);
            repositorioFabricantes.fabricantes.Add(fabricante3);
        }

        private void AtualizarQuantidadeEquipamentosFabricantes()
        {
            foreach (var fabricante in repositorioFabricantes.fabricantes)
            {
                fabricante.AtualizarQuantidadeEquipamentos(repositorioEquipamento.equipamentos);
            }
        }
        private void comboBoxFabricante_MouseClick(object sender, MouseEventArgs e)
        {
            InicializarComboBoxFabricantes();
        }
    }
}
