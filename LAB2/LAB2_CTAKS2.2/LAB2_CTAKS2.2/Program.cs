using System;
using System.Numerics;
using System.Text;

class SimpleRSA
{
   
    public static bool IsPrime(BigInteger number)
    {
        if (number < 2) return false;
        for (BigInteger i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    
    public static BigInteger GCD(BigInteger a, BigInteger b)
    {
        while (b != 0)
        {
            BigInteger temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

  
    public static BigInteger ModInverse(BigInteger e, BigInteger phi)
    {
        BigInteger m0 = phi, t, q;
        BigInteger x0 = 0, x1 = 1;

        if (phi == 1)
            return 0;

        while (e > 1)
        {
            q = e / phi;
            t = phi;

            phi = e % phi;
            e = t;
            t = x0;

            x0 = x1 - q * x0;
            x1 = t;
        }

        if (x1 < 0)
            x1 += m0;

        return x1;
    }

    
    public static (BigInteger, BigInteger, BigInteger) GenerateKeys(BigInteger p, BigInteger q, BigInteger e)
    {
        BigInteger n = p * q;
        BigInteger phi = (p - 1) * (q - 1);

        if (GCD(e, phi) != 1)
        {
            throw new Exception("e khong thoa man gcd(e, φ(n)) = 1");
        }

        BigInteger d = ModInverse(e, phi);

        return (n, e, d);
    }

   
    public static BigInteger Encrypt(BigInteger message, BigInteger n, BigInteger e)
    {
        return BigInteger.ModPow(message, e, n);
    }

   
    public static BigInteger Decrypt(BigInteger cipherText, BigInteger n, BigInteger d)
    {
        return BigInteger.ModPow(cipherText, d, n);
    }

    public static BigInteger StringToBigInteger(string message)
    {
        byte[] messageBytes = Encoding.UTF8.GetBytes(message);
        return new BigInteger(messageBytes);
    }

  
    public static string BigIntegerToString(BigInteger number)
    {
        byte[] numberBytes = number.ToByteArray();
        return Encoding.UTF8.GetString(numberBytes).TrimEnd('\0');
    }

    public static string BigIntegerToHex(BigInteger number)
    {
        return number.ToString("X");
    }

   
    public static BigInteger HexToBigInteger(string hex)
    {
        return BigInteger.Parse(hex, System.Globalization.NumberStyles.HexNumber);
    }

    static void Main(string[] args)
    {
        BigInteger p, q, e;

        Console.WriteLine("Nhap gia tri p (so nguyen to) hoac de trong de tu sinh ngau nhien:");
        string inputP = Console.ReadLine();

        Console.WriteLine("Nhap gia tri q (so nguyen to) hoac de trong de tu sinh ngau nhien:");
        string inputQ = Console.ReadLine();

        Console.WriteLine("Nhap gia tri e (khoa cong khai) hoac de trong de tu sinh ngau nhien:");
        string inputE = Console.ReadLine();

        if (string.IsNullOrEmpty(inputP) || string.IsNullOrEmpty(inputQ))
        {
            Random rand = new Random();
            p = BigInteger.Parse("61");
            q = BigInteger.Parse("53");
        }
        else
        {
            p = BigInteger.Parse(inputP);
            q = BigInteger.Parse(inputQ);

            if (!IsPrime(p) || !IsPrime(q))
            {
                Console.WriteLine("p hoac q khong phai la so nguyen to!");
                return;
            }
        }

        if (string.IsNullOrEmpty(inputE))
        {
            e = 17;
        }
        else
        {
            e = BigInteger.Parse(inputE);
        }

        try
        {
            var keys = GenerateKeys(p, q, e);
            BigInteger n = keys.Item1;
            BigInteger publicKey = keys.Item2;
            BigInteger privateKey = keys.Item3;

            Console.WriteLine($"Khoa cong khai (n, e): ({n}, {publicKey})");
            Console.WriteLine($"Khóa bi mat (d): {privateKey}");

            Console.WriteLine("Nhap thong điep can ma hoa (co the la so hoac chuoi):");
            string message = Console.ReadLine();

            BigInteger messageBigInt;
            bool isNumeric = BigInteger.TryParse(message, out messageBigInt);

            if (!isNumeric)
            {
                messageBigInt = StringToBigInteger(message);
            }

          
            BigInteger cipherText = Encrypt(messageBigInt, n, publicKey);
            string cipherTextHex = BigIntegerToHex(cipherText); 
            Console.WriteLine($"Thong diep da ma hoa (dang hexa): {cipherTextHex}");

            
            BigInteger decryptedCipherText = HexToBigInteger(cipherTextHex); 
            BigInteger decryptedMessage = Decrypt(decryptedCipherText, n, privateKey);

            string decryptedText;
            if (!isNumeric)
            {
                decryptedText = BigIntegerToString(decryptedMessage);
            }
            else
            {
                decryptedText = decryptedMessage.ToString();
            }

            Console.WriteLine($"Thong diep da giai ma: {decryptedText}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
    }
}