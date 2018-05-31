using Specter.MODEL;

namespace Specter
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLoginTitulo = new ns1.BunifuCustomLabel();
            this.lblVersion = new ns1.BunifuCustomLabel();
            this.lblCodigoPokemonRaro = new System.Windows.Forms.Label();
            this.txtCodigoPokemonRaro = new System.Windows.Forms.TextBox();
            this.lblEstadoServer = new System.Windows.Forms.Label();
            this.lblEstadoServerValue = new System.Windows.Forms.Label();
            this.btnBunifuElipse = new ns1.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new ns1.BunifuFlatButton();
            this.panelLoginTitle = new System.Windows.Forms.Panel();
            this.btnSair = new ns1.BunifuFlatButton();
            this.btnBunifuControl = new ns1.BunifuDragControl(this.components);
            this.lblVersaoValue = new ns1.BunifuCustomLabel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.lblDesatualizadaValue = new ns1.BunifuCustomLabel();
            this.lblDesatualizada = new ns1.BunifuCustomLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLingua = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLoginTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.AutoSize = true;
            this.lblLoginTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLoginTitulo.Location = new System.Drawing.Point(8, 9);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(77, 24);
            this.lblLoginTitulo.TabIndex = 12;
            this.lblLoginTitulo.Text = "LOGIN";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVersion.Location = new System.Drawing.Point(301, 265);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(47, 16);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Versão:";
            // 
            // lblCodigoPokemonRaro
            // 
            this.lblCodigoPokemonRaro.AutoSize = true;
            this.lblCodigoPokemonRaro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPokemonRaro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoPokemonRaro.Location = new System.Drawing.Point(30, 144);
            this.lblCodigoPokemonRaro.Name = "lblCodigoPokemonRaro";
            this.lblCodigoPokemonRaro.Size = new System.Drawing.Size(141, 21);
            this.lblCodigoPokemonRaro.TabIndex = 6;
            this.lblCodigoPokemonRaro.Text = "CatchGO Code:";
            // 
            // txtCodigoPokemonRaro
            // 
            this.txtCodigoPokemonRaro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPokemonRaro.Location = new System.Drawing.Point(169, 146);
            this.txtCodigoPokemonRaro.Name = "txtCodigoPokemonRaro";
            this.txtCodigoPokemonRaro.Size = new System.Drawing.Size(207, 21);
            this.txtCodigoPokemonRaro.TabIndex = 7;
            // 
            // lblEstadoServer
            // 
            this.lblEstadoServer.AutoSize = true;
            this.lblEstadoServer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstadoServer.Location = new System.Drawing.Point(4, 266);
            this.lblEstadoServer.Name = "lblEstadoServer";
            this.lblEstadoServer.Size = new System.Drawing.Size(85, 13);
            this.lblEstadoServer.TabIndex = 9;
            this.lblEstadoServer.Text = "Estado Servidor:";
            // 
            // lblEstadoServerValue
            // 
            this.lblEstadoServerValue.AutoSize = true;
            this.lblEstadoServerValue.Location = new System.Drawing.Point(84, 266);
            this.lblEstadoServerValue.Name = "lblEstadoServerValue";
            this.lblEstadoServerValue.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoServerValue.TabIndex = 10;
            this.lblEstadoServerValue.Text = "Waiting";
            // 
            // btnBunifuElipse
            // 
            this.btnBunifuElipse.ElipseRadius = 5;
            this.btnBunifuElipse.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Specter.Properties.Resources.logo_footer;
            this.pictureBox1.Location = new System.Drawing.Point(111, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = null;
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(85, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(107, 33);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelLoginTitle
            // 
            this.panelLoginTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.panelLoginTitle.Controls.Add(this.lblLoginTitulo);
            this.panelLoginTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginTitle.Location = new System.Drawing.Point(0, 0);
            this.panelLoginTitle.Name = "panelLoginTitle";
            this.panelLoginTitle.Size = new System.Drawing.Size(400, 38);
            this.panelLoginTitle.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.Activecolor = System.Drawing.Color.IndianRed;
            this.btnSair.BackColor = System.Drawing.Color.IndianRed;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.BorderRadius = 0;
            this.btnSair.ButtonText = "SAIR";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DisabledColor = System.Drawing.Color.Gray;
            this.btnSair.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSair.Iconimage = null;
            this.btnSair.Iconimage_right = null;
            this.btnSair.Iconimage_right_Selected = null;
            this.btnSair.Iconimage_Selected = null;
            this.btnSair.IconMarginLeft = 0;
            this.btnSair.IconMarginRight = 0;
            this.btnSair.IconRightVisible = true;
            this.btnSair.IconRightZoom = 0D;
            this.btnSair.IconVisible = true;
            this.btnSair.IconZoom = 90D;
            this.btnSair.IsTab = false;
            this.btnSair.Location = new System.Drawing.Point(198, 215);
            this.btnSair.Name = "btnSair";
            this.btnSair.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnSair.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnSair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSair.selected = false;
            this.btnSair.Size = new System.Drawing.Size(107, 33);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Textcolor = System.Drawing.Color.White;
            this.btnSair.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnBunifuControl
            // 
            this.btnBunifuControl.Fixed = true;
            this.btnBunifuControl.Horizontal = true;
            this.btnBunifuControl.TargetControl = this;
            this.btnBunifuControl.Vertical = true;
            // 
            // lblVersaoValue
            // 
            this.lblVersaoValue.AutoSize = true;
            this.lblVersaoValue.BackColor = System.Drawing.Color.Transparent;
            this.lblVersaoValue.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVersaoValue.Location = new System.Drawing.Point(342, 265);
            this.lblVersaoValue.Name = "lblVersaoValue";
            this.lblVersaoValue.Size = new System.Drawing.Size(26, 16);
            this.lblVersaoValue.TabIndex = 16;
            this.lblVersaoValue.Text = "null";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLoginTitle;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblDesatualizadaValue
            // 
            this.lblDesatualizadaValue.AutoSize = true;
            this.lblDesatualizadaValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDesatualizadaValue.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesatualizadaValue.ForeColor = System.Drawing.Color.Red;
            this.lblDesatualizadaValue.Location = new System.Drawing.Point(310, 266);
            this.lblDesatualizadaValue.Name = "lblDesatualizadaValue";
            this.lblDesatualizadaValue.Size = new System.Drawing.Size(91, 16);
            this.lblDesatualizadaValue.TabIndex = 18;
            this.lblDesatualizadaValue.Text = "Dezatualizada.";
            this.lblDesatualizadaValue.Visible = false;
            // 
            // lblDesatualizada
            // 
            this.lblDesatualizada.AutoSize = true;
            this.lblDesatualizada.BackColor = System.Drawing.Color.Transparent;
            this.lblDesatualizada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesatualizada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDesatualizada.Location = new System.Drawing.Point(263, 265);
            this.lblDesatualizada.Name = "lblDesatualizada";
            this.lblDesatualizada.Size = new System.Drawing.Size(47, 16);
            this.lblDesatualizada.TabIndex = 17;
            this.lblDesatualizada.Text = "Versão:";
            this.lblDesatualizada.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lingua:";
            // 
            // cbLingua
            // 
            this.cbLingua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLingua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLingua.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLingua.FormattingEnabled = true;
            this.cbLingua.Items.AddRange(new object[] {
            "Portugues",
            "English",
            "Spanish"});
            this.cbLingua.Location = new System.Drawing.Point(169, 181);
            this.cbLingua.Name = "cbLingua";
            this.cbLingua.Size = new System.Drawing.Size(121, 24);
            this.cbLingua.TabIndex = 20;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(400, 287);
            this.Controls.Add(this.cbLingua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDesatualizadaValue);
            this.Controls.Add(this.lblDesatualizada);
            this.Controls.Add(this.lblVersaoValue);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panelLoginTitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblEstadoServerValue);
            this.Controls.Add(this.lblEstadoServer);
            this.Controls.Add(this.txtCodigoPokemonRaro);
            this.Controls.Add(this.lblCodigoPokemonRaro);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLoginTitle.ResumeLayout(false);
            this.panelLoginTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void changeLanguage()
        {
            this.lblVersion.Text = Configuracoes.res_man.GetString("frmlogin_Versao", Configuracoes.cul);
            this.lblEstadoServer.Text = Configuracoes.res_man.GetString("frmlogin_estadoServidor", Configuracoes.cul); //bugged
            this.btnSair.Text = Configuracoes.res_man.GetString("frmlogin_Sair", Configuracoes.cul);
            this.lblDesatualizadaValue.Text = Configuracoes.res_man.GetString("frmlogin_Versao_dezatualizada", Configuracoes.cul);
            this.label1.Text = Configuracoes.res_man.GetString("frmlogin_Lingua", Configuracoes.cul);
            this.lblDesatualizada.Text = Configuracoes.res_man.GetString("frmlogin_Versao", Configuracoes.cul);
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodigoPokemonRaro;
        private System.Windows.Forms.TextBox txtCodigoPokemonRaro;
        private System.Windows.Forms.Label lblEstadoServer;
        private System.Windows.Forms.Label lblEstadoServerValue;
        private ns1.BunifuElipse btnBunifuElipse;
        private System.Windows.Forms.Panel panelLoginTitle;
        private ns1.BunifuFlatButton btnSair;
        private ns1.BunifuFlatButton btnLogin;
        private ns1.BunifuDragControl btnBunifuControl;
        private ns1.BunifuCustomLabel lblVersaoValue;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuCustomLabel lblDesatualizadaValue;
        private ns1.BunifuCustomLabel lblDesatualizada;
        private ns1.BunifuCustomLabel lblVersion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLingua;
        private ns1.BunifuCustomLabel lblLoginTitulo;
    }
}

