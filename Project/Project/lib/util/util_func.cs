using System.Text;

namespace lib.util
{
    public class util_func
    {
        public string Encryptor(string texto)
        {
            byte[] hashBytes = Encoding.Unicode.GetBytes(texto);
            using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {

                hashBytes = md5.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X5"));
                return stringBuilder.ToString();
            }
        }

        public enum TipoPesquisa
        {
            PesquisaAtivos = 1,
            PesquisaNaoAtivos
        }
    }
}
