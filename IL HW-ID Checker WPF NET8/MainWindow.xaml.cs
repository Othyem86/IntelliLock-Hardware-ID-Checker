using IntelliLock.Licensing;

namespace IL_HW_ID_Checker_WPF_NET8;

public partial class MainWindow
{
    public MainWindow()
    {
		var biosHwId = HardwareID.GetHardwareID(
		    CPU:       false,
		    HDD:       false,
		    MAC:       false,
		    Mainboard: false,
		    BIOS:      true,
		    OS:        false);

		var cpuHwId = HardwareID.GetHardwareID(
		    CPU:       true,
		    HDD:       false,
		    MAC:       false,
		    Mainboard: false,
		    BIOS:      false,
		    OS:        false);
		
		var hddHwId = HardwareID.GetHardwareID(
		    CPU:       false,
		    HDD:       true,
		    MAC:       false,
		    Mainboard: false,
		    BIOS:      false,
		    OS:        false);
		
		var macHwId = HardwareID.GetHardwareID(
		    CPU:       false,
		    HDD:       false,
		    MAC:       true,
		    Mainboard: false,
		    BIOS:      false,
		    OS:        false);
		
		var maiboardHwId = HardwareID.GetHardwareID(
		    CPU:       false,
		    HDD:       false,
		    MAC:       false,
		    Mainboard: true,
		    BIOS:      false,
		    OS:        false);
		
		var osHwId = HardwareID.GetHardwareID(
		    CPU:       false,
		    HDD:       false,
		    MAC:       false,
		    Mainboard: false,
		    BIOS:      false,
		    OS:        true);
		
		var cpuMainboardHwId = HardwareID.GetHardwareID(
		    CPU:       true,
		    HDD:       false,
		    MAC:       false,
		    Mainboard: true,
		    BIOS:      false,
		    OS:        false);
		
		var fullHwId = HardwareID.GetHardwareID(
		    CPU:       true,
		    HDD:       true,
		    MAC:       true,
		    Mainboard: true,
		    BIOS:      true,
		    OS:        true);
			
        InitializeComponent();

        BiosTextBlock.Text = biosHwId;
        CpuTextBlock.Text = cpuHwId;
        HddTextBlock.Text = hddHwId;
        MacTextBlock.Text = macHwId;
        MainboardTextBlock.Text = maiboardHwId;
        OsTextBlock.Text = osHwId;

        CpuMainboardTextBlock.Text = cpuMainboardHwId;
        FullTextBlock.Text = fullHwId;
    }
}