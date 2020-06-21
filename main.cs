using System;

class MainClass {
  public static void Main (string[] args) {
  /*
  The program will ask for the Salesperson’s name and Sales Amount
The program will calculate the Commission as shown below:
SALES COMMISSION = 200 + (0.09 * SALESAMOUNT)
Based on the sales amount, display Performance Status
a) $0–2999 - Poor
c) $3000–4999 - Average
d) $5000–9999 - Good
e) $10000–14999 - Excellent
f) $15000 and above – Outstanding
Note: Sales Amount and Commission can be decimal values ex.356.89
*/
  // Get input
    Console.WriteLine ("Enter Salesperson Name:");
    string salesPersonName = Console.ReadLine();
    Console.WriteLine ("Enter Sales Amount");
    double salesAmount = Convert.ToDouble(Console.ReadLine());
    // Calculate Sales Commission
    double salesCommission = 200 + (0.09 * salesAmount);
    // Display Sales Commission
    Console.WriteLine ("Sales commission for " + salesPersonName + " is $" + salesCommission + ".");
    // Display Performance status.
    if (salesAmount >= 0.00 && salesAmount <=2999.99)
    {
      Console.WriteLine ("Performance is Poor");
    }
    else if (salesAmount >= 3000.00 && salesAmount <=4999.99)
    {
      Console.WriteLine ("Performance is Average");
    }
    else if (salesAmount >= 5000.00 && salesAmount <=9999.99)
    {
      Console.WriteLine ("Performance is Good");
    }
    else if (salesAmount >= 10000.00 && salesAmount <=14999.99)
    {
      Console.WriteLine ("Performance is Excellent");
    }
    else if (salesAmount >= 15000.00)
    {
      Console.WriteLine ("Performance is Oustanding");
    }
  

  }
}