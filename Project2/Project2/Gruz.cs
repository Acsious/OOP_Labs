using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class Gruz
    {
        private static int _cntObj = 0;
        private int ?_price = null;
        private int ?_weightSum = null;
        private int ?_workersCnt = null;
        private int ?_carsCnt = null;
        private string _name = null;
        private double ?_averageWeight = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="weightSum"></param>
        /// <param name="workersCnt"></param>
        /// <param name="carsCnt"></param>
        /// <param name="name"></param>
        /// <param name="averageWeight"></param>
        public Gruz(int price, int weightSum, int workersCnt, int carsCnt, string name, double averageWeight)
        {
            _cntObj++;
            this._price = price;
            this._weightSum = weightSum;
            this._workersCnt = workersCnt;
            this._carsCnt = carsCnt;
            this._name = name;
            this._averageWeight = averageWeight;
        }
       
        public Gruz()
        {
            _cntObj++;
        }

        public Gruz(int price, string name)
        {
            _cntObj++;
            this._price = price;
            this._name = name;
        }

        public Gruz(string name)
        {
            _cntObj++;
            this._name = name;
        }
        
        public override string ToString()
        {
            Console.WriteLine("ИНФОРМАЦИЯ О КОМПАНИИ");
            if (_name==null)
            {
                return "Нет информации\n";
            }
            else
            {
                if (_price==0)
                {
                    return "Название компании: " + _name.ToString() + "\n";
                }
                else
                {
                    if (_workersCnt == 0)
                    {
                        return "Название компании: " + _name.ToString() + " стоимость одной перевозки: " + _price.ToString() + "\n";
                    }
                    else
                    {
                        return "Название компании: " + _name.ToString() + "\nCтоимость одной перевозки: " + _price.ToString() + "\nCуммарный вес перевезенных грузов: " + _weightSum.ToString() +
                            "\nКоличество работников: " + _workersCnt.ToString() + "\nCредний вес перевозимого груза: " + _averageWeight.ToString() + "\nКоличество автомобилей: " + _carsCnt.ToString() + "\n";
                    }
                }
            }
        }

        public void setPrice(int newPrice)
        {
            _price = newPrice;
        }
        public int getPrice()
        {
            return (int)_price;
        }

        public void setWeightSum(int newWeightSum)
        {
            _weightSum = newWeightSum;
        }
        public int getWeightSum()
        {
            return (int)_weightSum;
        }

        public void setName(string newName)
        {
            _name = newName;
        }
        public string getName()
        {
            return _name;
        }

        public void setWorkersCnt(int newWorkersCnt)
        {
            _workersCnt = newWorkersCnt;
        }
        public int getWorkersCnt()
        {
            return (int)_workersCnt;
        }

        public void setCarsCnt(int newCarsCnt)
        {
            _carsCnt = newCarsCnt;
        }
        public int getСarsCnt()
        {
            return (int)_carsCnt;
        }

        public void setAverageWeight(int newAverageWeight)
        {
            _averageWeight = newAverageWeight;
        }
        public double getAverageWeight()
        {
            return (double)_averageWeight;
        }

        public int getCntObj()
        {
            return _cntObj;
        }
        public void printName()
        {
            System.Console.WriteLine("Название компании: "+this._name);
        }
    }
}
