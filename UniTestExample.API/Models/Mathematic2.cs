namespace UnitTestExample.API.Models
{
    public class Mathematic2 : IMathematic
    {
        /*
         
         Peki bir sınıfı nasıl Mocking yapabiliriz?
        Bir sınıfı mocklayabilmek için o sınıfın implemente ettiği interface kullanılmalıdır. Aksi taktirde bunun dışında bir yapılanmayı denemek ilgili uygulamanın derleme aşamasında hata almasına sebep olacaktır…

        Şimdi aşağıdaki ‘Sum’ metodunu ele alırsak eğer görüldüğü üzere toplama işlemini filanca sebeplerden dolayı 5 saniye zarfında yaptığını görmekteyiz. Haliyle her test sürecinde bu 5 saniyeyi beklemek mecburiyetinde kalacağız.

         */
        public int Sum(int number1, int number2)
        {
            Thread.Sleep(5000);
            return number1 + number2;
        }
    }
}
