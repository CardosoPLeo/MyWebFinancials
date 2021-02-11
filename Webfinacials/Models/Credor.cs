using System;
using static Webfinacials.Models.BaseModel;

namespace Webfinacials.Models
{
    public class Credor : ModeloBase
    {
        
        public string Nome { get; set; } = "";

        public Credor()
        {
        }

        public Credor(string nome)
        {
            
            Nome = nome;
        }
    }
}
