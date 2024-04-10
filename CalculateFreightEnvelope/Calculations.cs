namespace CalculateFreightEnvelope;

public static class Calculations
{
    public static int CalculateFreight(double length, double width, double depth, double weight, double addedWeight)
    {
        double combinedWeight = weight + addedWeight;

        int priceFreight = 0;

        if (length < 500 && combinedWeight < 100)
            priceFreight = 45;
        
        if (length < 500 && combinedWeight > 100)
            priceFreight = 55;
    
    
        // up to 35cm x 25cm x 7cm
        // under 350g
        if ( length <= 350 && width <= 70 && depth <= 250)
        {
            if (weight <= 20 && width <= 20)
            {
                priceFreight = 50;
            }
            else if (weight is > 20 and <= 50 && width <= 20)
            {
                priceFreight = 50;
            }
            else if (weight is > 50 and <= 100 && width <= 20)
            { 
                priceFreight = 50;
            }
            else if (weight is > 100 and <= 350 &&  width <= 20)
            { 
                priceFreight = 50;
            }
            
            if (weight <= 20 && width <= 20)
            {
                priceFreight = 50;
            }
            else if (weight is > 20 and <= 50 && width is > 20 and <= 70)
            {
                priceFreight = 50;
            }
            else if (weight is > 50 and <= 100 && width is > 20 and <= 70)
            {
                priceFreight = 50;
            }
            else if (weight is > 100 and <= 350 &&  width is > 20 and <= 70)
            {
                priceFreight = 50;
            }
        }
        
        
        else if ( length + width + depth <= 900 && weight is > 350 and <= 2000)
        {
            if (weight is > 350 and <= 1000 )
            {
                
            }
            else if (weight is > 1000 and <= 2000 )
            {
                
            }
            
            if (weight <= 20 && width <= 20)
            {
                
            }
            else if (weight is > 20 and <= 50 && width is > 20 and <= 70)
            {
                
            }
            else if (weight is > 50 and <= 100 && width is > 20 and <= 70)
            {
                
            }
            else if (weight is > 100 and <= 350 &&  width is > 20 and <= 70)
            {
                
            }
        }
        else if ( width is > 2000 and <= 12000 && weight is > 349 and <= 2000 )
        {
            
        }
        else if ( width is > 12000 and <= 25000 && length <= 3500 && depth <= 12000 && weight < 5000 )
        {
            
        }

        return priceFreight;
    }
    
}