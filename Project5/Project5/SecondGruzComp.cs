using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{ 
    
    class SecondGruzComp : Company
    {
        private int _avgWeight;
        
        public override string[] CompInf()
        {
            string[] array = { Name, WorkersCnt.ToString(), AvgWeight.ToString() };
            return array;
        }
        
        public SecondGruzComp(string name, int workersCnt) : base(name, workersCnt)
        {

        }

        public SecondGruzComp(string name, int workersCnt, int avgWeight) : base(name, workersCnt)
        {
            AvgWeight = avgWeight;
        }

        public int AvgWeight
        {
            set
            {
                if (value > 0)
                {
                    _avgWeight = value;
                }
            }
            get
            {
                return _avgWeight;
            }
        }

        public static SecondGruzComp operator ++(SecondGruzComp secGruz)
        {
            return new SecondGruzComp(secGruz.Name, secGruz.WorkersCnt) { AvgWeight = secGruz.AvgWeight + 30 };
        }

    }
}
