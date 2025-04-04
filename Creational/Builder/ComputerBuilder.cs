using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class ComputerBuilder
    {
        private Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }

        public ComputerBuilder SetCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder SetRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public ComputerBuilder SetStorage(string storage)
        {
            _computer.Storage = storage;
            return this;
        }

        public ComputerBuilder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public ComputerBuilder SetMotherboard(string motherboard)
        {
            _computer.Motherboard = motherboard;
            return this;
        }

        public ComputerBuilder SetPowerSupply(string powerSupply)
        {
            _computer.PowerSupply = powerSupply;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
