using _103.ObjectType;

Console.WriteLine();

#region What is object ?
// Tum turleri karsilayabilen bir TUR dur.
// Tum turler varsayilan olarak object ten turerler.
// "object" referans turlu bir degiskendir. Deger turlu degiskenleri de karsilayabilir.
// object degiskenler veriyi RAM da object turde tutarlar. Ama verinin oz turunude icerisinde saklarlar.
// Yani object icerisinde veri kendi oz turunde tutulur. Bu durum object icerisindeki veriyi kendi turunde tekrar elde edebilmemizi saglar.
#endregion

#region Boxing

// object turderki bir degiskene herhangi bir turdeki degeri atamak Boxing islemidir.
object age = 27;
object name = "Emre";
object isActive = true;
object firtLetter = 'a';
// Burada age degeri kendi oz turunde saklanir. Fakat bu age degiskeni artik 28 degerini object turunde getirecektir.
// Dikkat etmemiz gereken yer boxing yapilan deger uzerinde turune ozgu islemler yapilamaz. Yani sayisal bir deger olan 27 uzerinde matematiksel islemler yapamayiz.

#endregion

#region Cast Operator

// Boxing edilmis bir veriyi kendi turunde elde etmemizi saglayan bit operatordur.
// ( ) --> Cast operatoru
// (int)object 
int a = 5;
object b = a; // Boxing
int c = (int)b; // Cast operatoru ile b objesinin degeri c ye int olarak atanmistir.

#endregion

#region UnBoxing

// Boxing edilmis bir veriyi kendi oz turune dondurmeyi saglamaktir.
//Console.WriteLine(age * 5);// --> hata alir

int _age = (int)age; // UnBoxing
Console.WriteLine(_age * 5); // Artik int turunun ozelliklerini kullanabilirim.

// UnBoxing esnasinda, Boxing edilmis verinin orijinal turu ne ise o ture unboxing edilmelidir.
string yas = (string)age;
// Uygulama ayaga kalmadan hata vermez.
// Fakat Compiler edilirken Runtime da bu yukaridaki satir bizi patlatir !!

#endregion

Keywords keywords = new();
keywords.VarKeyword();
keywords.DynamicKeyword();