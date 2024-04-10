namespace CalculateFreightEnvelope;

public class Calculations
{
    public static int CalculateFreight(double l, double b, double h, double w)
    {
        double length = l;
        double breadth = b;
        double depth = h;
        double weight = w;

        int priceFreight = 0;

        if (length < 500 && weight < 200)
            priceFreight = 45;
    
    
        // up to 35cm x 25cm x 7cm
        // under 350g
        if ( length <= 350 && breadth <= 70 && depth <= 250)
        {
            if (weight <= 20 && breadth <= 20)
            {
                priceFreight = 50;
            }
            else if (weight is > 20 and <= 50 && breadth <= 20)
            {
                priceFreight = 50;
            }
            else if (weight is > 50 and <= 100 && breadth <= 20)
            { 
                priceFreight = 50;
            }
            else if (weight is > 100 and <= 350 &&  breadth <= 20)
            { 
                priceFreight = 50;
            }
            
            if (weight <= 20 && breadth <= 20)
            {
                priceFreight = 50;
            }
            else if (weight is > 20 and <= 50 && breadth is > 20 and <= 70)
            {
                priceFreight = 50;
            }
            else if (weight is > 50 and <= 100 && breadth is > 20 and <= 70)
            {
                priceFreight = 50;
            }
            else if (weight is > 100 and <= 350 &&  breadth is > 20 and <= 70)
            {
                priceFreight = 50;
            }
        }
        
        
        else if ( length + breadth + depth <= 900 && weight is > 350 and <= 2000)
        {
            if (weight is > 350 and <= 1000 )
            {
                
            }
            else if (weight is > 1000 and <= 2000 )
            {
                
            }
            
            if (weight <= 20 && breadth <= 20)
            {
                
            }
            else if (weight is > 20 and <= 50 && breadth is > 20 and <= 70)
            {
                
            }
            else if (weight is > 50 and <= 100 && breadth is > 20 and <= 70)
            {
                
            }
            else if (weight is > 100 and <= 350 &&  breadth is > 20 and <= 70)
            {
                
            }
        }
        else if ( breadth is > 2000 and <= 12000 && weight is > 349 and <= 2000 )
        {
            
        }
        else if ( breadth is > 12000 and <= 25000 && length <= 3500 && depth <= 12000 && weight < 5000 )
        {
            
        }

        return priceFreight;
    }
    
}