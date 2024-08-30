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
    public partial class FrmCardapioCad : Form
    {
        //variavel que indica se esta criando um novo cardapio
        bool eNovo = false;
        public FrmCardapioCad(bool acao)
        {
            eNovo = acao;
            InitializeComponent();


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //se o form esta no modo de inclusao
            if (eNovo)
            {
                //executa o metodo q realiza o insert na tabela
                AdicionarCardapio();
            }
            else
            {
                //executa o metodo q realiza o update na tabela
                AtualizarCardapio();
            }
            //fecha a tela atual
            Close();
        }

        private void AtualizarCardapio()
        {
            throw new NotImplementedException();
        }

        private void AdicionarCardapio()
        {
            //usar o banco de dados
            //cria uma variavel banco que instancia uma conexa com o banco de dad
            using(var banco = new DataBase())
            {
                var novoCardapio = new Cardapio()
                {
                    Titulo = txtTitulo.TextButton,
                    Descricao = txtDescricao.TextButton,
                    Preco = decimal.Parse(txtPreco.TextButton),
                    PossuiPreparo = chkPreparo.Checked
                };
                banco.Cardapios.Add(novoCardapio);
                banco.SaveChanges();
            }
        }
    }
}
