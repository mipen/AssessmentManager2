using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using static AssessmentManager.PdfPageExt;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing.Layout;
using System.Drawing;

namespace AssessmentManager
{
    public class AssessmentWriter
    {
        private Assessment assessment;
        private string filePath = "";
        private int pageNumber = 1;
        private double PageBottomAdjustment = 10d;

        #region Fonts

        private const string XFontName = "Calibri";

        private static readonly XFont AuthorFont = new XFont(XFontName, 11, XFontStyle.Italic);
        private static readonly XFont TitleFont = new XFont(XFontName, 14, XFontStyle.Bold);
        private static readonly XFont WeightingFont = new XFont(XFontName, 11, XFontStyle.Regular);
        private static readonly XFont FooterFont = new XFont(XFontName, 10, XFontStyle.Italic);

        private static readonly XFont QuestionHeaderFont = new XFont(XFontName, 12, XFontStyle.Bold);
        private static readonly XFont QuestionTextFont = new XFont(XFontName, 12, XFontStyle.Regular);
        private static readonly XFont ModelAnswerHeaderFont = new XFont(XFontName, 11, XFontStyle.Italic);
        private static readonly XFont MarksHeaderFont = new XFont(XFontName, 12, XFontStyle.Bold);
        private static readonly XFont MarksHeaderSecondaryFont = new XFont(XFontName, 11, XFontStyle.Regular);

        #endregion

        #region Constants

        private const double SubQuestionIndent = 20d;
        private const double SubSubQuestionIndent = SubQuestionIndent * 2;
        private const double QuestionGap = 30d; //TODO:: configure this
        private const double AuthorGap = 10d;
        private const double LineGap = 5d;
        private double QuestionHeaderGap(XGraphics g)
        {
            const string measureString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            return g.MeasureString(measureString, MarksHeaderSecondaryFont).Height;
        }
        private const double QuestionTextGap = 10d; //TODO:: Configure this

        #endregion

        public AssessmentWriter(Assessment a, string filePath)
        {
            assessment = a;
            this.filePath = filePath;
        }

        public void MakePDF(bool withAnswers)
        {
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = assessment.AssessmentInfo.AssessmentName;

            //Add the first page. This variable will be used to access the current page being written to.
            XGraphics curGFX = null;
            //This variable will record the current y position on the current page
            double curY = 0;
            PdfPage curPage = NewPage(doc, ref curGFX, ref curY);

            //Draw the title pieces
            //Author
            string authorString = $"Author: {assessment.AssessmentInfo.Author}";
            //double height = curGFX.MeasureString(authorString, AuthorFont, XStringFormats.TopLeft).Height;
            double height = GetTextHeight(authorString, AuthorFont, curPage.PageWidth());
            XRect authorRect = new XRect(curPage.PageLeft(), curPage.PageTop(), curPage.PageWidth(), height);
            curGFX.DrawString(authorString, AuthorFont, XBrushes.Black, authorRect, XStringFormats.TopLeft);
            curY = authorRect.Bottom + AuthorGap;

            //Title 
            //TODO:: Make sure the long titles don't clip off the page here
            height = curGFX.MeasureString(assessment.AssessmentInfo.AssessmentName, TitleFont, XStringFormats.Center).Height;
            XRect titleRect = new XRect(curPage.PageLeft(), curY, curPage.PageWidth(), height);
            curGFX.DrawString(assessment.AssessmentInfo.AssessmentName, TitleFont, XBrushes.Black, titleRect, XStringFormats.Center);
            curY += titleRect.Height;
            double bot = titleRect.Bottom;

            //Weighting
            string weightingString = $"{assessment.AssessmentInfo.AssessmentWeighting}%";
            height = curGFX.MeasureString(weightingString, WeightingFont, XStringFormats.Center).Height;
            XRect weightingRect = new XRect(curPage.PageLeft(), curY, curPage.PageWidth(), height);
            curGFX.DrawString(weightingString, WeightingFont, XBrushes.Black, weightingRect, XStringFormats.Center);
            curY += weightingRect.Height + LineGap;

            //Draw the separation line
            curGFX.DrawLine(XPens.Black, curPage.PageLeft(), curY, curPage.PageRight(), curY);
            curY += LineGap;

            //Testing stuff
            XTextFormatter tf = new XTextFormatter(curGFX);
            string text = assessment.Questions[0].QuestionTextRaw;
            double testheight = GetTextHeight(text, QuestionTextFont, curPage.PageWidth());
            XRect testRect = new XRect(curPage.PageLeft(), curY, curPage.PageWidth(), testheight);
            tf.DrawString(assessment.Questions[0].QuestionText, QuestionTextFont, XBrushes.Black, testRect);
            curY += testRect.Bottom;
            curGFX.DrawLine(XPens.Black, curPage.PageLeft(), curY, curPage.PageRight(), curY);

            //Draw the questions now 
            //DrawQuestions(assessment.Questions, ref doc, ref curPage, ref curGFX, ref curY, 0d);

            try
            {
                doc.Save(filePath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error creating pdf document");
            }
        }

        private PdfPage NewPage(PdfDocument doc, ref XGraphics g, ref double curY)
        {
            //Make a new page with a footer containing page number
            PdfPage page = doc.AddPage();
            g = XGraphics.FromPdfPage(page);

            //Add the page number footer
            string pageNum = $"Page {pageNumber}";
            double height = g.MeasureString(pageNum, FooterFont, XStringFormats.Center).Height;
            double y = page.PageBottom() - height;
            XRect rect = new XRect(page.PageLeft(), y, page.PageWidth(), height);
            g.DrawString(pageNum, FooterFont, XBrushes.Black, rect, XStringFormats.Center);
            pageNumber++;

            curY = page.PageTop();
            PageBottomAdjustment = rect.Height + LineGap;

            return page;
        }

        private void DrawQuestions(List<Question> questions, ref PdfDocument doc, ref PdfPage page, ref XGraphics g, ref double curY, double indent)
        {
            foreach (Question q in questions)
            {
                //First check there is room to draw the question, if not then make a new page
                double availableSpace = page.PageBottom(PageBottomAdjustment);
                if (GetHeightOfQuestion(q, page, g, indent) > availableSpace)
                {
                    page = NewPage(doc, ref g, ref curY);
                }
                //Draw the question
                DrawQuestion(q, ref page, ref g, indent, ref curY);
                //If the question has sub questions, draw them.
                if (q.HasSubQuestions)
                {
                    double nextIndent = indent == 0d ? SubQuestionIndent : SubSubQuestionIndent;
                    DrawQuestions(q.SubQuestions, ref doc, ref page, ref g, ref curY, nextIndent);
                }
            }
        }

        private void DrawQuestion(Question q, ref PdfPage page, ref XGraphics g, double indent, ref double curY)
        {

        }

        private double GetHeightOfQuestion(Question q, PdfPage page, XGraphics g, double indent)
        {
            //TODO:: Calculate and return the total height required for the question
            double height = 0d;

            //Height of question header
            height = g.MeasureString(q.Name, QuestionHeaderFont, XStringFormats.TopLeft).Height;

            //Height of secondary marks line
            height += QuestionHeaderGap(g);

            //Height of question text


            return height;
        }

        private double GetTextHeight(string text, XFont font, double width)
        {
            if (text.NullOrEmpty()) throw new ArgumentNullException("text");
            if (font == null) throw new ArgumentNullException("font");
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics g = XGraphics.FromPdfPage(page);
            string[] words = text.Split(' ');
            double lineHeight = g.MeasureString(words[0], font).Height;
            double totalHeight = lineHeight;

            double curWidth = 0;
            double spaceWidth = g.MeasureString(" ", font).Width;
            foreach(var word in words)
            {
                double wordWidth = g.MeasureString(word, font).Width;
                curWidth += wordWidth + spaceWidth;
                if (curWidth >= width)
                {
                    curWidth = 0d;
                    totalHeight += lineHeight;
                }
            }
            doc.Dispose();
            return totalHeight;
        }

    }
}
