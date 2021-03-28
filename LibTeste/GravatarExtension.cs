using System;
using System.Security.Cryptography;
using System.Text;

namespace LibTeste
{
    public static class GravatarExtension
    {
        public static string ToGravatar(this string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return string.Empty;
            }

            var md5 = MD5.Create();
            var inputByte = Encoding.ASCII.GetBytes(valor);
            var hasBytes = md5.ComputeHash(inputByte);

            var sb = new StringBuilder();

            foreach (var item in hasBytes)
            {
                sb.Append(item.ToString("X2"));
            }

            return $"https://www.gravatar.com/avatar/{sb.ToString().ToLower()}";
        }

        public static string TesteRetornoExtension<T>(this ITestando valor, T name , TesteLib valor2)
        {
            var v = valor;
            return $"Metodo extension tentando entender {name} {valor2.ID} {valor.Sobrenome}";
        }
    }
}
