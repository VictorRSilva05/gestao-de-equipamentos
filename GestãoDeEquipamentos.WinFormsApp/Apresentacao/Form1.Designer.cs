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
            monthCalendar1 = new MonthCalendar();
            textBoxPrice = new TextBox();
            label6 = new Label();
            textBoxMaker = new TextBox();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonClean = new Button();
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(720, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1053, 550);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(682, 97);
            label1.Name = "label1";
            label1.Size = new Size(158, 44);
            label1.TabIndex = 1;
            label1.Text = "Storage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(371, 44);
            label2.TabIndex = 2;
            label2.Text = "Register Equipment";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(375, 50);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPrice.Location = new Point(369, 3);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(118, 29);
            textBoxPrice.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(258, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 38);
            label6.TabIndex = 8;
            label6.Text = "Equipment price:";
            // 
            // textBoxMaker
            // 
            textBoxMaker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMaker.Location = new Point(127, 85);
            textBoxMaker.Name = "textBoxMaker";
            textBoxMaker.Size = new Size(118, 29);
            textBoxMaker.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(127, 44);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(118, 29);
            textBoxName.TabIndex = 6;
            // 
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxId.Location = new Point(127, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(118, 29);
            textBoxId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 41);
            label4.Name = "label4";
            label4.Size = new Size(96, 38);
            label4.TabIndex = 1;
            label4.Text = "Equipment name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 0;
            label3.Text = "Equipment ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 82);
            label5.Name = "label5";
            label5.Size = new Size(96, 38);
            label5.TabIndex = 4;
            label5.Text = "Equipment maker:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(258, 41);
            label7.Name = "label7";
            label7.Size = new Size(99, 38);
            label7.TabIndex = 10;
            label7.Text = "Fabrication data:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.6274529F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.3725471F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 238F));
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxId, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxName, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxMaker, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxPrice, 3, 0);
            tableLayoutPanel1.Controls.Add(monthCalendar1, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonClean, 0, 6);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 6);
            tableLayoutPanel1.Controls.Add(buttonUpdate, 2, 6);
            tableLayoutPanel1.Controls.Add(buttonDelete, 3, 6);
            tableLayoutPanel1.Location = new Point(30, 159);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(605, 294);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonClean
            // 
            buttonClean.BackColor = Color.DeepSkyBlue;
            buttonClean.Location = new Point(3, 251);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(118, 40);
            buttonClean.TabIndex = 12;
            buttonClean.Text = "Clean";
            buttonClean.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Green;
            buttonSave.Location = new Point(127, 251);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 40);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Yellow;
            buttonUpdate.Location = new Point(258, 251);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(105, 40);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Location = new Point(369, 251);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 40);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
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
        private MonthCalendar monthCalendar1;
        private TextBox textBoxPrice;
        private Label label6;
        private TextBox textBoxMaker;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonUpdate;
        private Button buttonClean;
        private Button buttonDelete;
        private Button buttonSave;
    }
}
