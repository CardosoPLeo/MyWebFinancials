using System;
using System.ComponentModel.DataAnnotations.Schema;
using static Webfinacials.Models.BaseModel;

namespace Webfinacials.Models
{
    public class CadContas : ModeloBase
    {
        
        public string DescConta { get; set; }

        [Column(TypeName = "decimal (18,4)")]
        public decimal Valor { get; set; } = 0;

        public DateTime DataVencimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Credor Credor { get; set; }

        public CadContas()
        {

        }

        public CadContas(string descConta, decimal valor, DateTime dataVencimento, DateTime dataCadastro, Credor credor)
        {
            
            DescConta = descConta;
            Valor = valor;
            DataVencimento = dataVencimento;
            DataCadastro = dataCadastro;
            Credor = credor;
        }

    }
}
