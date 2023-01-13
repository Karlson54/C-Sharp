using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11.models
{
    class ServiceCenter
    {
        public static void FixedReinstallWindows(Orders orders) => orders.ReinstallWindows = true;
        public static void FixedReplaceTheMotherboard(Orders orders) { orders.ReplaceTheMotherboard = true; }
        public static void FixedReplaceThePowerSupply(Orders orders) => orders.ReplaceThePowerSupply = true;
        public static void FixedAddRAM(Orders orders) => orders.AddRAM = true;

        public static void FixedReplaceTheVideoCard(Orders orders) => orders.ReplaceTheVideoCard = true;
        public static void FixedConfigurePrograms(Orders orders) => orders.ConfigurePrograms = true;
    }
}
