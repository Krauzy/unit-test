namespace Unit
{
    partial class UnitFrame
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VersionText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.hSeparator1 = new Unit.Components.HSeparator();
            this.hSeparator2 = new Unit.Components.HSeparator();
            this.vSeparator1 = new Unit.Components.VSeparator();
            this.CashText = new System.Windows.Forms.Label();
            this.hSeparator3 = new Unit.Components.HSeparator();
            this.LossButton = new System.Windows.Forms.Button();
            this.ProfitButton = new System.Windows.Forms.Button();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ValueText = new System.Windows.Forms.TextBox();
            this.CheckText = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(306, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(36, 26);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "✕";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.VersionText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 26);
            this.panel1.TabIndex = 1;
            // 
            // VersionText
            // 
            this.VersionText.AutoSize = true;
            this.VersionText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionText.ForeColor = System.Drawing.Color.White;
            this.VersionText.Location = new System.Drawing.Point(80, 7);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(12, 16);
            this.VersionText.TabIndex = 2;
            this.VersionText.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit Test";
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.Color.DarkRed;
            this.SalesButton.FlatAppearance.BorderSize = 0;
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.Color.White;
            this.SalesButton.Location = new System.Drawing.Point(76, 56);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(49, 34);
            this.SalesButton.TabIndex = 4;
            this.SalesButton.Text = "OFF";
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 34);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caixa";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(167, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 34);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saldo";
            // 
            // hSeparator1
            // 
            this.hSeparator1.LineColor = System.Drawing.Color.RoyalBlue;
            this.hSeparator1.LineWidth = 2;
            this.hSeparator1.Location = new System.Drawing.Point(231, 78);
            this.hSeparator1.Name = "hSeparator1";
            this.hSeparator1.Size = new System.Drawing.Size(93, 23);
            this.hSeparator1.TabIndex = 7;
            this.hSeparator1.Text = "hSeparator1";
            // 
            // hSeparator2
            // 
            this.hSeparator2.LineColor = System.Drawing.Color.RoyalBlue;
            this.hSeparator2.LineWidth = 2;
            this.hSeparator2.Location = new System.Drawing.Point(231, 46);
            this.hSeparator2.Name = "hSeparator2";
            this.hSeparator2.Size = new System.Drawing.Size(93, 23);
            this.hSeparator2.TabIndex = 8;
            this.hSeparator2.Text = "hSeparator2";
            // 
            // vSeparator1
            // 
            this.vSeparator1.LineColor = System.Drawing.Color.RoyalBlue;
            this.vSeparator1.LineWidth = 2;
            this.vSeparator1.Location = new System.Drawing.Point(315, 56);
            this.vSeparator1.Name = "vSeparator1";
            this.vSeparator1.Size = new System.Drawing.Size(21, 34);
            this.vSeparator1.TabIndex = 9;
            this.vSeparator1.Text = "vSeparator1";
            // 
            // CashText
            // 
            this.CashText.AutoSize = true;
            this.CashText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashText.Location = new System.Drawing.Point(232, 65);
            this.CashText.Name = "CashText";
            this.CashText.Size = new System.Drawing.Size(63, 17);
            this.CashText.TabIndex = 10;
            this.CashText.Text = "R$ 100,00";
            // 
            // hSeparator3
            // 
            this.hSeparator3.LineColor = System.Drawing.Color.LightGray;
            this.hSeparator3.LineWidth = 1;
            this.hSeparator3.Location = new System.Drawing.Point(11, 96);
            this.hSeparator3.Name = "hSeparator3";
            this.hSeparator3.Size = new System.Drawing.Size(313, 23);
            this.hSeparator3.TabIndex = 11;
            this.hSeparator3.Text = "hSeparator3";
            // 
            // LossButton
            // 
            this.LossButton.BackColor = System.Drawing.Color.DarkRed;
            this.LossButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.LossButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LossButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossButton.ForeColor = System.Drawing.Color.White;
            this.LossButton.Location = new System.Drawing.Point(38, 125);
            this.LossButton.Name = "LossButton";
            this.LossButton.Size = new System.Drawing.Size(130, 36);
            this.LossButton.TabIndex = 12;
            this.LossButton.Text = "Sangria";
            this.LossButton.UseVisualStyleBackColor = false;
            this.LossButton.Click += new System.EventHandler(this.LossButton_Click);
            // 
            // ProfitButton
            // 
            this.ProfitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.ProfitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfitButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ProfitButton.Location = new System.Drawing.Point(167, 125);
            this.ProfitButton.Name = "ProfitButton";
            this.ProfitButton.Size = new System.Drawing.Size(130, 36);
            this.ProfitButton.TabIndex = 13;
            this.ProfitButton.Text = "Provento";
            this.ProfitButton.UseVisualStyleBackColor = true;
            this.ProfitButton.Click += new System.EventHandler(this.ProfitButton_Click);
            // 
            // DescriptionText
            // 
            this.DescriptionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DescriptionText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionText.Location = new System.Drawing.Point(38, 257);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(259, 188);
            this.DescriptionText.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(38, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 26);
            this.panel4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Motivo";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(38, 457);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(259, 33);
            this.ConfirmButton.TabIndex = 16;
            this.ConfirmButton.Text = "CONFIRMAR";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(38, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(38, 27);
            this.panel5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "R$";
            // 
            // ValueText
            // 
            this.ValueText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueText.Location = new System.Drawing.Point(76, 181);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(92, 27);
            this.ValueText.TabIndex = 17;
            this.ValueText.TextChanged += new System.EventHandler(this.ValueText_TextChanged);
            this.ValueText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueText_KeyPress);
            // 
            // CheckText
            // 
            this.CheckText.AutoSize = true;
            this.CheckText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckText.ForeColor = System.Drawing.Color.Red;
            this.CheckText.Location = new System.Drawing.Point(175, 187);
            this.CheckText.Name = "CheckText";
            this.CheckText.Size = new System.Drawing.Size(0, 17);
            this.CheckText.TabIndex = 18;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // UnitFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 503);
            this.Controls.Add(this.CheckText);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.ProfitButton);
            this.Controls.Add(this.LossButton);
            this.Controls.Add(this.hSeparator3);
            this.Controls.Add(this.CashText);
            this.Controls.Add(this.hSeparator1);
            this.Controls.Add(this.hSeparator2);
            this.Controls.Add(this.vSeparator1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnitFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VersionText;
        public System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Components.HSeparator hSeparator1;
        private Components.HSeparator hSeparator2;
        private Components.VSeparator vSeparator1;
        public System.Windows.Forms.Label CashText;
        private Components.HSeparator hSeparator3;
        private System.Windows.Forms.Button LossButton;
        private System.Windows.Forms.Button ProfitButton;
        public System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox ValueText;
        public System.Windows.Forms.Label CheckText;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

