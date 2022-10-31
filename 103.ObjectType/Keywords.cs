namespace _103.ObjectType
{
    public class Keywords
    {
        // Compile suresinde / Development asamasinda / derleme asamasinda
        public void VarKeyword()
        {
            // Tutulacak degerin turune uygun bir degisken tanimlayabilmek icin kullanilir.
            // var --> Compiler tarafindan kendisine atanana degerin turu olur.
            // var bir tur DEGILDIR.

            var age = 27;
            // burda var int turunu almistir.

            // Genellikle degiskenlerin turlerini yazmaya usendigimiz icin kullaniriz. Aslında ;
            // Farkli diller arasinda desteklenmeyen turdeki verileri karsilamak icin olusturulmus ortak bir keyword tur.

            // Turunu bilebildigimiz verilerin degisken turlerini var ile compiler a yaptirmak ufakta olsa bir maliyettir. Eger karsilayacagimiz turu biliyorsak o tur ile karsilamaliyiz.

            //var name;  --> hata alir
            // var ile degisken tanimlayacaksak degerini tanimlarken vermemiz gerekir.
            var name = "Emre";
            //name = 67;  --> Sonradan degeri degisecekse ilk degerin turunde degisebilir !!
            name = "Ali";

            // var bir keyword'tur objcet ise bir turdur. var ile tutulan deger dogrudan kendi turunden islemlerde kullanilir. object de ise unboxing islemi gerekir.

        }

        // Uygulama derlenip calistirildiginda / ayaga kalktiginda / runtime
        public void DynamicKeyword()
        {
            // Uzaktan gelen veriler var keywordu ile karsilanamaz. Cunku tanimlandiklari esnada deger isterler. 
            // Bu ihtiyacimizi dynamic keyword u ile karsiliyoruz.

            var yas = 27; // var --> int olmustur.
            yas.ToString(); // yas in ToString() metotu olmasaydı compile aninda hata alirdik.

            dynamic age = 27; // dynamic hala dynamic tir.
            age.ToString(); // age in ToString() metot u varsa runtime da onu cagiracaktir. Yoksa patlatir.

            // dynamic keyword u runtime da turu belirleyecektir fakat kararli davranmayacaktir.
            dynamic name = "Emre";
            Console.WriteLine(name.GetType()); // dynamic {string}
            name = 67;
            Console.WriteLine(name.GetType()); // dynamic {int}

            // runtime da degerini karsilayacagi icin compile aninda deger vermesekte patlatmaz.
            dynamic number; // --> Runtime da turu dynamic {object} olur. Degeri de null olur.
            Console.WriteLine();
        }
    }
}