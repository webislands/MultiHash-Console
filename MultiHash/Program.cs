/* Date de Creation : 2022-09-07
 * Mise a jour : 2022-09-09
 * Info: 
 *  Petit programme pour convertir un string en different hash
 *  *
 *  version 0.2
 * -0.1
 *    - entre string affichage resultat
 * -0.2
 *    - Ajout possibilite quitter ,recommencer
 *    - Sauvegarder resultat dans un fichier texte
 *
 * CODER : webislands
 * EMAIl : webislands@gmail.com
 * GITHUB : https://github.com/webislands
 * REPO : https://github.com/webislands/MultiHash-Console
 * 
 * ----------------------------------------------------------------------------
 * "LICENCE BEERWARE" (Révision 42):
 * <webislands@gmail.com> a créé ce fichier. Tant que vous conservez cet avertissement,
 * vous pouvez faire ce que vous voulez de ce truc. Si on se rencontre un jour et
 * que vous pensez que ce truc vaut le coup, vous pouvez me payer une bière en
 * retour. Webislands
 * ----------------------------------------------------------------------------
 */

using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace MultiHash
{
    class Program
    {
         static void Main()
            {
                menu();
            }
         static void menu()//affiche le menu principale et recupere le string a convertir
            {
                string texte;

                Console.Clear();

                banner();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"<String> ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(@" > ");

                texte = Console.ReadLine();

                    if (texte.Length > 0)
                        {
                            hashing(texte);
                            texte.DefaultIfEmpty();
                
                        }
                    else
                        {
                            Console.WriteLine("Imposible convertir,valeur null");
                            Console.WriteLine("Appuyer sur une touche pour recommence");
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                        }     
        }

        static private void banner()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("#####################");
                Console.Write("# ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Hash String  v0.2");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" #");
                Console.WriteLine("#####################");
            }// affiche lentete du menu

        static public void hashing(string txt)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("--------START--------");

            //String
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
               
            // Deplacement ver choix
                choix(txt);
           

            

            
   
        } // execute affichage et converti les hash
        static string base64(string value)
            {
                byte[] conversion = Encoding.UTF8.GetBytes(value);
                return Convert.ToBase64String(conversion);

            }  // converti en Base64

        static string MD5hash(string value)
            {
                using (MD5 md5 = MD5.Create())
                    {
                        byte[] input = Encoding.ASCII.GetBytes(value);
                        byte[] hash = md5.ComputeHash(input);

                        StringBuilder rebuild = new StringBuilder();

                            for (int i = 0; i < hash.Length; i++)
                                {
                                    rebuild.Append(hash[i].ToString("X2"));
                                }
                        return rebuild.ToString();
                    }
            }//converti en MD5

        static string RIPEMD160hash(string value)
            {
                using (RIPEMD160 rip165 = RIPEMD160.Create())
                    {
                        byte[] input = Encoding.ASCII.GetBytes(value);
                        byte[] hash = rip165.ComputeHash(input);

                        StringBuilder rebuild = new StringBuilder();

                            for (int i = 0; i < hash.Length; i++)
                                {
                                    rebuild.Append(hash[i].ToString("X2"));
                                }
                        return rebuild.ToString();
                    }
        }//converti en 

        static string SHA1hash(string value)
            {
                using (SHA1 sha1 = SHA1.Create())
                    {
                        byte[] input = Encoding.ASCII.GetBytes(value);
                        byte[] hash = sha1.ComputeHash(input);

                        StringBuilder rebuild = new StringBuilder();

                            for (int i = 0; i < hash.Length; i++)
                                {
                                    rebuild.Append(hash[i].ToString("X2"));
                                }

                        return rebuild.ToString();
                    }
        }//converti en SHA1
        static string SHA256hash(string value)
            {
                using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] input = Encoding.ASCII.GetBytes(value);
                        byte[] hash = sha256.ComputeHash(input);

                        StringBuilder rebuild = new StringBuilder();

                            for (int i = 0; i < hash.Length; i++)
                                {
                                    rebuild.Append(hash[i].ToString("X2"));
                                }

                        return rebuild.ToString();
                    }
        }//converti en SHA256
        static string SHA384hash(string value)
            {
                using (SHA384 sha384 = SHA384.Create())
                    {
                        byte[] input = Encoding.ASCII.GetBytes(value);
                        byte[] hash = sha384.ComputeHash(input);

                        StringBuilder rebuild = new StringBuilder();

                            for (int i = 0; i < hash.Length; i++)
                                {
                                    rebuild.Append(hash[i].ToString("X2"));
                                }
                        return rebuild.ToString();
                    }
        }//converti en SHA384
        static string SHA512hash(string value)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] input = Encoding.ASCII.GetBytes(value);
                byte[] hash = sha512.ComputeHash(input);

                StringBuilder rebuild = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    rebuild.Append(hash[i].ToString("X2"));
                }
                return rebuild.ToString();
            }
        }//converti en SHA512
        static private void choix(string value)
            {
                string selection;
                Console.WriteLine("(N)ouveaux string,(S)auvegarder,Autre quitte");
                selection = Console.ReadLine();
                    switch (selection)
                        {
                            case "N":
                                Main();
                            break;

                            case "n":
                                Main();
                            break;

                            case "S":
                                sauvegarde(value);
                            break;

                            case "s":
                                sauvegarde(value);
                            break;

                            default:
                                Environment.Exit(0);
                            break;
                            }
        }//affiche menu pour quitter recommence sauvegarder
        static private void sauvegarde(string value)
            {
            string patch = DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
            using (StreamWriter writer = new StreamWriter(patch))
            {
                writer.WriteLine(@"STRING : {0}", value);
                writer.WriteLine(@"BASE64 : {0}",base64(value));
                writer.WriteLine(@"RIPEMD160 : {0}", RIPEMD160hash(value));
                writer.WriteLine(@"SHA1 : {0}", SHA1hash(value));
                writer.WriteLine(@"SHA256 : {0}", SHA256hash(value));
                writer.WriteLine(@"SHA512 : {0}", SHA512hash(value));
            }
            Console.WriteLine("sauvegarde fais {0}", patch);
            choix("");
        }// sauvegarde resulta dans txt

    }
}
