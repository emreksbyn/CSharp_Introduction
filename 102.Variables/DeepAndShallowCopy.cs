namespace _102.Variables
{
    // Degiskenler arasi deger atanirken verisel acidan iki davranis soz konusudur :
    // Deep Copy ve Shallow Copy
    public class DeepAndShallowCopy
    {
        public void DeepCopy()
        {
            // Deep Copy ( Derin Kopyalama ) neticesinde eldeki veri cagalir / klonlanir.
            // Deger Turlu degiskenler birbirine atanirken default olarak Deep Copy davranisi gerceklestirir.
            int a = 1;
            int b = a;
            a = a * 5;
            Console.WriteLine(a + " and " + b);
        }

        public void ShallowCopy()
        {
            // Referans turlu degiskenlerin default davranisidir.
            // Degiskenler arasi deger atamalarinda degeri turetmek / cogaltmak / klonlamak yerine var olani birden fazla referans ile isaretlemeye dayali kopyalama yontemidir.
            // Bellekte birden fazla referansin tek bir veriyi isaret etmesidir.
            // Neticesinde iligli deger bir degisiklige ugradiginda, tum isaretleyen referanslara da bu degisiklik yansiyacaktir.
        }
    }
}