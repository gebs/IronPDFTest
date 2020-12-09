using IronPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IronPDFTest
{
    public class IronPDFGenerator : IPDFGenerator
    {
        private readonly HtmlToPdf _renderer;

        public IronPDFGenerator(HtmlToPdf renderer)
        {
            _renderer = renderer;
        }
        public byte[] CreatePDF(string html)
        {
            return _renderer.RenderHtmlAsPdf(html).BinaryData;
        }
    }
}
