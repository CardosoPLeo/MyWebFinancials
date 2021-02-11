using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static Webfinacials.Models.BaseModel;

namespace Webfinacials.Models
{

    public class LancamentoDeContas : ModeloBase
    {
        [Column(TypeName = "decimal (18,4)")]
        public decimal Desconto { get; set; } = 0;

        [Column(TypeName = "decimal (18,4)")]
        public decimal Acrescimo { get; set; } = 0;

        public Cliente Cliente { get; set; }
        public CadContas CadContas { get; set; }

        public LancamentoDeContas()
        {
            
        }
            
        public LancamentoDeContas(decimal desconto, decimal acrescimo, Cliente cliente, CadContas cadContas)
        {
            
            Desconto = desconto;
            Acrescimo = acrescimo;
            Cliente = cliente;
            CadContas = cadContas;

        }
    }
}
