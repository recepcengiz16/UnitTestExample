using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.API.Models;

namespace UnitTestExample.TEST
{
    public class MathematicTest
    {
        public static IEnumerable<object[]> sumDatas => new List<object[]> {
            new object[]{ 3, 5, 8 },
            new object[]{ 11, 5, 16 },
            new object[]{ 23, 2, 25 },
            new object[]{ 33, 44, 87 }
        };


        [Fact] //Test süreçlerinde ilgili metot herhangi bir parametre almıyorsa eğer ‘Fact’ attribute’u ile işaretlenmelidir.
        public void SubtractTest()
        {
            #region Arrange
            //Kaynaklar hazırlanıyor. İlgili nesne ve değişken tanımlamalarını burada yapıyoruz.
            int number1 = 10;
            int number2 = 20;
            int expected = -10;
            Mathematic mathematics = new Mathematic();
            #endregion

            #region Act
            //İlgili metot Arrange'de ki kaynaklarla test ediliyor. Burada metodu çalıştırıyoruz.
            int result = mathematics.Subtract(number1, number2);
            #endregion

            #region Assert
            //Test neticesinde gelen data doğrulanıyor.
            Assert.Equal(expected, result);
            #endregion
        }


        //Test metotları parametre almıyorsa eğer ‘Fact’ ile işaretliyoruz… Peki ya parametre alıyorsa? Parametre alan metotları ise ‘Theory’ attribute’u ile işaretliyor ve ardından parametrelerini ‘InlineData’ attribute’u ile opsiyonel olarak veriyoruz.Bunun için aşağıdaki örnek kodu inceleyiniz;

        //İlgili metodu farklı değerlerle test edecekseniz eğer birden fazla ‘InlineData’ attribute’unu aşağıdaki gibi kullanabilirsiniz.

        [Theory]
        //  [InlineData(3, 5, 8)]
        //  [InlineData(11, 5, 16)]
        //  [MemberData(nameof(sumDatas))] Eğer ki test edilecek data miktarı haddinden fazla ise ‘InlineData’ ile bunu yapmak mümkün olsa da yersiz kod maliyetine sebep olabilmektedir. Böyle durumlarda ‘MemberData’ attribute’unu kullanabilirsiniz. ‘MemberData’ attribute’u ile kullanılacak member türü IEnumerable<object[]> ve static olmak zorundadır.

        [MemberData(nameof(Datas.sumDatas), MemberType = typeof(Datas), DisableDiscoveryEnumeration = true)] //Eğer ki bu member farklı bir class’ın üyesi olsaydı  ‘MemberType’ property’si üzerinden sınıf bildiriminde bulunarak çalışma yapılması yeterli olacaktı; Ayrıca ‘MemberData’ ile yapılan test süreçlerinde veri seti yüzlerce yahut binlerce olanlar için ‘Test Explorer’da tek bir sonuç elde etmek istiyorsak eğer “DisableDiscoveryEnumeration” özelliğine ‘true’ vermemiz yeterli olacaktır.

        public void SumTest(int number1, int number2, int expected)
        {
            #region Arrange
            Mathematic mathematics = new Mathematic();
            #endregion

            #region Act
            int result = mathematics.Sum(number1, number2);
            #endregion

            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }

        [Theory]
        [ClassData(typeof(DatasTwo))] //Ayrıca ‘MemberData’ attribute’una alternatif olarak ‘ClassData’ attribute’unu da kullanabiliriz. Tabi ‘ClassData’ attribute’u, dataları alacağı sınıfa IEnumerable<object[]> arayüzünü implemente etmemizi ve ‘GetEnumerator’ içerisinde yield ile dataları itere etmemizi istemektedir.
        public void SumTest2(int number1, int number2, int expected)
        {
            #region Arrange
            Mathematic mathematics = new Mathematic();
            #endregion
            #region Act
            int result = mathematics.Sum(number1, number2);
            #endregion
            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }



        [Theory]
        [ClassData(typeof(TypeSafeData))] //Peki, IEnumerable<object[]> yerine IEnumerable<string[]> yahut IEnumerable<int[]> gibi tip güvenli test verilerini nasıl yazabiliriz? Bunun içinde ‘TheoryData’ attribute’undan faydalanabiliriz.Şöyle ki; TypeSafeData sınıfına bak.
        public void SumTest3(int number1, int number2, int expected)
        {
            #region Arrange
            Mathematic mathematics = new Mathematic();
            #endregion
            #region Act
            int result = mathematics.Sum(number1, number2);
            #endregion
            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }
    }
}
