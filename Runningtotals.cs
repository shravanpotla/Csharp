List<int> revenue = new List<int>()
{
    250,300,180,420,200
};

int cumulativeSum = 0;
int thresholdDay = -1;

for(int day=0; day<revenue.Count; day++)
{
    cumulativeSum += revenue[day];

    Console.WriteLine(
        $"Day {day+1}: {revenue[day]} Total={cumulativeSum}"
    );

    if(thresholdDay==-1 && cumulativeSum>1000)
    {
        thresholdDay = day + 1;
    }
}