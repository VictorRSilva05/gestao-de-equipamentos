using GestãoDeEquipamentos.WinFormsApp.Apresentacao;
using GestãoDeEquipamentos.WinFormsApp.Dados;
using GestãoDeEquipamentos.WinFormsApp.Negocio;
namespace GestãoDeEquipamentos.WinFormsApp
{
    public partial class Form1 : Form
    {
        public RepositorioChamado repositorioChamado = new RepositorioChamado();
        public RepositorioEquipamento repositorioEquipamento = new RepositorioEquipamento();
        public RepositorioFabricante repositorioFabricante = new RepositorioFabricante();
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

            List<Fabricante> fabricantes = new List<Fabricante>();

            foreach (var fabricante in repositorioFabricante.registros)
            {
                fabricantes.Add(fabricante as Fabricante);
            }

            comboBoxFabricante.Items.AddRange(fabricantes.Select(f => f.Nome).ToArray());
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
            repositorioEquipamento.Inserir(equipamento);
            MessageBox.Show($"Equipamento {equipamento.Nome} adicionado com sucesso!");
            LimparCamposEquipamento();
            AtualizarQuantidadeEquipamentosFabricantes();
            AtualizarDataGridViewEquipamentos();
        }

        private void buttonSalvarChamado_Click(object sender, EventArgs e)
        {
            TipoChamadoEnum tipoChamadoEnum = (TipoChamadoEnum)Enum.Parse(typeof(TipoChamadoEnum), comboBoxTipoChamado.SelectedItem.ToString());
            Equipamento equipamento = repositorioEquipamento.SelecionarPorId(Convert.ToInt32(textBoxIdEquipamentoChamado.Text)) as Equipamento;
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

            repositorioChamado.Inserir(chamado);
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
                repositorioEquipamento.Deletar(Convert.ToInt32(textBoxId.Text));
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
                repositorioChamado.Deletar(Convert.ToInt32(textBoxIdChamado.Text));
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
                Equipamento equipamentoEditado = new Equipamento();
                if (equipamentoEditado != null)
                {
                    equipamentoEditado.Nome = textBoxNome.Text;
                    equipamentoEditado.Fabricante = comboBoxFabricante.Text;
                    equipamentoEditado.PrecoAquisicao = Convert.ToDecimal(textBoxPreco.Text);
                    equipamentoEditado.DataFabricacao = DateOnly.FromDateTime(dateTimePickerDataFabricacao.Value);
                    repositorioEquipamento.Editar(id, equipamentoEditado);
                    MessageBox.Show($"Equipamento {equipamentoEditado.Nome} atualizado com sucesso!");
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
                Chamado chamadoEditado = new Chamado();
                if (chamadoEditado != null)
                {
                    TipoChamadoEnum tipoChamadoEnum = (TipoChamadoEnum)Enum.Parse(typeof(TipoChamadoEnum), comboBoxTipoChamado.SelectedItem.ToString());
                    chamadoEditado.TituloChamado = tipoChamadoEnum;
                    DateOnly aberturaChamado = DateOnly.FromDateTime(dateTimePickerChamado.Value);
                    chamadoEditado.DataAbertura = aberturaChamado;
                    string descricaoChamado = richTextBoxChamado.Text;
                    chamadoEditado.DescricaoChamado = descricaoChamado;

                    int idEquipamentoChamado = Convert.ToInt32(textBoxIdEquipamentoChamado.Text);

                    Equipamento equipamento = (Equipamento)repositorioEquipamento.SelecionarPorId(idEquipamentoChamado);

                    chamadoEditado.Equipamento = equipamento;
                    repositorioChamado.Editar(id, chamadoEditado);
                    MessageBox.Show($"Chamado: {chamadoEditado.Id} atualizado com sucesso!");
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
            List<Equipamento> equipamentos = new List<Equipamento>();

            foreach (var registro in repositorioEquipamento.registros)
            {
                equipamentos.Add(registro as Equipamento);
            }

            dataGridView1.Rows.Clear();
            foreach (var equipamento in equipamentos)
            {
                dataGridView1.Rows.Add(equipamento.Id, equipamento.Nome, equipamento.Fabricante, equipamento.PrecoAquisicao, equipamento.DataFabricacao, equipamento.NumeroSerie);
            }
        }

        private void AtualizarDataGridViewChamados()
        {
            List<Chamado> chamados = new List<Chamado>();

            foreach (var registro in repositorioChamado.registros)
            {
                chamados.Add(registro as Chamado);
            }

            dataGridView2.Rows.Clear();
            foreach (var chamado in chamados)
            {
                var dataAtual = DateTime.Now.Subtract(chamado.DataAbertura.ToDateTime(TimeOnly.MinValue));
                var equipamentoId = chamado.Equipamento?.Id ?? 0; // Use 0 or another default value
                dataGridView2.Rows.Add(chamado.Id, chamado.TituloChamado,chamado.DescricaoChamado, equipamentoId, chamado.DataAbertura, dataAtual.TotalDays.ToString("F0"));
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
            Equipamento equipamento1 = new("Sidewinder", "Raytheon", 380069, new DateOnly(2022, 5, 1));
            Equipamento equipamento2 = new("Sparrow", "Raytheon", 125000, new DateOnly(2021, 8, 15));
            Equipamento equipamento3 = new("Tomahawk", "Raytheon", 1500000, new DateOnly(2020, 12, 20));
            Equipamento equipamento4 = new("Hellfire", "Lockheed Martin", 110000, new DateOnly(2023, 1, 10));
            Equipamento equipamento5 = new("Javelin", "Lockheed Martin", 178000, new DateOnly(2023, 2, 5));
            Equipamento equipamento6 = new("Stinger", "Raytheon", 38000, new DateOnly(2023, 3, 12));
            Equipamento equipamento7 = new("Patriot", "Raytheon", 10000000, new DateOnly(2023, 4, 18));
            Equipamento equipamento8 = new("AIM-120", "Raytheon", 500000, new DateOnly(2023, 5, 25));
            Equipamento equipamento9 = new("AIM-9", "Raytheon", 200000, new DateOnly(2023, 6, 30));
            Equipamento equipamento10 = new("AIM-7", "Raytheon", 300000, new DateOnly(2023, 7, 15));
            Equipamento equipamento11 = new("AGM-86", "Boeing", 2000000, new DateOnly(2023, 8, 20)) ;
            Equipamento equipamento12 = new("AGM-114", "Lockheed Martin", 700000, new DateOnly(2023, 9, 25));
            Equipamento equipamento13 = new("AGM-158", "Lockheed Martin", 1200000, new DateOnly(2023, 10, 30));
            Equipamento equipamento14 = new("AGM-65", "Raytheon", 150000, new DateOnly(2023, 11, 5));
            Equipamento equipamento15 = new("AGM-88", "Raytheon", 200000, new DateOnly(2023, 12, 10));
            Equipamento equipamento16 = new("AGM-114R", "Lockheed Martin", 300000, new DateOnly(2024, 1, 15));
            Equipamento equipamento17 = new("AGM-176", "Raytheon", 500000, new DateOnly(2024, 2, 20));
            Equipamento equipamento18 = new("AGM-158B", "Lockheed Martin", 800000, new DateOnly(2024, 3, 25));
            Equipamento equipamento19 = new("AGM-158C", "Lockheed Martin", 1000000, new DateOnly(2024, 4, 30));
            Equipamento equipamento20 = new("AGM-158D", "Lockheed Martin", 1200000, new DateOnly(2024, 5, 5));
            Equipamento equipamento48 = new("AGM-164", "Lockheed Martin", 15000000, new DateOnly(2026, 9, 25));
            Equipamento equipamento49 = new("AGM-165", "Lockheed Martin", 15500000, new DateOnly(2026, 10, 30));
            Equipamento equipamento50 = new("AGM-166", "Lockheed Martin", 16000000, new DateOnly(2026, 11, 5));
            repositorioEquipamento.Inserir(equipamento1);
            repositorioEquipamento.Inserir(equipamento2);
            repositorioEquipamento.Inserir(equipamento3);
            repositorioEquipamento.Inserir(equipamento4);
            repositorioEquipamento.Inserir(equipamento5);
            repositorioEquipamento.Inserir(equipamento6);
            repositorioEquipamento.Inserir(equipamento7);
            repositorioEquipamento.Inserir(equipamento8);
            repositorioEquipamento.Inserir(equipamento9);
            repositorioEquipamento.Inserir(equipamento10);
            repositorioEquipamento.Inserir(equipamento11);
            repositorioEquipamento.Inserir(equipamento12);
            repositorioEquipamento.Inserir(equipamento13);
            repositorioEquipamento.Inserir(equipamento14);
            repositorioEquipamento.Inserir(equipamento15);
            repositorioEquipamento.Inserir(equipamento16);
            repositorioEquipamento.Inserir(equipamento17);
            repositorioEquipamento.Inserir(equipamento18);
            repositorioEquipamento.Inserir(equipamento19);
            repositorioEquipamento.Inserir(equipamento20);
            repositorioEquipamento.Inserir(equipamento48);
            repositorioEquipamento.Inserir(equipamento49);
            repositorioEquipamento.Inserir(equipamento50);
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
            PopularControlesEquipamento(repositorioEquipamento.registros[e.RowIndex] as Equipamento);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesChamado(repositorioChamado.registros[e.RowIndex] as Chamado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormFabricantes(repositorioFabricante, repositorioEquipamento).ShowDialog();
        }

        private void CargaInicialFabricantes()
        {
            Fabricante fabricante1 = new("Raytheon", "69696", "raytheondefence@raytheon.com");
            Fabricante fabricante2 = new("Lockheed Martin", "420420", "lockheedmartin@lockheedmartin.com");
            Fabricante fabricante3 = new("Boeing", "24242", "boeingindustries@boeing.com");
            repositorioFabricante.Inserir(fabricante1);
            repositorioFabricante.Inserir(fabricante2);
            repositorioFabricante.Inserir(fabricante3);
        }

        private void AtualizarQuantidadeEquipamentosFabricantes()
        {
            List<Equipamento> equipamentos = repositorioEquipamento.registros
                .Cast<Equipamento>()
                .ToList();

            List<Fabricante> fabricantes = repositorioFabricante.registros
                .Cast<Fabricante>()
                .ToList();

            foreach (var fabricante in fabricantes)
            {
                fabricante.AtualizarQuantidadeEquipamentos(equipamentos);
            }
        }
        private void comboBoxFabricante_MouseClick(object sender, MouseEventArgs e)
        {
            InicializarComboBoxFabricantes();
        }

        // Example helper method to update related data or UI
        private void AtualizarEquipamentosDoFabricante(string fabricante)
        {
            // Filter and display equipment related to the selected manufacturer
            var equipamentos = repositorioEquipamento.registros
                .Cast<Equipamento>()
                .ToList();

            dataGridView1.Rows.Clear();
            foreach (var equipamento in equipamentos)
            {
                dataGridView1.Rows.Add(equipamento.Id, equipamento.Nome, equipamento.Fabricante, equipamento.PrecoAquisicao, equipamento.DataFabricacao, equipamento.NumeroSerie);
            }
        }

    }
}
