# WebCrawler
## Programa que extrai vagas de empregos em site.
O site usado como exemplo foi o [Recruta Simples](https://www.recrutasimples.com.br/)

WebCrawler é um sistema (bot) utilizado para extrair informações dos websites disponíveis na World Wide Web.
>Um rastreador da Web , às vezes chamado de spider ou spiderbot e freqüentemente abreviado para crawler , é um bot da Internet que navega sistematicamente na World Wide Web , normalmente operado por mecanismos de pesquisa para fins de indexação da Web ( web spidering ). - Wikipedia

## Estrutura do projeto
- Sistema que crawlear vagas de sites
- [Program.cs] - Classe onde inicia a lógica do sistema chamando a classe paginacao.
- [Paginacao.cs] - Realiza a paginação do site, caso o site tenha mais de uma página de vagas e envia o link de cada página para o listaVagas.cs
- [ListaVagas.cs] - Recupera o link da página realiza o download do HTML da página e faz a busca de todos os links das vagas com o xpath enviando os links para a Vagas.cs
- [Vagas.cs] - Último processo do programa, recupera o link de cada vaga faz o download do HTML da página da vaga, com o xpath recupera informações importantes da vaga como função, salário, descrição, cidade, nome da empresa e url. E faz a trativa com regex melhorando a apresentação desses elementos.

Essa é a estrutura básica do projeto o processo que o programa deve rodar e suas características principais.

## Demostração
Uma apresentação de como o sistema funciona:

![Programa Rodando](https://i.imgur.com/6AwAchU.gif)

## Tecnologias

As principais tecnologias utilizadas para desenvolver o projeto:

| Ferramentas | README |
| ------ | ------ |
| C# | É uma linguagem de programação multiparadigma de propósito geral. C # engloba tipagem estática, tipagem forte, com escopo léxico, imperativa, declarativa, funcional, genérica, orientada a objetos e disciplinas de programação orientadas a componentes. |
| REGEX | Uma expressão regular é uma sequência de caracteres que especifica um padrão de pesquisa. Normalmente, esses padrões são usados ​​por algoritmos de pesquisa de strings para operações "localizar" ou "localizar e substituir" em strings ou para validação de entrada. |
| XPATH | XPath é uma linguagem de consulta para selecionar nós de um documento. Além disso, XPath pode ser usado para calcular valores do conteúdo de um documento. |
| Visual Studio 2019 Community | O Microsoft Visual Studio é um conjunto de ambientes de desenvolvimento integrados desenvolvidos pela Microsoft. |



**Desenvolvido com ❤️ por Fabrício Pereira 👋**
