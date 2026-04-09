namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //유효성 검사
            if (!rdoBurger.Checked && !rdoBulggogiburger.Checked && !rdoChickenburger.Checked)
            {
                // 아무것도 선택되지 않았다면 경고 라벨 표시
                lblErrorMessage.Visible = true;

                // 리스트박스와 금액 라벨도 깔끔하게 비움
                lstOrderbox.Items.Clear();
                lblAmount.Text = "총 금액 : 0원";

                return; // 이후 로직 실행 방지
            }

            // 정상 주문 시 처리
            // 에러 라벨을 다시 숨깁니다.
            lblErrorMessage.Visible = false;

            // 1. 초기화: 버튼을 누를 때마다 새로 계산해야 하므로 0으로 시작
            int totalCost = 0;
            lstOrderbox.Items.Clear(); // 리스트박스 비우기

            // 2. 단일 선택 (RadioButton) - 버거 종류 중 하나만 선택
            if (rdoBurger.Checked)
            {
                totalCost += 5000;
                lstOrderbox.Items.Add("햄버거: 5,000원");
            }
            else if (rdoBulggogiburger.Checked)
            {
                totalCost += 4000;
                lstOrderbox.Items.Add("불고기버거: 4,000원");
            }
            else if (rdoChickenburger.Checked)
            {
                totalCost += 3000;
                lstOrderbox.Items.Add("치킨버거: 3,000원");
            }

            // 3. 다중 선택 (CheckBox) - 개별적으로 체크 여부 확인
            if (chkFrenchfries.Checked)
            {
                totalCost += 3500;
                lstOrderbox.Items.Add(" ▶ 감자튀김 추가: 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrderbox.Items.Add(" ▶ 콜라 추가: 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrderbox.Items.Add(" ▶ 치즈 추가: 1,500원");
            }
            if (chkSause.Checked)
            {
                totalCost += 500;
                lstOrderbox.Items.Add(" ▶ 소스 추가: 500원");
            }

            // 4. 결과 출력
            lblAmount.Text = "총 결제 금액: " + totalCost.ToString("N0") + "원";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
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
        }
    }
}