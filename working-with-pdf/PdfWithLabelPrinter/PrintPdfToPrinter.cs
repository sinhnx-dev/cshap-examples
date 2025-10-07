using PDFtoPrinter;
public class PrintPdfToPrinter
{
    public static void PrintFile(string filename)
    {
        // Check if the file exists
        if (!File.Exists(filename))
        {
            throw new FileNotFoundException("The specified PDF file was not found.", filename);
        }

        OperatingSystem os = Environment.OSVersion;
        Console.WriteLine($"Platform: {os.Platform}");
        Console.WriteLine($"Version: {os.Version}");
        Console.WriteLine($"Version String: {os.VersionString}");
        Console.WriteLine($"Service Pack: {os.ServicePack}");
        Console.WriteLine($"ver.Major: {os.Version.Major}");

        switch (os.Platform)
        {
            case PlatformID.Win32S:
                Console.WriteLine("Printing on Win32s");
                break;
            case PlatformID.Win32Windows:
                Console.WriteLine("Printing on Windows 95/98/ME");
                break;
            case PlatformID.Win32NT:
                Console.WriteLine("Printing on Windows NT/2000/XP/Vista/7/8/10/11");
                var printTimeout = new TimeSpan(0, 30, 0);
                var printer = new PDFtoPrinterPrinter();
                printer.Print(new PrintingOptions("Clabel-CT221B", filename), printTimeout);
                break;
            case PlatformID.WinCE:
                Console.WriteLine("Printing on Windows CE");
                break;
            case PlatformID.MacOSX:
                Console.WriteLine("Printing on macOS");
                // macos
                System.Diagnostics.Process.Start("lpr", filename);
                break;
            case PlatformID.Unix:
                Console.WriteLine("Printing on Unix/Linux");
                System.Diagnostics.Process.Start("lpr", filename);     
                break;
            default:
                Console.WriteLine("Unknown platform");
                break;
        }
    }
}