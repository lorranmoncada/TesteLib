using LibTeste;
using System;
using Xunit;

namespace Gravatar.Teste
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("dariomoncadamendes@hotmail.com")]
        public void Test1(string email)
        {
            var result = "https://www.gravatar.com/avatar/dd6e0aceb160bc99e017cd942608ec0f";

            var obteve = email.ToGravatar();

            Assert.Equal(result, obteve);
        }

        //[Theory]
        //[InlineData("lorran")]
        //public void Test(string valor)
        //{
        //    var result = "Valor retornado é lorran";

        //    var obteve = new TesteLib().TesteRetorno(valor);

        //    Assert.Equal(result, obteve);
        //}

        [Theory]
        [InlineData("4")]
        public void Test3(string valor)
        {
            var result = "Metodo extension tentando entender 4 1 Moncada";
            var obj = new TesteLib() { ID = 1, Sobrenome = "Moncada" };
            var obteve = obj.TesteRetornoExtension<int>(int.Parse(valor), obj);

            Assert.Equal(result, obteve);
        }
    }
}
