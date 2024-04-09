static  void CalculateFreight(int l, int b, int h, int w)
{
    int lentgh = l;
    int breadth = b;
    int depth = h;
    int weight = w;


    // up to 35cm x 25cm x 7cm
    // under 350g
    if ( lentgh <= 350 && breadth <= 70 && depth <= 250)
    {
        if (weight <= 20 && breadth <= 20)
        {
            
        }
        else if (weight is > 20 and <= 50 && breadth <= 20)
        {
            
        }
        else if (weight is > 50 and <= 100 && breadth <= 20)
        {
            
        }
        else if (weight is > 100 and <= 350 &&  breadth <= 20)
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
    else if ( lentgh + breadth + depth <= 900 && weight is > 350 and <= 2000)
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
    else if ( breadth is > 12000 and <= 25000 && lentgh <= 3500 && depth <= 12000 && weight < 5000 )
    {
        
    }
    
}