# C# — Dominando Orientação a Objetos

Projeto desenvolvido como parte da **Carreira de Desenvolvimento Back-End .NET** da [Alura](https://www.alura.com.br/).

Este repositório contém o código criado durante o curso  
➡️ **[C#: dominando Orientação a Objetos](https://cursos.alura.com.br/course/csharp-dominando-orientacao-objetos)**

---

## 📘 Sobre o Curso

O objetivo deste curso é elevar o nível da aplicação **ScreenSound**, transformando-a em um sistema robusto, organizado e escalável. O foco principal é o domínio avançado da **Orientação a Objetos**, aplicando conceitos vitais para o desenvolvimento de software profissional.

Durante o treinamento, a aplicação foi refatorada para utilizar **herança**, **polimorfismo**, **interfaces** e uma melhor organização de código através de **namespaces** e **modificadores de acesso**, garantindo um código limpo e de fácil manutenção.

---

## 🛠 Tecnologias Utilizadas

- **C# / .NET**
- **Visual Studio** (ambiente de desenvolvimento)
- Aplicação baseada em **Console**

---

## 📚 Conteúdos Abordados

### 🗂 Organização e Arquitetura
- Organização de classes em **pastas** e **namespaces** (`ScreenSound.Modelos`, `ScreenSound.Menus`)
- Separação de responsabilidades para aumentar a produtividade e legibilidade
- Refatoração de classes extensas para códigos mais coesos

### 🔒 Encapsulamento e Visibilidade
- Controle de acesso com modificadores **`public`** e **`internal`**
- Uso de membros estáticos (**`static`**) para métodos que não dependem de instância
- Entendimento do método `Main()` como ponto de entrada da aplicação .NET

### 🧬 Herança e Polimorfismo
- Compartilhamento de comportamentos através de **herança**
- Sobrescrita de métodos com **`virtual`** e **`override`**
- Reutilização de código da classe base com a palavra reservada **`base`**

### 📜 Abstração e Contratos
- Criação e implementação de **Interfaces** (`IAvaliavel`)
- Diferença entre herança de classes e contratos de interfaces
- Aplicação de polimorfismo através de interfaces

---

## 🧪 Funcionalidades da Aplicação Desenvolvida

A versão aprimorada do **ScreenSound** permite:

- **Navegação por Menus:** Sistema interativo separado em classes específicas para cada ação (Registrar, Exibir, Avaliar).
- **Gestão de Domínio:** Cadastro robusto de Bandas, Álbuns e Músicas.
- **Sistema de Avaliação:** Implementação de uma interface comum para permitir a avaliação de diferentes tipos de objetos (Bandas e Álbuns).
- **Cálculos Dinâmicos:** Exibição de médias de avaliação calculadas em tempo real.

---

## 📂 Estrutura Principal do Projeto

O projeto foi reestruturado em pastas lógicas:

### 📁 Modelos (`ScreenSound.Modelos`)
Contém as entidades principais do domínio:
- **Banda**: Gerencia álbuns e notas.
- **Album**: Agrupa músicas e possui avaliações.
- **Musica**: Representa a faixa de áudio e seus detalhes.
- **Avaliacao**: Classe para encapsular a lógica de notas (tipo complexo).
- **IAvaliavel**: Interface que garante que bandas e álbuns possam ser avaliados.

### 📁 Menus (`ScreenSound.Menus`)
Contém a lógica de interação com o usuário, separada por responsabilidade:
- **MenuRegistrarBanda**
- **MenuAvaliarAlbum**
- **MenuExibirDetalhes**, entre outros.

---

## 🔗 Links

- Curso: https://cursos.alura.com.br/course/csharp-dominando-orientacao-objetos
- Plataforma Alura: https://www.alura.com.br/

---