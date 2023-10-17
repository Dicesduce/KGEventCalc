namespace KingdomGuardEventCalculator.Controllers
{
    public class UnitPhaseController
    {
        public UnitPhaseController()
        {
            
        }

        public long CalculateTotalUnitPhase(long tier1Value, long tier2Value, long tier3Value, long tier4Value, long crownsValue, long masterTalentValue)
        {
            var totalSum = tier1Value * 800 + tier2Value * 4000 + tier3Value * 20000 + tier4Value * 100000 + crownsValue * 5 + masterTalentValue * 56;

            return totalSum;
        }
    }
}