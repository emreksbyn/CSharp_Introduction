namespace _102.Variables
{
    public class AssigningValuesToVariables
    {
        public void AssigningValues()
        {
            #region Tanimladiktan Sonra Deger Atama

            int number; // --> Burada atama yapilmadan once int tipine ozel olarak number degeri 0 dir.
            //....
            //

            // Burada oldugu gibi " = " ( assignment operator ) un solunda degisken cagiriliyorsa degiskenin kendisi gelir.
            number = 67; // Artik burada degiskene 67 degeri atanmis olur.
            
            // Fakat saginda cagirirsak degiskenin degeri gelmis olur.
            string output = number.ToString();
            Console.WriteLine(output);
            #endregion
        }
    }
}