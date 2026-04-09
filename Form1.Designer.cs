namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbltitle = new Label();
            rdoMenu1 = new RadioButton();
            rdoMenu2 = new RadioButton();
            rdoMenu3 = new RadioButton();
            grpMenu = new GroupBox();
            grpOption = new GroupBox();
            picBurger = new PictureBox();
            picBulggogi = new PictureBox();
            picChicken = new PictureBox();
            chkOption1 = new CheckBox();
            chkOption2 = new CheckBox();
            chkOption3 = new CheckBox();
            chkOption4 = new CheckBox();
            grpOrder = new GroupBox();
            lstOrderbox = new ListBox();
            lblAmount = new Label();
            btnOrder = new Button();
            btnReset = new Button();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulggogi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("한컴 고딕", 26F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbltitle.ForeColor = Color.Blue;
            lbltitle.Location = new Point(35, 1);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(441, 68);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "버거 주문 키오스크";
            // 
            // rdoMenu1
            // 
            rdoMenu1.AutoSize = true;
            rdoMenu1.ForeColor = SystemColors.ActiveCaptionText;
            rdoMenu1.Location = new Point(24, 51);
            rdoMenu1.Name = "rdoMenu1";
            rdoMenu1.Size = new Size(105, 35);
            rdoMenu1.TabIndex = 1;
            rdoMenu1.TabStop = true;
            rdoMenu1.Text = "햄버거";
            rdoMenu1.UseVisualStyleBackColor = true;
            // 
            // rdoMenu2
            // 
            rdoMenu2.AutoSize = true;
            rdoMenu2.ForeColor = SystemColors.ActiveCaptionText;
            rdoMenu2.Location = new Point(24, 133);
            rdoMenu2.Name = "rdoMenu2";
            rdoMenu2.Size = new Size(149, 35);
            rdoMenu2.TabIndex = 2;
            rdoMenu2.TabStop = true;
            rdoMenu2.Text = "불고기버거";
            rdoMenu2.UseVisualStyleBackColor = true;
            // 
            // rdoMenu3
            // 
            rdoMenu3.AutoSize = true;
            rdoMenu3.ForeColor = SystemColors.ActiveCaptionText;
            rdoMenu3.Location = new Point(24, 228);
            rdoMenu3.Name = "rdoMenu3";
            rdoMenu3.Size = new Size(127, 35);
            rdoMenu3.TabIndex = 3;
            rdoMenu3.TabStop = true;
            rdoMenu3.Text = "치킨버거";
            rdoMenu3.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChicken);
            grpMenu.Controls.Add(picBulggogi);
            grpMenu.Controls.Add(picBurger);
            grpMenu.Controls.Add(rdoMenu3);
            grpMenu.Controls.Add(rdoMenu1);
            grpMenu.Controls.Add(rdoMenu2);
            grpMenu.Font = new Font("한컴 고딕", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(35, 80);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(300, 301);
            grpMenu.TabIndex = 4;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkOption4);
            grpOption.Controls.Add(chkOption3);
            grpOption.Controls.Add(chkOption2);
            grpOption.Controls.Add(chkOption1);
            grpOption.Font = new Font("한컴 고딕", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(352, 72);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(168, 309);
            grpOption.TabIndex = 4;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // picBurger
            // 
            picBurger.Image = Properties.Resources.Buger;
            picBurger.Location = new Point(179, 27);
            picBurger.Name = "picBurger";
            picBurger.Size = new Size(115, 75);
            picBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBurger.TabIndex = 5;
            picBurger.TabStop = false;
            // 
            // picBulggogi
            // 
            picBulggogi.Image = Properties.Resources.Bulggogi;
            picBulggogi.Location = new Point(179, 119);
            picBulggogi.Name = "picBulggogi";
            picBulggogi.Size = new Size(115, 75);
            picBulggogi.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulggogi.TabIndex = 6;
            picBulggogi.TabStop = false;
            // 
            // picChicken
            // 
            picChicken.Image = Properties.Resources.Shrimp;
            picChicken.Location = new Point(179, 203);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(115, 75);
            picChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            picChicken.TabIndex = 7;
            picChicken.TabStop = false;
            // 
            // chkOption1
            // 
            chkOption1.AutoSize = true;
            chkOption1.ForeColor = SystemColors.ActiveCaptionText;
            chkOption1.Location = new Point(8, 59);
            chkOption1.Name = "chkOption1";
            chkOption1.Size = new Size(128, 35);
            chkOption1.TabIndex = 0;
            chkOption1.Text = "감자튀김";
            chkOption1.UseVisualStyleBackColor = true;
            // 
            // chkOption2
            // 
            chkOption2.AutoSize = true;
            chkOption2.ForeColor = SystemColors.ActiveCaptionText;
            chkOption2.Location = new Point(8, 118);
            chkOption2.Name = "chkOption2";
            chkOption2.Size = new Size(84, 35);
            chkOption2.TabIndex = 1;
            chkOption2.Text = "콜라";
            chkOption2.UseVisualStyleBackColor = true;
            // 
            // chkOption3
            // 
            chkOption3.AutoSize = true;
            chkOption3.ForeColor = SystemColors.ActiveCaptionText;
            chkOption3.Location = new Point(8, 180);
            chkOption3.Name = "chkOption3";
            chkOption3.Size = new Size(134, 35);
            chkOption3.TabIndex = 2;
            chkOption3.Text = "치즈 추가";
            chkOption3.UseVisualStyleBackColor = true;
            // 
            // chkOption4
            // 
            chkOption4.AutoSize = true;
            chkOption4.ForeColor = SystemColors.ActiveCaptionText;
            chkOption4.Location = new Point(8, 237);
            chkOption4.Name = "chkOption4";
            chkOption4.Size = new Size(134, 35);
            chkOption4.TabIndex = 3;
            chkOption4.Text = "소스 추가";
            chkOption4.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(btnReset);
            grpOrder.Controls.Add(btnOrder);
            grpOrder.Controls.Add(lblAmount);
            grpOrder.Controls.Add(lstOrderbox);
            grpOrder.Font = new Font("한컴 고딕", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(526, 72);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(262, 309);
            grpOrder.TabIndex = 5;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lstOrderbox
            // 
            lstOrderbox.FormattingEnabled = true;
            lstOrderbox.Location = new Point(6, 43);
            lstOrderbox.Name = "lstOrderbox";
            lstOrderbox.Size = new Size(250, 159);
            lstOrderbox.TabIndex = 4;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.ForeColor = Color.Blue;
            lblAmount.Location = new Point(21, 211);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(135, 31);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "총 금액: 0원";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(0, 192, 0);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(6, 252);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(118, 57);
            btnOrder.TabIndex = 6;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(138, 252);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 57);
            btnReset.TabIndex = 7;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpOrder);
            Controls.Add(lbltitle);
            Controls.Add(grpMenu);
            Controls.Add(grpOption);
            Name = "Form1";
            Text = "Burger Kiosk";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulggogi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private RadioButton rdoMenu1;
        private RadioButton rdoMenu2;
        private RadioButton rdoMenu3;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private PictureBox picBurger;
        private PictureBox picChicken;
        private PictureBox picBulggogi;
        private CheckBox chkOption4;
        private CheckBox chkOption3;
        private CheckBox chkOption2;
        private CheckBox chkOption1;
        private GroupBox grpOrder;
        private ListBox lstOrderbox;
        private Button btnReset;
        private Button btnOrder;
        private Label lblAmount;
    }
}
