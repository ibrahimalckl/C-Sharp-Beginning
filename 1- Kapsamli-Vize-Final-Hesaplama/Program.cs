using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{

    class Program
    {
        static void Main(string[] args)

        {
            string[] ogrsayidizi = new string[] { " ", "\t", "!", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{ ", "|", " }", "~", "(", ")", "‚", "ƒ", "„", "...", "†", "‡", "ˆ", "‰", "Š", "‹", "Œ", "Ž", "‘", "'", "“", "”", "•", "–", "—", "˜", "™", "š", "›", "œ", "ž", "Ÿ", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "¬", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ğ", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "İ", "Ş", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë" };
            string[] addizi = new string[] { " ", "!", "#", "\t", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "]", "^", "_", "`", "{ ", "|", " }", "~", "(", ")", "‚", "ƒ", "„", "...", "†", "‡", "ˆ", "‰", "‹", "Œ", "‘", "'", "“", "”", "•", "–", "—", "˜", "™", "š", "›", "œ", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "¬", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] soyaddizi = new string[] { " ", "!", "#", "\t", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "]", "^", "_", "`", "{ ", "|", " }", "~", "(", ")", "‚", "ƒ", "„", "...", "†", "‡", "ˆ", "‰", "‹", "Œ", "‘", "'", "“", "”", "•", "–", "—", "˜", "™", "š", "›", "œ", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "¬", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] ogrnodizi = new string[] { " ", "!", "#", "\t", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{ ", "|", " }", "~", "(", ")", "‚", "ƒ", "„", "...", "†", "‡", "ˆ", "‰", "Š", "‹", "Œ", "Ž", "‘", "'", "“", "”", "•", "–", "—", "˜", "™", "š", "›", "œ", "ž", "Ÿ", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "¬", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ğ", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "İ", "Ş", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë" };
            string[] vizedizi = new string[] { " ", "!", "#", "\t", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{ ", "|", " }", "~", "(", ")", "‚", "ƒ", "„", "...", "†", "‡", "ˆ", "‰", "Š", "‹", "Œ", "Ž", "‘", "'", "“", "”", "•", "–", "—", "˜", "™", "š", "›", "œ", "ž", "Ÿ", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "¬", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ğ", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "İ", "Ş", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë" };
            string[] finaldizi = new string[] { " ", "\t", "!", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{ ", "|", " }", "~", "(", ")", "‚", "ƒ", "„", "...", "†", "‡", "ˆ", "‰", "Š", "‹", "Œ", "Ž", "‘", "'", "“", "”", "•", "–", "—", "˜", "™", "š", "›", "œ", "ž", "Ÿ", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "¬", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ğ", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "İ", "Ş", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë" };
  
         a:
            Console.WriteLine("Kac Ogrenci Var: ");
            string ogr = Console.ReadLine();
            
            foreach (string ogrsayisi in ogrsayidizi)
            {
                int sonuc = ogr.IndexOf(ogrsayisi, 0, ogr.Length);
                
                if (sonuc == 0 || string.IsNullOrEmpty(ogr))
                {
                    Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                    goto a;                
                }
            }
            
            bool ogrdonusum = int.TryParse(ogr, out int ogrdonusum1);

                if (ogrdonusum == false || ogr == "0")
                {
                    Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                    goto a;
                }
        
            Console.WriteLine("");
            int a = 0;
            int b = Convert.ToInt32(ogr);

            for (int i = 0; i < b; i++)
            {
                a++;
                Console.WriteLine("{0}. Ogrencinin: \n ", (a));

             b:
                Console.WriteLine("Adinizi Giriniz: ");
                string ad = Console.ReadLine();

                foreach (string adlar in addizi)
                {
                    int sonuc1 = ad.IndexOf(adlar, 0, ad.Length);

                    if (sonuc1 == 0 || string.IsNullOrEmpty(ad))
                    {
                        Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                        goto b;
                    }
                }

                Console.WriteLine("");

             c:
                Console.WriteLine("Soyadini Giriniz: ");
                string soyad = Console.ReadLine();

                foreach (string soyadlar in soyaddizi)
                {
                    int sonuc2 = soyad.IndexOf(soyadlar, 0, soyad.Length);

                    if (sonuc2 == 0 || string.IsNullOrEmpty(soyad))
                    {
                        Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                        goto c;
                    }
                }

                Console.WriteLine("");

             d:
                Console.WriteLine("Ogrenci Numaranizi Giriniz: ");
                string ogrno = Console.ReadLine();

                foreach (string ogrnolar in ogrnodizi)
                {
                    int sonuc3 = ogrno.IndexOf(ogrnolar, 0, ogrno.Length);

                    if (sonuc3 == 0 || string.IsNullOrEmpty(ogrno))
                    {
                        Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                        goto d;
                    }
                }

                bool ogrnobool = int.TryParse(ogrno, out int ogrnobool1);

                if (ogrnobool == false)
                {
                    Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                    goto d;
                }

                Console.WriteLine("");   

             e:
                Console.WriteLine("Vize Notunuzu Giriniz: ");
                string vize = Console.ReadLine();
                
                foreach (string vizeler in vizedizi)
                {
                    int sonuc4 = vize.IndexOf(vizeler, 0, vize.Length);

                    if (sonuc4 == 0 || string.IsNullOrEmpty(vize))
                    {
                        Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                        goto e;
                    }
                }

                bool vizebool = int.TryParse(vize, out int vizebool1);
               
                if (vizebool == false)
                {
                    Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                    goto e;
                }

                if (Convert.ToInt32(vize) > 100 || Convert.ToInt32(vize) < 0)
                {
                    Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                    goto e;
                }

                Console.WriteLine("");

             f:
                Console.WriteLine("Final Notunuzu Giriniz: ");
                string final = Console.ReadLine();

                foreach (string finaller in finaldizi)
                {
                    int sonuc5 = final.IndexOf(finaller, 0, final.Length);

                    if (sonuc5 == 0 || string.IsNullOrEmpty(final))
                    {
                        Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                        goto f;
                    }
                }

                bool finalbool = int.TryParse(final, out int finalbool1);
               
                if (finalbool == false)
                {
                    Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                    goto f;
                }

                if (Convert.ToInt32(final) > 100 || Convert.ToInt32(final) < 0)
                {
                    Console.WriteLine("Lutfen Dogru Deger Girdiginizden Emin Olunuz.\n");
                    goto f;
                }

                Console.WriteLine("");

                int ortalama = (Convert.ToInt32(vize) * 40 / 100) + (Convert.ToInt32(final) * 60 / 100);

                Console.WriteLine("Adiniz: {0}", ad);
                Console.WriteLine("Soyadiniz: {0}", soyad);
                Console.WriteLine("Ogrenci Numaraniz: {0}", ogrno);
                Console.WriteLine("Vize Notunuz: {0}", vize);
                Console.WriteLine("Final Notunuz: {0}", final);
                Console.WriteLine("Ortalamaniz: {0}", ortalama);

                if (ortalama >= 90 && ortalama <= 100)
                {
                    Console.WriteLine("Harf Notunuz: AA\nDurum: Gectin\n");
                }

                if (ortalama >= 80 && ortalama <= 89)
                {
                    Console.WriteLine("Harf Notunuz: BA\nDurum: Gectin\n");
                }

                if (ortalama >= 75 && ortalama <= 79)
                {
                    Console.WriteLine("Harf Notunuz: BB\nDurum: Gectin\n");
                }

                if (ortalama >= 70 && ortalama <= 74)
                {
                    Console.WriteLine("Harf Notunuz: CB\nDurum: Gectin\n");
                }

                if (ortalama >= 60 && ortalama <= 69)
                {
                    Console.WriteLine("Harf Notunuz: CC\nDurum: Gectin\n");
                }

                if (ortalama >= 45 && ortalama <= 59)
                {
                    Console.WriteLine("Harf Notunuz: DC\nDurum: Kosullu Gectin\n");
                }

                if (ortalama >= 40 && ortalama <= 44)
                {
                    Console.WriteLine("Harf Notunuz: DD\nDurum: Kaldin\n");
                }

                if (ortalama >= 30 && ortalama <= 39)
                {
                    Console.WriteLine("Harf Notunuz: FD\nDurum: Kaldin\n");
                }

                if (ortalama <= 29)
                {
                    Console.WriteLine("Harf Notunuz: FF\nDurum: Kaldin\n");
                }
                
            }

                Console.ReadKey();

        }
    }
}

