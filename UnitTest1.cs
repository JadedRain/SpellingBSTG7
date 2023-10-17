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

public interface ISortedSet where T: IComparable
{
bool add(T value);
T remove(T value);
T find(T value);
}

public interface ITraversable
{
IEnumerable PreOrder();
IEnumerable InOrder();
IEnumerable PostOrder();
}

public class Tree : ISortedSet, ITraversable where T :IComparable
{
    TreeNode? root = null;
    int size = 0;

    public class TreeNode<T>
    {
        public T Value;
        public TreeNode<T>? LeftChild;
        public TreeNode<T>? RightChild;
        public TreeNode(T value, TreeNode<T>? leftChild = null, TreeNode<T>? rightChild = null)
        {
            Value = value;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }

    public bool add(T value)
    {
        if(size == 0)
        {
            root = new TreeNode<T>(value);
            size++;
        }
        else if (value.CompareTo(root.Value) < 0)
        {
            
        }
    }


    public T remove(T value)
    {

    }

    public T? find(T value)
    {
        TreeNode<T>? W = root;
        while(W != null)
        {
            if(value.CompareTo(W.Value) < 0)
            {
                W = W.LeftChild;
            }
            else if (value.CompareTo(W.Value) > 0)
            {
                W = W.RightChild;
            }
            else
            {
                return W.Value;
            }
        }
    return W.Value;
    }

    public IEnumerable<T> PreOrder()
    {
        
    }

    public IEnumerable<T> InOrder()
    {
        
    }

    public IEnumerable<T> PostOrder()
    {
        
    }
}