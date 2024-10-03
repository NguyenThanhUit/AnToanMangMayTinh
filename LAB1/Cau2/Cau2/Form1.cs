using System.Text;

namespace Cau2
{
    public partial class Form1 : Form
    {
        private bool isBruteForceRunning = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbShift.Text, out int shift))
            {
                string encryptedText = Encrypt(tbData.Text, shift);
                tbEncryptedData.Text = encryptedText;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị Dịch hơp lệ");
            }
        }

        static string Encrypt(string input, int shift)
        {
            StringBuilder cipherText = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsLower(c))
                    {
                        char shifted = (char)(((c - 'a' + shift) % 26) + 'a');
                        cipherText.Append(shifted);
                    }
                    else if (char.IsUpper(c))
                    {
                        char shifted = (char)(((c - 'A' + shift) % 26) + 'A');
                        cipherText.Append(shifted);
                    }
                }
                else
                {
                    cipherText.Append(c);
                }
            }
            return cipherText.ToString();
        }
        static string Decrypt(string input, int shift)
        {
            StringBuilder plainText = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsLower(c))
                    {
                        char shifted = (char)(((c - 'a' - shift + 26) % 26) + 'a');
                        plainText.Append(shifted);
                    }
                    else if (char.IsUpper(c))
                    {
                        char shifted = (char)(((c - 'A' - shift + 26) % 26) + 'A');
                        plainText.Append(shifted);
                    }
                }
                else
                {
                    plainText.Append(c);
                }
            }
            return plainText.ToString();
        }
        private void btnDencrypt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbShift.Text, out int shift))
            {
                string decryptedText = Decrypt(tbEncryptedData.Text, shift);
                tbDencryptedData.Text = decryptedText;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị Dịch hơp lệ");
            }
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbDelay.Text, out int delay))
            {
                isBruteForceRunning = true;
                btn_start.Enabled = false;
                for (int shift = 0; shift < 26; shift++)
                {
                    if (!isBruteForceRunning) 
                        break;
                    string decryptedText = BruteForceDecrypt(tbData.Text, shift);
                    tbDencryptedData.Text = decryptedText;


                    tbCurrentKey.Text = $"{shift}";


                    await Task.Delay(delay * 1000);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị thời gian hợp lệ.");
            }
        }
        static string BruteForceDecrypt(string input, int shift)
        {
            StringBuilder plainText = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsLower(c))
                    {
                        char shifted = (char)(((c - 'a' - shift + 26) % 26) + 'a');
                        plainText.Append(shifted);
                    }
                    else if (char.IsUpper(c))
                    {
                        char shifted = (char)(((c - 'A' - shift + 26) % 26) + 'A');
                        plainText.Append(shifted);
                    }
                }
                else
                {
                    plainText.Append(c);
                }
            }
            return plainText.ToString();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            isBruteForceRunning = false;
            btn_start.Enabled = true;
        }
    }
}
