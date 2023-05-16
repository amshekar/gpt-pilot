//Create a device model it accepts a deviceIds, a device name, and a device type.
//deviceIds is a list of deviceId object,each object as kind and id.
//device name is a string.
//device type is a string.
//     }
//     public class DeviceIds
//     {
//         public string id { get; set; }
//         public string kind { get; set; }
//     }

public class Device
{
    public List<DeviceIds> deviceIds { get; set; }
    public string deviceName { get; set; }
    public string deviceType { get; set; }
}
//create a crud operation for the device model

public class AddDevice
{
    public void AddDevice(Device device)
    {
        try
        {
            deviceDAL.AddDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
public class DeleteDevice
{
    public void DeleteDevice(int deviceId)
    {
        try
        {
            deviceDAL.DeleteDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
public class UpdateDevice
{
    public void UpdateDevice(Device device)
    {
        try
        {
            deviceDAL.UpdateDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
public class GetDevice
{
    public void GetDevice(int deviceId)
    {
        try
        {
            deviceDAL.GetDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
//create a deviceDAL class
public class DeviceDAL
{
    public static List<Device> devices = new List<Device>();
    public void AddDevice(Device device)
    {
        devices.Add(device);
    }
    public void DeleteDevice(int deviceId)
    {
        Device device = devices.Find(id => id.deviceId == deviceId);
        devices.Remove(device);
    }
    public void UpdateDevice(Device device)
    {
        Device device1 = devices.Find(id => id.deviceId == device.deviceId);
        device1.deviceName = device.deviceName;
        device1.deviceType = device.deviceType;
    }
    public Device GetDevice(int deviceId)
    {
        Device device = devices.Find(id => id.deviceId == deviceId);
        return device;
    }
}
//create a deviceBAL class
public class DeviceBAL
{
    DeviceDAL deviceDAL = new DeviceDAL();
    public void AddDevice(Device device)
    {
        try
        {
            deviceDAL.AddDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void DeleteDevice(int deviceId)
    {
        try
        {
            deviceDAL.DeleteDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void UpdateDevice(Device device)
    {
        try
        {
            deviceDAL.UpdateDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public Device GetDevice(int deviceId)
    {
        try
        {
            return deviceDAL.GetDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
//create a device controller
public class DeviceController
{
    DeviceBAL deviceBAL = new DeviceBAL();
    public void AddDevice(Device device)
    {
        try
        {
            deviceBAL.AddDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void DeleteDevice(int deviceId)
    {
        try
        {
            deviceBAL.DeleteDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void UpdateDevice(Device device)
    {
        try
        {
            deviceBAL.UpdateDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public Device GetDevice(int deviceId)
    {
        try
        {
            return deviceBAL.GetDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
//create a device view
public class DeviceView
{
    DeviceController deviceController = new DeviceController();
    public void AddDevice(Device device)
    {
        try
        {
            deviceController.AddDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void DeleteDevice(int deviceId)
    {
        try
        {
            deviceController.DeleteDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void UpdateDevice(Device device)
    {
        try
        {
            deviceController.UpdateDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public Device GetDevice(int deviceId)
    {
        try
        {
            return deviceController.GetDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
//refcator the above code using interface

public interface IDeviceDAL
{
    void AddDevice(Device device);
    void DeleteDevice(int deviceId);
    void UpdateDevice(Device device);
    Device GetDevice(int deviceId);
}
public class DeviceDAL : IDeviceDAL
{
    public static List<Device> devices = new List<Device>();
    public void AddDevice(Device device)
    {
        devices.Add(device);
    }
    public void DeleteDevice(int deviceId)
    {
        Device device = devices.Find(id => id.deviceId == deviceId);
        devices.Remove(device);
    }
    public void UpdateDevice(Device device)
    {
        Device device1 = devices.Find(id => id.deviceId == device.deviceId);
        device1.deviceName = device.deviceName;
        device1.deviceType = device.deviceType;
    }
    public Device GetDevice(int deviceId)
    {
        Device device = devices.Find(id => id.deviceId == deviceId);
        return device;
    }
}
public interface IDeviceBAL
{
    void AddDevice(Device device);
    void DeleteDevice(int deviceId);
    void UpdateDevice(Device device);
    Device GetDevice(int deviceId);
}
public class DeviceBAL : IDeviceBAL
{
    IDeviceDAL deviceDAL = new DeviceDAL();
    public void AddDevice(Device device)
    {
        try
        {
            deviceDAL.AddDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void DeleteDevice(int deviceId)
    {
        try
        {
            deviceDAL.DeleteDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void UpdateDevice(Device device)
    {
        try
        {
            deviceDAL.UpdateDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public Device GetDevice(int deviceId)
    {
        try
        {
            return deviceDAL.GetDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
public interface IDeviceController
{
    void AddDevice(Device device);
    void DeleteDevice(int deviceId);
    void UpdateDevice(Device device);
    Device GetDevice(int deviceId);
}
public class DeviceController : IDeviceController
{
    IDeviceBAL deviceBAL = new DeviceBAL();
    public void AddDevice(Device device)
    {
        try
        {
            deviceBAL.AddDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void DeleteDevice(int deviceId)
    {
        try
        {
            deviceBAL.DeleteDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void UpdateDevice(Device device)
    {
        try
        {
            deviceBAL.UpdateDevice(device);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public Device GetDevice(int deviceId)
    {
        try
        {
            return deviceBAL.GetDevice(deviceId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
public interface IDeviceView
{
    void AddDevice(Device device);
    void DeleteDevice(int deviceId);
    void UpdateDevice(Device device);
    Device GetDevice(int deviceId);
}


//write unit test for above code
using nunit.framework;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System;
[TestFixture]
public class DeviceTest
{
    Mock<IDeviceDAL> mockDeviceDAL = new Mock<IDeviceDAL>();
    DeviceBAL deviceBAL = new DeviceBAL();
    [Test]
    public void AddDevice()
    {
        Device device = new Device();
        device.deviceId = 1;
        device.deviceName = "device1";
        device.deviceType = "type1";
        mockDeviceDAL.Setup(m => m.AddDevice(device));
        deviceBAL.AddDevice(device);
        mockDeviceDAL.VerifyAll();
    }
    [Test]
    public void DeleteDevice()
    {
        Device device = new Device();
        device.deviceId = 1;
        device.deviceName = "device1";
        device.deviceType = "type1";
        mockDeviceDAL.Setup(m => m.DeleteDevice(device.deviceId));
        deviceBAL.DeleteDevice(device.deviceId);
        mockDeviceDAL.VerifyAll();
    }
    [Test]
    public void UpdateDevice()
    {
        Device device = new Device();
        device.deviceId = 1;
        device.deviceName = "device1";
        device.deviceType = "type1";
        mockDeviceDAL.Setup(m => m.UpdateDevice(device));
        deviceBAL.UpdateDevice(device);
        mockDeviceDAL.VerifyAll();
    }
    [Test]
    public void GetDevice()
    {
        Device device = new Device();
        device.deviceId = 1;
        device.deviceName = "device1";
        device.deviceType = "type1";
        mockDeviceDAL.Setup(m => m.GetDevice(device.deviceId)).Returns(device);
        Device device1 = deviceBAL.GetDevice(device.deviceId);
        mockDeviceDAL.VerifyAll();
        Assert.AreEqual(device, device1);
    }
} 

