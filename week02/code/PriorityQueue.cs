public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.
    /// The node is always added to the back of the queue regardless of the priority.
    /// </summary>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    /// <summary>
    /// Remove and return the value with the highest priority.
    /// If multiple items have the same highest priority,
    /// the first one added (FIFO) is returned.
    /// </summary>
    public string Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        int highPriorityIndex = 0;
        int highestPriority = _queue[0].Priority;

        // Find the *first* occurrence of the highest priority item
        for (int i = 1; i < _queue.Count; i++)
        {
            if (_queue[i].Priority > highestPriority)
            {
                highestPriority = _queue[i].Priority;
                highPriorityIndex = i;
            }
        }

        var value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex); // Remove from queue
        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

/// <summary>
/// Internal class that holds the value and its associated priority
/// </summary>
internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}
