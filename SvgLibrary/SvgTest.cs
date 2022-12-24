using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;
using static System.Net.Mime.MediaTypeNames;
using Svg.FilterEffects;
using System.Xml;

namespace SvgLibrary
{
    public static class SvgTest
    {
        public static SvgDocument TestSvg(string fileName)
        {
            //var svgDoc = SvgDocument.Open(fileName);
            var svgDoc = SvgDocument.Open<SvgDocument>(fileName);

            return svgDoc;
        }
        
    }
}
