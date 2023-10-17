namespace KingdomGuardEventCalculator
{
    public partial class KingdomGuardCalcForm : Form
    {
        private long NValue = 0;
        private long RValue = 0;
        private long SRValue = 0;
        private long SSRValue = 0;

        public KingdomGuardCalcForm()
        {
            InitializeComponent();
        }

        private void N_NumericBox_ValueChanged(object sender, EventArgs e)
        {
            NValue = (long)N_NumericBox.Value;
            this.UpdateSumBox(NValue, N_SumBox, 100);
        }

        private void R_NumericBox_ValueChanged(object sender, EventArgs e)
        {
            RValue = (long)R_NumericBox.Value;
            this.UpdateSumBox(RValue, R_SumBox, 700);
        }

        private void SR_NumericBox_ValueChanged(object sender, EventArgs e)
        {
            SRValue = (long)SR_NumericBox.Value;
            this.UpdateSumBox(SRValue, SR_SumBox, 3500);
        }

        private void SSR_NumericBox_ValueChanged(object sender, EventArgs e)
        {
            SSRValue = (long)SSR_NumericBox.Value;
            this.UpdateSumBox(SSRValue, SSR_SumBox, 14000);
        }

        public void UpdateSumBox(long numericBoxValue, TextBox sumBox, int points)
        {
            var sum = numericBoxValue * points;
            sumBox.Text = sum.ToString("N0");
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var sum = NValue * 100 + RValue * 700 + SRValue * 3500 + SSRValue * 14000;  

            sumAll_Box.Text = sum.ToString("N0");
        }
    }
}
