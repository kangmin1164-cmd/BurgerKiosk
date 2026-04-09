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
            rdoBurger = new RadioButton();
            rdoBulggogiburger = new RadioButton();
            rdoChickenburger = new RadioButton();
            grpMenu = new GroupBox();
            picChicken = new PictureBox();
            picBulggogi = new PictureBox();
            picBurger = new PictureBox();
            grpOption = new GroupBox();
            chkSause = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkFrenchfries = new CheckBox();
            grpOrder = new GroupBox();
            lblAmount = new Label();
            lblErrorMessage = new Label();
            lstOrderbox = new ListBox();
            btnReset = new Button();
            btnOrder = new Button();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulggogi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBurger).BeginInit();
            grpOption.SuspendLayout();
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
            // rdoBurger
            // 
            rdoBurger.AutoSize = true;
            rdoBurger.ForeColor = SystemColors.ActiveCaptionText;
            rdoBurger.Location = new Point(24, 51);
            rdoBurger.Name = "rdoBurger";
            rdoBurger.Size = new Size(105, 35);
            rdoBurger.TabIndex = 0;
            rdoBurger.TabStop = true;
            rdoBurger.Text = "햄버거";
            rdoBurger.UseVisualStyleBackColor = true;
            rdoBurger.CheckedChanged += UpdateOrder;
            // 
            // rdoBulggogiburger
            // 
            rdoBulggogiburger.AutoSize = true;
            rdoBulggogiburger.ForeColor = SystemColors.ActiveCaptionText;
            rdoBulggogiburger.Location = new Point(24, 139);
            rdoBulggogiburger.Name = "rdoBulggogiburger";
            rdoBulggogiburger.Size = new Size(149, 35);
            rdoBulggogiburger.TabIndex = 1;
            rdoBulggogiburger.TabStop = true;
            rdoBulggogiburger.Text = "불고기버거";
            rdoBulggogiburger.UseVisualStyleBackColor = true;
            rdoBulggogiburger.CheckedChanged += UpdateOrder;
            // 
            // rdoChickenburger
            // 
            rdoChickenburger.AutoSize = true;
            rdoChickenburger.ForeColor = SystemColors.ActiveCaptionText;
            rdoChickenburger.Location = new Point(24, 227);
            rdoChickenburger.Name = "rdoChickenburger";
            rdoChickenburger.Size = new Size(127, 35);
            rdoChickenburger.TabIndex = 2;
            rdoChickenburger.TabStop = true;
            rdoChickenburger.Text = "치킨버거";
            rdoChickenburger.UseVisualStyleBackColor = true;
            rdoChickenburger.CheckedChanged += UpdateOrder;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChicken);
            grpMenu.Controls.Add(picBulggogi);
            grpMenu.Controls.Add(picBurger);
            grpMenu.Controls.Add(rdoChickenburger);
            grpMenu.Controls.Add(rdoBurger);
            grpMenu.Controls.Add(rdoBulggogiburger);
            grpMenu.Font = new Font("한컴 고딕", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(35, 80);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(300, 301);
            grpMenu.TabIndex = 2;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
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
            // grpOption
            // 
            grpOption.Controls.Add(chkSause);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkFrenchfries);
            grpOption.Font = new Font("한컴 고딕", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(352, 72);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(168, 309);
            grpOption.TabIndex = 3;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // chkSause
            // 
            chkSause.AutoSize = true;
            chkSause.ForeColor = SystemColors.ActiveCaptionText;
            chkSause.Location = new Point(8, 237);
            chkSause.Name = "chkSause";
            chkSause.Size = new Size(134, 35);
            chkSause.TabIndex = 3;
            chkSause.Text = "소스 추가";
            chkSause.UseVisualStyleBackColor = true;
            chkSause.CheckedChanged += UpdateOrder;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = SystemColors.ActiveCaptionText;
            chkCheese.Location = new Point(8, 180);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(134, 35);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += UpdateOrder;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = SystemColors.ActiveCaptionText;
            chkCola.Location = new Point(8, 118);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(84, 35);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += UpdateOrder;
            // 
            // chkFrenchfries
            // 
            chkFrenchfries.AutoSize = true;
            chkFrenchfries.ForeColor = SystemColors.ActiveCaptionText;
            chkFrenchfries.Location = new Point(8, 59);
            chkFrenchfries.Name = "chkFrenchfries";
            chkFrenchfries.Size = new Size(128, 35);
            chkFrenchfries.TabIndex = 0;
            chkFrenchfries.Text = "감자튀김";
            chkFrenchfries.UseVisualStyleBackColor = true;
            chkFrenchfries.CheckedChanged += UpdateOrder;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblAmount);
            grpOrder.Controls.Add(lblErrorMessage);
            grpOrder.Controls.Add(lstOrderbox);
            grpOrder.Font = new Font("한컴 고딕", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(526, 72);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(262, 309);
            grpOrder.TabIndex = 4;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.ForeColor = Color.Blue;
            lblAmount.Location = new Point(21, 205);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(135, 31);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "총 금액: 0원";
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("한컴 고딕", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(21, 243);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(218, 29);
            lblErrorMessage.TabIndex = 1;
            lblErrorMessage.Text = "메뉴를 선택해주세요!";
            lblErrorMessage.Visible = false;
            // 
            // lstOrderbox
            // 
            lstOrderbox.FormattingEnabled = true;
            lstOrderbox.Location = new Point(6, 43);
            lstOrderbox.Name = "lstOrderbox";
            lstOrderbox.Size = new Size(250, 159);
            lstOrderbox.TabIndex = 0;
            lstOrderbox.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("한컴 고딕", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(664, 347);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(124, 57);
            btnReset.TabIndex = 1;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(0, 192, 0);
            btnOrder.Font = new Font("한컴 고딕", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(532, 347);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(126, 57);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // Form1
            // 
            AcceptButton = btnOrder;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReset;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(lbltitle);
            Controls.Add(grpMenu);
            Controls.Add(grpOption);
            Name = "Form1";
            Text = "Burger Kiosk";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulggogi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBurger).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private RadioButton rdoBurger;
        private RadioButton rdoBulggogiburger;
        private RadioButton rdoChickenburger;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private PictureBox picBurger;
        private PictureBox picChicken;
        private PictureBox picBulggogi;
        private CheckBox chkSause;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkFrenchfries;
        private GroupBox grpOrder;
        private ListBox lstOrderbox;
        private Button btnReset;
        private Button btnOrder;
        private Label lblAmount;
        private Label lblErrorMessage;
    }
}
