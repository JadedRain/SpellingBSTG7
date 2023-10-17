namespace SpellingBSTG7;

public class Tests
{

[Test]
public void Test1()
{
    Tree testTree = new Tree();
    testTree.add(5);
    Assert.AreEqual(5, testTree.root.Value);
}
}

public interface ISortedSet<T>
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

public class Tree<T> : ISortedSet<T>, ITraversable<T> where T :IComparable
{
    public TreeNode<T>? root = null;
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
        TreeNode<T> current = root;
        TreeNode<T> parent = null;
        while(value.CompareTo(current) != 0)
        {
            parent = current;

            if (value.CompareTo(current.Value) < 0)
            {
                current = current.LeftChild;

                if (current == null)
                {
                    parent.LeftChild = new TreeNode<T>(value);
                    size++;
                    return true;
                }
            }
            else{
                current = current.RightChild;
                if (current == null)
                {
                    parent.RightChild = new TreeNode<T>(value);
                    return true;
                }
            }
        }
        return false;
    }


    public T remove(T value)
    {
        return value;
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
        throw new NotImplementedException();
    }

    public IEnumerable<T> InOrder()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> PostOrder()
    {
        throw new NotImplementedException();
    }
}