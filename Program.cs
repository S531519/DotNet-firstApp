using System;

namespace DotNet_firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Domestic Parcel Service*******");
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome ,"+userName +"!");
            Console.WriteLine("Enter the no. of parcels you want to include in the estimation");
            int numParcels =  Convert.ToInt32(Console.ReadLine());
            double Tcost = 0.0;
            
            for(int i=1;i<=numParcels;i++)
            {
                Console.WriteLine("Choose the size of the box you want:");
                Console.WriteLine("1. Small");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Large");
                int number = Convert.ToInt32(Console.ReadLine());
                if(number==1)
                    Console.WriteLine("You have opted for a small box.");
                else if(number==2)
                    Console.WriteLine("You have opted for a medium box.");
                else if(number==3)
                    Console.WriteLine("You have opted for a large box.");
                else
                     Console.WriteLine("You have opted invalid entry");    

                Console.WriteLine("Please enter the weight of your parcel in lbs:");
                
                double pWeight = 0.0;
                pWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your given weight is "+ pWeight +" lbs." );
               double cost = 0.0;
                
                switch(number)
                {
                    //double cost = 0;
                    case 1 :
                        
                        if (pWeight <= 0)
                        {
                            Console.WriteLine("You have entered invalid weight.");
                        }
                        else if(pWeight >0 && pWeight<10)
                        {
                            cost = pWeight * 1;
                            Console.WriteLine("Total cost for your parcel service is $" +cost);
                        }
                        else
                        {
                            cost = pWeight * 2;
                        Console.WriteLine("Total cost for your parcel service is $" +cost);
                        }
                        break;
                    case 2 :
                    //double cost=0;
                        if (pWeight <= 0)
                        {
                            Console.WriteLine("You have entered invalid weight.");
                        }
                        else if(pWeight >0 && pWeight<10)
                        {
                            cost = pWeight * 1.5;
                            Console.WriteLine("Total cost for your parcel service is $" +cost);
                        }
                        else
                        {
                            cost = pWeight * 2.5;
                        Console.WriteLine("Total cost for your parcel service is $" +cost);
                        }
                        break;
                    case 3 :
                    //double cost=0;
                        if (pWeight <= 0)
                        {
                            Console.WriteLine("You have entered invalid weight.");
                        }
                        else if(pWeight >0 && pWeight<10)
                        {
                            cost = pWeight * 1.75;
                            Console.WriteLine("Total cost for your parcel service is $" +cost);
                        }
                        else
                        {
                            cost = pWeight * 2.75;
                        Console.WriteLine("Total cost for your parcel service is $" +cost);
                        }
                        break;

                    default :
                        cost = 0.0;
                        Console.WriteLine("Total cost for your parcel service is $ " + cost);
                        break;
                    
                }

            Console.WriteLine(" cost for parcel number "+ i + " is "+cost);
            Tcost = Tcost + cost ;
        }
        Console.WriteLine("Total cost for all the parcels is " +Tcost);
    } 
    }
}