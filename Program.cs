using System;

namespace DotNet_firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Domestic Parcel Cost Estimator*******"+"\n\n"+"Please enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("\n"+"Welcome "+userName+"!"+"\n\n"+"Please enter the no. of parcels you want to include in the estimation :");
            int numParcels =  Convert.ToInt32(Console.ReadLine());
            double Tcost = 0.0;
            bool like = false;
            for(int i=1;i<=numParcels;i++)
            {
                Console.WriteLine("\n"+"Choose the size of the box you want for parcel number "+i+" :"+"\n");
                Console.WriteLine("a. Small");
                Console.WriteLine("b. Medium");
                Console.WriteLine("c. Large");
                char alpha = Convert.ToChar(Console.ReadLine());
                if(alpha=='a')
                    Console.WriteLine("You have opted for a small box.");
                else if(alpha=='b')
                    Console.WriteLine("You have opted for a medium box.");
                else if(alpha=='c')
                    Console.WriteLine("You have opted for a large box.");
                else
                     Console.WriteLine("You have opted invalid entry.");    

                Console.WriteLine("\n"+"Please enter the weight of your parcel in lbs:");
                
                double pWeight = 0.0;
                pWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your given weight is {pWeight} lbs." );
               double cost = 0.0;
                
                switch(alpha)
                {
                    //double cost = 0;
                    case 'a' :
                        
                        if (pWeight <= 0)
                        {
                           // Console.WriteLine("You have entered invalid weight.");
                        }
                        else if(pWeight >0 && pWeight<10)
                        {
                            cost = Cost(pWeight,1);
                           // Console.WriteLine("Cost estimation for your parcel number "+i+" is $" +cost);
                        }
                        else
                        {
                            cost = Cost(pWeight,2);
                       // Console.WriteLine("Cost estimation for your parcel number "+i+" is $" +cost);
                        }
                        break;
                    case 'b' :
                    //double cost=0;
                        if (pWeight <= 0)
                        {
                           // Console.WriteLine("You have entered invalid weight.");
                        }
                        else if(pWeight >0 && pWeight<10)
                        {
                            cost = Cost(pWeight,1.5);
                           // Console.WriteLine("Cost estimation for your parcel number "+i+" is $" +cost);
                        }
                        else
                        {
                            cost = Cost(pWeight,2.5);
                        //Console.WriteLine("Cost estimation for your parcel number "+i+" is $" +cost);
                        }
                        break;
                    case 'c' :
                    //double cost=0;
                        if (pWeight <= 0)
                        {
                          //  Console.WriteLine("You have entered invalid weight.");
                        }
                        else if(pWeight >0 && pWeight<10)
                        {
                            cost = Cost(pWeight,1.75);
                         //   Console.WriteLine("Cost estimation for your parcel number "+i+" is $" +cost);
                        }
                        else
                        {
                            cost = Cost(pWeight,2.75);
                       // Console.WriteLine("Cost estimation for your parcel number "+i+" is $" +cost);
                        }
                        break;

                    default :
                        cost = 0.0;
                        //Console.WriteLine("Cost estimation for your parcel number "+i+" is $" +cost);
                        break;
                    
                }

           Console.WriteLine("Cost estimation for your parcel number "+i+" is $" +cost);
            Tcost = Tcost + cost ;
        }
        decimal TotalCost = (decimal)(Tcost);

        Console.WriteLine("\n"+"Total cost for all the parcels is $ " +TotalCost);
        Console.WriteLine("\n"+"Did you like our app ? y/n");
        
        var option = Console.ReadLine();
        if (option == "y") {
            like = true;
        }
        if (like) {
            Console.WriteLine("Thank you so much !");
        } else {
            Console.WriteLine("Thank you, Please leave your suggestion.");
            string suggestion = Console.ReadLine();
        }
        

    } 
    static double Cost(double pWeight, double number) {
        return pWeight * number;
    }
    }
}