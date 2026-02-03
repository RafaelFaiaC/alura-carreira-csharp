# C# — Consumindo API, Gravando Arquivos e Utilizando LINQ

Projeto desenvolvido como parte da **Carreira de Desenvolvimento Back-End .NET** da [Alura](https://www.alura.com.br/).

Este repositório contém o código criado durante o curso  
➡️ **[C#: consumindo API, gravando arquivos e utilizando o LINQ](https://cursos.alura.com.br/course/c-sharp-consumindo-api-gravando-arquivos-linq)**

---

## 📘 Sobre o Curso

O objetivo deste curso é aprofundar o uso do **C# na integração com APIs externas**, explorando o consumo de dados via **HTTP**, a **desserialização de JSON**, a **manipulação de dados com LINQ** e a **gravação de arquivos JSON**.

Durante o treinamento, foi desenvolvida a aplicação **ScreenSound**, que consome uma API pública de músicas, processa os dados recebidos e permite realizar diversos filtros, consultas e exportações, aplicando boas práticas de organização de código e tratamento de erros.

---

## 🛠 Tecnologias Utilizadas

- **C# / .NET**
- **HttpClient** para consumo de APIs
- **System.Text.Json** para serialização e desserialização
- **LINQ (Language Integrated Query)**
- **Visual Studio**
- Aplicação baseada em **Console**

---

## 📚 Conteúdos Abordados

### 🌐 Consumo de API com HttpClient
- Criação de requisições HTTP utilizando a classe **`HttpClient`**
- Consumo de dados de uma API externa no formato JSON
- Leitura da resposta como string e posterior processamento

### ⚠️ Tratamento de Erros
- Uso de **`try-catch`** para capturar exceções durante requisições HTTP
- Tratamento de falhas de rede e erros inesperados
- Exibição de mensagens claras para facilitar o diagnóstico de problemas

### 🔁 Serialização e Desserialização de Dados
- Desserialização do JSON da API para objetos C#
- Uso do atributo **`JsonPropertyName`** para mapear corretamente os campos da API
- Conversão de objetos C# em JSON para persistência em arquivos

### 🔍 Manipulação de Dados com LINQ
- Aplicação de consultas LINQ para:
  - Selecionar e filtrar dados
  - Ordenar artistas e músicas
  - Remover duplicidades com **`Distinct()`**
- Uso de **`Where`**, **`Select`**, **`OrderBy`** e outras operações
- Consultas case-insensitive utilizando **`StringComparison.OrdinalIgnoreCase`**

### 🎵 Lógica Musical e Tonalidades
- Interpretação da tonalidade musical a partir de valores numéricos
- Conversão de chaves musicais em tons como **C, C#, D, F#**, entre outros
- Filtros específicos, como músicas em **Dó sustenido**

### 💾 Geração de Arquivos JSON
- Criação de playlists personalizadas
- Escrita de arquivos JSON no disco utilizando **`File.WriteAllText`**
- Estruturação do JSON contendo nome da playlist e músicas
- Integração do JSON com o frontend da aplicação

---

## 🧪 Funcionalidades da Aplicação Desenvolvida

A aplicação **ScreenSound** permite:

- **Consumo de músicas via API externa**
- **Listagem de gêneros musicais disponíveis**
- **Exibição de artistas ordenados alfabeticamente**
- **Filtragem de artistas por gênero musical**
- **Consulta de músicas por artista**
- **Filtragem de músicas por tonalidade**
- **Criação de playlists personalizadas**
- **Exportação de playlists em formato JSON**

---

## 📂 Estrutura Principal do Projeto

O projeto foi organizado de forma clara e modular:

### 📁 Modelos (`ScreenSound.Modelos`)
Contém as entidades principais da aplicação:
- **Musica**
  - Mapeamento direto dos dados da API
  - Propriedades com `JsonPropertyName`
  - Cálculo automático da tonalidade musical
- **Playlist**
  - Gerenciamento de listas de músicas
  - Geração de arquivos JSON da playlist

### 📁 Filtros (`ScreenSound.Filtros`)
Responsável pela lógica de consultas e filtros com LINQ:
- **LinqFilter**
  - Filtragem de gêneros musicais
  - Ordenação de artistas
  - Filtros por gênero, artista e tonalidade

### 📄 Program.cs
- Ponto de entrada da aplicação
- Consumo da API utilizando `HttpClient`
- Desserialização do JSON
- Execução dos filtros e geração de playlists

---

## 🔗 Links

- Curso: https://cursos.alura.com.br/course/c-sharp-consumindo-api-gravando-arquivos-linq  
- Plataforma Alura: https://www.alura.com.br/

---