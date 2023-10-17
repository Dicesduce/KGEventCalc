using KingdomGuardEventCalculator.Controllers;

namespace KingdomGuardEventCalculator
{
    public partial class KingdomGuardCalcForm : Form
    {
        private long nValue = 0;
        private long rValue = 0;
        private long srValue = 0;
        private long ssrValue = 0;

        private long rareRuneValue = 0;
        private long excellentRuneValue = 0;
        private long perfectRuneValue = 0;
        private long epicRuneValue = 0;
        private long lightValue = 0;
        private long forgeValue = 0;
        private long advancedScrollValue = 0;
        private long perfectScrollValue = 0;

        HeroPhaseController heroPhaseController = new HeroPhaseController();
        SummonPhaseController summonPhaseController = new SummonPhaseController();


        public KingdomGuardCalcForm()
        {
            InitializeComponent();
        }

        #region Hero phase
        private void N_NumericBox_ValueChanged(object sender, EventArgs e)
        {
            nValue = (long)N_NumericBox.Value;
            UpdateSumBox(nValue, N_SumBox, 100);
        }

        private void R_NumericBox_ValueChanged(object sender, EventArgs e)
        {
            rValue = (long)R_NumericBox.Value;
            UpdateSumBox(rValue, R_SumBox, 700);
        }

        private void SR_NumericBox_ValueChanged(object sender, EventArgs e)
        {
            srValue = (long)SR_NumericBox.Value;
            UpdateSumBox(srValue, SR_SumBox, 3500);
        }

        private void SSR_NumericBox_ValueChanged(object sender, EventArgs e)
        {
            ssrValue = (long)SSR_NumericBox.Value;
            UpdateSumBox(ssrValue, SSR_SumBox, 14000);
        }
        #endregion

        #region Summon phase
        private void RareRune_numericbox_ValueChanged(object sender, EventArgs e)
        {
            rareRuneValue = (long)RareRune_numericbox.Value;
            UpdateSumBox(rareRuneValue, RareRune_sumbox, 70);
        }

        private void ExcellentRune_numericbox_ValueChanged(object sender, EventArgs e)
        {
            excellentRuneValue = (long)ExcellentRune_numericbox.Value;
            UpdateSumBox(excellentRuneValue, ExcellentRune_sumbox, 700);
        }

        private void PerfectRune_numericbox_ValueChanged(object sender, EventArgs e)
        {
            perfectRuneValue = (long)PerfectRune_numericbox.Value;
            UpdateSumBox(perfectRuneValue, PerfectRune_sumbox, 7000);
        }

        private void EpicRune_numericbox_ValueChanged(object sender, EventArgs e)
        {
            epicRuneValue = (long)EpicRune_numericbox.Value;
            UpdateSumBox(epicRuneValue, EpicRune_sumbox, 14000);
        }

        private void Light_numericbox_ValueChanged(object sender, EventArgs e)
        {
            lightValue = (long)Light_numericbox.Value;
            UpdateSumBox(lightValue, Light_sumbox, 70);
        }

        private void Forge_numericbox_ValueChanged(object sender, EventArgs e)
        {
            forgeValue = (long)Forge_numericbox.Value;
            UpdateSumBox(forgeValue, Forge_sumbox, 100);
        }

        private void AdvancedScroll_numericbox_ValueChanged(object sender, EventArgs e)
        {
            advancedScrollValue = (long)AdvancedScroll_numericbox.Value;
            UpdateSumBox(advancedScrollValue, AdvancedScroll_sumbox, 14);
        }

        private void PerfectScroll_numericbox_ValueChanged(object sender, EventArgs e)
        {
            perfectScrollValue = (long)PerfectScroll_numericbox.Value;
            UpdateSumBox(perfectScrollValue, PerfectScroll_sumbox, 140);
        }
        #endregion

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var sumHeroPhase = heroPhaseController.CalculateTotalHeroPhasePoints(nValue, rValue, srValue, ssrValue);
            var sumSummonPhase = summonPhaseController.CalculateTotalSummonPhasePoints(rareRuneValue, excellentRuneValue, perfectRuneValue, epicRuneValue, lightValue, forgeValue, advancedScrollValue, perfectScrollValue);

            var sumAllPhases = sumHeroPhase + sumSummonPhase;

            sumAll_Box.Text = sumAllPhases.ToString("N0");
        }

        private void UpdateSumBox(long numericBoxValue, TextBox sumBox, int points)
        {
            var sum = numericBoxValue * points;
            sumBox.Text = sum.ToString("N0");
        }
    }
}
