namespace _102.Variables
{
    #region Tanimlamalar
    // Sabitler: Degismeyen degerleri tutmak icin olusturulmustur.
    // Surecte var olan degeri degistirilemez. Degistirilmeye calisildiginda Compiler tarafindan hata verilir.
    // Ozunde static yapilanmadir.
    // Const larin sadece tanimlandiklari yerlerde degerleri atanabilir !!

    // Static : Bellekteki uygulama bazli veri depolama alani.
    // Static degiskenler adi ustunde degisebilir, const lar sabittir.

    // Readonly : Sadece okunabilir degisken tanimlamaya yarar.
    // const dan farki constructor icerisinde de degerleri atanabiliyor. Ayrica static degillerdir. 
    #endregion

    public class Constants
    {
        public void ConstExamples()
        {
            // Degismemesi gereken bir degisken tanimlama asagidaki gibi olmamalidir !!
            //double pi = 3.14;
            //pi = 3.25;

            // Tanimlama asamasinda degeri girilmelidir !!
            //const double pi;

            const double pi = 3.14;
            // Hata verecektir.
            //pi = 3.25;
        }
    }
}