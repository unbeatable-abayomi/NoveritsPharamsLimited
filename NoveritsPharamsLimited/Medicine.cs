namespace NoveritsPharamsLimited
{
   public abstract class Medicine
    {

        private string mediCode;
        private string mediName;
        private string manuName;
        private double unitPrc;
        private int quanty;
        private string batchNum;
        //private string Maundate;
        //private string expriydate;

        public Medicine(string mediCde, string mediNme, string mauNme, double untPrc, int qunt, string batNum)
        {
            MedicineCode = mediCde;
            MedicineName = mediNme;
            ManufactuerName = mauNme;
            UnitPrice = untPrc;
            Quantity = qunt;
            BatchNumber = batNum;



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
            get { return quanty; }
            private set
            {
                if (value > 0)
                {
                    quanty = value;
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
            return $"Medicine Name: {MedicineName} \n Medicine Code: {MedicineCode} \n Manufactuer Name:{ManufactuerName}\n Unit Price:{UnitPrice}\n : Quantity : {Quantity} \n BatchNumber: {BatchNumber}";
        }

    }
}
