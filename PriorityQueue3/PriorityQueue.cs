using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue3
{
    public class PriorityQueue<T> where T : IEquatable<T>
    {
        private class PriorityNode
        {
            public int Priority { get; private set; }
            public T data { get; private set; }

            public PriorityNode(int priority, T data)
            {
                Priority = priority;
                this.data = data;
            }
        }

        private IList<PriorityNode> elements;


        public PriorityQueue()
        {
            elements = new List<PriorityNode>();
        }

        public PriorityQueue(IDictionary<int, IList<T>> inputElements)
        {
            elements = new List<PriorityNode>();

            foreach (var e in inputElements)
            {
                var abc = inputElements[e.Key];

                for (int i = 0; i < abc.Count(); i++)
                {
                    PriorityNode node = new PriorityNode(e.Key, abc[i]);
                    elements.Add(node);
                }
            }
        }

        public int Count()
        {
            int count = elements.Count();
            return count;
        }

        public bool Contains(T item)
        {
            foreach (PriorityNode node in elements)
            {
                if (node.data.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Dequeue()
        {
            int highestPriority = GetHighestPriority();
            PriorityNode obj = elements.Where(x => x.Priority == highestPriority).FirstOrDefault();
            if (obj != null)
            {
                elements.Remove(obj);
            }

        }

        public void Enqueue(int priority, T item)
        {
            PriorityNode node = new PriorityNode(priority, item);
            elements.Add(node);
        }

        public T Peek()
        {
            int highestPriority = GetHighestPriority();
            PriorityNode obj = elements.Where(x => x.Priority == highestPriority).FirstOrDefault();


            return obj != null ? obj.data : default(T);
        }

        public int GetHighestPriority()
        {
            //return elements.ElementAt(0).Priority;
            return elements.Select(x => x.Priority).ToList().Max();            
        }
    }
}
