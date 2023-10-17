namespace KingdomGuardEventCalculator.Controllers
{
    public class WitchPhaseController
    {
        public WitchPhaseController()
        {
            
        }

        public long CalculateTotalWitchPhase(long lightValue, long strengthValue, long fortuneValue)
        {
            var totalSum = lightValue * 70 + strengthValue * 3 + fortuneValue * 28;

            return totalSum;
        }
    }
}