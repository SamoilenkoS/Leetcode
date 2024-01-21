using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public static IList<int> PreorderTraversal(TreeNode root)
        {
            return TraversalRecursive(root).ToList();
        }

        public static bool EqualFrequency(string word)
        {
            Dictionary<char, ushort> frequency = new Dictionary<char, ushort>();
            foreach (var ch in word)
            {
                if (!frequency.ContainsKey(ch))
                {
                    frequency.Add(ch, 1);
                }
                else
                {
                    frequency[ch]++;
                }
            }

            var counts = GetCounts(frequency.Values.ToList());
            if(counts.Count == 1 && !counts.ContainsKey(1))
            {
                return false;
            }
            if (counts.ContainsKey(1) && counts[1] == 1)
            {
                counts.Remove(1);
            }
            else if (counts.Last().Value == 1)
            {
                counts.Remove(counts.Last().Key);
            }
            else
            {
                var last = counts.Last();
                counts[last.Key]--;
                if (last.Value == 0)
                {
                    counts.Remove(last.Key);
                }
                var newKey = (ushort)(last.Key - 1);
                if (counts.ContainsKey(newKey))
                {
                    counts[newKey]++;
                }
                else if(newKey != 0)
                {
                    counts.Add(newKey, 1);
                }
            }

            return counts.Count == 1;
        }

        private static SortedDictionary<ushort, ushort> GetCounts(IEnumerable<ushort> items)
        {
            SortedDictionary<ushort, ushort> result = new SortedDictionary<ushort, ushort>();
            foreach (var item in items)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
                }
            }

            return result;
        }

        private static IEnumerable<int> TraversalRecursive(TreeNode root)
        {
            if(root == null)
            {
                yield break;
            }

            yield return root.val;
            if (root.left != null)
            {
                var leftTree = TraversalRecursive(root.left);
                foreach (var item in leftTree)
                    yield return item;
            }

            if (root.right != null)
            {
                var rightTree = TraversalRecursive(root.right);
                foreach (var item in rightTree)
                    yield return item;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
