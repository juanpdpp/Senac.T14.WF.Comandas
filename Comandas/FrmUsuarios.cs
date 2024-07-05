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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // metodo que ira inserir o usuario no banco
            CriarUsuario();
            //AtualizarUsuario();
        }

        private void CriarUsuario()
        {
            // acessar o banco 
            using(var banco = new BancoDeDados())
            {
                // criar um novo usuario
                var novoUsuario = new Usuario();
                // atribuindo as propriedades do usuario
                novoUsuario.Nome = "Juan";
                novoUsuario.Email = "juan@gmail.com";
                novoUsuario.Senha = "123";
                // salvar as alteracoes(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuário cadastrado com sucesso.");
            }
        }
    }
}
