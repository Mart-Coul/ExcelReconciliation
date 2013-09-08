using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using iTextSharp.text;
using System.Collections;
using System.IO;
namespace BankReconciliation
{
    public  class PdfFileReader
    {
        public string ParsePdf(string filePath)
        {
            string text = string.Empty;

            PdfReader reader = new iTextSharp.text.pdf.PdfReader(filePath);
            byte[] streamBytes = reader.GetPageContent(1);

            FileStream fStream = File.OpenRead(filePath);

            byte[] contents = new byte[fStream.Length];

            fStream.Read(contents, 0, (int)fStream.Length);

            fStream.Close();

            string s = Encoding.UTF8.GetString(contents, 0, contents.Length);
            var table = (Encoding.Default.GetString(streamBytes, 0, streamBytes.Length - 1)).Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            byte[] buf = Encoding.Convert(Encoding.GetEncoding("iso-8859-1"), Encoding.UTF8, streamBytes);
            string tempString = Encoding.UTF8.GetString(buf, 0, buf.Count());
            PRTokeniser tokenizer = new PRTokeniser(streamBytes);

            while (tokenizer.NextToken())
            {
                if (tokenizer.TokenType == PRTokeniser.TK_STRING)
                {
                    text += tokenizer.StringValue;
                }
            }

            // create a reader (constructor overloaded for path to local file or URL)
            //PdfReader reader
            //    = new PdfReader("http://www.chinehamchat.com/Chineham_Chat_Advertisements.pdf");
            // total number of pages
            int n = reader.NumberOfPages;
            // size of the first page
            Rectangle psize = reader.GetPageSize(1);
            //float width = psize.Width;
            //float height = psize.Height;
            //Console.WriteLine("Size of page 1 of {0} => {1} × {2}", n, width, height);
            // file properties
            Hashtable infoHash = reader.Info;
            ICollection keys = infoHash.Keys;
           // Dictionary<string, string> infodict = (Dictionary<string,string>)reader.Info;
            foreach (string key in keys)
                text += key + " => " + infoHash[key];
               // Console.WriteLine(key+ " => " + infoHash[key]);
            return text;
        }
        public  string parseUsingPDFBox(string filename)
        {
            PDDocument doc = PDDocument.load(filename);
            PDFTextStripper stripper = new PDFTextStripper();
            string text = stripper.getText(doc);
            doc.close();
            return text;
        }  
    }
}
