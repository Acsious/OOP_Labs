using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    class FirstGruzComp : Company
    {

        private int _carsCnt;
        //public int _randValue = 100;

        public override string[] CompInf()
        {
            string[] array = { Name, WorkersCnt.ToString() ,CarsCnt.ToString() };
            return array;
        }

        public FirstGruzComp(string name, int workersCnt) : base(name, workersCnt)
        {

        }

        public FirstGruzComp(string name, int workersCnt, int carsCnt) : base(name, workersCnt)
        {
            CarsCnt = carsCnt;
        }

        public int CarsCnt
        {
            set
            {
                if (value > 0)
                {
                    _carsCnt = value;
                }
            }
            get
            {
                return _carsCnt;
            }
        }
    }
}
