using System;
using System.Collections.Generic;
using System.Text;

namespace WebCrawler
{
    class Paginacao
    {
        private string url = "https://www.recrutasimples.com.br/vagas?page=";

        public void CrawlUrl()
        {
            ListaVagas listaVagas = new ListaVagas();
            
            for (var i = 1; i <= 2; i++)
            {
                string novaUrl = $"{url}{i}&search=";
                listaVagas.CrawlUrl(novaUrl);
            }
        }
    }
}
