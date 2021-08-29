using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WebCrawler
{
    class ListaVagas
    {
        public void CrawlUrl(string url)
        {
            Vagas vaga = new Vagas();
            HtmlDocument html = new HtmlDocument();
            var client = new WebClient();

            string htmlstring = client.DownloadString(url);

            html.LoadHtml(htmlstring);

            var listaDeUrl = html.DocumentNode.SelectNodes("//*[@class='card-clickable']//h2/a/@href");

            foreach (var urlVaga in listaDeUrl)
            {
                string linkVaga = "https://www.recrutasimples.com.br" + urlVaga.GetAttributeValue("href", null);
                vaga.Crawlurl(linkVaga);
            }
        }
    }
}
