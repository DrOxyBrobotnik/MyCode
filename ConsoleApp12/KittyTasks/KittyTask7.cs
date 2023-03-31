namespace KittyTask
{
    public class KittyTask7
    {
        /* Count total number of animal legs and assign result to 'totalCount'.
         * Assume that chicken have 2 legs, while cows and pigs have 4.
         * Animal count can be any integer. In case any animal count is less than 0 then treat it as 0.
         */
        public int Invoke(int chickenCount, int cowCount, int pigCount)
        {
            var totalCount = 0;

            
            totalCount = chickenCount * 2 + cowCount * 4 + pigCount * 4;

            if (chickenCount < 0)
            {
                totalCount = 0;
            }

            if (cowCount < 0)
            {
                totalCount = 0;
            }

            if (pigCount < 0)
            {
                totalCount = 0;
            }
            return totalCount;
        }
    }
}
