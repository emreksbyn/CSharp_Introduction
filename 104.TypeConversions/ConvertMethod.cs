namespace _104.TypeConversions
{
    public class ConvertMethod
    {
        // Convert metodu Parse metodu gibi degildir. Sadece string ifadelerden diger turlere donusum yapmaz.
        // Turler arasinda donusum yaparken kullanilir.
        public static void MyConvert()
        {
            #region String -> Others
            string age = "27";
            long age3 = Convert.ToInt64(age);
            int age2 = Convert.ToInt32(age);
            Console.WriteLine(age2 * age3);

            string isActive = "true";
            bool aktifMi = Convert.ToBoolean(isActive);
            Console.WriteLine(aktifMi);

            // virgul kullanirsak 314 olarak convert eder. nokta kullanirsak decimal olarak ondalikli convert eder.
            //string pi = "3,14";
            string pi = "3.14";
            double pi2 = Convert.ToDouble(pi);
            Console.WriteLine(pi2);
            #endregion

            #region Others -> String 
            int a = 27;
            string b = Convert.ToString(a);
            #endregion
        }

        // Others --> String
        public static void MyToString()
        {
            // ToString() fonk. butun turlerde mevcuttur !!
            float f = 25;
            string a = f.ToString();
            Console.WriteLine(a);
        }
    }
}
