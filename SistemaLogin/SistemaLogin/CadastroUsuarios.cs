using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario() { Nome = "Caio", Senha = "abc123" },
            new Usuario() { Nome = "Danny", Senha = "123abc"},
            new Usuario() { Nome = "Lucas", Senha = "acbd"}
        };

        private static Usuario _userLogado = null;
    }
}
