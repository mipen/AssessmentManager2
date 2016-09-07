using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public static class PdfPageExt
    {
        public const double PageBottomMarginInt = 20d;
        public const double PageTopMarginInt = 20d;
        public const double PageSideMarginInt = 20d;

        public static double PageBottom(this PdfPage page)
        {
            return page.Height - PageBottomMarginInt;
        }

        public static double PageBottom(this PdfPage page, double adjustment)
        {
            return PdfPageExt.PageBottom(page) - adjustment;
        }

        public static double PageTop(this PdfPage page)
        {
            return PageTopMarginInt;
        }

        public static double PageLeft(this PdfPage page)
        {
            return PageSideMarginInt;
        }

        public static double PageRight(this PdfPage page)
        {
            return page.Width - PageSideMarginInt;
        }

        public static double PageWidth(this PdfPage page)
        {
            return page.Width - (2 * PageSideMarginInt);
        }
    }
}
