using DinkToPdf;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinkToPdfAllOs
{
    public static class PdfToolsFactory
    {
        public static PdfTools Create() => new PdfTools();
    }
}
