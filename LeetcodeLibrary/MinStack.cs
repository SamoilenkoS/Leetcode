using System;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/min-stack/
        public class MinStack
        {
            private class Node
            {
                public Node(int val)
                {
                    Value = val;
                }
                public Node Next { get; set; }
                public int Value { get; set; }
            }

            private Node _minRoot;
            private Node _root;
            public MinStack()
            {

            }

            public void Push(int val)
            {
                Node newRoot = new Node(val);
                newRoot.Next = _root;
                _root = newRoot;
                int currentMinRootValue = _minRoot != null ? GetMin() : val;
                Node newMinRoot = new Node(Math.Min(val, currentMinRootValue));
                newMinRoot.Next = _minRoot;
                _minRoot = newMinRoot;
            }

            public void Pop()
            {
                _root = _root.Next;
                _minRoot = _minRoot.Next;
            }

            public int Top()
            {
                return _root.Value;
            }

            public int GetMin()
            {
                return _minRoot.Value;
            }
        }
    }
}
