namespace Specter.FORMS
{
    partial class frmNewLogin
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
            System.Windows.Forms.Label label1;
            ns1.BunifuImageButton btImageLog;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewLogin));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblVersao = new ns1.BunifuCustomLabel();
            this.txtCodigo = new ns1.BunifuMetroTextbox();
            this.dragTop = new ns1.BunifuDragControl(this.components);
            this.btnExit = new ns1.BunifuFlatButton();
            this.btnLogin = new ns1.BunifuFlatButton();
            label1 = new System.Windows.Forms.Label();
            btImageLog = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(btImageLog)).BeginInit();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(332, 22);
            label1.TabIndex = 1;
            label1.Text = "SPECTER - Capturador de Pokemon";
            // 
            // btImageLog
            // 
            btImageLog.BackColor = System.Drawing.Color.Transparent;
            btImageLog.Image = global::Specter.Properties.Resources.logoSpecter;
            btImageLog.ImageActive = null;
            btImageLog.Location = new System.Drawing.Point(272, 66);
            btImageLog.Name = "btImageLog";
            btImageLog.Size = new System.Drawing.Size(178, 147);
            btImageLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            btImageLog.TabIndex = 0;
            btImageLog.TabStop = false;
            btImageLog.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnTop.Controls.Add(label1);
            this.pnTop.Controls.Add(this.lblVersao);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(736, 38);
            this.pnTop.TabIndex = 1;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblVersao.Location = new System.Drawing.Point(633, 13);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(85, 13);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "VERSÃO: NULL";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtCodigo.BorderColorIdle = System.Drawing.Color.White;
            this.txtCodigo.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtCodigo.BorderThickness = 3;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigo.isPassword = false;
            this.txtCodigo.Location = new System.Drawing.Point(179, 240);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(370, 44);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Text = "CODIGO DE ACESSO";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            // 
            // dragTop
            // 
            this.dragTop.Fixed = true;
            this.dragTop.Horizontal = true;
            this.dragTop.TargetControl = this.pnTop;
            this.dragTop.Vertical = true;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.Firebrick;
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "EXIT";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = null;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(387, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnExit.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(139, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnLogin.Location = new System.Drawing.Point(200, 312);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(139, 48);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmNewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(736, 383);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(btImageLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewLogin";
            this.Load += new System.EventHandler(this.frmNewLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(btImageLog)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuFlatButton btnExit;
        private ns1.BunifuMetroTextbox txtCodigo;
        private ns1.BunifuFlatButton btnLogin;
        private System.Windows.Forms.Panel pnTop;
        private ns1.BunifuDragControl dragTop;
        private ns1.BunifuCustomLabel lblVersao;
    }
}