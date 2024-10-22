using System.Numerics;

namespace LAB2_CTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool IsPrimeNumber(BigInteger n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            for (BigInteger i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
            }
            return true;
        }
        static BigInteger GeneratePrime(int bits)
        {
            Random random = new Random();
            BigInteger lowerBound = BigInteger.One << (bits - 1);
            BigInteger upperBound = (BigInteger.One << bits) - 1;
            BigInteger candidate;

            do
            {
                byte[] bytes = new byte[bits / 8];
                random.NextBytes(bytes);
                candidate = new BigInteger(bytes);

                if (candidate < lowerBound) candidate += lowerBound;
                if (candidate > upperBound) candidate = upperBound;
            } while (!IsPrimeNumber(candidate));

            return candidate;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tb8.Text = GeneratePrime(8).ToString();
            tb16.Text = GeneratePrime(16).ToString();
            tb64.Text = GeneratePrime(64).ToString();
        }

        static BigInteger MersennePrimesNumber(int i)
        {
            BigInteger primes = (BigInteger.One << i) - 1;
            return primes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<BigInteger> primes = new List<BigInteger>();

            for (int i = 1; i <= 10; i++)
            {
                BigInteger mersennePrime = MersennePrimesNumber(i);

                for (int j = 1; j <= 100; j++)
                {
                    BigInteger candidate = mersennePrime - j;
                    if (IsPrimeNumber(candidate))
                    {
                        primes.Add(candidate);
                        break; 
                    }
                }
            }

            foreach (BigInteger prime in primes)
            {
                listBox2.Items.Add(prime);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvMersenne.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                BigInteger mersennePrime = MersennePrimesNumber(i);
                lvMersenne.Items.Add(mersennePrime.ToString());
            }
        }
        static bool CheckPrimeNumberUnder2mu9(BigInteger n)
        {
            BigInteger total = (BigInteger.One << 89) - 1;
            if (n > total)
            {
                MessageBox.Show("Vui long nhap so nho hon 2^89 - 1");
                return false;
            }

            return IsPrimeNumber(n);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(tbCheck.Text, out BigInteger number))
            {

                bool isPrime = CheckPrimeNumberUnder2mu9(number);
                if (isPrime && number <= ((BigInteger.One << 89) - 1))
                {
                    MessageBox.Show($"{number} là số nguyên tố.");
                }
                else if (number <= ((BigInteger.One << 89) - 1))
                {
                    MessageBox.Show($"{number} không phải là số nguyên tố.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }
        static BigInteger GcdLarge(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        private void btnLook_Click(object sender, EventArgs e)
        {
            if ((BigInteger.TryParse(tbfirstnumber.Text, out BigInteger number1)) && (BigInteger.TryParse(tbsecondnumber.Text, out BigInteger number2)))
            {
                BigInteger gcdKetQua = GcdLarge(number1, number2);
                tbKetQua.Text = gcdKetQua.ToString();
            }

        }
        static BigInteger ModularExponentiation(BigInteger a, BigInteger x, BigInteger p)
        {
            BigInteger result = 1;
            a = a % p;
            while (x > 0)
            {
                if (x % 2 == 1)
                {
                    result = (result * a) % p;
                }
                x = x >> 1;
                a = (a * a) % p;
            }
            return result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((BigInteger.TryParse(tbA.Text, out BigInteger number1)) && (BigInteger.TryParse(tbX.Text, out BigInteger number2)) && (BigInteger.TryParse(tbB.Text, out BigInteger number3)))
            {
                BigInteger result = ModularExponentiation(number1, number2, number3);
                tbResult.Text = result.ToString();
            }    
        }
    }

}
