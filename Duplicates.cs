List<int> data = new List<int>()
{
    3,7,3,9,7,1,3
};

Dictionary<int,int> countMap =
    new Dictionary<int,int>();

foreach(int value in data)
{
    if(countMap.ContainsKey(value))
        countMap[value]++;
    else
        countMap[value]=1;
}

foreach(var pair in countMap)
{
    if(pair.Value > 1)
    {
        Console.WriteLine(
            $"{pair.Key} occurs {pair.Value} times"
        );
    }
}