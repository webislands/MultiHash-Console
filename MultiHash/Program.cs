// Date de Creation : 2022-09-08
// Info: 
//  Petit programme pour convertir un string en different hash
//  version 0.1
//
// CODER : webislands
// EMAIl : webislands@gmail.com
// GITHUB : https://github.com/webislands
// REPO : https://github.com/webislands/MultiHash-Console



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MultiHash
{
    class Program
    {
        static void Main(string[] args)
        {
            string texte;
            banner();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"<String> ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(@" > ");
            texte = Console.ReadLine();
            hashing(texte);
            Console.Read();
  
        }
        static void banner()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("#####################");
            Console.Write("# ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Hash String  v0.1");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" #");
            Console.WriteLine("#####################");

        }

        public static void hashing(string txt)
        {
           
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("--------START--------");


            Console.WriteLine(@"<String>");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(txt);

            //Base64
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"<BASE64>");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(base64(txt));

            //MD5
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"<MD5>");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(MD5hash(txt));

            //RIPEMD160
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"<RIPEMD160>");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(RIPEMD160hash(txt));

            //SHA1
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"<SHA1>");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(SHA1hash(txt));

            //SHA256
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"<SHA256>");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(SHA256hash(txt));

            //SHA384
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"<SHA384>");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(SHA384hash(txt));

            //SHA512
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"<SHA512>");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(SHA512hash(txt));

            //END
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("---------END---------");



            string base64(string value)
                {
                    byte[] conversion = Encoding.UTF8.GetBytes(value);
                    return Convert.ToBase64String(conversion);

                }

            string MD5hash(string value)
                {
                    using (MD5 md5 = MD5.Create())
                        {
                            byte[] input = Encoding.ASCII.GetBytes(value);
                            byte[] hash = md5.ComputeHash(input);

                            StringBuilder sb = new StringBuilder();

                            for (int i = 0; i < hash.Length; i++)
                                {
                                    sb.Append(hash[i].ToString("X2"));
                                }
                        return sb.ToString();
                        }
               
                }

            string RIPEMD160hash (string value)
                {
                    using (RIPEMD160 rip165 = RIPEMD160.Create())
                        {
                            byte[] input = Encoding.ASCII.GetBytes(value);
                            byte[] hash = rip165.ComputeHash(input);

                            StringBuilder sb = new StringBuilder();

                            for (int i = 0; i < hash.Length; i++)
                                {
                                    sb.Append(hash[i].ToString("X2"));
                                }
                            return sb.ToString();
                        }
                }

            string SHA1hash(string value)
            {
                using (SHA1 sha1 = SHA1.Create())
                {
                    byte[] input = Encoding.ASCII.GetBytes(value);
                    byte[] hash = sha1.ComputeHash(input);

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            }

            string SHA256hash(string value)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] input = Encoding.ASCII.GetBytes(value);
                    byte[] hash = sha256.ComputeHash(input);

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            }

            string SHA384hash(string value)
            {
                using (SHA384 sha384 = SHA384.Create())
                {
                    byte[] input = Encoding.ASCII.GetBytes(value);
                    byte[] hash = sha384.ComputeHash(input);

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            }

            string SHA512hash(string value)
            {
                using (SHA512 sha512 = SHA512.Create())
                {
                    byte[] input = Encoding.ASCII.GetBytes(value);
                    byte[] hash = sha512.ComputeHash(input);

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            }




        }

    }
}
