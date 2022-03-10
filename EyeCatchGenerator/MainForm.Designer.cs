namespace EyeCatchGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.gpImage = new System.Windows.Forms.GroupBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblNavigate2 = new System.Windows.Forms.Label();
            this.lblNavigate1 = new System.Windows.Forms.Label();
            this.gpSettings = new System.Windows.Forms.GroupBox();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTitleAlignH = new System.Windows.Forms.Panel();
            this.rdoTitleAHRight = new System.Windows.Forms.RadioButton();
            this.rdoTitleAHCenter = new System.Windows.Forms.RadioButton();
            this.rdoTitleAHLeft = new System.Windows.Forms.RadioButton();
            this.pnlTitleAlignV = new System.Windows.Forms.Panel();
            this.rdoTitleAVBottom = new System.Windows.Forms.RadioButton();
            this.rdoTitleAVCenter = new System.Windows.Forms.RadioButton();
            this.rdoTitleAVTop = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSizeH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSizeW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.gpImage.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.gpSettings.SuspendLayout();
            this.pnlTitleAlignH.SuspendLayout();
            this.pnlTitleAlignV.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpImage
            // 
            this.gpImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpImage.Controls.Add(this.pnlImage);
            this.gpImage.Location = new System.Drawing.Point(14, 15);
            this.gpImage.Margin = new System.Windows.Forms.Padding(4);
            this.gpImage.Name = "gpImage";
            this.gpImage.Padding = new System.Windows.Forms.Padding(4);
            this.gpImage.Size = new System.Drawing.Size(607, 572);
            this.gpImage.TabIndex = 0;
            this.gpImage.TabStop = false;
            this.gpImage.Text = "イメージ";
            // 
            // pnlImage
            // 
            this.pnlImage.AllowDrop = true;
            this.pnlImage.AutoScroll = true;
            this.pnlImage.Controls.Add(this.picImage);
            this.pnlImage.Controls.Add(this.lblNavigate2);
            this.pnlImage.Controls.Add(this.lblNavigate1);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(4, 20);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(599, 548);
            this.pnlImage.TabIndex = 1;
            this.pnlImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlNavigate_DragDrop);
            this.pnlImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlImage_DragEnter);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(599, 548);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            this.picImage.Visible = false;
            this.picImage.Paint += new System.Windows.Forms.PaintEventHandler(this.picImage_Paint);
            // 
            // lblNavigate2
            // 
            this.lblNavigate2.AutoSize = true;
            this.lblNavigate2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNavigate2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNavigate2.Location = new System.Drawing.Point(26, 205);
            this.lblNavigate2.Name = "lblNavigate2";
            this.lblNavigate2.Size = new System.Drawing.Size(383, 32);
            this.lblNavigate2.TabIndex = 0;
            this.lblNavigate2.Text = "設定で画像ファイルを選択してください。";
            // 
            // lblNavigate1
            // 
            this.lblNavigate1.AutoSize = true;
            this.lblNavigate1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNavigate1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNavigate1.Location = new System.Drawing.Point(26, 173);
            this.lblNavigate1.Name = "lblNavigate1";
            this.lblNavigate1.Size = new System.Drawing.Size(418, 32);
            this.lblNavigate1.TabIndex = 0;
            this.lblNavigate1.Text = "ここに画像ファイルをドラッグ＆ドロップするか";
            // 
            // gpSettings
            // 
            this.gpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpSettings.Controls.Add(this.btnFontColor);
            this.gpSettings.Controls.Add(this.cmbSize);
            this.gpSettings.Controls.Add(this.btnFont);
            this.gpSettings.Controls.Add(this.label1);
            this.gpSettings.Controls.Add(this.btnReset);
            this.gpSettings.Controls.Add(this.label10);
            this.gpSettings.Controls.Add(this.pnlTitleAlignH);
            this.gpSettings.Controls.Add(this.pnlTitleAlignV);
            this.gpSettings.Controls.Add(this.btnSave);
            this.gpSettings.Controls.Add(this.label9);
            this.gpSettings.Controls.Add(this.label8);
            this.gpSettings.Controls.Add(this.txtTitle);
            this.gpSettings.Controls.Add(this.label7);
            this.gpSettings.Controls.Add(this.label6);
            this.gpSettings.Controls.Add(this.txtSizeH);
            this.gpSettings.Controls.Add(this.label5);
            this.gpSettings.Controls.Add(this.txtSizeW);
            this.gpSettings.Controls.Add(this.label4);
            this.gpSettings.Controls.Add(this.label3);
            this.gpSettings.Controls.Add(this.btnFileSearch);
            this.gpSettings.Controls.Add(this.txtFilePath);
            this.gpSettings.Location = new System.Drawing.Point(627, 15);
            this.gpSettings.Margin = new System.Windows.Forms.Padding(4);
            this.gpSettings.Name = "gpSettings";
            this.gpSettings.Padding = new System.Windows.Forms.Padding(4);
            this.gpSettings.Size = new System.Drawing.Size(237, 572);
            this.gpSettings.TabIndex = 1;
            this.gpSettings.TabStop = false;
            this.gpSettings.Text = "設定";
            // 
            // btnFontColor
            // 
            this.btnFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFontColor.Location = new System.Drawing.Point(7, 445);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(222, 23);
            this.btnFontColor.TabIndex = 35;
            this.btnFontColor.Text = "フォントカラー";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "オリジナル",
            "カスタム",
            "小(横300px)",
            "中(横500px)",
            "大(横700px)"});
            this.cmbSize.Location = new System.Drawing.Point(7, 128);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(222, 23);
            this.cmbSize.TabIndex = 34;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFont.Location = new System.Drawing.Point(7, 416);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(222, 23);
            this.btnFont.TabIndex = 32;
            this.btnFont.Text = "フォント・修飾・サイズ";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "フォント";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(7, 513);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(222, 23);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "タイトル位置(上下)";
            // 
            // pnlTitleAlignH
            // 
            this.pnlTitleAlignH.Controls.Add(this.rdoTitleAHRight);
            this.pnlTitleAlignH.Controls.Add(this.rdoTitleAHCenter);
            this.pnlTitleAlignH.Controls.Add(this.rdoTitleAHLeft);
            this.pnlTitleAlignH.Enabled = false;
            this.pnlTitleAlignH.Location = new System.Drawing.Point(2, 324);
            this.pnlTitleAlignH.Name = "pnlTitleAlignH";
            this.pnlTitleAlignH.Size = new System.Drawing.Size(233, 25);
            this.pnlTitleAlignH.TabIndex = 30;
            // 
            // rdoTitleAHRight
            // 
            this.rdoTitleAHRight.AutoSize = true;
            this.rdoTitleAHRight.Location = new System.Drawing.Point(133, 3);
            this.rdoTitleAHRight.Name = "rdoTitleAHRight";
            this.rdoTitleAHRight.Size = new System.Drawing.Size(59, 19);
            this.rdoTitleAHRight.TabIndex = 16;
            this.rdoTitleAHRight.Text = "右寄せ";
            this.rdoTitleAHRight.UseVisualStyleBackColor = true;
            this.rdoTitleAHRight.CheckedChanged += new System.EventHandler(this.rdoTitleAlign_CheckedChanged);
            // 
            // rdoTitleAHCenter
            // 
            this.rdoTitleAHCenter.AutoSize = true;
            this.rdoTitleAHCenter.Location = new System.Drawing.Point(73, 3);
            this.rdoTitleAHCenter.Name = "rdoTitleAHCenter";
            this.rdoTitleAHCenter.Size = new System.Drawing.Size(49, 19);
            this.rdoTitleAHCenter.TabIndex = 15;
            this.rdoTitleAHCenter.Text = "中央";
            this.rdoTitleAHCenter.UseVisualStyleBackColor = true;
            this.rdoTitleAHCenter.CheckedChanged += new System.EventHandler(this.rdoTitleAlign_CheckedChanged);
            // 
            // rdoTitleAHLeft
            // 
            this.rdoTitleAHLeft.AutoSize = true;
            this.rdoTitleAHLeft.Checked = true;
            this.rdoTitleAHLeft.Location = new System.Drawing.Point(3, 3);
            this.rdoTitleAHLeft.Name = "rdoTitleAHLeft";
            this.rdoTitleAHLeft.Size = new System.Drawing.Size(59, 19);
            this.rdoTitleAHLeft.TabIndex = 14;
            this.rdoTitleAHLeft.TabStop = true;
            this.rdoTitleAHLeft.Text = "左寄せ";
            this.rdoTitleAHLeft.UseVisualStyleBackColor = true;
            this.rdoTitleAHLeft.CheckedChanged += new System.EventHandler(this.rdoTitleAlign_CheckedChanged);
            // 
            // pnlTitleAlignV
            // 
            this.pnlTitleAlignV.Controls.Add(this.rdoTitleAVBottom);
            this.pnlTitleAlignV.Controls.Add(this.rdoTitleAVCenter);
            this.pnlTitleAlignV.Controls.Add(this.rdoTitleAVTop);
            this.pnlTitleAlignV.Enabled = false;
            this.pnlTitleAlignV.Location = new System.Drawing.Point(2, 370);
            this.pnlTitleAlignV.Name = "pnlTitleAlignV";
            this.pnlTitleAlignV.Size = new System.Drawing.Size(233, 25);
            this.pnlTitleAlignV.TabIndex = 29;
            // 
            // rdoTitleAVBottom
            // 
            this.rdoTitleAVBottom.AutoSize = true;
            this.rdoTitleAVBottom.Location = new System.Drawing.Point(133, 3);
            this.rdoTitleAVBottom.Name = "rdoTitleAVBottom";
            this.rdoTitleAVBottom.Size = new System.Drawing.Size(59, 19);
            this.rdoTitleAVBottom.TabIndex = 16;
            this.rdoTitleAVBottom.Text = "下寄せ";
            this.rdoTitleAVBottom.UseVisualStyleBackColor = true;
            this.rdoTitleAVBottom.CheckedChanged += new System.EventHandler(this.rdoTitleAlign_CheckedChanged);
            // 
            // rdoTitleAVCenter
            // 
            this.rdoTitleAVCenter.AutoSize = true;
            this.rdoTitleAVCenter.Checked = true;
            this.rdoTitleAVCenter.Location = new System.Drawing.Point(73, 3);
            this.rdoTitleAVCenter.Name = "rdoTitleAVCenter";
            this.rdoTitleAVCenter.Size = new System.Drawing.Size(49, 19);
            this.rdoTitleAVCenter.TabIndex = 15;
            this.rdoTitleAVCenter.TabStop = true;
            this.rdoTitleAVCenter.Text = "中央";
            this.rdoTitleAVCenter.UseVisualStyleBackColor = true;
            this.rdoTitleAVCenter.CheckedChanged += new System.EventHandler(this.rdoTitleAlign_CheckedChanged);
            // 
            // rdoTitleAVTop
            // 
            this.rdoTitleAVTop.AutoSize = true;
            this.rdoTitleAVTop.Location = new System.Drawing.Point(3, 3);
            this.rdoTitleAVTop.Name = "rdoTitleAVTop";
            this.rdoTitleAVTop.Size = new System.Drawing.Size(59, 19);
            this.rdoTitleAVTop.TabIndex = 14;
            this.rdoTitleAVTop.Text = "上寄せ";
            this.rdoTitleAVTop.UseVisualStyleBackColor = true;
            this.rdoTitleAVTop.CheckedChanged += new System.EventHandler(this.rdoTitleAlign_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(7, 542);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "サイズ(簡単設定)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "タイトル位置(左右)";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(7, 172);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(222, 131);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "タイトル";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "px";
            // 
            // txtSizeH
            // 
            this.txtSizeH.Enabled = false;
            this.txtSizeH.Location = new System.Drawing.Point(131, 82);
            this.txtSizeH.Name = "txtSizeH";
            this.txtSizeH.Size = new System.Drawing.Size(72, 23);
            this.txtSizeH.TabIndex = 6;
            this.txtSizeH.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "px  ×  ";
            // 
            // txtSizeW
            // 
            this.txtSizeW.Enabled = false;
            this.txtSizeW.Location = new System.Drawing.Point(7, 82);
            this.txtSizeW.Name = "txtSizeW";
            this.txtSizeW.Size = new System.Drawing.Size(72, 23);
            this.txtSizeW.TabIndex = 4;
            this.txtSizeW.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "サイズ(横×高さ)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "画像選択";
            // 
            // btnFileSearch
            // 
            this.btnFileSearch.Location = new System.Drawing.Point(203, 37);
            this.btnFileSearch.Name = "btnFileSearch";
            this.btnFileSearch.Size = new System.Drawing.Size(26, 25);
            this.btnFileSearch.TabIndex = 1;
            this.btnFileSearch.Text = "...";
            this.btnFileSearch.UseVisualStyleBackColor = true;
            this.btnFileSearch.Click += new System.EventHandler(this.btnFileSearch_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(7, 38);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(189, 23);
            this.txtFilePath.TabIndex = 0;
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 602);
            this.Controls.Add(this.gpSettings);
            this.Controls.Add(this.gpImage);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(894, 641);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "アイキャッチジェネレーター";
            this.gpImage.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.gpSettings.ResumeLayout(false);
            this.gpSettings.PerformLayout();
            this.pnlTitleAlignH.ResumeLayout(false);
            this.pnlTitleAlignH.PerformLayout();
            this.pnlTitleAlignV.ResumeLayout(false);
            this.pnlTitleAlignV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpImage;
        private System.Windows.Forms.GroupBox gpSettings;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label lblNavigate2;
        private System.Windows.Forms.Label lblNavigate1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSizeH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSizeW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFileSearch;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel pnlTitleAlignH;
        private System.Windows.Forms.RadioButton rdoTitleAHRight;
        private System.Windows.Forms.RadioButton rdoTitleAHCenter;
        private System.Windows.Forms.RadioButton rdoTitleAHLeft;
        private System.Windows.Forms.Panel pnlTitleAlignV;
        private System.Windows.Forms.RadioButton rdoTitleAVBottom;
        private System.Windows.Forms.RadioButton rdoTitleAVCenter;
        private System.Windows.Forms.RadioButton rdoTitleAVTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

