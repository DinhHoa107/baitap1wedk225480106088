using System;
using System.Collections.Generic;
using System.Text;
using DLL;
namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 cipher = new Class1();

            Console.Write("Nhập chuỗi cần mã hóa: ");
            cipher.PlainText = Console.ReadLine();

            cipher.Encrypt();
            Console.WriteLine("Encrypted: " + cipher.CipherText);

            cipher.Decrypt();
            Console.WriteLine("Decrypted: " + cipher.DecryptedText);

            Console.ReadLine();
        }
    }
}
