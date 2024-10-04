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
        private FrmCardapio _frmCardapio;

        public int ID { get; }
        public string? TITULO { get; }
        public string? DESCRICAO { get; }
        public decimal PRECO { get; }
        public bool POSSUI_PREPARO { get; }

        public FrmCardapioCad(bool acao, FrmCardapio frmCardapio)
        {
            eNovo = acao;
            _frmCardapio = frmCardapio;
            InitializeComponent();


        }

        public FrmCardapioCad(bool acao, int iD, string? tITULO, string? dESCRICAO, decimal pRECO, bool pOSSUI_PREPARO, FrmCardapio frmCardapio) : this(acao, frmCardapio)
        {
            eNovo = acao;
            InitializeComponent();
            ID = iD;
            TITULO = tITULO;
            DESCRICAO = dESCRICAO;
            PRECO = pRECO;
            POSSUI_PREPARO = pOSSUI_PREPARO;
            PopularCampos();
        }

        private void PopularCampos()
        {
            txtId.TextButton = ID.ToString();
            txtTitulo.TextButton = TITULO;
            txtDescricao.TextButton = DESCRICAO;
            txtPreco.TextButton = PRECO.ToString();
            chkPreparo.Checked = POSSUI_PREPARO;
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
            _frmCardapio.ListarCardapios();
            //fecha a tela atual
            Close();
        }

        private void AtualizarCardapio()
        {
            //conecta no banco de dados :)
            using (var banco = new DataBase())
            {
                var cardapio = banco.Cardapios.FirstOrDefault(c => c.Id == int.Parse(txtId.TextButton));

                cardapio.Titulo = txtTitulo.TextButton;
                cardapio.Descricao = txtDescricao.TextButton;
                cardapio.Preco = decimal.Parse(txtPreco.TextButton);
                cardapio.PossuiPreparo = chkPreparo.Checked;
                banco.SaveChanges();
            }
        }

        private void AdicionarCardapio()
        {
            //usar o banco de dados
            //cria uma variavel banco que instancia uma conexa com o banco de dad
            using (var banco = new DataBase())
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
