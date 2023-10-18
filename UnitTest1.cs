using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace SpellingBSTG7;

public class Tests
{

    [Test]
    public void Test1()
    {
        Tree<int> testTree = new Tree<int>();
        testTree.add(5);
        testTree.add(7);
        int actual = 5;
        Assert.That(actual, Is.EqualTo(testTree.find(actual)));
        int actual_2 = 7;
        Assert.That(actual_2, Is.EqualTo(testTree.remove(actual_2)));
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

public static class Spelling<T>
{
    static public List<string> Fix(List<string> inputWords)
    {
        Tree<string> tree = new Tree<string>();
        List<string> outputWords = new List<string>();
        int AlreadyInTree = 0;
        int NotInTree = 0;

        for (int i = 0; i < inputWords.Count(); i++)
        {
                if (tree.add(inputWords[i]))
                {
                    NotInTree++;
                    if (NotInTree % 3 == 0 && i != 0)
                    {
                        
                    }
                }
                else
                {
                    AlreadyInTree++;
                }
        }
        return inputWords;
    }
}

public class Tree<T> : ISortedSet<T>, ITraversable<T> where T : IComparable
{
    public TreeNode<T>? root = null;
    public int size = 0;

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
        if (size == 0)
        {
            root = new TreeNode<T>(value);
            size++;
            return true;
        }
        TreeNode<T> current = root;
        TreeNode<T> parent = null;
        while (value.CompareTo(current.Value) != 0)
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
            else
            {
                current = current.RightChild;
                if (current == null)
                {
                    parent.RightChild = new TreeNode<T>(value);
                    size++;
                    return true;
                }
            }
        }
        return false;
    }


    public T remove(T value)
    {
        TreeNode<T> current = root;
        TreeNode<T> parent = null;
        while (value.CompareTo(current.Value) != 0)
        {
            parent = current;

            if (value.CompareTo(current.Value) < 0)
            {
                current = current.LeftChild;

                if (current == null)
                {
                    T temp = parent.LeftChild.Value;
                    parent.LeftChild = null;
                    size--;
                    return temp;
                }
            }
            else
            {
                current = current.RightChild;
                if (current == null)
                {
                    T temp = parent.RightChild.Value;
                    parent.RightChild = null;
                    size--;
                    return temp;
                }
            }
        }
        return value;
    }

    public T? find(T value)
    {
        TreeNode<T>? W = root;
        while (W != null)
        {
            if (value.CompareTo(W.Value) < 0)
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