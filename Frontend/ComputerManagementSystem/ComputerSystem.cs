using System;

namespace ComputerManagementSystem
{
    public class ComputerSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string OperatingSystem { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Motherboard { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; } // RAM in MB
        public int Storage { get; set; } // Storage in GB
    }
}