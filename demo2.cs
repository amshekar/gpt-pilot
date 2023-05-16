public class IoTDevice
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }

    //change the abive class to the following example
    /*{
      "devices": [
        {
          "deviceIds": [
            {
              "id": "20-digit ICCID",
              "kind": "iccid"
            }
          ]
        }
      ],
      "reasonCode": "FF",
      "etfWaiver": true,
      "deleteAfterDeactivation": true
    }*/

    public class DeviceIds
    {
        public string id { get; set; }
        public string kind { get; set; }
    }
    public class Devices
    {
        public List<DeviceIds> deviceIds { get; set; }
    }
    public class RootObject
    {
        public List<Devices> devices { get; set; }
        public string reasonCode { get; set; }
        public bool etfWaiver { get; set; }
        public bool deleteAfterDeactivation { get; set; }
    }



    public class IoTDevice
    {
        public List<DeviceIds> Devices { get; set; }
        public string ReasonCode { get; set; }
        public bool EtfWaiver { get; set; }
        public bool DeleteAfterDeactivation { get; set; }
    }

    public class DeviceIds
    {
        public string Id { get; set; }
        public string Kind { get; set; }
    }
    // Can you correct IoTDevice class to match the JSON structure?
    // IoTDevice class should have the following structure:
    /*{
      "devices": [
        {
          "deviceIds": [
            {
              "id": "20-digit ICCID",
              "kind": "iccid"
            }
          ]
        }
      ],
      "reasonCode": "FF",
      "etfWaiver": true,
      "deleteAfterDeactivation": true
    }*/
    // IoTDevice class should have the following structure:
    /*{
      "devices": [
        {
          "deviceIds": [
            {
              "id": "20-digit ICCID",
              "kind": "iccid"
            }
          ]
        }
      ],
      "reasonCode": "FF",
      "etfWaiver": true,
      "deleteAfterDeactivation": true
    }*/
    // IoTDevice class should have the following structure:
    public class IoTDevice
    {
        public List<Devices> devices { get; set; }
        public string reasonCode { get; set; }
        public bool etfWaiver { get; set; }
        public bool deleteAfterDeactivation { get; set; }
    }
    public class Devices
    {
        public List<DeviceIds> deviceIds { get; set; }
    }
    public class DeviceIds
    {
        public string id { get; set; }
        public string kind { get; set; }
    }
    //Rename IoTDevice to DeactivationRequest
    public class DeactivationRequest
    {
        public List<Devices> devices { get; set; }
        public string reasonCode { get; set; }
        public bool etfWaiver { get; set; }
        public bool deleteAfterDeactivation { get; set; }
    }
    public class Devices
    {
        public List<DeviceIds> deviceIds { get; set; }
    }
    public class DeviceIds
    {
        public string id { get; set; }
        public string kind { get; set; }
    }
    
