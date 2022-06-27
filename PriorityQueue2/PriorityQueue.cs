using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue2
{
    public interface IPriority
    {
        int Priority { get; set; }
        int Data { get; set; }
    }
    public class PriorityQueue<T> where T : IEquatable<T>, IPriority
    {
        private IDictionary<int, IList<T>> elements;

        public PriorityQueue()
        {
            elements = new Dictionary<int, IList<T>>();
        }

        public PriorityQueue(IEnumerable<T> _elements) : this()
        {
            elements = new Dictionary<int, IList<T>>();
            foreach (var ele in _elements)
            {
                elements.Add(ele.Priority, new List<T>());
            }
        }

        public int Count()
        {
            int count = 0;
            foreach (var e in elements)
            {
                count += e.Value.Count;
            }
            return count;
        }

        public bool Contains(T item)
        {
            foreach (var e in elements)
            {
                foreach (var node in e.Value)
                {
                    if (node.Equals(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Dequeue()
        {
            int highestPriority = GetHighestPriority();

            elements[highestPriority].Remove(elements[highestPriority].First());
        }

        public void Enqueue(int priority, T item)
        {
            var isKeyExist = elements.FirstOrDefault(x => x.Key == priority).Value;

            if (isKeyExist != null)
            {
                isKeyExist.Add(item);
            }
            else
            {
                IList<T> list = new List<T>();
                list.Add(item);
                elements.Add(priority, list);
            }
        }

        public T Peek()
        {

            int highestPriority = GetHighestPriority();

            return elements[highestPriority].First();

        }

        public int GetHighestPriority()
        {
            return elements.Keys.Max();

        }

        internal void Enqueue(PQInput addInput)
        {
            throw new NotImplementedException();
        }
    }
}
