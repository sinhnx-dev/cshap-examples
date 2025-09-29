using System.Diagnostics;
public class PrintPdfToPrinter
{
    public static void Print(string filename)
    {
        Console.WriteLine($"Printing PDF file: {filename}");
        OperatingSystem os = Environment.OSVersion;

        Console.WriteLine($"Platform: {os.Platform}");
        Console.WriteLine($"Version: {os.Version}");
        Console.WriteLine($"Version String: {os.VersionString}");
        Console.WriteLine($"Service Pack: {os.ServicePack}");
        Console.WriteLine($"ver.Major: {os.Version.Major}");

        switch (os.Platform)
        {
            case PlatformID.Win32S:
                Console.WriteLine("Running on Win32s");
                // Check if the file exists
                if (!File.Exists(filename))
                {
                    throw new FileNotFoundException("The specified PDF file was not found.", filename);
                }

                // Configure the process to use the "print" verb
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = filename,
                    Verb = "print", // Tells Windows to print using the default PDF app
                    UseShellExecute = true, // Required for using file verbs
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                try
                {
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while attempting to print the PDF: {ex.Message}");
                    // Depending on your application, you may want to handle specific exceptions
                }
                break;
            case PlatformID.Win32Windows:
                Console.WriteLine("Running on Windows 95/98/ME");
                break;
            case PlatformID.Win32NT:
                Console.WriteLine("Running on Windows NT/2000/XP/Vista/7/8/10/11");
                break;
            case PlatformID.WinCE:
                Console.WriteLine("Running on Windows CE");
                break;
            case PlatformID.MacOSX:
                Console.WriteLine("Running on macOS");
                // macos
                System.Diagnostics.Process.Start("lpr", filename);
                break;
            case PlatformID.Unix:
                Console.WriteLine("Running on Unix/Linux");
                //Process.Start("lpr", "customSizePdf.pdf");
                break;
            default:
                Console.WriteLine("Unknown platform");
                break;
        }
    }
}