using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        private void CriarBancoDeDados()
        {
            // criar uma variavel do tipo AppDbContext
            // usar a variavel e acessar o context
            // executar a migracao == F5
            using (var banco = new BancoDeDados())
            {
                // exec a migracao(CREATE TABLE Usuarios)
                banco.Database.Migrate();
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            new FrmCardapio().ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //encerra o aplicativo
            Application.Exit();
        }
    }
}
