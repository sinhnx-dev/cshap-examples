// dotnet add package PDFsharp
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Fonts;
public class CustomPageSize
{
    public enum SizeUnit
    {
        Point,
        Inch,
        Millimeter,
        Centimeter,
        Pixel
    }
    public static void CreatePdfWithCustomSize(string filename, SizeUnit sizeUnit, double width, double height)
    {
        // Create a new PDF document
        PdfDocument document = new PdfDocument();

        // Add a new page to the document
        PdfPage page = document.AddPage();

        switch (sizeUnit)
        {
            case SizeUnit.Point:
                page.Width = XUnit.FromPoint(width);
                page.Height = XUnit.FromPoint(height);
                break;
            case SizeUnit.Inch:
                page.Width = XUnit.FromInch(width);
                page.Height = XUnit.FromInch(height);
                break;
            case SizeUnit.Millimeter:
                page.Width = XUnit.FromMillimeter(width);
                page.Height = XUnit.FromMillimeter(height);
                break;
            case SizeUnit.Centimeter:
                page.Width = XUnit.FromCentimeter(width);
                page.Height = XUnit.FromCentimeter(height);
                break;
            case SizeUnit.Pixel:
                // Assuming 96 DPI for pixel to point conversion
                double widthInPoints = (width / 96.0) * 72.0;
                double heightInPoints = (height / 96.0) * 72.0;
                page.Width = XUnit.FromPoint(widthInPoints);
                page.Height = XUnit.FromPoint(heightInPoints);
                break;
            default:
                throw new ArgumentException("Invalid size unit");
        }

        // Get an XGraphics object for drawing on the page
        XGraphics gfx = XGraphics.FromPdfPage(page);

        // Draw a simple text string
        GlobalFontSettings.FontResolver = new CustomFontResolver();
        XFont customFont = new XFont("MyCustomFont", 9, XFontStyleEx.Regular);
        gfx.DrawString("Nước CHXHCN Việt Nam", customFont, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

        // Save the document
        document.Save(filename);
        document.Close();
    }
}

public class CustomFontResolver : IFontResolver
{
    public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        // Map your desired font family name to the actual font file details
        if (familyName.Equals("MyCustomFont", StringComparison.OrdinalIgnoreCase))
        {
            // Assuming you have a regular and a bold version of your custom font
            if (isBold)
                return new FontResolverInfo("MyCustomFont#Bold");
            else
                return new FontResolverInfo("MyCustomFont#Regular");
        }
        // Fallback to default resolver for other fonts if needed
        return null;
    }

    public byte[] GetFont(string typefaceName)
    {
        // Load the font data from your custom font files
        switch (typefaceName)
        {
            case "MyCustomFont#Regular":
                return File.ReadAllBytes("arial.ttf");
            case "MyCustomFont#Bold":
                return File.ReadAllBytes("MyCustomFont-Bold.ttf");
            default:
                return null;
        }
    }
}
