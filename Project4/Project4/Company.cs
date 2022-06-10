using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    
    abstract class Company
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
    }
}
