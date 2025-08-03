using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Devices;

namespace BuggyTasks.ViewModels
{
    public partial class DeviceInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        string model;

        [ObservableProperty]
        string platform;

        public DeviceInfoViewModel()
        {
            Model = DeviceInfo.Model;
            Platform = DeviceInfo.Platform.ToString();
        }
    }
}