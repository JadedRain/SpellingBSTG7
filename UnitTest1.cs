namespace SpellingBSTG7;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}

public interface ISortedSet<T> where T: IComparable<T>
{
    bool add(T value);
    T remove(T value);
    T find(T value);
}

public interface ITraversable<T>
{
    IEnumerable<T> PreOrder();
    IEnumerable<T> InOrder();
    IEnumerable<T> PostOrder();
}

public class Tree<T> : ISortedSet<T>, ITraversable<T>
{
    TreeNode? root = null;
    int size = 0;

    class TreeNode<T>
    {
        public T Value;
        public Tree<T> LeftChild;
        public Tree<T> RightChild;
        TreeNode(T value, Tree<T> leftChild, Tree<T> rightChild)
        {
            Value = value;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }

    public bool add(T value)
    {

    }

    // This is a test to try and get soe=mething to work



    public T remove(T value)
    {

    }

    public T find(T value)
    {

    }
}