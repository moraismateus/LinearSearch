//test array
var myArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var target = 7;

Console.WriteLine(LinearSearch(myArray, target));

int LinearSearch(int[] array, int target)
{
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] == target)
            return index;
    }

    return -1;
}

