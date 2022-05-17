Console.WriteLine("Sliding door problem, refer Readme.md file for question");

Console.WriteLine("Find longest sub-array from the given");

var stringData = "cbbebi";
var keyValue = 3;
var result = LongestSubArray(stringData, keyValue);


Console.WriteLine($"Longest substring of '{stringData}' of '{keyValue}' is {result}");
Console.ReadLine();


int LongestSubArray(string source, int key)
{
    var max = 0;
    var startIndex = 0;
    var dict = new Dictionary<char, int>();
    for (int i = 0; i < source.Length; i++)
    {
        // find r.char and add to dict / index++
        var rChar = source[i];
        if (!dict.ContainsKey(rChar))
            dict.Add(rChar, dict.GetValueOrDefault(rChar, 0) + 1);
        else dict[rChar]++;

        while (dict.Count > key) // if dict count > key for distant check 
        {
            var lChar = source[startIndex];
            if (dict.ContainsKey(lChar))
                dict[lChar] = dict[lChar] - 1;
            //dict[lChar]--;
            if (dict[lChar] == 0)
                dict.Remove(lChar);
            startIndex++;
        }
        max = Math.Max(max, i - startIndex + 1);
    }
    return max;
}
