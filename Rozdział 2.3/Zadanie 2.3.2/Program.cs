using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._3._2 {
    class Program {
        static void Main(string[] args) {
            //       5
            //    4/   \63
            // 17/ \2 3/  \27 
            BinaryTreeNode<int> drzewko = new BinaryTreeNode<int>() {
                Value = 5,
                Left = new BinaryTreeNode<int>() {
                    Value = 4,
                    Left = new BinaryTreeNode<int>() {
                        Value = 17
                    },
                    Right = new BinaryTreeNode<int>() {
                        Value = 2
                    }
                },
                Right = new BinaryTreeNode<int>() {
                    Value = 63,
                    Left = new BinaryTreeNode<int>() {
                        Value = 3
                    },
                    Right = new BinaryTreeNode<int>() {
                        Value = 27
                    }
                }
            };

            Console.Write("Porządek DFS: ");
            foreach(int i in drzewko) {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            Console.Write("Porządek BFS: ");
            var BFSenum = drzewko.GetEnumeratorBFSExp();
            while (BFSenum.MoveNext()) {
                Console.Write($"{BFSenum.Current}, ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        class BinaryTreeNode<T> : IEnumerable<T> {
            public T Value { get; set; }
            public BinaryTreeNode<T> Left { get; set; } = null;
            public BinaryTreeNode<T> Right { get; set; } = null;

            public IEnumerator<T> GetEnumerator() {
                yield return Value;
                if (Left != null) {
                    foreach (T v in Left) {
                        yield return v;
                    } 
                }

                if (Right != null) {
                    foreach (T v in Right) {
                        yield return v;
                    } 
                }
            }

            public IEnumerator<T> GetEnumeratorDFSExp() {
                return new TreeEnumeratorDFS<T>(this);
            }

            public IEnumerator<T> GetEnumeratorBFS() {
                Queue<BinaryTreeNode<T>> q = new Queue<BinaryTreeNode<T>>();
                q.Enqueue(this);
                while(q.Count > 0) {
                    BinaryTreeNode<T> cur = q.Dequeue();
                    if (cur.Left != null) q.Enqueue(cur.Left);
                    if (cur.Right != null) q.Enqueue(cur.Right);
                    yield return cur.Value;
                }
            }

            public IEnumerator<T> GetEnumeratorBFSExp() {
                return new TreeEnumeratorBFS<T>(this);
            }

            IEnumerator IEnumerable.GetEnumerator() {
                return GetEnumerator();
            }
        }

        class TreeEnumeratorDFS<T> : IEnumerator<T> {
            BinaryTreeNode<T> current = null;
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();

            public TreeEnumeratorDFS(BinaryTreeNode<T> tree) {
                stack.Push(tree);
            }

            public T Current => current.Value;

            object IEnumerator.Current => current;

            public void Dispose() {
                throw new NotImplementedException();
            }

            public bool MoveNext() {
                if (stack.Count == 0) return false;
                current = stack.Pop();
                if (current.Left != null) stack.Push(current.Left);
                if (current.Right != null) stack.Push(current.Right);
                return true;
            }

            public void Reset() {
                throw new NotImplementedException();
            }
        }

        class TreeEnumeratorBFS<T> : IEnumerator<T> {
            BinaryTreeNode<T> current = null;
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

            public TreeEnumeratorBFS(BinaryTreeNode<T> tree) {
                queue.Enqueue(tree);
            }

            public T Current => current.Value;

            object IEnumerator.Current => current;

            public void Dispose() {
                throw new NotImplementedException();
            }

            public bool MoveNext() {
                if (queue.Count == 0) return false;
                current = queue.Dequeue();
                if (current.Left != null) queue.Enqueue(current.Left);
                if (current.Right != null) queue.Enqueue(current.Right);
                return true;
            }

            public void Reset() {
                throw new NotImplementedException();
            }
        }
    }
}
