using System;

class Program
{
    static void Main()
    {
        /*Asset asset = new House();
        Console.WriteLine(asset.Name);
        Console.WriteLine((asset as House).NetIncome);
        */

        Asset asset = new Asset();
        House house = new House();

        Console.WriteLine(asset.Name);
        Console.WriteLine(house.Name);

        Console.WriteLine(asset.msg);
        Console.WriteLine(house.msg);

    }
}

/*public abstract class Asset
{ 
    public abstract string Name { get; }

}

public class House : Asset
{
    public override string Name => "Hasan Mahmud Tuhin";
    public decimal NetIncome => 100000000M;
}
*/


//Hidding Inherited Members
public class Asset
{
    public string Name => "Asset.Name";
    public string msg => "Asset.msg";
    public decimal NetIncome => 1000000000M;
    
}

public class House: Asset
{
    public string Name => "House.Name hides Asset.Name";
    public new string msg => "House.msg Hides Asset.msg, This hidding is intentional";

}
