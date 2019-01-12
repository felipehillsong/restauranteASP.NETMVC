using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Models {
    public class Pedido {
        public string Nome { get; set; }

        public int Mesa { get; set; }

        public string Pratos { get; set; }

        public int QtdPratos { get; set; }

        public string Bebidas { get; set; }

        public int QtdBebidas { get; set; }

        public string Sobremesas { get; set; }

        public int QtdSobremesas { get; set; }

        public DateTime tempo = DateTime.Now;

    }
}
