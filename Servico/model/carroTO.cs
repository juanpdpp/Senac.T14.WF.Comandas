using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.model

{
    public class CarroTO
    {
        public int Id { get; set; }
        public String Nome { get; set; } = String.Empty;
        public String Fabricante { get; set; } = String.Empty;
        public String Marca { get; set; } = String.Empty;
        public String Modelo { get; set; } = String.Empty;
        public int Ano { get; set; }
    }
}