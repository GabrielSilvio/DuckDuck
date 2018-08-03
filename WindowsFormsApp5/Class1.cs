using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public enum linguagens
    { 
        BR, EN
    }
    public static class Erros
    {
        public static Dictionary<linguagens, Dictionary<string, string>>  erros = new Dictionary<linguagens,  Dictionary<string,string >>();
        public static void init() {
            erros.Add(linguagens.BR, new Dictionary<string, string>());
            erros.Add(linguagens.EN, new Dictionary<string, string>());
            erros[linguagens.BR].Add("004", "Verifique seu Login e Senha");
            erros[linguagens.EN].Add("004", "Verify your credentials");
            
        }
        
        

    }
}
