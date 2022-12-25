using System.Xml.Linq;

namespace BlazorSVGDemo.Services;

public static class SvgHelperService
{
    public static void AddMarker(string fileName, string x, string y)
    {
        //<circle id="@marker.Name" class="Markers" fill="red" transform="translate(@marker.X,@marker.Y)" r="6" stroke="black" stroke-width="1"/>
        var doc = XDocument.Load(fileName);
        var rootElements = doc.Root;
        doc.Root.Add(
            new XElement("g",
                new XElement("circle", new XAttribute("transform", $"translate({x},{y})"),
                    new XAttribute("class", "Markers"), new XAttribute("fill", "blue"), new XAttribute("r", "6"),
                    new XAttribute("stroke", "black"), new XAttribute("stroke-width", "1"))));
        doc.Save(fileName);
        Console.WriteLine();
    }
}