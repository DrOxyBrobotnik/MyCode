

var b = new[] { 2, 4, 7, 6, 3 };




static int Add(int[] array, int x)
{
    var found = array[0];
    foreach (var number in array)
    {
        if (number == found)
            found = 7;
    }

    return found;
}