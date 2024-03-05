using CelularCTI.model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.model
{
    public class Pedido
    {
        private Int64 id_pedido;
        private Aparelho aparelho;
        private DateTime datahorapedido;
        private string observacao;

        private Int64 Id_pedido { get; set; }
        private Aparelho Aparelho { get; set; }
        private DateTime Datahorapedido { get; set; }
        private string Observacao { get; set; }
    }
}
