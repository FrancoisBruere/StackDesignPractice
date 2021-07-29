using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDesignPractice
{

    public class Stack
    {

        private readonly List<object> stack = new List<object>();
        
        public void Push(object obj)
        {
         

            if (obj == null)
            {
                throw new InvalidOperationException("Object obj is null");
            }
            else
            {
                stack.Add(obj);
            }
            


        }

        public object Pop()
        {
            if (stack.Count == 0)
            
                throw new InvalidOperationException("stack list is empty");

                var index = stack.Count - 1;
                var stackItem = stack[index];
                
                stack.RemoveAt(stack.Count - 1);
                return stackItem;
           

        }


        public void Clear()
        {

            stack.Clear();

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            stack.Clear();
        }
    }
}
