List<int> visitorLog = new List<int>()
{
    101,102,103,101,104,102,105,103
};

HashSet<int> uniqueUsers =
    new HashSet<int>();

int duplicateCount = 0;

foreach(int userId in visitorLog)
{
    if(!uniqueUsers.Add(userId))
    {
        duplicateCount++;
    }
}