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
            textBoxFabricante = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(720, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(657, 550);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(682, 97);
            label1.Name = "label1";
            label1.Size = new Size(167, 44);
            label1.TabIndex = 1;
            label1.Text = "Estoque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(425, 44);
            label2.TabIndex = 2;
            label2.Text = "Registrar equipamento";
            // 
            // textBoxPreco
            // 
            textBoxPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPreco.Location = new Point(380, 3);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(118, 29);
            textBoxPreco.TabIndex = 9;
            textBoxPreco.KeyPress += textBoxPreco_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(259, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 38);
            label6.TabIndex = 8;
            label6.Text = "Preço equipamento:";
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFabricante.Location = new Point(121, 85);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(118, 29);
            textBoxFabricante.TabIndex = 7;
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNome.Location = new Point(121, 44);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(118, 29);
            textBoxNome.TabIndex = 6;
            // 
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxId.Location = new Point(121, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(118, 29);
            textBoxId.TabIndex = 5;
            textBoxId.KeyPress += textBoxId_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 41);
            label4.Name = "label4";
            label4.Size = new Size(109, 41);
            label4.TabIndex = 1;
            label4.Text = "Nome equipamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 38);
            label3.TabIndex = 0;
            label3.Text = "ID equipmento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 82);
            label5.Name = "label5";
            label5.Size = new Size(109, 43);
            label5.TabIndex = 4;
            label5.Text = "Fabricante equipamento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(259, 41);
            label7.Name = "label7";
            label7.Size = new Size(95, 38);
            label7.TabIndex = 10;
            label7.Text = "Data de fabricação:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.037735F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.962265F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutPanel1.Controls.Add(dateTimePickerDataFabricacao, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxId, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxNome, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxFabricante, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxPreco, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonLimpar, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonSalvar, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonAtualizar, 2, 4);
            tableLayoutPanel1.Controls.Add(buttonDeletar, 3, 4);
            tableLayoutPanel1.Location = new Point(30, 159);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(621, 294);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dateTimePickerDataFabricacao
            // 
            dateTimePickerDataFabricacao.Location = new Point(380, 44);
            dateTimePickerDataFabricacao.Name = "dateTimePickerDataFabricacao";
            dateTimePickerDataFabricacao.Size = new Size(237, 23);
            dateTimePickerDataFabricacao.TabIndex = 4;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.DeepSkyBlue;
            buttonLimpar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpar.Location = new Point(3, 161);
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
            buttonSalvar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvar.Location = new Point(121, 161);
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
            buttonAtualizar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAtualizar.Location = new Point(259, 161);
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
            buttonDeletar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletar.Location = new Point(380, 161);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(112, 35);
            buttonDeletar.TabIndex = 14;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = false;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBoxPreco;
        private Label label6;
        private TextBox textBoxFabricante;
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
    }
}
