namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private ComboBox cmbAlgorithm;
        private TextBox txtKey;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnLoadFile;
        private Button btnSaveFile;
        private Button btnClearInput;
        private Button btnClearOutput;
        private Label lblStatus;
        private Label lblAlgorithm;
        private Label lblKey;
        private Label lblInput;
        private Label lblOutput;

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
            cmbAlgorithm = new ComboBox();
            txtKey = new TextBox();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnLoadFile = new Button();
            btnSaveFile = new Button();
            btnClearInput = new Button();
            btnClearOutput = new Button();
            lblAlgorithm = new Label();
            lblKey = new Label();
            lblInput = new Label();
            lblOutput = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.Items.AddRange(new object[] { "Децимация (английский)", "Виженер (русский)" });
            cmbAlgorithm.Location = new Point(130, 20);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(489, 31);
            cmbAlgorithm.TabIndex = 1;
            cmbAlgorithm.SelectedIndex = 0;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(130, 70);
            txtKey.Name = "txtKey";
            txtKey.PlaceholderText = "Введите ключ (число для децимации, слово для Виженера)";
            txtKey.Size = new Size(489, 30);
            txtKey.TabIndex = 5;
            // 
            // txtInput
            // 
            txtInput.AcceptsReturn = true;
            txtInput.AcceptsTab = true;
            txtInput.Location = new Point(20, 150);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(960, 200);
            txtInput.TabIndex = 7;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.WhiteSmoke;
            txtOutput.Location = new Point(20, 400);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(960, 200);
            txtOutput.TabIndex = 9;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.LightGreen;
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.Location = new Point(20, 620);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(150, 48);
            btnEncrypt.TabIndex = 10;
            btnEncrypt.Text = "Зашифровать";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.LightBlue;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Location = new Point(180, 620);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(150, 48);
            btnDecrypt.TabIndex = 11;
            btnDecrypt.Text = "Расшифровать";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.LightYellow;
            btnLoadFile.FlatStyle = FlatStyle.Flat;
            btnLoadFile.Location = new Point(340, 620);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(150, 48);
            btnLoadFile.TabIndex = 12;
            btnLoadFile.Text = "Загрузить файл";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.LightCoral;
            btnSaveFile.FlatStyle = FlatStyle.Flat;
            btnSaveFile.Location = new Point(500, 620);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(150, 48);
            btnSaveFile.TabIndex = 13;
            btnSaveFile.Text = "Сохранить файл";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnClearInput
            // 
            btnClearInput.BackColor = Color.LightGray;
            btnClearInput.FlatStyle = FlatStyle.Flat;
            btnClearInput.Location = new Point(660, 620);
            btnClearInput.Name = "btnClearInput";
            btnClearInput.Size = new Size(150, 48);
            btnClearInput.TabIndex = 14;
            btnClearInput.Text = "Очистить ввод";
            btnClearInput.UseVisualStyleBackColor = false;
            btnClearInput.Click += btnClearInput_Click;
            // 
            // btnClearOutput
            // 
            btnClearOutput.BackColor = Color.LightGray;
            btnClearOutput.FlatStyle = FlatStyle.Flat;
            btnClearOutput.Location = new Point(820, 620);
            btnClearOutput.Name = "btnClearOutput";
            btnClearOutput.Size = new Size(160, 48);
            btnClearOutput.TabIndex = 15;
            btnClearOutput.Text = "Очистить результат";
            btnClearOutput.UseCompatibleTextRendering = true;
            btnClearOutput.UseVisualStyleBackColor = false;
            btnClearOutput.Click += btnClearOutput_Click;
            // 
            // lblAlgorithm
            // 
            lblAlgorithm.Location = new Point(20, 20);
            lblAlgorithm.Name = "lblAlgorithm";
            lblAlgorithm.Size = new Size(100, 25);
            lblAlgorithm.TabIndex = 0;
            lblAlgorithm.Text = "Алгоритм:";
            // 
            // lblKey
            // 
            lblKey.Location = new Point(20, 70);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(100, 25);
            lblKey.TabIndex = 4;
            lblKey.Text = "Ключ:";
            // 
            // lblInput
            // 
            lblInput.Location = new Point(20, 120);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(150, 25);
            lblInput.TabIndex = 6;
            lblInput.Text = "Входной текст:";
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(20, 370);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(150, 25);
            lblOutput.TabIndex = 8;
            lblOutput.Text = "Результат:";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(20, 670);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(960, 25);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Готов к работе";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            ClientSize = new Size(1000, 702);
            Controls.Add(lblAlgorithm);
            Controls.Add(cmbAlgorithm);
            Controls.Add(lblKey);
            Controls.Add(txtKey);
            Controls.Add(lblInput);
            Controls.Add(txtInput);
            Controls.Add(lblOutput);
            Controls.Add(txtOutput);
            Controls.Add(btnEncrypt);
            Controls.Add(btnDecrypt);
            Controls.Add(btnLoadFile);
            Controls.Add(btnSaveFile);
            Controls.Add(btnClearInput);
            Controls.Add(btnClearOutput);
            Controls.Add(lblStatus);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Шифрование текста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}