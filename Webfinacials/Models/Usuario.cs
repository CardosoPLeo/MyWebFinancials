using System;
using static Webfinacials.Models.BaseModel;

namespace Webfinacials.Models
{
    public class Usuario : ModeloBase
    {
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";
        public string Senha { get; set; } = "";

        public Usuario()
        {

        }

        public Usuario(string nome, string email, string senha)
        {
            
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}
