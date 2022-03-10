using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStack
{
    class Stack
    {
        private readonly List<object> _list = new List<object>();
        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("The Object value is null.");

            }

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty.");

            }

            object objLimited = _list[_list.Count - 1];

            _list.RemoveAt(_list.Count - 1);

            return objLimited;
        }

        public void Clear()
        {
            _list.Clear();

        }
    }
}
