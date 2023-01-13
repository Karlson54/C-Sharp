namespace lab11.models
{
    class Orders
    {
        public bool ReinstallWindows { get; set; }
        public bool ReplaceTheMotherboard { get; set; }
        public bool ReplaceThePowerSupply { get; set; }
        public bool AddRAM { get; set; }
        public bool ReplaceTheVideoCard { get; set; }

        public bool ConfigurePrograms { get; set; }

        public override string ToString()
        {
            return $"ReinstallWindows -- {ReinstallWindows}" +
                   $"\nReplaceTheMotherboard -- {ReplaceTheMotherboard}" +
                   $"\nAddRAM -- {AddRAM}" +
                   $"\nReplaceTheVideoCard -- {ReplaceTheVideoCard} " +
                   $"\nConfigurePrograms -- {ConfigurePrograms}";
        }
        public Orders()
        {
            this.ReinstallWindows = false;
            this.ReplaceTheMotherboard = false;
            this.ReplaceThePowerSupply = false;
            this.AddRAM = false;
            this.ReplaceThePowerSupply = false;
            this.ConfigurePrograms = false;
        }
    }
}
