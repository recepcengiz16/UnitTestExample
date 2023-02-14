using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.API;

namespace UnitTestExample.TEST
{
    public class MathematicTest3
    {
        /*
         Aşağıdaki kod parçasına göz atarsanız eğer 24. satırda ‘Mock’ sınıfına generic olarak ‘IMathematics’ interface’i verilmekte ve böylece hangi interface içerisindeki metotların simüle edileceği bildirilmiş olunmaktadır. 25. satırda ise ilgili interface içerisinde simüle edilecek olan metot ‘Setup’ edilmekte ve böylece simüle sürecinde verilecek ‘1’ ve ‘2’ parametre değerlerine karşı geriye ‘3’ değerinin dönmesi gerektiği bildirilmektedir. 27. satırda ise artık simülasyon ayarları bitmiş olan ‘Mock’ nesnesi üzerinden ‘Object’ property’si ile üretilen nesne çağrılmakta ve ilgili metot tetiklenmektedir. Ve sonuç olarak ilgili metot yandaki gibi taklidi üzerinden milisaniye cinsinden kısa bir sürede test edilmiş olacaktır.


         
         */


        [Fact]
        public void SumTest()
        {
            //arrange
            var mathematics = new Mock<IMathematic>();
            mathematics.Setup(m => m.Sum(1, 2))
                .Returns(3);

            //act
            int result = mathematics.Object.Sum(1, 2);

            //assert
            Assert.Equal(3, result);
        }
    }
}
