using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Gruz
    {
        private int price;
        private int weightSum;
        private int workersCnt;
        private int carsCnt;
        private string name;
        private double averageWeight;

        public Gruz(int price, int weightSum, int workersCnt, int carsCnt, string name, double averageWeight)
        {
            this.price = price;
            this.weightSum = weightSum;
            this.workersCnt = workersCnt;
            this.carsCnt = carsCnt;
            this.name = name;
            this.averageWeight = averageWeight;
        }

        public Gruz()
        {
        }

        public Gruz(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public Gruz(string name)
        {
            this.name = name;
        }

        void setPrice(int newPrice)
        {
            price = newPrice;
        }
        void setWeightSum(int newWeightSum)
        {
            weightSum = newWeightSum;
        }
        void setName(string newName)
        {
            name = newName;
        }
        void setWorkersCnt(int newWorkersCnt)
        {
            workersCnt = newWorkersCnt;
        }
        void setCarsCnt(int newCarsCnt)
        {
            carsCnt = newCarsCnt;
        }
        void setAverageWeight(int newAverageWeight)
        {
            averageWeight = newAverageWeight;
        }
        int getPrice()
        {
            return price;
        }
        int getWeightSum()
        {
            return weightSum;
        }
        int getWorkersCnt()
        {
            return workersCnt;
        }
        int getcarsCnt()
        {
            return carsCnt;
        }
        string getName()
        {
            return name;
        }
        double getAverageWeight()
        {
            return averageWeight;
        }



    }
}
