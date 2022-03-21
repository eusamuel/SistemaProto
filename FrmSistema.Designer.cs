namespace Sistema
{
    partial class FrmSistema
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
            this.components = new System.ComponentModel.Container();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.staInformacoes = new System.Windows.Forms.StatusStrip();
            this.tipInformacoes = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrAtualizaEstado = new System.Windows.Forms.Timer(this.components);
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.staInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuArquivo,
            this.mnuCadastro,
            this.relatóriosToolStripMenuItem,
            this.mnuAjuda});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 28);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "mnuSistema";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(75, 24);
            this.mnuArquivo.Text = "&Arquivo";
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(117, 26);
            this.mnuSair.Text = "Sai&r";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuario});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(82, 24);
            this.mnuCadastro.Text = "&Cadastro";
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(224, 26);
            this.mnuUsuario.Text = "Us&uário";
            this.mnuUsuario.Click += new System.EventHandler(this.mnuUsuario_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(62, 24);
            this.mnuAjuda.Text = "A&juda";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(224, 26);
            this.mnuSobre.Text = "&Sobre";
            // 
            // staInformacoes
            // 
            this.staInformacoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staInformacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipInformacoes});
            this.staInformacoes.Location = new System.Drawing.Point(0, 424);
            this.staInformacoes.Name = "staInformacoes";
            this.staInformacoes.Size = new System.Drawing.Size(800, 26);
            this.staInformacoes.TabIndex = 3;
            // 
            // tipInformacoes
            // 
            this.tipInformacoes.Name = "tipInformacoes";
            this.tipInformacoes.Size = new System.Drawing.Size(183, 20);
            this.tipInformacoes.Text = "Usuário: ... -- Logon: .../.../...";
            // 
            // tmrAtualizaEstado
            // 
            this.tmrAtualizaEstado.Enabled = true;
            this.tmrAtualizaEstado.Interval = 60000;
            this.tmrAtualizaEstado.Tick += new System.EventHandler(this.tmrAtualizaEstado_Tick);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRelatorioUsuarios});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // mnuRelatorioUsuarios
            // 
            this.mnuRelatorioUsuarios.Name = "mnuRelatorioUsuarios";
            this.mnuRelatorioUsuarios.Size = new System.Drawing.Size(224, 26);
            this.mnuRelatorioUsuarios.Text = "&Usuários";
            this.mnuRelatorioUsuarios.Click += new System.EventHandler(this.mnuRelatorioUsuarios_Click);
            // 
            // FrmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staInformacoes);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmSistema";
            this.Text = "Sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSistema_FormClosed);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.staInformacoes.ResumeLayout(false);
            this.staInformacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.StatusStrip staInformacoes;
        private System.Windows.Forms.ToolStripStatusLabel tipInformacoes;
        private System.Windows.Forms.Timer tmrAtualizaEstado;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioUsuarios;
    }
}