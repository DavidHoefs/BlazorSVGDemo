using Svg;

namespace SvgLibrary;

public static class SvgTest
{
    public static SvgDocument TestSvg(string fileName)
    {
        //var svgDoc = SvgDocument.Open(fileName);
        var svgDoc = SvgDocument.Open<SvgDocument>(fileName);

        return svgDoc;
    }
}