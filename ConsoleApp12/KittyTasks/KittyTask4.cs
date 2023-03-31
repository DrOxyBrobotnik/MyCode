namespace KittyTask
{
    public class KittyTask4
    {
        /* Calculate area of a triangle and assign it to variable 'area'.
         * Assume that both inputs are natural numbers.
         */
        public int Invoke(int triangleBase, int triangleHeight)
        {
            var area = 0;

            area = triangleBase * triangleHeight / 2;

            return area;
        }
    }
}
