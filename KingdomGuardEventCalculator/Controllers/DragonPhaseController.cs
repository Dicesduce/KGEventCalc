namespace KingdomGuardEventCalculator.Controllers
{
    public class DragonPhaseController
    {
        public DragonPhaseController()
        {
            
        }

        public long CalculateTotalDragonPhasePoints(long rareRuneValue, long excellentRuneValue, long perfectRuneValue, long epicRuneValue, long dragonSoulStone, long deluxeSoulStone)
        {
            var totalSum = rareRuneValue * 70 + excellentRuneValue * 700 + perfectRuneValue * 7000 + epicRuneValue * 14000 + dragonSoulStone * 5 + deluxeSoulStone * 56;

            return totalSum;
        }
    }
}