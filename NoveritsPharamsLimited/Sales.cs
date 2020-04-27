﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NoveritsPharamsLimited
{
    class Sales
    {
        private string medicineCode;
        private int qunatitySold;
        private int plannedSales;
        private int sales;
        private string region;

        public Sales(string mediCde, int quantSld, int plandSales, int actualSales,string salergion)
        {
            MedicineCode = mediCde;
            QuantitySold = quantSld;
            PlannedSales = plandSales;
            ActualSales = actualSales;
            Region = salergion;

        }


        public string MedicineCode
        {
            get { return medicineCode; }
            private set { medicineCode = value; }
        }
        public int QuantitySold
        {
            get { return qunatitySold; }
            private set
            {
                if(value > 0)
                {
                    qunatitySold = value;
                }
            }
        }

        public int PlannedSales
        {
            get { return plannedSales; }
            private set
            {
                if(value > 0)
                {
                    plannedSales = value;
                }
            }
        }

        public int ActualSales
        {
            get { return sales; }
            private set
            {
                if(value > 0)
                {
                    sales = value;
                }
            }
        }
        public string Region
        {
            get { return region; }
            private set
            {
                region = value;
            }
        }
        public string Display(int code)
        {
            
            double differnce = PlannedSales - ActualSales;
            if (differnce > 0)
            {
                return $"Sales for Medicine with code good Expectation Exceeded :{code} is {differnce}";
            }else if(differnce < 0)
            {
                return $"Sales for Medicine with code bad Below Expectation:{code} is {differnce}";
            }
            return $"Fair Expectation Meet{differnce}";
           
        }

        public string Display()
        {
            return$"Medicine Code: {MedicineCode}\n Quatity Sold: {QuantitySold}\n Planned Sales: {PlannedSales}\n Actual Sale: {ActualSales}\n Region :{Region}\n";
        }
    }
}
