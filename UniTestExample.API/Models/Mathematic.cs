namespace UnitTestExample.API.Models
{
    public class Mathematic
    {
        public int Sum(int number1, int number2) => number1 + number2;
      //  public int Subtract(int number1, int number2)  => number1 % number2; //bilerek mod aldık. Hatayı görebilmek için
        public int Subtract(int number1, int number2)  => number1 - number2; //bilerek mod aldık. Hatayı görebilmek için
        public int Multiply(int number1, int number2) => number1 * number2;
        public int Divide(int number1, int number2) => number1 / number2;
    }
}
