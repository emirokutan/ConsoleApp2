string ogrno, ad, soyad;
Console.Write("öĞRENCİ NO GİRİNİZ:");
ogrno = Console.ReadLine();
Console.Write("ADINIZI GİRİNİZ:");
ad = Console.ReadLine();
Console.Write("SOYADINIZI GİRİNİZ:");
soyad = Console.ReadLine();
Console.WriteLine("Hoşgeldiniz:" + " " + ad + " " + soyad);
Random random = new Random();
int number = random.Next(1, 500);
Console.WriteLine("Yeni Numaranız = " + number);
Random rastgele = new Random();
string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
string uret = "";
for (int i = 0; i < 6; i++)
{
    uret += harfler[rastgele.Next(harfler.Length)];
}
Console.Write("Yeni Şifreniz Üretildi " + ad + " " + "Bey:" );
Console.Write(uret);
Console.ReadKey();
Console.Read();

// Bilgiler girildikten sonra yeni bir numara ve yeni bir şifre atayan program
//The program that assigns a new number and a new password after the information is entered
