# 🌦 ConsumoApiClima

Aplicação ASP.NET MVC desenvolvida em C# para consumo de dados meteorológicos em tempo real através da API da OpenWeather.

Este projeto foi criado com o objetivo de praticar consumo de APIs externas, manipulação de JSON, injeção de dependência e organização de código seguindo o padrão MVC.

---

## 📌 Sobre o Projeto

O ConsumoApiClima permite que o usuário informe o nome de uma cidade e receba as seguintes informações climáticas:

- 🌡 Temperatura atual
- ☁ Condição do clima
- 💧 Umidade
- 🌬 Velocidade do vento

A aplicação realiza uma requisição HTTP para a API da OpenWeather, processa o JSON retornado e exibe os dados formatados na interface.

---

## 🏗 Arquitetura

O projeto segue o padrão MVC (Model-View-Controller):

- **Controllers** → Responsáveis por receber as requisições e processar as regras da aplicação  
- **Models** → Representação estruturada dos dados climáticos  
- **Views** → Interface de exibição para o usuário  
- **wwwroot** → Arquivos estáticos (CSS, JavaScript, bibliotecas)  

Fluxo da aplicação:

1. Usuário informa a cidade
2. Controller recebe a requisição
3. A API externa é consumida via HttpClient
4. O JSON retornado é convertido em objeto C#
5. Os dados são enviados para a View

---

## 🚀 Tecnologias Utilizadas

- C#
- .NET
- ASP.NET MVC
- HttpClient
- Newtonsoft.Json
- REST API

---

## 🌐 API Utilizada

Este projeto consome a API pública da OpenWeather:

https://openweathermap.org/api

---

## 🔐 Configuração da API Key

Para executar o projeto, é necessário gerar uma API Key gratuita na OpenWeather.

### 1️⃣ Criar conta
Acesse:
https://openweathermap.org/

Crie uma conta e gere sua API Key.

### 2️⃣ Clone o repositório:

### 3️⃣ Abra o projeto:

### 4️⃣ Acesse a pasta appsettings.json:
Altere a região "SUA_CHAVE_AQUI" pela sua chave api gerada no site da openweather e inicie o projeto

## 🧠 Conceitos Aplicados

- Consumo de API REST
- Injeção de Dependência
- Async/Await
- Manipulação de JSON
- Configuração via appsettings
- Tratamento básico de exceções
- Separação de responsabilidades (MVC)

---



