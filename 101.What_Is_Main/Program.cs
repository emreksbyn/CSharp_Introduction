using System;

namespace _101.What_Is_Main
{
    // Uygulamalarda Program.cs dosyasi : Baslangic kodlarinin bulundugu, yani uygulamanin ayaga kalkabilmesi ile ilgili kodlari bulunduran dosyadir.
    internal class Program
    {
        /*
         *  Main fonksiyonu :
         *  1- Sadece 1 tane Main fonksiyonu vardir.
         *  2- Uygulama ayaga kaltiginda isletim sistemiyle iletisim kuracak metottur.
         */
        static void Main(string[] args)
        {
            // " dotnet run emre kisaboyun " --> Developer PowerShell den dosyanin bulundugu dizinde bu kodlari yazip calistirirsak
            // Once Hello World! altinda da emre onun altindada kisaboyun yazar.
            // Isletim sisteminden uygulamaya bu sekilde deger gondermis oluruz.
            Console.WriteLine("Hello World!");
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
        }
    }
}

#region Top - Level Statements Property

//// Top - Level Statements Ozelligi :
//// Microservices yapilanmasinda kodun gelisimi acisindan hiz kazandirici bir nitelige sahiptir.

//using System;


//// C# 9.0 dan sonra bu sekilde kullanima olanak tanindi. --> .Net 6.0 dan sonra yukaridaki using e de gerek kalmamistir.
//Console.WriteLine("Hello World!");
//Console.WriteLine(args[0]);
//Console.WriteLine(args[1]); 
#endregion