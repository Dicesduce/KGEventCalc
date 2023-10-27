namespace KingdomGuardEventCalculator.Controllers
{
    public class GearPhaseController
    {
        public GearPhaseController()
        {
            
        }

        public long CalculateTotalGearPhasePoints(long forgeGearValue, long elementalVialValue, long bloodTitanValue)
        {
            var totalSum = forgeGearValue * 100 + elementalVialValue * 14 + bloodTitanValue * 140;

            return totalSum;
        }
    }
}