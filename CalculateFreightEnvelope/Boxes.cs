namespace CalculateFreightEnvelope;

public class Boxes
{
    static int length;
    static int width;
    static int depth;
    static double weight;
    static double price;
    
    static void BoxMini()
    {
        length = 240;
        width = 159;
        depth = 60;
        weight = 67;

        price = 18;
    }
    
    static void BoxSmall()
    {
        length = 332;
        width = 246;
        depth = 65;
        weight = 125.5;

        price = 20;
    }
    
    static void BoxLarge()
    {
        length = 500;
        width = 300;
        depth = 200;
        weight = 359;

        price = 27;
    }
    
    static void NorgespakkeLiten()
    {
        length = 350;
        width = 250;
        depth = 120;
        weight = 191;

        price = 24;
    }
}