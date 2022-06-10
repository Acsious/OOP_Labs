
namespace Project4
{
    class FirstGruzComp : Company
    {

        private int _carsCnt;

        public override string[] CompInf()
        {
            string[] array = { Name, WorkersCnt.ToString(), CarsCnt.ToString() };
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

        public static FirstGruzComp operator ++(FirstGruzComp firstGruz)
        {
            return new FirstGruzComp(firstGruz.Name, firstGruz.WorkersCnt) { CarsCnt = firstGruz.CarsCnt + 15 };
        }
    }
}
