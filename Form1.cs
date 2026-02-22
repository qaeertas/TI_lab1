using System.Text;

namespace lab1
{
    public partial class Form1 : Form
    {
        private const string EnglishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string RussianAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                string key = txtKey.Text;

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Введите ключ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string result = ProcessText(input, key, true);
                txtOutput.Text = result;
                lblStatus.Text = "Текст зашифрован успешно!";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                string key = txtKey.Text;

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Введите ключ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string result = ProcessText(input, key, false);
                txtOutput.Text = result;
                lblStatus.Text = "Текст расшифрован успешно!";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                ofd.Title = "Выберите файл для загрузки";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string content = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                        txtInput.Text = content;
                        lblStatus.Text = $"Файл загружен: {Path.GetFileName(ofd.FileName)}";
                        lblStatus.ForeColor = Color.Blue;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOutput.Text))
            {
                MessageBox.Show("Нет данных для сохранения!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                sfd.Title = "Сохранить результат";
                sfd.FileName = "result.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, txtOutput.Text, Encoding.UTF8);
                        lblStatus.Text = $"Файл сохранен: {Path.GetFileName(sfd.FileName)}";
                        lblStatus.ForeColor = Color.Blue;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка сохранения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblStatus.Text = "Поле ввода очищено";
            lblStatus.ForeColor = Color.Black;
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            lblStatus.Text = "Поле результата очищено";
            lblStatus.ForeColor = Color.Black;
        }

        private string ProcessText(string input, string key, bool encrypt)
        {
            if (cmbAlgorithm.SelectedIndex == 0) 
            {
                return ProcessDecimation(input, key, encrypt);
            }
            else
            {
                return ProcessVigenere(input, key, encrypt);
            }
        }

        private string ProcessDecimation(string input, string key, bool encrypt)
        {
            if (!int.TryParse(key, out int step))
            {
                throw new ArgumentException("Для метода децимации ключ должен быть целым числом!");
            }

            step = step % EnglishAlphabet.Length;
            if (step == 0) step = 1;

            StringBuilder result = new StringBuilder();
            string upperInput = input.ToUpper();

            foreach (char c in upperInput)
            {
                int index = EnglishAlphabet.IndexOf(c);

                if (index >= 0)
                {
                    if (encrypt)
                    {
                        int newIndex = (index + step) % EnglishAlphabet.Length;
                        result.Append(EnglishAlphabet[newIndex]);
                    }
                    else
                    {
                        int newIndex = (index - step + EnglishAlphabet.Length) % EnglishAlphabet.Length;
                        result.Append(EnglishAlphabet[newIndex]);
                    }
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private string ProcessVigenere(string input, string key, bool encrypt)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Ключ не может быть пустым!");

            string cleanKey = new string(key.ToUpper().Where(c => RussianAlphabet.Contains(c)).ToArray());

            if (string.IsNullOrEmpty(cleanKey))
                throw new ArgumentException("Ключ должен содержать хотя бы одну русскую букву!");

            StringBuilder result = new StringBuilder();
            string upperInput = input.ToUpper();
            int keyIndex = 0;

            foreach (char c in upperInput)
            {
                int charIndex = RussianAlphabet.IndexOf(c);

                if (charIndex >= 0)
                {
                    int keyCharIndex = RussianAlphabet.IndexOf(cleanKey[keyIndex % cleanKey.Length]);

                    int newIndex;
                    if (encrypt)
                    {
                        newIndex = (charIndex + keyCharIndex) % RussianAlphabet.Length;
                    }
                    else
                    {
                        newIndex = (charIndex - keyCharIndex + RussianAlphabet.Length) % RussianAlphabet.Length;
                    }

                    result.Append(RussianAlphabet[newIndex]);
                    keyIndex++;
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}