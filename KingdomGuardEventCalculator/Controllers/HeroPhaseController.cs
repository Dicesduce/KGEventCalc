namespace KingdomGuardEventCalculator.Controllers
{
    public class HeroPhaseController
    {
        public HeroPhaseController()
        {
            
        }

        public long CalculateTotalHeroPhasePoints(long nCardValue, long rCardValue, long srCardValue, long ssrCardValue)
        {
            var totalSum = nCardValue * 100 + rCardValue * 700 + srCardValue * 3500 + ssrCardValue * 14000;

            return totalSum;
        }
    }
}