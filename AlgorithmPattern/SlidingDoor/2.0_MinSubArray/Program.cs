Console.WriteLine("Sliding door problem, refer ReadMe.md file for question");

//var arraySource = new int[] { 2, 1, 5, 2, 3, 2 };
//var arraySource = new int[] { 2, 1, 5, 2, 8 };
var arraySource = new int[] { 3, 4, 1, 1, 6 };
var keyValue = 7;
var result = GetMinimumSubArray(arraySource, keyValue);


Console.WriteLine($"Result is {result}");
Console.ReadLine();


int GetMinimumSubArray(int[] arraySource, int key)
{
    var min = int.MaxValue;
    var tempSum = 0;
    var startIndex = 0;
    for (int i = 0; i < arraySource.Length; i++)
    {
        tempSum += arraySource[i];
        while (tempSum >= key) // until sum >= to the key provided , then get MIN of that positions 
        {
            min = Math.Min(min, i - startIndex + 1);
            tempSum -= arraySource[startIndex]; // and reduce the indexsiotion from sum
            startIndex++;
        }
    }
    return min;
}
