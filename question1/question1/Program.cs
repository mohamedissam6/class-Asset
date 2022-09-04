using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asset asset1 = new Asset("mohamed", -22, 25);
            Asset asset2 = new Asset("essam", 200, 30);
            Console.WriteLine("name: {0}\tvalue: {1}\tdepreciation rate: {2}", asset1.Name, asset1.Value, asset1.DepreciationRate);
            Console.WriteLine("name: {0}\tvalue: {1}\tdepreciation rate: {2}", asset2.Name, asset2.Value, asset2.DepreciationRate);
            Console.WriteLine("\n5% increase\n");
            asset1.Value = asset1.Value + (Convert.ToDecimal(Convert.ToDouble(asset1.Value) * (0.05)));
            asset2.Value = asset2.Value + (Convert.ToDecimal(Convert.ToDouble(asset2.Value) * (0.05)));
            Console.WriteLine("name: {0}\tvalue: {1}\tdepreciation rate: {2}", asset1.Name, asset1.Value, asset1.DepreciationRate);
            Console.WriteLine("name: {0}\tvalue: {1}\tdepreciation rate: {2}", asset2.Name, asset2.Value, asset2.DepreciationRate);
            Console.ReadLine();

        }
    }
}
