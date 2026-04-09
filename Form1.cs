namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateOrder(object sender, EventArgs e)
        {
            if (isResetting) return;

            int totalCost = 0;
            lstOrderbox.Items.Clear();

            // 1. 유효성 검사
            if (!rdoBurger.Checked && !rdoBulggogiburger.Checked && !rdoChickenburger.Checked)
            {
                lblErrorMessage.Visible = true;
                lblAmount.Text = "총 금액 : 0원";
                return;
            }

            lblErrorMessage.Visible = false;

            // 2. 메뉴 선택 처리 (RadioButton)
            if (rdoBurger.Checked) { totalCost += 5000; lstOrderbox.Items.Add("햄버거: 5,000원"); }
            else if (rdoBulggogiburger.Checked) { totalCost += 4000; lstOrderbox.Items.Add("불고기버거: 4,000원"); }
            else if (rdoChickenburger.Checked) { totalCost += 3000; lstOrderbox.Items.Add("치킨버거: 3,000원"); }

            // 3. 옵션 선택 처리 (CheckBox)
            if (chkFrenchfries.Checked) { totalCost += 3500; lstOrderbox.Items.Add(" ▶ 감자튀김: 3,500원"); }
            if (chkCola.Checked) { totalCost += 2500; lstOrderbox.Items.Add(" ▶ 콜라: 2,500원"); }
            if (chkCheese.Checked) { totalCost += 1500; lstOrderbox.Items.Add(" ▶ 치즈 추가: 1,500원"); }
            if (chkSause.Checked) { totalCost += 500; lstOrderbox.Items.Add(" ▶ 소스 추가: 500원"); }

            // 4. 합계 출력
            lblAmount.Text = "총 결제 금액: " + totalCost.ToString("N0") + "원";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 이미 실시간으로 계산되고 있으므로, 여기선 최종 확인만!
            if (lstOrderbox.Items.Count > 0)
            {
                MessageBox.Show(lblAmount.Text + " 결제가 완료되었습니다!", "결제 완료");
            }
            else
            {
                lblErrorMessage.Visible = true;
            }
        }

        bool isResetting = false;

        private void btnReset_Click(object sender, EventArgs e)
        {
            isResetting = true; // 리셋 시작

            // 초기화 버튼 시에도 에러 라벨은 숨김.
            lblErrorMessage.Visible = false;

            // 모든 컨트롤 상태 초기화
            rdoBurger.Checked = false;
            rdoBulggogiburger.Checked = false;
            rdoChickenburger.Checked = false;

            chkFrenchfries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSause.Checked = false;

            lstOrderbox.Items.Clear();
            lblAmount.Text = "총 금액 : 0원";

            isResetting = false; // 리셋 끝!
        }
    }
}