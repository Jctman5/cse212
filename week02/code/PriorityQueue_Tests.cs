using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 items with different priorities. Ensure highest priority is removed first.
    // Expected Result: Items are returned in order of highest priority (not insertion order).
    // Defect(s) Found: 1
    // The dequeue function in PriorityQueue was not removing the highest priority number, so it would return 4 every time.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("4",3);
        priorityQueue.Enqueue("5", 2);
        priorityQueue.Enqueue("6", 1);

        Assert.AreEqual("4",priorityQueue.Dequeue());
        
        Assert.AreEqual("5", priorityQueue.Dequeue());

        Assert.AreEqual("6", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority.
    // Expected Result: Items are dequeued in FIFO order.
    // Defect(s) Found: 0
    public void TestPriorityQueue_2(){
    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("A", 5);
    priorityQueue.Enqueue("B", 5);
    priorityQueue.Enqueue("C", 5);

    Assert.AreEqual("A", priorityQueue.Dequeue());
    Assert.AreEqual("B", priorityQueue.Dequeue());
    Assert.AreEqual("C", priorityQueue.Dequeue());
}
    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Mix of priorities with ties.
    // Expected Result: Highest priority first, ties resolved FIFO.
    // Defect(s) Found: 1
    // The for loop in the dequeue function was going off of _queue.Count -1, meaning it was never counting the last item in the list.
    public void TestPriorityQueue_3(){

    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("A", 1);
    priorityQueue.Enqueue("B", 3);
    priorityQueue.Enqueue("C", 3);
    priorityQueue.Enqueue("D", 2);

    Assert.AreEqual("B", priorityQueue.Dequeue());
    Assert.AreEqual("C", priorityQueue.Dequeue()); 
    Assert.AreEqual("D", priorityQueue.Dequeue()); 
    Assert.AreEqual("A", priorityQueue.Dequeue()); 
}


    [TestMethod]
    // Scenario: Dequeue from empty queue.
    // Expected Result: InvalidOperationException with correct message.
    // Defect(s) Found: 0
    public void TestPriorityQueue_Empty(){
    
    var priorityQueue = new PriorityQueue();

    var ex = Assert.ThrowsException<InvalidOperationException>(() =>
    {
        priorityQueue.Dequeue();
    });

    Assert.AreEqual("The queue is empty.", ex.Message);
}

}
