namespace Comandas
{
    partial class FrmCardapio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            dgvCardapio = new DataGridView();
            btnEditar = new ReaLTaiizor.Controls.CyberButton();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            btnAdicionar = new ReaLTaiizor.Controls.CyberButton();
            txtPrato = new ReaLTaiizor.Controls.CyberTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(51, 51, 51);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(12, 393);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(106, 45);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 1;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "Voltar";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvCardapio
            // 
            dgvCardapio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCardapio.Location = new Point(12, 70);
            dgvCardapio.Name = "dgvCardapio";
            dgvCardapio.RowHeadersWidth = 51;
            dgvCardapio.Size = new Size(776, 317);
            dgvCardapio.TabIndex = 2;
            dgvCardapio.CellClick += dgvCardapio_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.Alpha = 20;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Background = true;
            btnEditar.Background_WidthPen = 4F;
            btnEditar.BackgroundPen = true;
            btnEditar.ColorBackground = Color.LawnGreen;
            btnEditar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnEditar.ColorBackground_Pen = Color.FromArgb(51, 51, 51);
            btnEditar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnEditar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEditar.Effect_1 = true;
            btnEditar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEditar.Effect_1_Transparency = 25;
            btnEditar.Effect_2 = true;
            btnEditar.Effect_2_ColorBackground = Color.White;
            btnEditar.Effect_2_Transparency = 20;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Arial", 11F);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Lighting = false;
            btnEditar.LinearGradient_Background = false;
            btnEditar.LinearGradientPen = false;
            btnEditar.Location = new Point(491, 393);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 70;
            btnEditar.Size = new Size(147, 45);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 3;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_Effect_1 = 5;
            btnEditar.Timer_RGB = 300;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 4F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.Red;
            btnExcluir.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.ColorBackground_Pen = Color.FromArgb(51, 51, 51);
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Effect_1 = true;
            btnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir.Effect_1_Transparency = 25;
            btnExcluir.Effect_2 = true;
            btnExcluir.Effect_2_ColorBackground = Color.White;
            btnExcluir.Effect_2_Transparency = 20;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Arial", 11F);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradient_Background = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(644, 393);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(144, 45);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 4;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Alpha = 20;
            btnAdicionar.BackColor = Color.Transparent;
            btnAdicionar.Background = true;
            btnAdicionar.Background_WidthPen = 4F;
            btnAdicionar.BackgroundPen = true;
            btnAdicionar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnAdicionar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnAdicionar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnAdicionar.ColorBackground_Pen = Color.FromArgb(51, 51, 51);
            btnAdicionar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAdicionar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAdicionar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAdicionar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAdicionar.Effect_1 = true;
            btnAdicionar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAdicionar.Effect_1_Transparency = 25;
            btnAdicionar.Effect_2 = true;
            btnAdicionar.Effect_2_ColorBackground = Color.White;
            btnAdicionar.Effect_2_Transparency = 20;
            btnAdicionar.Font = new Font("Arial", 11F);
            btnAdicionar.ForeColor = Color.FromArgb(245, 245, 245);
            btnAdicionar.Lighting = false;
            btnAdicionar.LinearGradient_Background = false;
            btnAdicionar.LinearGradientPen = false;
            btnAdicionar.Location = new Point(644, 12);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.PenWidth = 15;
            btnAdicionar.Rounding = true;
            btnAdicionar.RoundingInt = 70;
            btnAdicionar.Size = new Size(144, 52);
            btnAdicionar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Tag = "Cyber";
            btnAdicionar.TextButton = "Adicionar";
            btnAdicionar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdicionar.Timer_Effect_1 = 5;
            btnAdicionar.Timer_RGB = 300;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtPrato
            // 
            txtPrato.Alpha = 20;
            txtPrato.BackColor = Color.Transparent;
            txtPrato.Background_WidthPen = 3F;
            txtPrato.BackgroundPen = true;
            txtPrato.ColorBackground = Color.FromArgb(37, 52, 68);
            txtPrato.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtPrato.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPrato.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPrato.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPrato.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPrato.Font = new Font("Arial", 12F);
            txtPrato.ForeColor = Color.FromArgb(245, 245, 245);
            txtPrato.Lighting = false;
            txtPrato.LinearGradientPen = false;
            txtPrato.Location = new Point(12, 14);
            txtPrato.Name = "txtPrato";
            txtPrato.PenWidth = 15;
            txtPrato.RGB = false;
            txtPrato.Rounding = true;
            txtPrato.RoundingInt = 60;
            txtPrato.Size = new Size(549, 50);
            txtPrato.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPrato.TabIndex = 6;
            txtPrato.Tag = "Cyber";
            txtPrato.TextButton = "";
            txtPrato.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPrato.Timer_RGB = 300;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrato);
            Controls.Add(btnAdicionar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(dgvCardapio);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cardapio";
            Load += FrmCardapio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnVoltar;
        private DataGridView dgvCardapio;
        private ReaLTaiizor.Controls.CyberButton btnEditar;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
        private ReaLTaiizor.Controls.CyberButton btnAdicionar;
        private ReaLTaiizor.Controls.CyberTextBox txtPrato;
    }
}