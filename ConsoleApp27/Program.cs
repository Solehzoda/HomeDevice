using System;

namespace homeDevice
{
    public class HomeDevice
    {
        private string DeviceName;
        protected int EnergyConsumption;
        private bool IsOn;

        
        public HomeDevice(string DeviceName, int EnergyConsumption)
        {
            this.DeviceName = DeviceName;
            this.EnergyConsumption = EnergyConsumption;
            this.IsOn = false; 
        }

        
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine(DeviceName + "Работает");
        }

        
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine(DeviceName + "Отлкючён");
        }

        
        public void SetEnergy(int value)
        {
            EnergyConsumption = value;
            Console.WriteLine(DeviceName + "Расходует" + EnergyConsumption + "Вт.");
        }

        
        public void Run()
        {
            Console.WriteLine("Техника" + DeviceName + "Расходи электричество" + EnergyConsumption + " Вт: " + IsOn );
        }
    }



}