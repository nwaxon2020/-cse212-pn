using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items A (1), B (3), C (2), then remove one item.
    // Expected Result: Should return B because it has the highest priority.
    // Defect(s) Found: Used to return the wrong item before fix.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Add items A (2), B (3), C (3), D (1), then remove one item.
    // Expected Result: Should return B because B and C have the same priority but B was added first.
    // Defect(s) Found: Before fixing, it returned C instead of B.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Add a few items, then remove all of them one by one.
    // Expected Result: X, Z, Y, W (based on priority and order)
    // Defect(s) Found: Wrong order before fixing.
    public void TestPriorityQueue_MultipleDequeue()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("X", 4);
        queue.Enqueue("Y", 2);
        queue.Enqueue("Z", 4);
        queue.Enqueue("W", 1);

        Assert.AreEqual("X", queue.Dequeue());
        Assert.AreEqual("Z", queue.Dequeue());
        Assert.AreEqual("Y", queue.Dequeue());
        Assert.AreEqual("W", queue.Dequeue());
    }
}