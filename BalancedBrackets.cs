static bool CheckBrackets(string expression)
{
    Stack<char> brackets =
        new Stack<char>();

    foreach(char symbol in expression)
    {
        if(symbol=='(' || symbol=='{' || symbol=='[')
        {
            brackets.Push(symbol);
        }
        else
        {
            if(brackets.Count==0)
                return false;

            char open = brackets.Pop();

            if((symbol==')' && open!='(') ||
               (symbol=='}' && open!='{') ||
               (symbol==']' && open!='['))
            {
                return false;
            }
        }
    }

    return brackets.Count==0;
}