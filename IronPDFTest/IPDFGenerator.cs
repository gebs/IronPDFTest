using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IronPDFTest
{
    public interface IPDFGenerator
    {
        byte[] CreatePDF(string html);
    }
}
