using lab11.models;
using System;

namespace lab11
{
    class Program
    {
        delegate void Mylb11(Orders oders);
        static void Main(string[] args)
        {
            Orders orders = new Orders();

            Console.WriteLine(orders);

            Mylb11 mylb = new(ServiceCenter.FixedReinstallWindows);
            mylb += ServiceCenter.FixedReplaceTheMotherboard;
            mylb += ServiceCenter.FixedReplaceThePowerSupply;
            mylb += ServiceCenter.FixedAddRAM;
            mylb += ServiceCenter.FixedReplaceTheVideoCard;
            mylb += ServiceCenter.FixedConfigurePrograms;

            mylb(orders);

            Console.WriteLine(orders);

        }
    }
}
