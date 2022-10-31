using _102.Variables;

/*

Bir yazilimda islenecek veriyi RAM' de tutabilmek icin degiskenler kullanilir.

C# ozelinde RAM de veri tutabilmemiz icin degiskenlerin turu belirtilmelidir.

C# tip guvenli (type safety) bir dildir.

*/


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

// Ondalikli degerlerin default degeri double dir.
float f1 = 3.14f;
float f2 = 3.14F;

double d1 = 3.14; // defaul oldugu icin float yada decimal gibi f yada m gibi eklemeler yapmamiz gerekmez.
double d2 = 3.14d;
double d3 = 3.14D;

decimal m1 = 3.14m;
decimal m2 = 3.14M;

assigningValuesToVariables.DefaultValues();

DeepAndShallowCopy deepAndShallowCopy = new DeepAndShallowCopy();
deepAndShallowCopy.DeepCopy();
