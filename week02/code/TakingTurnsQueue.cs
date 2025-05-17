/// <summary>
/// This queue is circular. When people are added via AddPerson, they are added to the 
/// back of the queue (FIFO). When GetNextPerson is called, the next person
/// in the queue is dequeued and then placed back at the back of the queue.
/// Each person has a number of turns. If turns is 0 or less, they stay in the queue forever.
/// If a person has no turns left, they are removed from the queue.
/// </summary>
public class TakingTurnsQueue
{
    // Use the PersonQueue wrapper class to hold people in order
    private readonly PersonQueue _people = new();

    // Returns the number of people currently in the queue
    public int Length => _people.Length;

    /// <summary>
    /// Adds a new person to the queue with the specified name and turns
    /// </summary>
    /// <param name="name">Name of the person</param>
    /// <param name="turns">Number of turns the person gets; 0 or less means infinite turns</param>
    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Returns the next person in the queue and updates their turns.
    /// If turns remain (more than 1), the person is placed back at the end of the queue.
    /// If turns are 0 or less, the person stays forever in the queue.
    /// If turns are exactly 1, they are not placed back (removed from queue).
    /// Throws InvalidOperationException if the queue is empty.
    /// </summary>
    /// <returns>The person whose turn it is</returns>
    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        Person person = _people.Dequeue();

        if (person.Turns > 1)
        {
            person.Turns -= 1;  // Decrease turns
            _people.Enqueue(person); // Put back at end of queue
        }
        else if (person.Turns <= 0)
        {
            // Infinite turns, keep them in queue forever
            _people.Enqueue(person);
        }
        // If turns == 1, do NOT enqueue again; person is done

        return person;
    }

    /// <summary>
    /// Returns a string representation of the queue
    /// </summary>
    public override string ToString()
    {
        return _people.ToString();
    }
}
