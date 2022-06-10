using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{

    public abstract class Company
    {
        private string _name;
        private int _workersCnt;

        public abstract string[] CompInf();

        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public int WorkersCnt
        {
            set
            {
                if (value > 0)
                {
                    _workersCnt = value;
                }
            }
            get
            {
                return _workersCnt;
            }
        }

        protected Company(string name, int workersCnt)
        {
            Name = name;
            WorkersCnt = workersCnt;
        }

        public static Stack<Company> operator +(Stack<Company> stack, Company comp)
        {
            stack.Push(comp);
            return stack;
        }
        
        public static Stack<Company> operator -(Stack<Company> stack, Company comp)
        { 
            Stack<Company> newStack = new Stack<Company>();
            bool naydeno = false; 
            while(stack.Count!=0)
            {
                if (stack.Peek().Name != comp.Name)
                {
                    newStack.Push(stack.Pop());
                }
                else
                {
                    naydeno = true;
                    stack.Pop();
                    while(newStack.Count != 0)
                    {
                        stack.Push(newStack.Pop());
                    }
                    break;
                }
            }
            if (naydeno)
            {
                return stack;
            }
            else
            {
                return newStack;
            }
        }
    }

}
