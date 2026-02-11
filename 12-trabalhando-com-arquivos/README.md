# C# — Trabalhando com Arquivos

Projeto desenvolvido como parte da **Carreira de Desenvolvimento Back-End .NET** da [Alura](https://www.alura.com.br/).

Este repositório contém o código criado durante o curso  
➡️ **[C#: trabalhando com arquivos](https://cursos.alura.com.br/course/c-sharp-trabalhando-arquivos)**

---

## 📘 Sobre o Curso

O objetivo deste curso é aprofundar o conhecimento em **manipulação de arquivos no C#**, explorando leitura e escrita de dados utilizando **Streams**, além de compreender conceitos fundamentais como **encoding**, **buffers**, arquivos **.csv**, leitura binária e funcionamento interno da **Console**.

Durante o curso, são abordadas boas práticas para lidar com arquivos grandes, controle adequado de recursos e uso correto das classes disponíveis no .NET para entrada e saída de dados.

---

## 🛠 Tecnologias Utilizadas

- **C# / .NET**
- **System.IO**
- **Streams (FileStream, StreamReader, StreamWriter)**
- **BinaryReader e BinaryWriter**
- **Visual Studio**
- Aplicação baseada em **Console**

---

## 📚 Conteúdos Abordados

### 📦 Manipulação de Arquivos Grandes
- Como lidar com arquivos maiores que a memória RAM
- Leitura baseada em **buffers**
- Uso do método `Read()` para processamento em blocos

### 🔁 Streams
- Conceito de **Stream** como sequência de bytes
- Funcionamento de `FileStream`
- Importância de fechar o fluxo com `Close()`
- Uso do método `Flush()` para garantir gravação no disco

### 📝 Leitura de Arquivos Texto
- Uso de **StreamReader**
- Métodos:
  - `Read()`
  - `ReadLine()`
  - `ReadToEnd()`
- Verificação de fim de arquivo com `EndOfStream`

### ✍️ Escrita em Arquivos
- Uso de **StreamWriter**
- Escrita de caracteres com codificação específica
- Diferença entre:
  - `FileMode.Create`
  - `FileMode.CreateNew`

### 🔢 Conversão e Processamento de Dados
- Uso de `int.Parse()`
- Uso de `double.Parse()`
- Conversão para ponto flutuante de dupla precisão
- Manipulação de arquivos no formato **.csv**

### 🔐 Leitura e Escrita Binária
- Uso de **BinaryReader**
- Uso de **BinaryWriter**
- Escrita e leitura de dados primitivos em formato binário

### 🖥 Console e Streams
- Como a **Console** funciona com streams
- Uso de `Console.OpenStandardInput()`
- Fluxo de entrada padrão da aplicação

### 🧩 Organização de Código
- Uso do modificador **`partial`**
- Separação da definição de classes em múltiplos arquivos
- Métodos auxiliares da classe `File` para:
  - Criar arquivos
  - Copiar arquivos
  - Abrir arquivos
  - Manipular caminhos

---

## 🧪 Funcionalidades Desenvolvidas

Durante o curso foram implementadas funcionalidades como:

- Leitura de arquivos texto linha a linha
- Processamento de dados em arquivos CSV
- Escrita controlada em arquivos
- Manipulação de arquivos binários
- Controle explícito de fluxo e recursos
- Simulação de operações bancárias com persistência em arquivo

---

## 📂 Estrutura do Projeto

O projeto utiliza:

- **Program.cs** como ponto de entrada
- Classes organizadas para leitura e escrita de dados
- Separação de responsabilidades utilizando `partial`
- Manipulação direta de arquivos via `System.IO`

---

## 🔗 Links

- Curso: https://cursos.alura.com.br/course/c-sharp-trabalhando-arquivos  
- Plataforma Alura: https://www.alura.com.br/

---
