using System;

namespace WebCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Paginacao paginacao = new Paginacao();
            paginacao.CrawlUrl();
        }
    }
}
