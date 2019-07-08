using System;

namespace HousingLoanCustomer
{
    class Program
    {
     class HousingLoanCustomer
        {
            int CustomerId;
            string Name;
            double LoanAmount;
            static double _ROI;

            public static double ROI
            {
                get { return _ROI; }
                set { _ROI = value; }
            }

            static HousingLoanCustomer()
            {
                _ROI = 4.589;
            }



            public HousingLoanCustomer(int CustomerId, string Name, double LoanAmount )
            {
                this.CustomerId = CustomerId;
                this.Name = Name;
                this.LoanAmount = LoanAmount;
                
            }

            public void CalculateInterest(int months)
            {
                double IntAmount = LoanAmount * _ROI / 100;
                double RePayAmount = LoanAmount + IntAmount;
                Console.WriteLine("Loan Amount:{0} IntAmount:{1} RePayAmount:{2} ROI:{3}", LoanAmount, IntAmount, RePayAmount, _ROI);
                Console.WriteLine("EMI:" + (RePayAmount / months));
            }

            public static void Enquiry(double EnLoanAmount, int months)
            {
                Console.WriteLine("ROI:" + ROI);
                Console.WriteLine("Loan Amount:" + EnLoanAmount);
                Console.WriteLine("IntAmount:" + EnLoanAmount * ROI / 100);
                Console.WriteLine("RePayLoanAmount:" + (EnLoanAmount + (EnLoanAmount * ROI / 100)));
                Console.WriteLine("EMI Months:" + months);
                Console.WriteLine("EMI:" + (EnLoanAmount + (EnLoanAmount * ROI / 100)) / months);
            }
        }
        static void Main(string[] args)
        {
            //var loanCustomer1 = new HousingLoanCustomer(1, "Henry", 135000);
            //loanCustomer1.CalculateInterest(360);
            //var loanCustomer2 = new HousingLoanCustomer(2, "Mack", 155000 );
            //loanCustomer2.CalculateInterest(180);

            //var loanCustomer3 = new HousingLoanCustomer(1, "Sony", 105000);
            //loanCustomer3.CalculateInterest(180);
            //var loanCustomer4 = new HousingLoanCustomer(2, "Dave", 185000);
            //loanCustomer4.CalculateInterest(360);

            //HousingLoanCustomer.ROI = 4.25;
            //loanCustomer1.CalculateInterest(360);
            //loanCustomer2.CalculateInterest(180);

            HousingLoanCustomer.Enquiry(135000, 360);

            Console.ReadLine();
        }
    }
}
