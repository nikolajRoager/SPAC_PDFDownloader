using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PDFDownloader
{
    internal class PDFDocument
    {
        public string Source;
        public string? Output;//If null, it will not be saved

        public string Error = "No Error";
        private byte[] data;//Will be empty if we either skip, or fail

        public enum PdfStatus {NotLoaded/*Has not even tried loading, bytes and error are empty*/, Loaded/*No problem (bytes are not empty, error is empty)*/, Skipped/*Already existed (bytes and error are empty)*/, Failed/*Error included (bytes is empty, error is not)*/};

        public PdfStatus pdfStatus=PdfStatus.NotLoaded;

        public PDFDocument(string source,string? folder, string name, bool force=false/*Overwrite existing files in the output (Keep this false for debugging, that way we quickly get to the ones which failed!)*/)
        {
            Source = source;
            Output = folder == null ? null : Path.Combine(folder,name);
            pdfStatus = PdfStatus.NotLoaded;
            Error = "No error";

            data = new byte[0];
        }

    }
}
