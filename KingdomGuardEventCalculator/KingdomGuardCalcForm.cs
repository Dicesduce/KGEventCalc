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

        private long tier1Value = 0;
        private long tier2Value = 0;
        private long tier3Value = 0;
        private long tier4Value = 0;
        private long crownsValue = 0;
        private long masterTalentValue = 0;

        private long lightWitchValue = 0;
        private long strengtheningValue = 0;
        private long fortuneValue = 0;

        UnitPhaseController unitPhaseController = new UnitPhaseController();
        SummonPhaseController summonPhaseController = new SummonPhaseController();
        WitchPhaseController witchPhasecontroller = new WitchPhaseController();
        HeroPhaseController heroPhaseController = new HeroPhaseController();


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

        #region Unit phase
        private void Tier1_numericBox_ValueChanged(object sender, EventArgs e)
        {
            tier1Value = (long)Tier1_numericBox.Value;
            UpdateSumBox(tier1Value, Tier1_sumBox, 800);
        }

        private void Tier2_numericBox_ValueChanged(object sender, EventArgs e)
        {
            tier2Value = (long)Tier2_numericBox.Value;
            UpdateSumBox(tier2Value, Tier2_sumBox, 4000);
        }

        private void Tier3_numericBox_ValueChanged(object sender, EventArgs e)
        {
            tier3Value = (long)Tier3_numericBox.Value;
            UpdateSumBox(tier3Value, Tier3_sumBox, 20000);
        }

        private void Tier4_numericBox_ValueChanged(object sender, EventArgs e)
        {
            tier4Value = (long)Tier4_numericBox.Value;
            UpdateSumBox(tier4Value, Tier4_sumBox, 100000);
        }

        private void Crown_numericBox_ValueChanged(object sender, EventArgs e)
        {
            crownsValue = (long)Crown_numericBox.Value;
            UpdateSumBox(crownsValue, Crown_sumBox, 5);
        }

        private void MasterTalent_numericBox_ValueChanged(object sender, EventArgs e)
        {
            masterTalentValue = (long)MasterTalent_numericBox.Value;
            UpdateSumBox(masterTalentValue, MasterTalent_sumBox, 56);
        }
        #endregion

        #region Witch phase
        private void Light_witch_numericBox_ValueChanged(object sender, EventArgs e)
        {
            lightWitchValue = (long)Light_witch_numericBox.Value;
            UpdateSumBox(lightWitchValue, Light_witch_sumBox, 70);
        }

        private void Strengthening_numericBox_ValueChanged(object sender, EventArgs e)
        {
            strengtheningValue = (long)Strengthening_numericBox.Value;
            UpdateSumBox(strengtheningValue, Strengthening_sumBox, 3);
        }

        private void Fortune_numericBox_ValueChanged(object sender, EventArgs e)
        {
            fortuneValue = (long)Fortune_numericBox.Value;
            UpdateSumBox(fortuneValue, Fortune_sumBox, 28);
        }
        #endregion

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var totalUnitPhase = unitPhaseController.CalculateTotalUnitPhase(tier1Value, tier2Value, tier3Value, tier4Value, crownsValue, masterTalentValue);
            var totalHeroPhase = heroPhaseController.CalculateTotalHeroPhasePoints(nValue, rValue, srValue, ssrValue);
            var totalSummonPhase = summonPhaseController.CalculateTotalSummonPhasePoints(rareRuneValue, excellentRuneValue, perfectRuneValue, epicRuneValue, lightValue, forgeValue, advancedScrollValue, perfectScrollValue);
            var totalWitchPhase = witchPhasecontroller.CalculateTotalWitchPhase(lightWitchValue, strengtheningValue, fortuneValue);


            var sumAllPhases = totalUnitPhase + totalSummonPhase + totalWitchPhase + totalHeroPhase;

            sumAll_Box.Text = sumAllPhases.ToString("N0");
        }

        private void UpdateSumBox(long numericBoxValue, TextBox sumBox, int points)
        {
            var sum = numericBoxValue * points;
            sumBox.Text = sum.ToString("N0");
        }
    }
}
