using Specter.MODEL;

namespace Specter.FORMS

{
    partial class FrmPrincipal
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
            System.Windows.Forms.Label lblMochilaP;
            ns1.BunifuCustomLabel lblLoginTitulo;
            System.Windows.Forms.Label lblApiText;
            System.Windows.Forms.Label lblPokemonLista;
            System.Windows.Forms.Label lblTituloStatus;
            System.Windows.Forms.Panel panelLoginTitle;
            System.Windows.Forms.Label lblTextoPanelLogin;
            System.Windows.Forms.Panel panel5;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Panel panel8;
            ns1.BunifuDragControl bunifuDragControl2;
            ns1.BunifuDragControl bunifuDragFormsLogin;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label10 = new System.Windows.Forms.Label();
            this.pnHeaderRight = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new ns1.BunifuSeparator();
            this.lblApiValue = new System.Windows.Forms.Label();
            this.lblescapado = new System.Windows.Forms.Label();
            this.lblVersionValue = new System.Windows.Forms.Label();
            this.lblTotalCapturado = new System.Windows.Forms.Label();
            this.lblCapturado = new System.Windows.Forms.Label();
            this.lblVersionText = new System.Windows.Forms.Label();
            this.lblPokebolas = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPokebolasValue = new System.Windows.Forms.Label();
            this.lblEscapadoValue = new System.Windows.Forms.Label();
            this.lblNomeValue = new System.Windows.Forms.Label();
            this.lblMochilaValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPokemonPremium = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelListaPokemon = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardsPrincipal = new ns1.BunifuCards();
            this.bunifuCards3 = new ns1.BunifuCards();
            this.linkErrorBugs = new System.Windows.Forms.LinkLabel();
            this.linkNomePokemons = new System.Windows.Forms.LinkLabel();
            this.linkGerarSenhaApp = new System.Windows.Forms.LinkLabel();
            this.linkComprarChave = new System.Windows.Forms.LinkLabel();
            this.linkPaginaOficial = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblAtividadesTexto = new System.Windows.Forms.Label();
            this.rchLog = new System.Windows.Forms.RichTextBox();
            this.gridPokemons = new ns1.BunifuCustomDataGrid();
            this.cPokemonIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.cNumver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCountry = new System.Windows.Forms.DataGridViewImageColumn();
            this.cIV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTimeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuSnipe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSniperCatchStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSniperCatchManual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSniperRazzBerry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSniperPinapBerry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSniperNanaBerry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSniperGoldenBerry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSniperCopyCoordinates = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCapturaAutomatica = new System.Windows.Forms.Label();
            this.btnConfigurarAutoCatch = new ns1.BunifuFlatButton();
            this.btnAutoCatch = new ns1.BunifuiOSSwitch();
            this.txtProcuraPoke = new System.Windows.Forms.TextBox();
            this.cbPokebola = new System.Windows.Forms.ComboBox();
            this.btnProcurarPokemon = new ns1.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIv100 = new ns1.BunifuCheckbox();
            this.bunifuSeparator4 = new ns1.BunifuSeparator();
            this.cbPlaySom = new ns1.BunifuCheckbox();
            this.bunifuCards2 = new ns1.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblLastPogoDate = new System.Windows.Forms.Label();
            this.lblLastPogoInfo = new System.Windows.Forms.Label();
            this.lblLastPogoName = new System.Windows.Forms.Label();
            this.imgPokemonLastCaught = new ns1.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPogoPassword = new ns1.BunifuMetroTextbox();
            this.txtPogoUsername = new ns1.BunifuMetroTextbox();
            this.btnLogout = new ns1.BunifuFlatButton();
            this.btnLogin = new ns1.BunifuFlatButton();
            this.rbPTC = new System.Windows.Forms.RadioButton();
            this.rbGoogle = new System.Windows.Forms.RadioButton();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.timerAtualizaStatus = new System.Windows.Forms.Timer(this.components);
            this.workerAPI = new System.ComponentModel.BackgroundWorker();
            this.timerAPI = new System.Windows.Forms.Timer(this.components);
            this.tpDicas = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragFormsPrincipal = new ns1.BunifuDragControl(this.components);
            this.loadingPokemons = new System.ComponentModel.BackgroundWorker();
            this.timerSnipingTick = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateGrid = new System.Windows.Forms.Timer(this.components);
            lblMochilaP = new System.Windows.Forms.Label();
            lblLoginTitulo = new ns1.BunifuCustomLabel();
            lblApiText = new System.Windows.Forms.Label();
            lblPokemonLista = new System.Windows.Forms.Label();
            lblTituloStatus = new System.Windows.Forms.Label();
            panelLoginTitle = new System.Windows.Forms.Panel();
            lblTextoPanelLogin = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            panel8 = new System.Windows.Forms.Panel();
            bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            bunifuDragFormsLogin = new ns1.BunifuDragControl(this.components);
            panel2 = new System.Windows.Forms.Panel();
            label11 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panelLoginTitle.SuspendLayout();
            panel5.SuspendLayout();
            this.pnHeaderRight.SuspendLayout();
            panel2.SuspendLayout();
            this.panelListaPokemon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cardsPrincipal.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPokemons)).BeginInit();
            this.menuSnipe.SuspendLayout();
            this.panel4.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemonLastCaught)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMochilaP
            // 
            lblMochilaP.AutoSize = true;
            lblMochilaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMochilaP.Location = new System.Drawing.Point(419, 13);
            lblMochilaP.Name = "lblMochilaP";
            lblMochilaP.Size = new System.Drawing.Size(89, 15);
            lblMochilaP.TabIndex = 6;
            lblMochilaP.Text = "POKEMONS:";
            // 
            // lblLoginTitulo
            // 
            lblLoginTitulo.AutoSize = true;
            lblLoginTitulo.BackColor = System.Drawing.Color.Transparent;
            lblLoginTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLoginTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblLoginTitulo.Location = new System.Drawing.Point(16, 2);
            lblLoginTitulo.Name = "lblLoginTitulo";
            lblLoginTitulo.Size = new System.Drawing.Size(143, 31);
            lblLoginTitulo.TabIndex = 13;
            lblLoginTitulo.Text = "SPECTER";
            // 
            // lblApiText
            // 
            lblApiText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblApiText.AutoSize = true;
            lblApiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblApiText.Location = new System.Drawing.Point(791, 37);
            lblApiText.Name = "lblApiText";
            lblApiText.Size = new System.Drawing.Size(32, 15);
            lblApiText.TabIndex = 24;
            lblApiText.Text = "API:";
            // 
            // lblPokemonLista
            // 
            lblPokemonLista.AutoSize = true;
            lblPokemonLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPokemonLista.ForeColor = System.Drawing.SystemColors.Control;
            lblPokemonLista.Location = new System.Drawing.Point(337, 7);
            lblPokemonLista.Name = "lblPokemonLista";
            lblPokemonLista.Size = new System.Drawing.Size(153, 29);
            lblPokemonLista.TabIndex = 28;
            lblPokemonLista.Text = "POKÉMONS";
            // 
            // lblTituloStatus
            // 
            lblTituloStatus.AutoSize = true;
            lblTituloStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTituloStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            lblTituloStatus.Location = new System.Drawing.Point(47, 13);
            lblTituloStatus.Name = "lblTituloStatus";
            lblTituloStatus.Size = new System.Drawing.Size(72, 18);
            lblTituloStatus.TabIndex = 2;
            lblTituloStatus.Text = "STATUS";
            // 
            // panelLoginTitle
            // 
            panelLoginTitle.BackColor = System.Drawing.Color.SeaGreen;
            panelLoginTitle.Controls.Add(lblTextoPanelLogin);
            panelLoginTitle.Dock = System.Windows.Forms.DockStyle.Top;
            panelLoginTitle.Location = new System.Drawing.Point(0, 0);
            panelLoginTitle.Name = "panelLoginTitle";
            panelLoginTitle.Size = new System.Drawing.Size(278, 44);
            panelLoginTitle.TabIndex = 29;
            // 
            // lblTextoPanelLogin
            // 
            lblTextoPanelLogin.AutoSize = true;
            lblTextoPanelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTextoPanelLogin.ForeColor = System.Drawing.SystemColors.Control;
            lblTextoPanelLogin.Location = new System.Drawing.Point(90, 14);
            lblTextoPanelLogin.Name = "lblTextoPanelLogin";
            lblTextoPanelLogin.Size = new System.Drawing.Size(87, 29);
            lblTextoPanelLogin.TabIndex = 28;
            lblTextoPanelLogin.Text = "LOGIN";
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel5.Controls.Add(this.label10);
            panel5.Location = new System.Drawing.Point(7, 201);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(268, 24);
            panel5.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(62, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "TIPO DE CONTA";
            // 
            // label14
            // 
            label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            label14.Location = new System.Drawing.Point(606, 37);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(122, 18);
            label14.TabIndex = 28;
            label14.Text = "Pokemon Raro";
            // 
            // label15
            // 
            label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.ForeColor = System.Drawing.Color.CornflowerBlue;
            label15.Location = new System.Drawing.Point(630, 17);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(72, 18);
            label15.TabIndex = 27;
            label15.Text = "STATUS";
            // 
            // panel8
            // 
            panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel8.Location = new System.Drawing.Point(7, 290);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(268, 10);
            panel8.TabIndex = 33;
            // 
            // bunifuDragControl2
            // 
            bunifuDragControl2.Fixed = true;
            bunifuDragControl2.Horizontal = true;
            bunifuDragControl2.TargetControl = this.pnHeaderRight;
            bunifuDragControl2.Vertical = true;
            // 
            // pnHeaderRight
            // 
            this.pnHeaderRight.AutoSize = true;
            this.pnHeaderRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnHeaderRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHeaderRight.Controls.Add(this.bunifuSeparator3);
            this.pnHeaderRight.Controls.Add(label14);
            this.pnHeaderRight.Controls.Add(label15);
            this.pnHeaderRight.Controls.Add(lblMochilaP);
            this.pnHeaderRight.Controls.Add(this.lblApiValue);
            this.pnHeaderRight.Controls.Add(this.lblescapado);
            this.pnHeaderRight.Controls.Add(this.lblVersionValue);
            this.pnHeaderRight.Controls.Add(this.lblTotalCapturado);
            this.pnHeaderRight.Controls.Add(lblApiText);
            this.pnHeaderRight.Controls.Add(this.lblCapturado);
            this.pnHeaderRight.Controls.Add(this.lblVersionText);
            this.pnHeaderRight.Controls.Add(this.lblPokebolas);
            this.pnHeaderRight.Controls.Add(this.bunifuSeparator2);
            this.pnHeaderRight.Controls.Add(this.lblTimeValue);
            this.pnHeaderRight.Controls.Add(this.bunifuSeparator1);
            this.pnHeaderRight.Controls.Add(this.lblTime);
            this.pnHeaderRight.Controls.Add(this.label8);
            this.pnHeaderRight.Controls.Add(lblTituloStatus);
            this.pnHeaderRight.Controls.Add(this.lblNome);
            this.pnHeaderRight.Controls.Add(this.lblPokebolasValue);
            this.pnHeaderRight.Controls.Add(this.lblEscapadoValue);
            this.pnHeaderRight.Controls.Add(this.lblNomeValue);
            this.pnHeaderRight.Controls.Add(this.lblMochilaValue);
            this.pnHeaderRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderRight.Location = new System.Drawing.Point(0, 35);
            this.pnHeaderRight.Name = "pnHeaderRight";
            this.pnHeaderRight.Size = new System.Drawing.Size(1213, 67);
            this.pnHeaderRight.TabIndex = 13;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(736, 17);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(42, 33);
            this.bunifuSeparator3.TabIndex = 29;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // lblApiValue
            // 
            this.lblApiValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApiValue.AutoSize = true;
            this.lblApiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApiValue.Location = new System.Drawing.Point(819, 37);
            this.lblApiValue.Name = "lblApiValue";
            this.lblApiValue.Size = new System.Drawing.Size(15, 16);
            this.lblApiValue.TabIndex = 26;
            this.lblApiValue.Text = "0";
            // 
            // lblescapado
            // 
            this.lblescapado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblescapado.AutoSize = true;
            this.lblescapado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescapado.Location = new System.Drawing.Point(945, 35);
            this.lblescapado.Name = "lblescapado";
            this.lblescapado.Size = new System.Drawing.Size(95, 15);
            this.lblescapado.TabIndex = 8;
            this.lblescapado.Text = "T.ESCAPADO:";
            // 
            // lblVersionValue
            // 
            this.lblVersionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersionValue.AutoSize = true;
            this.lblVersionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionValue.Location = new System.Drawing.Point(847, 17);
            this.lblVersionValue.Name = "lblVersionValue";
            this.lblVersionValue.Size = new System.Drawing.Size(15, 16);
            this.lblVersionValue.TabIndex = 25;
            this.lblVersionValue.Text = "0";
            // 
            // lblTotalCapturado
            // 
            this.lblTotalCapturado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCapturado.AutoSize = true;
            this.lblTotalCapturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCapturado.Location = new System.Drawing.Point(1030, 16);
            this.lblTotalCapturado.Name = "lblTotalCapturado";
            this.lblTotalCapturado.Size = new System.Drawing.Size(15, 16);
            this.lblTotalCapturado.TabIndex = 15;
            this.lblTotalCapturado.Text = "0";
            // 
            // lblCapturado
            // 
            this.lblCapturado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapturado.AutoSize = true;
            this.lblCapturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapturado.Location = new System.Drawing.Point(942, 15);
            this.lblCapturado.Name = "lblCapturado";
            this.lblCapturado.Size = new System.Drawing.Size(105, 15);
            this.lblCapturado.TabIndex = 7;
            this.lblCapturado.Text = "T.CAPTURADO:";
            // 
            // lblVersionText
            // 
            this.lblVersionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersionText.AutoSize = true;
            this.lblVersionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionText.Location = new System.Drawing.Point(791, 17);
            this.lblVersionText.Name = "lblVersionText";
            this.lblVersionText.Size = new System.Drawing.Size(65, 15);
            this.lblVersionText.TabIndex = 23;
            this.lblVersionText.Text = "VERSÃO:";
            // 
            // lblPokebolas
            // 
            this.lblPokebolas.AutoSize = true;
            this.lblPokebolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokebolas.Location = new System.Drawing.Point(419, 36);
            this.lblPokebolas.Name = "lblPokebolas";
            this.lblPokebolas.Size = new System.Drawing.Size(92, 15);
            this.lblPokebolas.TabIndex = 9;
            this.lblPokebolas.Text = "POKEBOLAS:";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 4;
            this.bunifuSeparator2.Location = new System.Drawing.Point(578, 1);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(24, 61);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.Location = new System.Drawing.Point(217, 35);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(15, 16);
            this.lblTimeValue.TabIndex = 14;
            this.lblTimeValue.Text = "0";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(140, 15);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(42, 35);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(179, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 15);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "TIME:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(23, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "PERSONAGEM";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(179, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 15);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "NOME:";
            // 
            // lblPokebolasValue
            // 
            this.lblPokebolasValue.AutoSize = true;
            this.lblPokebolasValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokebolasValue.Location = new System.Drawing.Point(507, 36);
            this.lblPokebolasValue.Name = "lblPokebolasValue";
            this.lblPokebolasValue.Size = new System.Drawing.Size(15, 16);
            this.lblPokebolasValue.TabIndex = 16;
            this.lblPokebolasValue.Text = "0";
            // 
            // lblEscapadoValue
            // 
            this.lblEscapadoValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEscapadoValue.AutoSize = true;
            this.lblEscapadoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscapadoValue.Location = new System.Drawing.Point(1026, 36);
            this.lblEscapadoValue.Name = "lblEscapadoValue";
            this.lblEscapadoValue.Size = new System.Drawing.Size(15, 16);
            this.lblEscapadoValue.TabIndex = 19;
            this.lblEscapadoValue.Text = "0";
            // 
            // lblNomeValue
            // 
            this.lblNomeValue.AutoSize = true;
            this.lblNomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeValue.Location = new System.Drawing.Point(228, 15);
            this.lblNomeValue.Name = "lblNomeValue";
            this.lblNomeValue.Size = new System.Drawing.Size(15, 16);
            this.lblNomeValue.TabIndex = 13;
            this.lblNomeValue.Text = "0";
            // 
            // lblMochilaValue
            // 
            this.lblMochilaValue.AutoSize = true;
            this.lblMochilaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMochilaValue.Location = new System.Drawing.Point(507, 14);
            this.lblMochilaValue.Name = "lblMochilaValue";
            this.lblMochilaValue.Size = new System.Drawing.Size(13, 13);
            this.lblMochilaValue.TabIndex = 18;
            this.lblMochilaValue.Text = "0";
            // 
            // bunifuDragFormsLogin
            // 
            bunifuDragFormsLogin.Fixed = true;
            bunifuDragFormsLogin.Horizontal = true;
            bunifuDragFormsLogin.TargetControl = lblLoginTitulo;
            bunifuDragFormsLogin.Vertical = true;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel2.Controls.Add(this.label6);
            panel2.Location = new System.Drawing.Point(7, 408);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(268, 24);
            panel2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "ULTIMO POKÉMON CAPTURADO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(12, 537);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(48, 16);
            label11.TabIndex = 36;
            label11.Text = "DATA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(10, 515);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 16);
            label7.TabIndex = 35;
            label7.Text = "INFORMAÇÕES:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(11, 489);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 16);
            label3.TabIndex = 34;
            label3.Text = "NOME:";
            // 
            // lblPokemonPremium
            // 
            this.lblPokemonPremium.AutoSize = true;
            this.lblPokemonPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokemonPremium.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPokemonPremium.Location = new System.Drawing.Point(30, 15);
            this.lblPokemonPremium.Name = "lblPokemonPremium";
            this.lblPokemonPremium.Size = new System.Drawing.Size(217, 24);
            this.lblPokemonPremium.TabIndex = 30;
            this.lblPokemonPremium.Text = "Pokémon Melhor CP / IV";
            this.tpDicas.SetToolTip(this.lblPokemonPremium, "Mostra os melhores Pokémons. Com CP/IV altos.");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(65, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "DADOS DE LOGIN";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(11, 116);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(107, 17);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "USUARIO/E-MAIL";
            this.tpDicas.SetToolTip(this.lblUsuario, "Nome de Usuario para contas PTC & E-mail para contas Google.");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "SENHA/S. APP";
            this.tpDicas.SetToolTip(this.label1, "Senha para Pokémon Trainer Clube & Senha de APP para contas Google.");
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Window;
            this.label22.Location = new System.Drawing.Point(468, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 24);
            this.label22.TabIndex = 28;
            this.label22.Text = "POKEMON:";
            this.tpDicas.SetToolTip(this.label22, "Digite o nome sem espaços, virulas ou acentos.");
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(811, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "POKEBOLA";
            this.tpDicas.SetToolTip(this.label5, "Desativado no momento. Em desenvolvimento.");
            // 
            // panelListaPokemon
            // 
            this.panelListaPokemon.AutoSize = true;
            this.panelListaPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListaPokemon.Controls.Add(this.panel1);
            this.panelListaPokemon.Controls.Add(this.label2);
            this.panelListaPokemon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListaPokemon.Location = new System.Drawing.Point(280, 102);
            this.panelListaPokemon.Name = "panelListaPokemon";
            this.panelListaPokemon.Size = new System.Drawing.Size(933, 564);
            this.panelListaPokemon.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cardsPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 562);
            this.panel1.TabIndex = 18;
            // 
            // cardsPrincipal
            // 
            this.cardsPrincipal.AutoSize = true;
            this.cardsPrincipal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cardsPrincipal.BorderRadius = 20;
            this.cardsPrincipal.BottomSahddow = false;
            this.cardsPrincipal.color = System.Drawing.Color.Tomato;
            this.cardsPrincipal.Controls.Add(this.bunifuCards3);
            this.cardsPrincipal.Controls.Add(this.panel6);
            this.cardsPrincipal.Controls.Add(this.gridPokemons);
            this.cardsPrincipal.Controls.Add(this.panel4);
            this.cardsPrincipal.Controls.Add(this.bunifuCards2);
            this.cardsPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardsPrincipal.LeftSahddow = false;
            this.cardsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.cardsPrincipal.Name = "cardsPrincipal";
            this.cardsPrincipal.RightSahddow = false;
            this.cardsPrincipal.ShadowDepth = 70;
            this.cardsPrincipal.Size = new System.Drawing.Size(931, 562);
            this.cardsPrincipal.TabIndex = 24;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.AutoSize = true;
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = false;
            this.bunifuCards3.color = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCards3.Controls.Add(this.linkErrorBugs);
            this.bunifuCards3.Controls.Add(this.linkNomePokemons);
            this.bunifuCards3.Controls.Add(this.linkGerarSenhaApp);
            this.bunifuCards3.Controls.Add(this.linkComprarChave);
            this.bunifuCards3.Controls.Add(this.linkPaginaOficial);
            this.bunifuCards3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(556, 117);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = false;
            this.bunifuCards3.ShadowDepth = 90;
            this.bunifuCards3.Size = new System.Drawing.Size(375, 317);
            this.bunifuCards3.TabIndex = 37;
            // 
            // linkErrorBugs
            // 
            this.linkErrorBugs.ActiveLinkColor = System.Drawing.Color.SpringGreen;
            this.linkErrorBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkErrorBugs.AutoSize = true;
            this.linkErrorBugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkErrorBugs.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkErrorBugs.Location = new System.Drawing.Point(120, 228);
            this.linkErrorBugs.Name = "linkErrorBugs";
            this.linkErrorBugs.Size = new System.Drawing.Size(179, 16);
            this.linkErrorBugs.TabIndex = 6;
            this.linkErrorBugs.TabStop = true;
            this.linkErrorBugs.Text = "ERROS, BUGS, SOLUÇÕES";
            this.linkErrorBugs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkErrorBugs_LinkClicked);
            // 
            // linkNomePokemons
            // 
            this.linkNomePokemons.ActiveLinkColor = System.Drawing.Color.SpringGreen;
            this.linkNomePokemons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkNomePokemons.AutoSize = true;
            this.linkNomePokemons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNomePokemons.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkNomePokemons.Location = new System.Drawing.Point(84, 206);
            this.linkNomePokemons.Name = "linkNomePokemons";
            this.linkNomePokemons.Size = new System.Drawing.Size(246, 16);
            this.linkNomePokemons.TabIndex = 5;
            this.linkNomePokemons.TabStop = true;
            this.linkNomePokemons.Text = "NOME DOS POKÉMONS DISPONÍVEIS";
            this.linkNomePokemons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNomePokemons_LinkClicked);
            // 
            // linkGerarSenhaApp
            // 
            this.linkGerarSenhaApp.ActiveLinkColor = System.Drawing.Color.SpringGreen;
            this.linkGerarSenhaApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGerarSenhaApp.AutoSize = true;
            this.linkGerarSenhaApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGerarSenhaApp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkGerarSenhaApp.Location = new System.Drawing.Point(104, 184);
            this.linkGerarSenhaApp.Name = "linkGerarSenhaApp";
            this.linkGerarSenhaApp.Size = new System.Drawing.Size(201, 16);
            this.linkGerarSenhaApp.TabIndex = 4;
            this.linkGerarSenhaApp.TabStop = true;
            this.linkGerarSenhaApp.Text = "COMO GERAR SENHA DE APP";
            this.linkGerarSenhaApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGerarSenhaApp_LinkClicked);
            // 
            // linkComprarChave
            // 
            this.linkComprarChave.ActiveLinkColor = System.Drawing.Color.SpringGreen;
            this.linkComprarChave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkComprarChave.AutoSize = true;
            this.linkComprarChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkComprarChave.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkComprarChave.Location = new System.Drawing.Point(140, 162);
            this.linkComprarChave.Name = "linkComprarChave";
            this.linkComprarChave.Size = new System.Drawing.Size(125, 16);
            this.linkComprarChave.TabIndex = 3;
            this.linkComprarChave.TabStop = true;
            this.linkComprarChave.Text = "COMPRAR CHAVE";
            this.linkComprarChave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkComprarChave_LinkClicked);
            // 
            // linkPaginaOficial
            // 
            this.linkPaginaOficial.ActiveLinkColor = System.Drawing.Color.SpringGreen;
            this.linkPaginaOficial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkPaginaOficial.AutoSize = true;
            this.linkPaginaOficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPaginaOficial.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkPaginaOficial.Location = new System.Drawing.Point(146, 140);
            this.linkPaginaOficial.Name = "linkPaginaOficial";
            this.linkPaginaOficial.Size = new System.Drawing.Size(110, 16);
            this.linkPaginaOficial.TabIndex = 2;
            this.linkPaginaOficial.TabStop = true;
            this.linkPaginaOficial.Text = "PAGINA OFICIAL";
            this.linkPaginaOficial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPaginaOficial_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblAtividadesTexto);
            this.panel6.Controls.Add(this.rchLog);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 434);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(931, 128);
            this.panel6.TabIndex = 42;
            // 
            // lblAtividadesTexto
            // 
            this.lblAtividadesTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtividadesTexto.AutoSize = true;
            this.lblAtividadesTexto.BackColor = System.Drawing.Color.Black;
            this.lblAtividadesTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadesTexto.ForeColor = System.Drawing.Color.White;
            this.lblAtividadesTexto.Location = new System.Drawing.Point(811, 8);
            this.lblAtividadesTexto.Name = "lblAtividadesTexto";
            this.lblAtividadesTexto.Size = new System.Drawing.Size(92, 18);
            this.lblAtividadesTexto.TabIndex = 17;
            this.lblAtividadesTexto.Text = "ATIVIDADES";
            // 
            // rchLog
            // 
            this.rchLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rchLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchLog.Location = new System.Drawing.Point(0, 0);
            this.rchLog.Name = "rchLog";
            this.rchLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rchLog.Size = new System.Drawing.Size(931, 128);
            this.rchLog.TabIndex = 11;
            this.rchLog.Text = "";
            // 
            // gridPokemons
            // 
            this.gridPokemons.AllowUserToAddRows = false;
            this.gridPokemons.AllowUserToDeleteRows = false;
            this.gridPokemons.AllowUserToResizeColumns = false;
            this.gridPokemons.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridPokemons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPokemons.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridPokemons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPokemons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPokemons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPokemons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPokemonIcon,
            this.cNumver,
            this.cName,
            this.cCountry,
            this.cIV,
            this.cCP,
            this.cTimeLeft,
            this.cLatitude,
            this.cLongitude,
            this.cCatchTime});
            this.gridPokemons.ContextMenuStrip = this.menuSnipe;
            this.gridPokemons.DoubleBuffered = true;
            this.gridPokemons.EnableHeadersVisualStyles = false;
            this.gridPokemons.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridPokemons.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.gridPokemons.Location = new System.Drawing.Point(0, 118);
            this.gridPokemons.MultiSelect = false;
            this.gridPokemons.Name = "gridPokemons";
            this.gridPokemons.ReadOnly = true;
            this.gridPokemons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPokemons.RowHeadersVisible = false;
            this.gridPokemons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPokemons.Size = new System.Drawing.Size(558, 314);
            this.gridPokemons.TabIndex = 20;
            // 
            // cPokemonIcon
            // 
            this.cPokemonIcon.HeaderText = "Icon";
            this.cPokemonIcon.Name = "cPokemonIcon";
            this.cPokemonIcon.ReadOnly = true;
            this.cPokemonIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cPokemonIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cPokemonIcon.Width = 70;
            // 
            // cNumver
            // 
            this.cNumver.HeaderText = "Num";
            this.cNumver.Name = "cNumver";
            this.cNumver.ReadOnly = true;
            this.cNumver.Width = 60;
            // 
            // cName
            // 
            this.cName.HeaderText = "Pokemon";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.ToolTipText = "Nome do Pokemon";
            // 
            // cCountry
            // 
            this.cCountry.HeaderText = "País";
            this.cCountry.Name = "cCountry";
            this.cCountry.ReadOnly = true;
            this.cCountry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cCountry.Width = 50;
            // 
            // cIV
            // 
            this.cIV.HeaderText = "IV";
            this.cIV.Name = "cIV";
            this.cIV.ReadOnly = true;
            this.cIV.ToolTipText = "Genética";
            this.cIV.Width = 50;
            // 
            // cCP
            // 
            this.cCP.HeaderText = "CP";
            this.cCP.Name = "cCP";
            this.cCP.ReadOnly = true;
            this.cCP.Width = 50;
            // 
            // cTimeLeft
            // 
            this.cTimeLeft.HeaderText = "Tempo";
            this.cTimeLeft.Name = "cTimeLeft";
            this.cTimeLeft.ReadOnly = true;
            this.cTimeLeft.ToolTipText = "Tempo restante";
            this.cTimeLeft.Width = 80;
            // 
            // cLatitude
            // 
            this.cLatitude.HeaderText = "latitude";
            this.cLatitude.Name = "cLatitude";
            this.cLatitude.ReadOnly = true;
            this.cLatitude.ToolTipText = "Latitude";
            this.cLatitude.Visible = false;
            this.cLatitude.Width = 125;
            // 
            // cLongitude
            // 
            this.cLongitude.HeaderText = "longitude";
            this.cLongitude.Name = "cLongitude";
            this.cLongitude.ReadOnly = true;
            this.cLongitude.ToolTipText = "longitude";
            this.cLongitude.Visible = false;
            // 
            // cCatchTime
            // 
            this.cCatchTime.HeaderText = "T. P/ Captura";
            this.cCatchTime.Name = "cCatchTime";
            this.cCatchTime.ReadOnly = true;
            this.cCatchTime.Width = 110;
            // 
            // menuSnipe
            // 
            this.menuSnipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSnipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSniperCatchStandard,
            this.menuSniperCatchManual,
            this.menuSniperRazzBerry,
            this.menuSniperPinapBerry,
            this.menuSniperNanaBerry,
            this.menuSniperGoldenBerry,
            this.menuSniperCopyCoordinates});
            this.menuSnipe.Name = "menuSnipe";
            this.menuSnipe.ShowImageMargin = false;
            this.menuSnipe.Size = new System.Drawing.Size(217, 158);
            this.menuSnipe.Opened += new System.EventHandler(this.menuSnipe_Opened);
            // 
            // menuSniperCatchStandard
            // 
            this.menuSniperCatchStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSniperCatchStandard.ForeColor = System.Drawing.Color.Green;
            this.menuSniperCatchStandard.Name = "menuSniperCatchStandard";
            this.menuSniperCatchStandard.Size = new System.Drawing.Size(216, 22);
            this.menuSniperCatchStandard.Text = "CAPTURAR";
            this.menuSniperCatchStandard.Click += new System.EventHandler(this.menuSniperCatchStandard_Click);
            // 
            // menuSniperCatchManual
            // 
            this.menuSniperCatchManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSniperCatchManual.ForeColor = System.Drawing.Color.Green;
            this.menuSniperCatchManual.Name = "menuSniperCatchManual";
            this.menuSniperCatchManual.Size = new System.Drawing.Size(216, 22);
            this.menuSniperCatchManual.Text = "CAPTURA MANUAL";
            this.menuSniperCatchManual.ToolTipText = "Informe as coordenadas do Pokemon";
            this.menuSniperCatchManual.Click += new System.EventHandler(this.menuSniperCatchManual_Click);
            // 
            // menuSniperRazzBerry
            // 
            this.menuSniperRazzBerry.ForeColor = System.Drawing.Color.Green;
            this.menuSniperRazzBerry.Name = "menuSniperRazzBerry";
            this.menuSniperRazzBerry.Size = new System.Drawing.Size(216, 22);
            this.menuSniperRazzBerry.Text = "CAPTURAR [Razz Berry]";
            this.menuSniperRazzBerry.Click += new System.EventHandler(this.menuSniperRazzBerry_Click);
            // 
            // menuSniperPinapBerry
            // 
            this.menuSniperPinapBerry.ForeColor = System.Drawing.Color.Green;
            this.menuSniperPinapBerry.Name = "menuSniperPinapBerry";
            this.menuSniperPinapBerry.Size = new System.Drawing.Size(216, 22);
            this.menuSniperPinapBerry.Text = "CAPTURAR [Pinap Berry]";
            this.menuSniperPinapBerry.Click += new System.EventHandler(this.menuSniperPinapBerry_Click);
            // 
            // menuSniperNanaBerry
            // 
            this.menuSniperNanaBerry.ForeColor = System.Drawing.Color.Green;
            this.menuSniperNanaBerry.Name = "menuSniperNanaBerry";
            this.menuSniperNanaBerry.Size = new System.Drawing.Size(216, 22);
            this.menuSniperNanaBerry.Text = "CAPTURAR [Nana Berry]";
            this.menuSniperNanaBerry.Click += new System.EventHandler(this.menuSniperNanaBerry_Click);
            // 
            // menuSniperGoldenBerry
            // 
            this.menuSniperGoldenBerry.ForeColor = System.Drawing.Color.Green;
            this.menuSniperGoldenBerry.Name = "menuSniperGoldenBerry";
            this.menuSniperGoldenBerry.Size = new System.Drawing.Size(216, 22);
            this.menuSniperGoldenBerry.Text = "CAPTURAR [Golden Berry]";
            this.menuSniperGoldenBerry.Click += new System.EventHandler(this.menuSniperGoldenBerry_Click);
            // 
            // menuSniperCopyCoordinates
            // 
            this.menuSniperCopyCoordinates.Enabled = false;
            this.menuSniperCopyCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSniperCopyCoordinates.ForeColor = System.Drawing.Color.Green;
            this.menuSniperCopyCoordinates.Name = "menuSniperCopyCoordinates";
            this.menuSniperCopyCoordinates.Size = new System.Drawing.Size(216, 22);
            this.menuSniperCopyCoordinates.Text = "COPIAR COORDENADAS";
            this.menuSniperCopyCoordinates.Click += new System.EventHandler(this.cOPIARCOORDENADASToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCapturaAutomatica);
            this.panel4.Controls.Add(this.btnConfigurarAutoCatch);
            this.panel4.Controls.Add(this.btnAutoCatch);
            this.panel4.Controls.Add(this.txtProcuraPoke);
            this.panel4.Controls.Add(this.cbPokebola);
            this.panel4.Controls.Add(this.btnProcurarPokemon);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbIv100);
            this.panel4.Controls.Add(this.bunifuSeparator4);
            this.panel4.Controls.Add(this.cbPlaySom);
            this.panel4.Controls.Add(this.lblPokemonPremium);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(931, 81);
            this.panel4.TabIndex = 41;
            // 
            // lblCapturaAutomatica
            // 
            this.lblCapturaAutomatica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapturaAutomatica.AutoSize = true;
            this.lblCapturaAutomatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapturaAutomatica.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCapturaAutomatica.Location = new System.Drawing.Point(319, 45);
            this.lblCapturaAutomatica.Name = "lblCapturaAutomatica";
            this.lblCapturaAutomatica.Size = new System.Drawing.Size(228, 24);
            this.lblCapturaAutomatica.TabIndex = 46;
            this.lblCapturaAutomatica.Text = "CAPTURA AUTOMATICA";
            this.tpDicas.SetToolTip(this.lblCapturaAutomatica, "Selecione para capturar automatica");
            // 
            // btnConfigurarAutoCatch
            // 
            this.btnConfigurarAutoCatch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConfigurarAutoCatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigurarAutoCatch.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigurarAutoCatch.BackgroundImage = global::Specter.Properties.Resources.btnAutoSnipeSettingsV3;
            this.btnConfigurarAutoCatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfigurarAutoCatch.BorderRadius = 0;
            this.btnConfigurarAutoCatch.ButtonText = "";
            this.btnConfigurarAutoCatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigurarAutoCatch.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfigurarAutoCatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarAutoCatch.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfigurarAutoCatch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfigurarAutoCatch.Iconimage = global::Specter.Properties.Resources.btnAutoSnipeSettingsV3;
            this.btnConfigurarAutoCatch.Iconimage_right = null;
            this.btnConfigurarAutoCatch.Iconimage_right_Selected = null;
            this.btnConfigurarAutoCatch.Iconimage_Selected = null;
            this.btnConfigurarAutoCatch.IconMarginLeft = 0;
            this.btnConfigurarAutoCatch.IconMarginRight = 0;
            this.btnConfigurarAutoCatch.IconRightVisible = false;
            this.btnConfigurarAutoCatch.IconRightZoom = 0D;
            this.btnConfigurarAutoCatch.IconVisible = false;
            this.btnConfigurarAutoCatch.IconZoom = 90D;
            this.btnConfigurarAutoCatch.IsTab = false;
            this.btnConfigurarAutoCatch.Location = new System.Drawing.Point(554, 44);
            this.btnConfigurarAutoCatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfigurarAutoCatch.Name = "btnConfigurarAutoCatch";
            this.btnConfigurarAutoCatch.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConfigurarAutoCatch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnConfigurarAutoCatch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfigurarAutoCatch.selected = false;
            this.btnConfigurarAutoCatch.Size = new System.Drawing.Size(28, 27);
            this.btnConfigurarAutoCatch.TabIndex = 45;
            this.btnConfigurarAutoCatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfigurarAutoCatch.Textcolor = System.Drawing.Color.White;
            this.btnConfigurarAutoCatch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarAutoCatch.Click += new System.EventHandler(this.btnConfigurarAutoCatch_Click);
            // 
            // btnAutoCatch
            // 
            this.btnAutoCatch.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoCatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoCatch.BackgroundImage")));
            this.btnAutoCatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoCatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoCatch.Enabled = false;
            this.btnAutoCatch.Location = new System.Drawing.Point(268, 43);
            this.btnAutoCatch.Name = "btnAutoCatch";
            this.btnAutoCatch.OffColor = System.Drawing.Color.Gray;
            this.btnAutoCatch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.btnAutoCatch.Size = new System.Drawing.Size(43, 25);
            this.btnAutoCatch.TabIndex = 44;
            this.btnAutoCatch.Value = false;
            // 
            // txtProcuraPoke
            // 
            this.txtProcuraPoke.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProcuraPoke.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProcuraPoke.BackColor = System.Drawing.Color.SeaGreen;
            this.txtProcuraPoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcuraPoke.ForeColor = System.Drawing.SystemColors.Info;
            this.txtProcuraPoke.Location = new System.Drawing.Point(584, 10);
            this.txtProcuraPoke.Name = "txtProcuraPoke";
            this.txtProcuraPoke.Size = new System.Drawing.Size(199, 26);
            this.txtProcuraPoke.TabIndex = 43;
            this.txtProcuraPoke.Text = "Dragonite";
            this.tpDicas.SetToolTip(this.txtProcuraPoke, "Nome do Pokemon");
            // 
            // cbPokebola
            // 
            this.cbPokebola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPokebola.BackColor = System.Drawing.Color.SeaGreen;
            this.cbPokebola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPokebola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPokebola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPokebola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbPokebola.Items.AddRange(new object[] {
            "Pokeball",
            "GreatBall",
            "Ultraball",
            "Master Ball",
            "Premier Ball"});
            this.cbPokebola.Location = new System.Drawing.Point(629, 42);
            this.cbPokebola.Name = "cbPokebola";
            this.cbPokebola.Size = new System.Drawing.Size(180, 28);
            this.cbPokebola.TabIndex = 42;
            // 
            // btnProcurarPokemon
            // 
            this.btnProcurarPokemon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProcurarPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProcurarPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurarPokemon.BorderRadius = 0;
            this.btnProcurarPokemon.ButtonText = "PROCURAR";
            this.btnProcurarPokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarPokemon.DisabledColor = System.Drawing.Color.Gray;
            this.btnProcurarPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarPokemon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProcurarPokemon.Iconimage = null;
            this.btnProcurarPokemon.Iconimage_right = null;
            this.btnProcurarPokemon.Iconimage_right_Selected = null;
            this.btnProcurarPokemon.Iconimage_Selected = null;
            this.btnProcurarPokemon.IconMarginLeft = 0;
            this.btnProcurarPokemon.IconMarginRight = 0;
            this.btnProcurarPokemon.IconRightVisible = false;
            this.btnProcurarPokemon.IconRightZoom = 0D;
            this.btnProcurarPokemon.IconVisible = false;
            this.btnProcurarPokemon.IconZoom = 90D;
            this.btnProcurarPokemon.IsTab = false;
            this.btnProcurarPokemon.Location = new System.Drawing.Point(803, 9);
            this.btnProcurarPokemon.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcurarPokemon.Name = "btnProcurarPokemon";
            this.btnProcurarPokemon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProcurarPokemon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProcurarPokemon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProcurarPokemon.selected = false;
            this.btnProcurarPokemon.Size = new System.Drawing.Size(118, 26);
            this.btnProcurarPokemon.TabIndex = 22;
            this.btnProcurarPokemon.Text = "PROCURAR";
            this.btnProcurarPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProcurarPokemon.Textcolor = System.Drawing.Color.White;
            this.btnProcurarPokemon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarPokemon.Click += new System.EventHandler(this.btnProcurarPokemon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(30, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "SOM DE NOTIFICAÇÃO";
            this.tpDicas.SetToolTip(this.label4, "OPÇÃO PAGA. Grauita no periodo de teste.");
            // 
            // cbIv100
            // 
            this.cbIv100.BackColor = System.Drawing.Color.White;
            this.cbIv100.ChechedOffColor = System.Drawing.Color.White;
            this.cbIv100.Checked = false;
            this.cbIv100.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbIv100.ForeColor = System.Drawing.Color.White;
            this.cbIv100.Location = new System.Drawing.Point(7, 17);
            this.cbIv100.Name = "cbIv100";
            this.cbIv100.Size = new System.Drawing.Size(20, 20);
            this.cbIv100.TabIndex = 29;
            this.tpDicas.SetToolTip(this.cbIv100, "OPÇÃO PAGA. Grauita no periodo de teste.");
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator4.AutoSize = true;
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(-7, 75);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(5525, 10);
            this.bunifuSeparator4.TabIndex = 31;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // cbPlaySom
            // 
            this.cbPlaySom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbPlaySom.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbPlaySom.Checked = true;
            this.cbPlaySom.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbPlaySom.ForeColor = System.Drawing.Color.White;
            this.cbPlaySom.Location = new System.Drawing.Point(8, 47);
            this.cbPlaySom.Name = "cbPlaySom";
            this.cbPlaySom.Size = new System.Drawing.Size(20, 20);
            this.cbPlaySom.TabIndex = 39;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.AutoSize = true;
            this.bunifuCards2.BackColor = System.Drawing.Color.DarkCyan;
            this.bunifuCards2.BorderRadius = 10;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(lblPokemonLista);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(931, 36);
            this.bunifuCards2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ATIVIDADES";
            // 
            // panelLogin
            // 
            this.panelLogin.AutoSize = true;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.lblLastPogoDate);
            this.panelLogin.Controls.Add(this.lblLastPogoInfo);
            this.panelLogin.Controls.Add(this.lblLastPogoName);
            this.panelLogin.Controls.Add(this.imgPokemonLastCaught);
            this.panelLogin.Controls.Add(label11);
            this.panelLogin.Controls.Add(label7);
            this.panelLogin.Controls.Add(label3);
            this.panelLogin.Controls.Add(panel2);
            this.panelLogin.Controls.Add(panel8);
            this.panelLogin.Controls.Add(panel5);
            this.panelLogin.Controls.Add(this.panel3);
            this.panelLogin.Controls.Add(panelLoginTitle);
            this.panelLogin.Controls.Add(this.txtPogoPassword);
            this.panelLogin.Controls.Add(this.txtPogoUsername);
            this.panelLogin.Controls.Add(this.btnLogout);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.rbPTC);
            this.panelLogin.Controls.Add(this.lblUsuario);
            this.panelLogin.Controls.Add(this.rbGoogle);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 102);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(280, 564);
            this.panelLogin.TabIndex = 0;
            // 
            // lblLastPogoDate
            // 
            this.lblLastPogoDate.AutoSize = true;
            this.lblLastPogoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPogoDate.Location = new System.Drawing.Point(52, 537);
            this.lblLastPogoDate.Name = "lblLastPogoDate";
            this.lblLastPogoDate.Size = new System.Drawing.Size(15, 16);
            this.lblLastPogoDate.TabIndex = 40;
            this.lblLastPogoDate.Text = "0";
            // 
            // lblLastPogoInfo
            // 
            this.lblLastPogoInfo.AutoSize = true;
            this.lblLastPogoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPogoInfo.Location = new System.Drawing.Point(110, 515);
            this.lblLastPogoInfo.Name = "lblLastPogoInfo";
            this.lblLastPogoInfo.Size = new System.Drawing.Size(15, 16);
            this.lblLastPogoInfo.TabIndex = 39;
            this.lblLastPogoInfo.Text = "0";
            // 
            // lblLastPogoName
            // 
            this.lblLastPogoName.AutoSize = true;
            this.lblLastPogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPogoName.Location = new System.Drawing.Point(57, 489);
            this.lblLastPogoName.Name = "lblLastPogoName";
            this.lblLastPogoName.Size = new System.Drawing.Size(15, 16);
            this.lblLastPogoName.TabIndex = 38;
            this.lblLastPogoName.Text = "0";
            // 
            // imgPokemonLastCaught
            // 
            this.imgPokemonLastCaught.BackColor = System.Drawing.Color.Transparent;
            this.imgPokemonLastCaught.Image = global::Specter.Properties.Resources.imgPokemonUnknow;
            this.imgPokemonLastCaught.ImageActive = null;
            this.imgPokemonLastCaught.Location = new System.Drawing.Point(95, 438);
            this.imgPokemonLastCaught.Name = "imgPokemonLastCaught";
            this.imgPokemonLastCaught.Size = new System.Drawing.Size(50, 45);
            this.imgPokemonLastCaught.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgPokemonLastCaught.TabIndex = 37;
            this.imgPokemonLastCaught.TabStop = false;
            this.imgPokemonLastCaught.Zoom = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(3, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 24);
            this.panel3.TabIndex = 30;
            // 
            // txtPogoPassword
            // 
            this.txtPogoPassword.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtPogoPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPogoPassword.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtPogoPassword.BorderThickness = 3;
            this.txtPogoPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPogoPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPogoPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPogoPassword.isPassword = true;
            this.txtPogoPassword.Location = new System.Drawing.Point(126, 138);
            this.txtPogoPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPogoPassword.Name = "txtPogoPassword";
            this.txtPogoPassword.Size = new System.Drawing.Size(139, 25);
            this.txtPogoPassword.TabIndex = 24;
            this.txtPogoPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tpDicas.SetToolTip(this.txtPogoPassword, "Senha para Pokémon Trainer Clube & Senha de APP para contas Google.");
            // 
            // txtPogoUsername
            // 
            this.txtPogoUsername.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtPogoUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPogoUsername.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtPogoUsername.BorderThickness = 3;
            this.txtPogoUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPogoUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPogoUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPogoUsername.isPassword = false;
            this.txtPogoUsername.Location = new System.Drawing.Point(126, 108);
            this.txtPogoUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtPogoUsername.Name = "txtPogoUsername";
            this.txtPogoUsername.Size = new System.Drawing.Size(139, 25);
            this.txtPogoUsername.TabIndex = 23;
            this.txtPogoUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tpDicas.SetToolTip(this.txtPogoUsername, "Nome de Usuario para contas PTC & E-mail para contas Google.");
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.IndianRed;
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "DESLOGAR";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Enabled = false;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = null;
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 90D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(136, 326);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnLogout.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(121, 49);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "DESLOGAR";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "LOGAR";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnLogin.Location = new System.Drawing.Point(7, 326);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(121, 49);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "LOGAR";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // rbPTC
            // 
            this.rbPTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPTC.Location = new System.Drawing.Point(168, 244);
            this.rbPTC.Name = "rbPTC";
            this.rbPTC.Size = new System.Drawing.Size(89, 21);
            this.rbPTC.TabIndex = 8;
            this.rbPTC.Text = "PTC";
            this.tpDicas.SetToolTip(this.rbPTC, "Contas que utilizam o Pokémon Trainer Clube para realizar o login.");
            this.rbPTC.UseVisualStyleBackColor = true;
            // 
            // rbGoogle
            // 
            this.rbGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGoogle.Location = new System.Drawing.Point(35, 244);
            this.rbGoogle.Name = "rbGoogle";
            this.rbGoogle.Size = new System.Drawing.Size(110, 21);
            this.rbGoogle.TabIndex = 6;
            this.rbGoogle.Text = "GOOGLE";
            this.tpDicas.SetToolTip(this.rbGoogle, "Contas que utilizam o Google para realizar o login.");
            this.rbGoogle.UseVisualStyleBackColor = true;
            // 
            // panelStatus
            // 
            this.panelStatus.AutoSize = true;
            this.panelStatus.BackColor = System.Drawing.Color.SeaGreen;
            this.panelStatus.Controls.Add(this.btnMinimize);
            this.panelStatus.Controls.Add(this.btnMaximize);
            this.panelStatus.Controls.Add(this.btnExit);
            this.panelStatus.Controls.Add(lblLoginTitulo);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1213, 35);
            this.panelStatus.TabIndex = 99;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::Specter.Properties.Resources.btnMinize;
            this.btnMinimize.Location = new System.Drawing.Point(1125, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = global::Specter.Properties.Resources.btnMaximize;
            this.btnMaximize.Location = new System.Drawing.Point(1153, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(22, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 18;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Specter.Properties.Resources.btnExit;
            this.btnExit.Location = new System.Drawing.Point(1181, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerAtualizaStatus
            // 
            this.timerAtualizaStatus.Interval = 750;
            this.timerAtualizaStatus.Tick += new System.EventHandler(this.timerAtualizaStatus_Tick);
            // 
            // bunifuDragFormsPrincipal
            // 
            this.bunifuDragFormsPrincipal.Fixed = true;
            this.bunifuDragFormsPrincipal.Horizontal = true;
            this.bunifuDragFormsPrincipal.TargetControl = this.panelStatus;
            this.bunifuDragFormsPrincipal.Vertical = true;
            // 
            // timerUpdateGrid
            // 
            this.timerUpdateGrid.Interval = 1000;
            this.timerUpdateGrid.Tick += new System.EventHandler(this.timerUpdateGrid_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1213, 666);
            this.Controls.Add(this.panelListaPokemon);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pnHeaderRight);
            this.Controls.Add(this.panelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Specter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            panelLoginTitle.ResumeLayout(false);
            panelLoginTitle.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            this.pnHeaderRight.ResumeLayout(false);
            this.pnHeaderRight.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.panelListaPokemon.ResumeLayout(false);
            this.panelListaPokemon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cardsPrincipal.ResumeLayout(false);
            this.cardsPrincipal.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPokemons)).EndInit();
            this.menuSnipe.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemonLastCaught)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelListaPokemon;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.RadioButton rbPTC;
        private System.Windows.Forms.RadioButton rbGoogle;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblEscapadoValue;
        private System.Windows.Forms.Label lblMochilaValue;
        private System.Windows.Forms.Label lblPokebolasValue;
        private System.Windows.Forms.Label lblTotalCapturado;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblNomeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchLog;
        private System.Windows.Forms.Panel pnHeaderRight;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblAtividadesTexto;
        private ns1.BunifuFlatButton btnLogin;
        public ns1.BunifuMetroTextbox txtPogoPassword;
        private ns1.BunifuMetroTextbox txtPogoUsername;
        private ns1.BunifuFlatButton btnLogout;
        private System.Windows.Forms.Label lblApiValue;
        private System.Windows.Forms.Label lblVersionValue;
        private System.Windows.Forms.Label lblVersionText;
        private System.Windows.Forms.Timer timerAtualizaStatus;
        private ns1.BunifuCustomDataGrid gridPokemons;
        private ns1.BunifuFlatButton btnProcurarPokemon;
        private System.Windows.Forms.ContextMenuStrip menuSnipe;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuSeparator bunifuSeparator3;
        private System.ComponentModel.BackgroundWorker workerAPI;
        private System.Windows.Forms.Timer timerAPI;
        private System.Windows.Forms.ToolStripMenuItem menuSniperRazzBerry;
        private System.Windows.Forms.ToolStripMenuItem menuSniperNanaBerry;
        private System.Windows.Forms.ToolStripMenuItem menuSniperCopyCoordinates;
        private System.Windows.Forms.ToolStripMenuItem menuSniperCatchStandard;
        private ns1.BunifuCards cardsPrincipal;
        private ns1.BunifuCards bunifuCards2;
        private ns1.BunifuSeparator bunifuSeparator4;
        private ns1.BunifuCheckbox cbIv100;
        private System.Windows.Forms.ToolStripMenuItem menuSniperCatchManual;
        private System.Windows.Forms.ToolTip tpDicas;
        private ns1.BunifuDragControl bunifuDragFormsPrincipal;
        private ns1.BunifuCards bunifuCards3;
        private System.Windows.Forms.LinkLabel linkErrorBugs;
        private System.Windows.Forms.LinkLabel linkNomePokemons;
        private System.Windows.Forms.LinkLabel linkGerarSenhaApp;
        private System.Windows.Forms.LinkLabel linkComprarChave;
        private System.Windows.Forms.LinkLabel linkPaginaOficial;
        private System.ComponentModel.BackgroundWorker loadingPokemons;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCapturado;
        private System.Windows.Forms.Label lblescapado;
        private System.Windows.Forms.Label lblPokebolas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPokemonPremium;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerSnipingTick;
        private ns1.BunifuCheckbox cbPlaySom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem menuSniperPinapBerry;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.ComboBox cbPokebola;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtProcuraPoke;
        private System.Windows.Forms.ToolStripMenuItem menuSniperGoldenBerry;
        private System.Windows.Forms.Label lblCapturaAutomatica;
        private ns1.BunifuFlatButton btnConfigurarAutoCatch;
        private ns1.BunifuiOSSwitch btnAutoCatch;
        private System.Windows.Forms.Timer timerUpdateGrid;
        private ns1.BunifuImageButton imgPokemonLastCaught;
        private System.Windows.Forms.DataGridViewImageColumn cPokemonIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumver;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewImageColumn cCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTimeLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCatchTime;
        private System.Windows.Forms.Label lblLastPogoDate;
        private System.Windows.Forms.Label lblLastPogoInfo;
        private System.Windows.Forms.Label lblLastPogoName;
    }
}