using Specter.MODEL;

namespace Specter.FORMS
{
    partial class FrmCapturaManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapturaManual));
            this.lblNomePokemon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.txtCaptura = new ns1.BunifuMetroTextbox();
            this.btnCapturar = new ns1.BunifuFlatButton();
            this.btnFechar = new ns1.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomePokemon
            // 
            this.lblNomePokemon.AutoSize = true;
            this.lblNomePokemon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePokemon.Location = new System.Drawing.Point(21, 55);
            this.lblNomePokemon.Name = "lblNomePokemon";
            this.lblNomePokemon.Size = new System.Drawing.Size(87, 21);
            this.lblNomePokemon.TabIndex = 5;
            this.lblNomePokemon.Text = "CAPTURA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "CAPTURA MANUAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formato: NomeDoPokemon, Latitude, Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Exemplo: Dragonite,34.43434,-66.343443";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtCaptura
            // 
            this.txtCaptura.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCaptura.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCaptura.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCaptura.BorderThickness = 3;
            this.txtCaptura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaptura.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCaptura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCaptura.isPassword = false;
            this.txtCaptura.Location = new System.Drawing.Point(115, 48);
            this.txtCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaptura.Name = "txtCaptura";
            this.txtCaptura.Size = new System.Drawing.Size(282, 30);
            this.txtCaptura.TabIndex = 0;
            this.txtCaptura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapturar.BorderRadius = 0;
            this.btnCapturar.ButtonText = "CAPTURAR";
            this.btnCapturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapturar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCapturar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCapturar.Iconimage = null;
            this.btnCapturar.Iconimage_right = null;
            this.btnCapturar.Iconimage_right_Selected = null;
            this.btnCapturar.Iconimage_Selected = null;
            this.btnCapturar.IconMarginLeft = 0;
            this.btnCapturar.IconMarginRight = 0;
            this.btnCapturar.IconRightVisible = true;
            this.btnCapturar.IconRightZoom = 0D;
            this.btnCapturar.IconVisible = true;
            this.btnCapturar.IconZoom = 90D;
            this.btnCapturar.IsTab = false;
            this.btnCapturar.Location = new System.Drawing.Point(87, 87);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapturar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCapturar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCapturar.selected = false;
            this.btnCapturar.Size = new System.Drawing.Size(103, 31);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "CAPTURAR";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapturar.Textcolor = System.Drawing.Color.White;
            this.btnCapturar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Activecolor = System.Drawing.Color.Tomato;
            this.btnFechar.BackColor = System.Drawing.Color.Tomato;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.BorderRadius = 0;
            this.btnFechar.ButtonText = "FECHAR";
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFechar.Iconimage = null;
            this.btnFechar.Iconimage_right = null;
            this.btnFechar.Iconimage_right_Selected = null;
            this.btnFechar.Iconimage_Selected = null;
            this.btnFechar.IconMarginLeft = 0;
            this.btnFechar.IconMarginRight = 0;
            this.btnFechar.IconRightVisible = true;
            this.btnFechar.IconRightZoom = 0D;
            this.btnFechar.IconVisible = true;
            this.btnFechar.IconZoom = 90D;
            this.btnFechar.IsTab = false;
            this.btnFechar.Location = new System.Drawing.Point(240, 87);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Normalcolor = System.Drawing.Color.Tomato;
            this.btnFechar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFechar.selected = false;
            this.btnFechar.Size = new System.Drawing.Size(95, 31);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.Textcolor = System.Drawing.Color.White;
            this.btnFechar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 28);
            this.panel1.TabIndex = 9;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNomePokemon);
            this.panel2.Controls.Add(this.txtCaptura);
            this.panel2.Controls.Add(this.btnCapturar);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 133);
            this.panel2.TabIndex = 10;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // FrmCapturaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 161);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCapturaManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapturaManual";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmCapturaManual_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuFlatButton btnFechar;
        private ns1.BunifuFlatButton btnCapturar;
        private ns1.BunifuMetroTextbox txtCaptura;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label lblNomePokemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}