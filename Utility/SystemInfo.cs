using System.Management;
using Newtonsoft.Json;

namespace Utility
{
    public sealed class SystemInfo
    {
        public string Architecture { get; set; }
        public string Characteristics { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string NumberOfCores { get; set; }
        public string NumberOfEnabledCore { get; set; }
        public string NumberOfLogicalProcessors { get; set; }
        public string ProcessorId { get; set; }
        public string ProcessorType { get; set; }
        public string Role { get; set; }
        public string SocketDesignation { get; set; }
        public string SystemName { get; set; }
        public string ThreadCount { get; set; }

        public SystemInfo()
        {
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Architecture = queryObj["Architecture"].ToString();
                    Characteristics = queryObj["Characteristics"].ToString();
                    Description = queryObj["Description"].ToString();
                    Family = queryObj["Family"].ToString();                   
                    Manufacturer = queryObj["Manufacturer"].ToString();
                    Name = queryObj["Name"].ToString();
                    NumberOfCores = queryObj["NumberOfCores"].ToString();
                    NumberOfEnabledCore = queryObj["NumberOfEnabledCore"].ToString();
                    NumberOfLogicalProcessors = queryObj["NumberOfLogicalProcessors"].ToString();
                    ProcessorId = queryObj["ProcessorId"].ToString();
                    ProcessorType = queryObj["ProcessorType"].ToString();
                    Role = queryObj["Role"].ToString();
                    SocketDesignation = queryObj["SocketDesignation"].ToString();
                    SystemName = queryObj["SystemName"].ToString();
                    ThreadCount = queryObj["ThreadCount"].ToString();
                }
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
