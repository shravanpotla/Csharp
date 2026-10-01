Queue<string> serviceQueue =
    new Queue<string>();

serviceQueue.Enqueue("T101");
serviceQueue.Enqueue("T102");
serviceQueue.Enqueue("T103");
serviceQueue.Enqueue("T104");

Console.WriteLine(
    $"Processing {serviceQueue.Dequeue()}"
);

Console.WriteLine(
    $"Processing {serviceQueue.Dequeue()}"
);

Console.WriteLine(
    $"Upcoming Ticket: {serviceQueue.Peek()}"
);