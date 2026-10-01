HashSet<string> candidateOne =
    new HashSet<string>()
{
    "C#","SQL","Python"
};

HashSet<string> candidateTwo =
    new HashSet<string>()
{
    "C#","SQL","React","Azure"
};

HashSet<string> commonSkills =
    new HashSet<string>(candidateOne);

commonSkills.IntersectWith(candidateTwo);

HashSet<string> exclusiveSkills =
    new HashSet<string>(candidateOne);

exclusiveSkills.ExceptWith(candidateTwo);

HashSet<string> mergedSkills =
    new HashSet<string>(candidateOne);

mergedSkills.UnionWith(candidateTwo);