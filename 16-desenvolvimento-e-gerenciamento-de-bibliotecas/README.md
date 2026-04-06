# C# — Manipulação de Dados com Coleções e LINQ

Projeto desenvolvido como parte da **Carreira de Desenvolvimento Back-End .NET** da [Alura](https://www.alura.com.br/).

Este repositório contém o código criado durante o curso  
➡️ **[C#: manipulação de dados](https://cursos.alura.com.br/course/csharp-bibliotecas)**

---

## 📘 Sobre o Curso

O objetivo deste curso é aprofundar o conhecimento em **manipulação e processamento de dados no C#**, explorando o uso de **coleções**, **LINQ**, **orientação a objetos** e **geração de arquivos estruturados**.

Durante o treinamento, foi desenvolvida uma aplicação chamada **ReportGenerator**, responsável por gerar relatórios a partir de dados em memória, permitindo exportação em diferentes formatos como **CSV e PDF**.

O projeto aplica conceitos importantes como **herança, abstração, reutilização de código e separação de responsabilidades**, além de demonstrar como transformar dados em saídas estruturadas para diferentes finalidades.

---

## 🛠 Tecnologias Utilizadas

- **C# / .NET**
- **Coleções do .NET** (`List`, `Dictionary`)
- **LINQ (Language Integrated Query)**
- **System.IO**
- **System.Text**
- **iText7** (geração de PDF)
- **Visual Studio**
- Aplicação baseada em **Console**

---

## 📚 Conteúdos Abordados

### 📦 Estruturas de Dados e Coleções
- Uso de `List<Dictionary<string, string>>` como estrutura de dados
- Representação de registros dinâmicos (chave/valor)
- Manipulação de dados em memória para geração de relatórios

### 🔁 Orientação a Objetos e Abstração
- Criação de uma classe base **`ReportGeneratorBase`**
- Definição de contrato com **`IReportGenerator`**
- Reutilização de propriedades comuns:
  - `Title`
  - `HeadLine`
  - `FooterLine`
- Especialização de comportamento através de herança

### 🔍 Manipulação de Dados com LINQ
- Uso de LINQ para acessar dados:
  - `First()` para obter cabeçalhos
- Extração dinâmica de colunas a partir das chaves do dicionário

### 📊 Geração de Relatórios CSV
- Construção de conteúdo com **`StringBuilder`**
- Criação de cabeçalhos com base nas chaves do dicionário
- Geração de linhas com `string.Join`
- Escrita em arquivo utilizando `File.WriteAllText`
- Inclusão de título, cabeçalho e rodapé no relatório

### 📄 Geração de Relatórios PDF
- Uso da biblioteca **iText7**
- Criação de documento PDF com:
  - Título formatado (negrito, tamanho maior)
  - Headline em itálico
- Construção de tabelas dinâmicas:
  - Cabeçalhos baseados nas chaves
  - Linhas baseadas nos valores
- Inserção de rodapé no documento

### 🧩 Formatação e Utilitários
- Uso de classe utilitária **`DateFormatter`**
- Implementação de interface **`IDataFormatter`**
- Formatação de data para inclusão no relatório

### 📁 Escrita de Arquivos
- Geração de arquivos:
  - `report.csv`
  - `report.pdf`
- Retorno do caminho absoluto do arquivo gerado
- Uso de encoding UTF-8 no CSV

---

## 🧪 Funcionalidades Desenvolvidas

Durante o curso foram implementadas funcionalidades como:

- Criação de relatórios a partir de dados estruturados em memória
- Geração de arquivos em múltiplos formatos (CSV e PDF)
- Construção dinâmica de tabelas com base nos dados
- Aplicação de herança para reutilização de lógica
- Separação entre lógica de geração e formatação
- Uso de coleções para representar registros genéricos
- Inclusão de título, descrição e rodapé nos relatórios
- Exportação de arquivos com retorno do caminho gerado

---

## 📂 Estrutura do Projeto

O projeto é dividido em duas partes principais:

### 📁 ConsoleReport
- **Program.cs**
  - Criação dos dados (lista de dicionários)
  - Configuração do gerador de relatório
  - Execução da geração do arquivo

### 📁 ReportGenerator

#### 📁 Generators
- **ReportGeneratorBase**
  - Classe base com propriedades comuns
- **IReportGenerator**
  - Interface que define o método `GenerateReport`
- **CSVReporterGenerator**
  - Implementação para geração de arquivos CSV
- **PDFReporterGenerator**
  - Implementação para geração de arquivos PDF

#### 📁 Util
- **DateFormatter**
  - Formatação de data para inclusão no relatório
- **IDataFormatter**
  - Interface para padronização de formatação

---

## 🔗 Links

- Curso: https://cursos.alura.com.br/course/csharp-bibliotecas  
- Plataforma Alura: https://www.alura.com.br/

---