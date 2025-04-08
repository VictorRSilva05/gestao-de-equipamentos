namespace GestãoDeEquipamentos.WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBoxPreco = new TextBox();
            label6 = new Label();
            textBoxNome = new TextBox();
            textBoxId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePickerDataFabricacao = new DateTimePicker();
            buttonLimpar = new Button();
            buttonSalvar = new Button();
            buttonAtualizar = new Button();
            buttonDeletar = new Button();
            comboBoxFabricante = new ComboBox();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            label14 = new Label();
            dateTimePickerChamado = new DateTimePicker();
            label9 = new Label();
            comboBoxTipoChamado = new ComboBox();
            buttonDeletarChamado = new Button();
            buttonAtualizarChamado = new Button();
            buttonSalvarChamado = new Button();
            buttonLimparChamado = new Button();
            textBoxIdEquipamentoChamado = new TextBox();
            textBoxIdChamado = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            richTextBoxChamado = new RichTextBox();
            label15 = new Label();
            button1 = new Button();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(682, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 609);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Orbitron", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(682, 97);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 1;
            label1.Text = "Estoque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Orbitron", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(552, 46);
            label2.TabIndex = 2;
            label2.Text = "Controle de equipamentos";
            // 
            // textBoxPreco
            // 
            textBoxPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPreco.Location = new Point(383, 3);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(118, 29);
            textBoxPreco.TabIndex = 9;
            textBoxPreco.KeyPress += textBoxPreco_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(259, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 38);
            label6.TabIndex = 8;
            label6.Text = "Preço equipamento:";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNome.Location = new Point(127, 50);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(118, 29);
            textBoxNome.TabIndex = 6;
            // 
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxId.Location = new Point(127, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(118, 29);
            textBoxId.TabIndex = 5;
            textBoxId.KeyPress += textBoxId_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 47);
            label4.Name = "label4";
            label4.Size = new Size(116, 38);
            label4.TabIndex = 1;
            label4.Text = "Nome equipamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 38);
            label3.TabIndex = 0;
            label3.Text = "ID equipmento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 94);
            label5.Name = "label5";
            label5.Size = new Size(116, 38);
            label5.TabIndex = 4;
            label5.Text = "Fabricante equipamento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(259, 47);
            label7.Name = "label7";
            label7.Size = new Size(99, 38);
            label7.TabIndex = 10;
            label7.Text = "Data de fabricação:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5625F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.Controls.Add(dateTimePickerDataFabricacao, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxId, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxNome, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxPreco, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonLimpar, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonSalvar, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonAtualizar, 2, 4);
            tableLayoutPanel1.Controls.Add(buttonDeletar, 3, 4);
            tableLayoutPanel1.Controls.Add(comboBoxFabricante, 1, 2);
            tableLayoutPanel1.Location = new Point(30, 159);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(621, 212);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dateTimePickerDataFabricacao
            // 
            dateTimePickerDataFabricacao.Location = new Point(383, 50);
            dateTimePickerDataFabricacao.Name = "dateTimePickerDataFabricacao";
            dateTimePickerDataFabricacao.Size = new Size(235, 23);
            dateTimePickerDataFabricacao.TabIndex = 4;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.DeepSkyBlue;
            buttonLimpar.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpar.Location = new Point(3, 173);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(112, 35);
            buttonLimpar.TabIndex = 12;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Green;
            buttonSalvar.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvar.Location = new Point(127, 173);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(112, 35);
            buttonSalvar.TabIndex = 13;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = Color.Yellow;
            buttonAtualizar.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizar.Location = new Point(259, 173);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(105, 35);
            buttonAtualizar.TabIndex = 13;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = false;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonDeletar
            // 
            buttonDeletar.BackColor = Color.Red;
            buttonDeletar.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletar.Location = new Point(383, 173);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(112, 35);
            buttonDeletar.TabIndex = 14;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = false;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // comboBoxFabricante
            // 
            comboBoxFabricante.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFabricante.Font = new Font("Segoe UI", 12F);
            comboBoxFabricante.FormattingEnabled = true;
            comboBoxFabricante.Location = new Point(127, 97);
            comboBoxFabricante.Name = "comboBoxFabricante";
            comboBoxFabricante.Size = new Size(121, 29);
            comboBoxFabricante.TabIndex = 15;
            comboBoxFabricante.SelectedIndexChanged += comboBoxFabricante_SelectedIndexChanged;
            comboBoxFabricante.MouseClick += comboBoxFabricante_MouseClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1299, 159);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(585, 609);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Orbitron", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1313, 97);
            label8.Name = "label8";
            label8.Size = new Size(454, 46);
            label8.TabIndex = 5;
            label8.Text = "Chamados em aberto";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Orbitron", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(12, 476);
            label14.Name = "label14";
            label14.Size = new Size(477, 46);
            label14.TabIndex = 7;
            label14.Text = "Controle de chamados";
            // 
            // dateTimePickerChamado
            // 
            dateTimePickerChamado.Location = new Point(380, 3);
            dateTimePickerChamado.Name = "dateTimePickerChamado";
            dateTimePickerChamado.Size = new Size(237, 23);
            dateTimePickerChamado.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(259, 0);
            label9.Name = "label9";
            label9.Size = new Size(112, 38);
            label9.TabIndex = 10;
            label9.Text = "Abertura do chamado:";
            // 
            // comboBoxTipoChamado
            // 
            comboBoxTipoChamado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoChamado.FormattingEnabled = true;
            comboBoxTipoChamado.Location = new Point(127, 45);
            comboBoxTipoChamado.Name = "comboBoxTipoChamado";
            comboBoxTipoChamado.Size = new Size(118, 29);
            comboBoxTipoChamado.TabIndex = 15;
            // 
            // buttonDeletarChamado
            // 
            buttonDeletarChamado.BackColor = Color.Red;
            buttonDeletarChamado.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletarChamado.Location = new Point(380, 200);
            buttonDeletarChamado.Name = "buttonDeletarChamado";
            buttonDeletarChamado.Size = new Size(112, 35);
            buttonDeletarChamado.TabIndex = 14;
            buttonDeletarChamado.Text = "Fechar";
            buttonDeletarChamado.UseVisualStyleBackColor = false;
            buttonDeletarChamado.Click += buttonDeletarChamado_Click;
            // 
            // buttonAtualizarChamado
            // 
            buttonAtualizarChamado.BackColor = Color.Yellow;
            buttonAtualizarChamado.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizarChamado.Location = new Point(259, 200);
            buttonAtualizarChamado.Name = "buttonAtualizarChamado";
            buttonAtualizarChamado.Size = new Size(105, 35);
            buttonAtualizarChamado.TabIndex = 13;
            buttonAtualizarChamado.Text = "Atualizar";
            buttonAtualizarChamado.UseVisualStyleBackColor = false;
            buttonAtualizarChamado.Click += buttonAtualizarChamado_Click;
            // 
            // buttonSalvarChamado
            // 
            buttonSalvarChamado.BackColor = Color.Green;
            buttonSalvarChamado.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvarChamado.Location = new Point(127, 200);
            buttonSalvarChamado.Name = "buttonSalvarChamado";
            buttonSalvarChamado.Size = new Size(112, 35);
            buttonSalvarChamado.TabIndex = 13;
            buttonSalvarChamado.Text = "Abrir";
            buttonSalvarChamado.UseVisualStyleBackColor = false;
            buttonSalvarChamado.Click += buttonSalvarChamado_Click;
            // 
            // buttonLimparChamado
            // 
            buttonLimparChamado.BackColor = Color.DeepSkyBlue;
            buttonLimparChamado.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparChamado.Location = new Point(3, 200);
            buttonLimparChamado.Name = "buttonLimparChamado";
            buttonLimparChamado.Size = new Size(112, 35);
            buttonLimparChamado.TabIndex = 12;
            buttonLimparChamado.Text = "Limpar";
            buttonLimparChamado.UseVisualStyleBackColor = false;
            buttonLimparChamado.Click += buttonLimparChamado_Click;
            // 
            // textBoxIdEquipamentoChamado
            // 
            textBoxIdEquipamentoChamado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIdEquipamentoChamado.Location = new Point(127, 84);
            textBoxIdEquipamentoChamado.Name = "textBoxIdEquipamentoChamado";
            textBoxIdEquipamentoChamado.Size = new Size(118, 29);
            textBoxIdEquipamentoChamado.TabIndex = 7;
            // 
            // textBoxIdChamado
            // 
            textBoxIdChamado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIdChamado.Location = new Point(127, 3);
            textBoxIdChamado.Name = "textBoxIdChamado";
            textBoxIdChamado.Size = new Size(118, 29);
            textBoxIdChamado.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 42);
            label12.Name = "label12";
            label12.Size = new Size(87, 38);
            label12.TabIndex = 1;
            label12.Text = "Tipo do chamado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 38);
            label11.TabIndex = 0;
            label11.Text = "ID do chamado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 81);
            label10.Name = "label10";
            label10.Size = new Size(116, 38);
            label10.TabIndex = 4;
            label10.Text = "ID do equipamento:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4375F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5625F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutPanel2.Controls.Add(label10, 0, 2);
            tableLayoutPanel2.Controls.Add(label11, 0, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxIdChamado, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxIdEquipamentoChamado, 1, 2);
            tableLayoutPanel2.Controls.Add(buttonLimparChamado, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonSalvarChamado, 1, 4);
            tableLayoutPanel2.Controls.Add(buttonAtualizarChamado, 2, 4);
            tableLayoutPanel2.Controls.Add(buttonDeletarChamado, 3, 4);
            tableLayoutPanel2.Controls.Add(comboBoxTipoChamado, 1, 1);
            tableLayoutPanel2.Controls.Add(label9, 2, 0);
            tableLayoutPanel2.Controls.Add(dateTimePickerChamado, 3, 0);
            tableLayoutPanel2.Controls.Add(richTextBoxChamado, 3, 3);
            tableLayoutPanel2.Controls.Add(label15, 2, 3);
            tableLayoutPanel2.Location = new Point(30, 523);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51.7241364F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.2758636F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.Size = new Size(621, 261);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // richTextBoxChamado
            // 
            richTextBoxChamado.Location = new Point(380, 122);
            richTextBoxChamado.Name = "richTextBoxChamado";
            richTextBoxChamado.Size = new Size(238, 72);
            richTextBoxChamado.TabIndex = 16;
            richTextBoxChamado.Text = "";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(259, 119);
            label15.Name = "label15";
            label15.Size = new Size(111, 38);
            label15.TabIndex = 17;
            label15.Text = "Descrição do chamado:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(289, 395);
            button1.Name = "button1";
            button1.Size = new Size(236, 35);
            button1.TabIndex = 13;
            button1.Text = "Fabricantes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(30, 403);
            label13.Name = "label13";
            label13.Size = new Size(201, 19);
            label13.TabIndex = 14;
            label13.Text = "Controle de fabricantes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBoxPreco;
        private Label label6;
        private TextBox textBoxNome;
        private TextBox textBoxId;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAtualizar;
        private Button buttonLimpar;
        private Button buttonDeletar;
        private Button buttonSalvar;
        private DateTimePicker dateTimePickerDataFabricacao;
        private DataGridView dataGridView2;
        private Label label8;
        private Label label14;
        private DateTimePicker dateTimePickerChamado;
        private Label label9;
        private ComboBox comboBoxTipoChamado;
        private Button buttonDeletarChamado;
        private Button buttonAtualizarChamado;
        private Button buttonSalvarChamado;
        private Button buttonLimparChamado;
        private TextBox textBoxIdEquipamentoChamado;
        private TextBox textBoxIdChamado;
        private Label label12;
        private Label label11;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox richTextBoxChamado;
        private Label label15;
        private Button button1;
        private Label label13;
        private ComboBox comboBoxFabricante;
    }
}
