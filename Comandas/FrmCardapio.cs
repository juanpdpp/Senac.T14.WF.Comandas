using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmCardapio : Form
    {
        //variaveis locais
        public int ID { get; set; }
        public string? TITULO { get; set; }
        public string? DESCRICAO { get; set; }
        public decimal PRECO { get; set; }
        public bool POSSUI_PREPARO { get; set; }

        public FrmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        public void ListarCardapios()
        {
            using (var banco = new DataBase())
            {
                var cardapios = banco.Cardapios.ToList();
                dgvCardapio.DataSource = cardapios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var eNovo = true;
            new FrmCardapioCad(eNovo, this).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //exije confirmacao do usuario
            var result= MessageBox.Show(
                $"deseja excluir o item {TITULO}?",
                "Excluir cardapio",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            //se o cara clicou nao
            if (result == DialogResult.No)
            {
                //para o metodo
                return;
            }

            //chamar o metodo excluir
            if (ExcluirCardapio(ID))
            {
                ListarCardapios();
                MessageBox.Show($"o cardapio {TITULO} foi excluido com sucesso!");
                //desabilita o botao excluir
                btnExcluir.Enabled = false;
                
            }


        }

        private bool ExcluirCardapio(int iD)
        {
            //conectar no banco
            using (var banco= new DataBase())
            {
                //buscar o cardapio atraves do id (SELECT * FROM Cardapios WHERE id = @iD)
                var cardapio= banco.Cardapios.First(c=>c.Id== iD);
                //avisar o banco da exclusao
                banco.Cardapios.Remove(cardapio);
                //confirmar para o banco a acao
                banco.SaveChanges();
            }
            return true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var eNovo = false;
            new FrmCardapioCad(eNovo, ID, TITULO, DESCRICAO, PRECO, POSSUI_PREPARO,this).ShowDialog();
        }

        private void dgvCardapio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtem o numero da linha clickada
            var numeroLinha = e.RowIndex;

            if (numeroLinha >= 0)
            {

                var id = dgvCardapio.Rows[numeroLinha].Cells["Id"].Value.ToString();
                var titulo = dgvCardapio.Rows[numeroLinha].Cells["Titulo"].Value.ToString();
                var descricao = dgvCardapio.Rows[numeroLinha].Cells["Descricao"].Value.ToString();
                var preco = dgvCardapio.Rows[numeroLinha].Cells["Preco"].Value.ToString();
                var possuiPreparo = dgvCardapio.Rows[numeroLinha].Cells["PossuiPreparo"].Value.ToString();

                //converter para os tipos corretos
                ID = int.Parse(id);
                TITULO = titulo;
                DESCRICAO = descricao;
                PRECO = decimal.Parse(preco);
                POSSUI_PREPARO = bool.Parse(possuiPreparo);

                //habilitar o botao editar e o excluir
                btnEditar.Enabled= true;
                btnExcluir.Enabled = true;
            }
        }


    }

}
