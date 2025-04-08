namespace GestãoDeEquipamentos.WinFormsApp.Apresentacao
{
    partial class FormFabricantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxQtd = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxId = new TextBox();
            textBoxNome = new TextBox();
            label6 = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            textBoxEmail = new TextBox();
            buttonLimpar = new Button();
            buttonSalvar = new Button();
            buttonAtualizar = new Button();
            buttonDeletar = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5625F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.Controls.Add(textBoxQtd, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxId, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxNome, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(maskedTextBoxTelefone, 3, 0);
            tableLayoutPanel1.Controls.Add(textBoxEmail, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonLimpar, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonSalvar, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonAtualizar, 2, 3);
            tableLayoutPanel1.Controls.Add(buttonDeletar, 3, 3);
            tableLayoutPanel1.Location = new Point(12, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(621, 172);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // textBoxQtd
            // 
            textBoxQtd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxQtd.Location = new Point(135, 89);
            textBoxQtd.Name = "textBoxQtd";
            textBoxQtd.Size = new Size(118, 29);
            textBoxQtd.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 86);
            label5.Name = "label5";
            label5.Size = new Size(126, 38);
            label5.TabIndex = 17;
            label5.Text = "Qtd equipamentos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(259, 43);
            label7.Name = "label7";
            label7.Size = new Size(95, 38);
            label7.TabIndex = 10;
            label7.Text = "Email fabricante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 0;
            label3.Text = "ID fabricante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 43);
            label4.Name = "label4";
            label4.Size = new Size(95, 38);
            label4.TabIndex = 1;
            label4.Text = "Nome fabricante:";
            // 
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxId.Location = new Point(135, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(118, 29);
            textBoxId.TabIndex = 5;
            textBoxId.KeyPress += textBoxId_KeyPress;
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNome.Location = new Point(135, 46);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(118, 29);
            textBoxNome.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Orbitron", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(259, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 38);
            label6.TabIndex = 8;
            label6.Text = "Telefone equipamento:";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Font = new Font("Segoe UI", 12F);
            maskedTextBoxTelefone.Location = new Point(383, 3);
            maskedTextBoxTelefone.Mask = "(99) 000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(235, 29);
            maskedTextBoxTelefone.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(383, 46);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(235, 29);
            textBoxEmail.TabIndex = 16;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.DeepSkyBlue;
            buttonLimpar.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpar.Location = new Point(3, 133);
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
            buttonSalvar.Location = new Point(135, 133);
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
            buttonAtualizar.Location = new Point(259, 133);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(105, 35);
            buttonAtualizar.TabIndex = 13;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = false;
            // 
            // buttonDeletar
            // 
            buttonDeletar.BackColor = Color.Red;
            buttonDeletar.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletar.Location = new Point(383, 133);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(112, 35);
            buttonDeletar.TabIndex = 14;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Orbitron", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 22);
            label2.Name = "label2";
            label2.Size = new Size(500, 46);
            label2.TabIndex = 5;
            label2.Text = "Controle de fabricantes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(616, 276);
            dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Orbitron", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 276);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 7;
            label1.Text = "Fabricantes";
            // 
            // FormFabricantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 627);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Name = "FormFabricantes";
            Text = "FormFabricantes";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label label3;
        private Label label4;
        private TextBox textBoxId;
        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
        private Label label6;
        private TextBox textBoxPreco;
        private Label label2;
        private Button buttonLimpar;
        private Button buttonSalvar;
        private Button buttonAtualizar;
        private Button buttonDeletar;
        private MaskedTextBox maskedTextBoxTelefone;
        private TextBox textBoxEmail;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label5;
        private TextBox textBoxQtd;
    }
}