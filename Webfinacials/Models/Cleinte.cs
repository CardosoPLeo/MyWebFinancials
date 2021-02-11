using System;
using static Webfinacials.Models.BaseModel;

namespace Webfinacials.Models
{
    public class Cliente : ModeloBase
    {
        
        public string Nome { get; set; } = "";

        public Cliente()
        {
        }

        public Cliente(string nome)
        {
            
            Nome = nome;
        }
    }
}
