
## 1. Qual a função da pasta 'Pages'?
A pasta 'Pages' é o cerne de um Razor Pages. Ela tem os arquivos de front-end por meio do .cshtml e suas respectivas lógicas de back-end por meio do .cshtml.cs. Ela faz a divisão de tudo, como por exemplo a URL baseado nas pastas do projeto. 

## 2. O que faz o arquivo 'Program.cs'?
O 'Program.cs' é o entry point de todo app ASP.NET Core. 

Tem como responsabilidade:
1. Inicializar o WebApplicationBuilder configurando o Kestrel e o ambiente de execução.
2. Configurar a Injeção de Dependência registrando serviços que serão usados.
3. Construir o Pipeline de Requisições HTTP definindo como os componentes que fazem as requisições e respostas executam.

## 3. Onde são configurados os serviços da aplicação?
Dentro do próprio Program.cs, utilizando o builder.Services. 

É neste local que você inclui suporte a funcionalidades específicas como banco de dados, autenticação, etc... ao contêiner de Injeção de Dependência do .NET. 

## 4. Como é feito o roteamento de URLs?
É baseado na ordem de diretórios, determinada pela pasta Pages, como explicado acima.

Por exemplo:

O arquivo Pages/Index.cshtml responde pela rota raiz '/' ou '/Index'.
O arquivo Pages/Produtos.cshtml responde pela rota '/Produtos'.

