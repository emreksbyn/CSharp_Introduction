namespace _102.Variables
{

    public class AssigningValuesToVariables
    {
        string name = "Emre";
        public void AssigningValues()
        {
            string lastname = "Kisaboyun";

            void Metot()
            {
                // Ust scope da tanimlanan degiskene alt scope da da erisebiliriz.
                name = "Ali";
                lastname = "Veli";
                int age = 27;
            }
            // Fakat alt scope da tanimlanan bir degiskene ust scobunda erisemeyiz !!
            //age = 1;

            #region Tanimladiktan Sonra Deger Atama

            int number; // --> Burada atama yapilmadan once int tipine ozel olarak number degeri 0 dir.
            //....
            //

            // Burada oldugu gibi " = " ( assignment operator ) un solunda degisken cagiriliyorsa degiskenin kendisi(bellek adresi) gelir.
            number = 67; // Artik burada degiskene 67 degeri atanmis olur.

            // Fakat saginda cagirirsak degiskenin degeri gelmis olur.
            string output = number.ToString();
            // Metot da kullanirsak da degiskenin degeri gelir.
            Console.WriteLine(output);

            #endregion

            #region Tuple Turuyle Deger Atama (_a, _b) = (a, b)

            // Tek bir syntax uzerinden fazla degisken tanimlamamizi saglayan NESNE dir.
            // ( int a, int b, type c, type d ... ) z;
            // Tuple degisken olan z icerisinde int, int, type vs. olmak uzere birden fazla degisken tanimi mevcuttur.
            (int age, string name) tuple = (27, "emre");
            tuple.name = "ali";

            #endregion

            #region Literal Duzenlemeler (C# 7.0)

            // Kompleks sayisal ifadeleri _ ile duzenlememizi saglar. Istedimiz yere koyabiliriz hata vermez.
            // Fakat kolay okunulabilir olmasi icin asagidaki gibi kullanmak mantikli olandir.
            int litetal = 1_000_000;
            Console.WriteLine();
            #endregion

            #region Default Literals (C# 7.1)

            //bool x = default;
            //decimal y = default;

            #endregion

        }

        public void DefaultValues()
        {
            /*
    
            Degiskenlerin turlerine gore default degerleri vardir.
            * Class tanimlamasi yapildiginda icerisindeki degiskenlerin default degeri atanir.
            * Metot icerisinde tanimlanan degiskenlerde ilk deger manuel verilmelidir.

            string --> null 
            char --> '\0'
            sayisal ifadelerin --> 0
            bool --> false

             */

            // default keyword : icerisindeki turun default degerini geri dondurur.
            bool default1 = default(bool);
            string default2 = default(string);
            int default3 = default(int);
        }

        public void CustomScopes()
        {
            int a = 1;
            {
                a = 2;
                int b = 3;
                {
                    a++;
                }
            }
            {
                a--;
                //b;
            }
        }
    }
    class VariablesExamples
    {
        // Bir degisken class scope icerisinde tanimlaniyorsa buna global degisken diyoruz.
        int a; // global degisken
        public void Method()
        {
            int b;

            int x, y, z;
            int q = 1, w = 2, e = 3;
        }
    }
}