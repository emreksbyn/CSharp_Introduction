namespace _104.TypeConversions
{
    public class ParseMethod
    {
        // String -> Others
        public static void MyParse()
        {
            // Parse metotu, sadece string datalari hedef ture donustururken kullanilir.
            string age1 = "27";
            int age2 = int.Parse(age1);
            short age3 = short.Parse(age1);
            Console.WriteLine(age2 * age3);

            string isActive = "true";
            bool aktifMi = bool.Parse(isActive);
            Console.WriteLine(aktifMi);

            // Compile da hata vermez, fakat runtime da "true" degerini long turune parse edemeyeceginden dolayi bizi patlatacaktir.
            //long aktifMi2 = long.Parse(isActive);
        }
    }
}