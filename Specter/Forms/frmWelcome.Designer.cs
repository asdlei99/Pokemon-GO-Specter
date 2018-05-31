namespace Specter.Forms
{
    partial class frmWelcome
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
            ns1.BunifuCustomLabel lblWelcomeTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnNext = new ns1.BunifuFlatButton();
            this.picGuide = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new ns1.BunifuDragControl(this.components);
            lblWelcomeTitle = new ns1.BunifuCustomLabel();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGuide)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.AutoSize = true;
            lblWelcomeTitle.BackColor = System.Drawing.Color.Transparent;
            lblWelcomeTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWelcomeTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblWelcomeTitle.Location = new System.Drawing.Point(12, 9);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new System.Drawing.Size(385, 33);
            lblWelcomeTitle.TabIndex = 14;
            lblWelcomeTitle.Text = "BEM VINDO AO GUIA INICIAL";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.SeaGreen;
            this.pnTop.Controls.Add(lblWelcomeTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(980, 54);
            this.pnTop.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.BorderRadius = 0;
            this.btnNext.ButtonText = "PROSSEGUIR";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledColor = System.Drawing.Color.Gray;
            this.btnNext.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNext.Iconimage = null;
            this.btnNext.Iconimage_right = null;
            this.btnNext.Iconimage_right_Selected = null;
            this.btnNext.Iconimage_Selected = null;
            this.btnNext.IconMarginLeft = 0;
            this.btnNext.IconMarginRight = 0;
            this.btnNext.IconRightVisible = true;
            this.btnNext.IconRightZoom = 0D;
            this.btnNext.IconVisible = true;
            this.btnNext.IconZoom = 90D;
            this.btnNext.IsTab = false;
            this.btnNext.Location = new System.Drawing.Point(321, 454);
            this.btnNext.Name = "btnNext";
            this.btnNext.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNext.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNext.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNext.selected = false;
            this.btnNext.Size = new System.Drawing.Size(241, 48);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "PROSSEGUIR";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Textcolor = System.Drawing.Color.White;
            this.btnNext.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picGuide
            // 
            this.picGuide.Image = global::Specter.Properties.Resources.GUIA1;
            this.picGuide.Location = new System.Drawing.Point(53, 83);
            this.picGuide.Name = "picGuide";
            this.picGuide.Size = new System.Drawing.Size(865, 353);
            this.picGuide.TabIndex = 2;
            this.picGuide.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = lblWelcomeTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this;
            this.bunifuDragControl3.Vertical = true;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(980, 514);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picGuide);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPECTER: GUIA";
            this.TopMost = true;
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGuide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.PictureBox picGuide;
        private ns1.BunifuFlatButton btnNext;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuDragControl bunifuDragControl3;
    }
}