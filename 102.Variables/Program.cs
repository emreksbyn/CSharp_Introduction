/*

Bir yazilimda islenecek veriyi RAM' de tutabilmek icin degiskenler kullanilir.

C# ozelinde RAM de veri tutabilmemiz icin degiskenlerin turu belirtilmelidir.

C# tip guvenli (type safety) bir dildir.

*/

#region Value(Deger) Type
// Bir degiskenle RAM de alan aciliyorsa, bu degiskene Deger Turlu degisken denir.
// Sadece bir deger tutarlar. Adimiz, soyadimiz, d.tarihi... 
#endregion

#region Primitive Type
// En ilkel turdur. Olmasi icin baska bir ture ihtiyac duymaz. Ornegin byte..

// IsPrimitive ile turumuzun primitive olup olmadigini kontrol edebiliriz.
using _102.Variables;

Console.WriteLine(typeof(decimal).IsPrimitive);  // false
Console.WriteLine(typeof(int).IsPrimitive);  // true
Console.WriteLine(typeof(byte).IsPrimitive);  // true
#endregion

string name;
int age;

// Yukaridaki gibi bir degisken tanimla yaptigimizda hemen RAM de yerleri tutulmaz. Ne zamanki uygulamayi calistiririz (Runtime) o zaman tutulur.

// Degisken isimleri tanimlanirken PascalCase, camelCase ve Snake_Case olarak genel kabul gormus kurallar vardir bunlara dikkat edilmelidir.

#region PascalCase
// Her kelimenin ilk harfi buyuk olmalidir der.
// Kısaltmalarda kullaniliyorken --> 2 harften olusuyorsa ikiside buyuk olmalidir. (InOut) IOStream
// Sinif, metot ve property isimleri verilirken PascalCase' e uygun olarak verilmelidir.
#endregion

#region camelCase
// Ilk kelimenin ilk harfi kucuk yazilir, diger kelimeler varsa ilk harfleri buyuk yazilir der.
// Degisken ve metot parametrelerini isimleri verilirken bu sekilde verilir.
#endregion

#region _snakeCase
// C# da global tanimlanan field isimlerine verilir.
// private readonly ProductService _productService;
#endregion

// Degisken isimleri programatik keyword iceremez.
//string string; --> Bu hata verir.
// Illaki kullanmam lazim dedigimiz durumlarda @ operatoru kullanilir.
string @string;
// Diger degiskenleri tanimlarken kullansak da bir sorun teskil etmez.
string @surname;


AssigningValuesToVariables assigningValuesToVariables = new AssigningValuesToVariables();
assigningValuesToVariables.AssigningValues();