

            // Prices and tax
             int smallCarpetPrice = 250 ;
             int largeCarpetPrice = 350;
             double taxRate = .14 ; 

            // Title
            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Charges:");
            Console.WriteLine("$250 per small carpet");
            Console.WriteLine("$350 per large carpet");
            Console.WriteLine("Sales tax rate is 14%");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine();

            // User Input
            Console.Write("Number of small carpets: ");
            int smallCarpets = Convert.ToInt16(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            int largeCarpets = Convert.ToInt16(Console.ReadLine());

            // Calculations

            int totalPriceSmall = (smallCarpets * smallCarpetPrice);
            int totalPriceLarge = (largeCarpets * largeCarpetPrice); 
            int cost = (smallCarpets * smallCarpetPrice) +
                       (largeCarpets * largeCarpetPrice);

            double tax = cost * taxRate;
            double totalEstimate = cost + tax;

            // Result
         
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Number of small carpets: {smallCarpets}");
            Console.WriteLine($"Number of large carpets: {largeCarpets}");
            Console.WriteLine($"Price per small carpets: ${totalPriceSmall}");
            Console.WriteLine($"Price per large carpets: ${totalPriceLarge}");
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine("===================================");
            Console.WriteLine($"Total estimate: ${totalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");   
            Console.ReadLine();

            

 






