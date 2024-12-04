using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Pilas
    {
        private Stack<string> stack;

        public Pilas()
        {
            stack = new Stack<string>();
        }

        public void Push(string item)
        {
            stack.Push(item);
        }

        public string Pop()
        {
            return stack.Count > 0 ? stack.Pop() : null;
        }

        public string Peek()
        {
            return stack.Count > 0 ? stack.Peek() : null;
        }

        public int Count()
        {
            return stack.Count;
        }
        public IEnumerable<string> GetAllItems()
        {
            return stack;
        }
    }
}
