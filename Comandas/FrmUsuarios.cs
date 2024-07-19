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
        private bool eNovo;

        public FrmUsuarios()
        {
            InitializeComponent();
            // metodo q lista os usuarios
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            // 1 conectar ao banco
            using (var banco = new BancoDeDados())
            {
                // 2 SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                // 3 popular a tabela na tela
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (eNovo)
                CriarUsuario();
            else
                AtualizarUsuario();

            DesabilitarCampos();
            ListarUsuarios();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        private void AtualizarUsuario()
        {
            using (var banco = new BancoDeDados())
            {
                //consulta um usuario da tabela, usando um id
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.TextButton))
                    .FirstOrDefault();

                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;
                banco.SaveChanges();
            }
        }

        private void CriarUsuario()
        {
            // acessar o banco 
            using (var banco = new BancoDeDados())
            {
                // criar um novo usuario
                var novoUsuario = new Usuario();
                // atribuindo as propriedades do usuario
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;
                // salvar as alteracoes(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuário cadastrado com sucesso.");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            eNovo = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // indica q esta editando um usuario
            eNovo = false;
        }
    }
}
