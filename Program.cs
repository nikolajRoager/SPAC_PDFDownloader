using PDFDownloader;
using static System.Net.WebRequestMethods;

class Program
{
    
    public static void Main(string[] args)
    {
        //Some examples, the comment indicate the expected output
        string[] urls = {
            "http://arpeissig.at/wp-content/uploads/2016/02/D7_NHB_ARP_Final_2.pdf",//File not found
            "http://cdn12.a1.net/m/resources/media/pdf/A1-Umwelterkl-rung-2016-2017.pdf",//Works 
            "https://s3-eu-west-1.amazonaws.com/a2a-be/a2a/gbb-uploads/N0Go7n-BilancioSostenibilita_EN.pdf",//Does not work, possibly permission denied from server, or invalid pdf
            "file:///C:/Users/miller/Downloads/AA_AR2017.pdf",//This is not a website url, it doesn't exist.
            "http://www.hkexnews.hk/listedco/listconews/SEHK/2017/0512/LTN20170512165.pdf",//Works
            ""//This obviously doesn't exist
        };

        string folder = "Downloads";

        PDFDocument[] docs = new PDFDocument[urls.Length];
        for (int i = 0; i < urls.Length; i++)
        {
            docs[i]=new PDFDocument(urls[i], folder,$"File{i}.pdf",true);
        }
    }
}
