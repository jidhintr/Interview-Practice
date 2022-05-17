
Console.WriteLine("Sliding door problem, refer ReadMe.md file for question");

var arraySource = new[] { 2, 1, 5, 1, 3, 2 };
var position = 3;
var result = GetMaximumSubArray(arraySource, position);


Console.WriteLine($"Result is {result}");
Console.ReadLine();

static int GetMaximumSubArray(int[] arraySource, int position)
{
    var sum = 0;
    var tempSum = 0;
    var piovtIndex = 0;
    for (int i = 0; i < arraySource.Length; i++)
    {
        tempSum += arraySource[i];
        if (i >= position - 1)
        {
            sum = Math.Max(tempSum, sum);
            tempSum -= arraySource[piovtIndex];
            piovtIndex++;
        }
    }
    return sum;
}

