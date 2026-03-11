# C# — Manipulação de Dados com Coleções e LINQ

Projeto desenvolvido como parte da **Carreira de Desenvolvimento Back-End .NET** da [Alura](https://www.alura.com.br/).

Este repositório contém o código criado durante o curso  
➡️ **[C#: manipulação de dados](https://cursos.alura.com.br/course/csharp-manipulacao-dados)**

---

## 📘 Sobre o Curso

O objetivo deste curso é aprofundar o conhecimento em **manipulação e processamento de dados no C#**, explorando o uso de **coleções**, **iteradores**, **LINQ**, **expressões lambda**, **expressões regulares** e **serialização de dados**.

Durante o treinamento, são aplicadas diversas técnicas para trabalhar com conjuntos de dados de forma eficiente, utilizando recursos avançados da linguagem para **filtrar, transformar, agrupar e analisar informações**.

O curso também aborda boas práticas para organização do código, reutilização de lógica e otimização de performance ao lidar com **coleções grandes de dados**.

---

## 🛠 Tecnologias Utilizadas

- **C# / .NET**
- **Coleções do .NET** (`List`, `HashSet`, `Queue`, `Stack`, `Dictionary`)
- **LINQ (Language Integrated Query)**
- **Expressões Lambda**
- **Regex (Expressões Regulares)**
- **System.Text.Json**
- **Visual Studio**
- Aplicação baseada em **Console**

---

## 📚 Conteúdos Abordados

### 📦 Estruturas de Dados e Coleções
- Diferença entre **Arrays** e **Listas** em C#
- Uso de **Generics** para garantir segurança de tipos
- Implementação e uso de:
  - `List<T>`
  - `HashSet<T>`
  - `Queue<T>`
  - `Stack<T>`
  - `Dictionary<TKey, TValue>`

### 🔁 Iteração e Iteradores
- Uso do **`foreach`** para percorrer coleções
- Criação de iteradores utilizando **`yield return`**
- Implementação de coleções personalizadas com:
  - `IEnumerable<T>`
  - `IEnumerator<T>`
- Funcionamento dos métodos:
  - `MoveNext()`
  - `Reset()`
  - `Current`

### 🔍 Manipulação de Dados com LINQ
- Uso de consultas para transformar e filtrar dados
- Operações importantes como:
  - `Select`
  - `Where`
  - `Distinct`
  - `OrderBy`
  - `SelectMany`
  - `GroupBy`
- Encadeamento de operações para criação de **pipelines de dados**

### 📊 Operações de Consulta e Agregação
- Métodos de agregação:
  - `Count`
  - `Sum`
  - `Min`
  - `Max`
  - `Average`
- Verificação de existência com:
  - `Any`
  - `Contains`
- Recuperação de elementos com:
  - `First`
  - `FirstOrDefault`
  - `MaxBy`

### ⚙️ Comparação e Ordenação de Dados
- Implementação das interfaces:
  - `IComparable`
  - `IComparer<T>`
- Personalização da lógica de ordenação
- Controle de duplicidade com `HashSet`

### 📑 Manipulação de Strings
- Imutabilidade das **strings** no C#
- Métodos importantes:
  - `Replace`
  - `ToUpper`
  - `StartsWith`
  - `EndsWith`
- Comparações utilizando `StringComparison.OrdinalIgnoreCase`
- Formatação com:
  - interpolação de strings
  - `PadLeft`
  - `PadRight`
  - `string.Format`

### 🔎 Expressões Regulares (Regex)
- Identificação de padrões em strings
- Uso da classe **`Regex`**
- Criação de **grupos de captura**
- Extração de dados utilizando `Match.Groups`
- Uso de elementos opcionais em expressões (`?`)

### 📁 Leitura e Processamento de Arquivos
- Leitura de arquivos com **`FileStream`** e **`StreamReader`**
- Gerenciamento de recursos com **`using`**
- Processamento de dados linha a linha

### 📤 Serialização de Dados
- Conversão de objetos para JSON com **`JsonSerializer`**
- Configuração de opções de serialização com **`JsonSerializerOptions`**
- Manipulação de caminhos de arquivos com **`Environment.SpecialFolder`**

---

## 🧪 Funcionalidades Desenvolvidas

Durante o curso foram implementadas funcionalidades como:

- Criação e manipulação de diferentes tipos de coleções
- Filtragem e transformação de dados com LINQ
- Implementação de comparadores personalizados
- Processamento e análise de dados em coleções
- Criação de iteradores personalizados utilizando `yield`
- Identificação e extração de padrões em textos com Regex
- Serialização de coleções em arquivos JSON
- Organização de pipelines de processamento de dados

---

## 📂 Estrutura do Projeto

O projeto utiliza:

- **Program.cs** como ponto de entrada da aplicação
- Classes responsáveis pela manipulação e processamento de dados
- Implementação de coleções e iteradores personalizados
- Uso extensivo de **LINQ** para consultas e transformações de dados

---

## 🔗 Links

- Curso: https://cursos.alura.com.br/course/csharp-manipulacao-dados  
- Plataforma Alura: https://www.alura.com.br/

---