Stack<string> visitedPages =
    new Stack<string>();

visitedPages.Push("home");
visitedPages.Push("products");
visitedPages.Push("cart");
visitedPages.Push("checkout");

visitedPages.Pop();
visitedPages.Pop();

Console.WriteLine(
    $"Current Page: {visitedPages.Peek()}"
);