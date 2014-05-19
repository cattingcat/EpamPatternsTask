using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class LogDecorator: ICollection<int>
    {
        private ICollection<int> _data;

        public LogDecorator(ICollection<int> collection)
        {
            _data = collection;
        }

        public void Add(int item)
        {
            _data.Add(item);
            Console.WriteLine("Add {0}", item);
        }

        public void Clear()
        {
            _data.Clear();
            Console.WriteLine("Clear");
        }

        public bool Contains(int item)
        {
            return _data.Contains(item);
            Console.WriteLine("Contains {0}", item);
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            _data.CopyTo(array, arrayIndex);
            Console.WriteLine("CopyTo");
        }

        public int Count
        {
            get 
            {
                Console.WriteLine("Count");
                return _data.Count; 
            }

        }

        public bool IsReadOnly
        {
            get 
            {
                Console.WriteLine("IsReadOnly");
                return _data.IsReadOnly; 
            }
        }

        public bool Remove(int item)
        {
            Console.WriteLine("Remove {0}", item);
            return _data.Remove(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            Console.WriteLine("IEnumerator<int> GetEnumerator()");
            return _data.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            Console.WriteLine("IEnumerable.GetEnumerator()");
            return _data.GetEnumerator();
        }
    }
}
