using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas
{
    public class Cardapio
    {
        // propriedades da classe
        // colunas da tabela Usuarios
        [Key] //chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto incremento
        public int Id { get; set; } // o "set;" permite mudar o valor da propriedade // o "get;" permite consguir a propriedade no projeto inteiro
        public string Titulo { get; set; } = default!;
        public string Descricao { get; set; } = default!;
        public decimal Preco {  get ; set; }
        public bool PossuiPreparo { get; set; }
    }
}