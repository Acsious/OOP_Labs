using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Project4
{
    /// <summary>
    /// Обобщенный класс
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ObobshenniyClass<T> : IComparable<T>
    {
        Stack<T> myStack = new Stack<T>();
        LinkedList<T> myList = new LinkedList<T>();
        public Stack<T> MyStack
        {
            get
            {
                return myStack;
            }
        }
        public LinkedList<T> MyList
        {
            get
            {
                return myList;
            }
        }

        public int CompareTo([AllowNull] T other)
        {
            return myList.Count.CompareTo(other);
        }

        /// <summary>
        /// Метод удаления элемента из стека
        /// </summary>
        /// <param name="comp">элемент который необходимо удалить</param>
        public void del(T comp)
        {
            Stack<T> newStack = new Stack<T>();
            while (myStack.Count != 0)
            {
                if (!myStack.Peek().Equals(comp))
                {
                    newStack.Push(myStack.Pop());
                }
                else
                {
                    myStack.Pop();
                    break;
                }
            }
            while(newStack.Count!=0)
            {
                myStack.Push(newStack.Pop());
            }
        }
    }
}
