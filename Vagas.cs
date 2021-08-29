using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace WebCrawler
{
    class Vagas
    {
        public void Crawlurl(string urlDaVaga)
        {
            HtmlDocument html = new HtmlDocument();
            var client = new WebClient();

            string htmlString = client.DownloadString(urlDaVaga);
            html.LoadHtml(htmlString);

            string escopo = html.DocumentNode.SelectSingleNode("//*[@class='job-header__body']").InnerText;
            string funcao = html.DocumentNode.SelectSingleNode("//h2[@class='card-title']").InnerText;
            string dataVaga = html.DocumentNode.SelectSingleNode("//span[@class='card-text']//b").InnerText;
            var beneficiosbase = html.DocumentNode.SelectSingleNode("//*[@class='list card-text']//li");
            string beneficios = beneficiosbase != null ? beneficiosbase.InnerText : "";

            escopo = Regex.Replace(escopo, @"\s+", " ");

            string cidade = Regex.Match(escopo, @"(?<=Localização).*(?=Contrato)").ToString();
            if (string.IsNullOrEmpty(cidade))
            {
                cidade = Regex.Match(escopo, @"(?<=Localização).*(?=Remuneração)").ToString();
            }
            string empresa = Regex.Match(escopo, @"(?<=Empresa).*(?=Localização)").ToString();
            empresa = Regex.Replace(empresa, @"(\.){3}|(participações).*", "");
            empresa = Regex.Replace(empresa, @"(?<=familiar).*", "");
            if(empresa == "")
            {
                empresa = "Confidencial";
            }
            string salario = Regex.Match(escopo, @"(?<=Remuneração).*(?=Benefícios)").ToString();
            string contrato = Regex.Match(escopo, @"(?<=Contrato).*(?=Remuneração)").ToString();

            string descricao = Regex.Match(escopo, @"(?<=Descrição).*").ToString();
            descricao = Regex.Replace(descricao, @"\n", " ");
            descricao = Regex.Replace(descricao, @"[***]", " ");
            descricao = Regex.Replace(descricao, @"-", "");
            descricao = Regex.Replace(descricao, @"\s+", " ");
            descricao = $"{descricao} Benefícios: {beneficios}";

            Console.WriteLine("\nVaga:\n");
            Console.WriteLine("\nFunção: " + funcao);
            Console.WriteLine("\nData: " + dataVaga);
            Console.WriteLine("\nEmpresa: " + empresa);
            Console.WriteLine("\nLocalização: " + cidade);
            Console.WriteLine("\nContrato: " + contrato);
            Console.WriteLine("\nSalário: " + salario);
            Console.WriteLine("\nDescrição: " + descricao);
            Console.WriteLine("\nUrl da vaga: " + urlDaVaga);
        }
    }
}
