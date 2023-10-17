namespace KingdomGuardEventCalculator.Controllers
{
    public class SummonPhaseController
    {
        public SummonPhaseController()
        {
            
        }


        public long CalculateTotalSummonPhasePoints(long rareRuneValue, long excellentRuneValue, long perfectRuneValue, long epicRuneValue, long lightValue, long forgeValue, long advancedScrollValue, long perfectScrollValue)
        {
            var totalSum = rareRuneValue * 70 + excellentRuneValue * 700 + perfectRuneValue * 7000 + epicRuneValue * 14000 + lightValue * 70 + forgeValue * 100 + advancedScrollValue * 14 + perfectScrollValue * 140;
            
            return totalSum;
        }
    }
}
