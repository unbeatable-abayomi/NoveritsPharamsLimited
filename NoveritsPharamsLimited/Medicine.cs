namespace NoveritsPharamsLimited
{
    class Medicine
    {

        private string mediCode;
        private string mediName;
        private string manuName;
        private double unitPrc;
        private int quantity;
        private string batchNum;
        public Date ManufactureDate { get; set; }
        public Date ExpiryDate { get; set; }

        public Medicine(string mediCde, string mediNme, string mauNme, double untPrc, int qunt, string batNum,Date manufacture,Date expiry)
        {
            MedicineCode = mediCde;
            MedicineName = mediNme;
            ManufactuerName = mauNme;
            UnitPrice = untPrc;
            Quantity = qunt;
            BatchNumber = batNum;
            ManufactureDate = manufacture;
            ExpiryDate = expiry;
        }

        public string MedicineCode
        {
            get { return mediCode; }
            private set { mediCode = value; }
        }
        public string MedicineName
        {
            get { return mediName; }
            private set { mediName = value; }
        }
        public string ManufactuerName
        {
            get { return manuName; }
            private set { manuName = value; }
        }

        public double UnitPrice
        {
            get { return unitPrc; }
            private set
            {
                if (value > 0.0)
                {
                    unitPrc = value;
                }
            }
        }
        public int Quantity
        {
            get { return quantity; }
            private set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
        }

        public string BatchNumber
        {
            get { return batchNum; }
            private set
            {
                batchNum = value;
            }
        }

        public int IncreaseStock(int code)
        { 
            if(Quantity == 0)
            {
                Quantity = Quantity + 50;
            }
            return Quantity;
        }


        public int Print(int code)
        {
            return Quantity;
        }
        public string Print(string name,int code)
        {
            return base.ToString();
        }

        public string Print()
        {
            return $"Medicine Name: {MedicineName} \n Medicine Code: {MedicineCode} \n Manufactuer Name:{ManufactuerName}\n Unit Price:{UnitPrice}\n : Quantity : {Quantity} \n BatchNumber: {BatchNumber}\n Manufactuer Date:{ ManufactureDate}\n Expiry Date:{ExpiryDate}";
        }

    }
}
