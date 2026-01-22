# 🧬 Praticando C# — Orientação a Objetos com Herança

Projeto desenvolvido como parte da **Carreira de Desenvolvimento Back-End .NET** da [Alura](https://www.alura.com.br/).

Este repositório contém os exercícios desenvolvidos durante o curso:  
➡️ **[Praticando C#: orientação a objetos com herança](https://cursos.alura.com.br/course/praticando-csharp-orientacao-objetos-heranca)**

---

## 📘 Sobre o Curso

O objetivo deste curso é **consolidar o conhecimento em Herança e Interfaces**, explorando como criar hierarquias de classes para reaproveitar atributos e definir contratos de comportamento padronizados para diferentes entidades.

Os exercícios reforçam a relação **"é um"**, onde classes especializadas herdam de classes base, e o uso de interfaces para garantir que diferentes classes implementem métodos essenciais.

---

## 🛠 Tecnologias Utilizadas

- **C# / .NET**
- **Console Application**
- **Visual Studio** (ambiente de desenvolvimento)

---

## 📂 Exercícios Desenvolvidos

Os desafios abaixo estão organizados em **projetos independentes**, focados na aplicação de herança e contratos via interfaces.

---

### ▶️ **CadastroFuncionarios**
Modelagem de colaboradores em uma empresa.
- Classe base `Funcionario`
- Classes derivadas `Freelancer` e `Interno`
- Reuso de propriedades comuns a todos os tipos de funcionários

---

### ▶️ **CertificadoProfissoes**
Geração de certificados baseada em títulos profissionais.
- Classe base `Profissao`
- Especializações `Analista` e `Docente`
- Uso do construtor da classe base via `base()`

---

### ▶️ **CatalogacaoItens**
Gerenciamento de itens físicos e digitais.
- Classe base `Item`
- Classes filhas `Pergaminho` (físico) e `ItemDigital`
- Organização de metadados específicos para cada categoria

---

### ▶️ **SistemaPagamentos**
Simulação de diferentes métodos de pagamento.
- Interface `IPagamento` para padronizar o processo
- Herança de `Pessoa` para `PagamentoBoleto` e `PagamentoCredito`
- Implementação de regras de processamento distintas

---

### ▶️ **DispositivosSensores**
Monitoramento via dispositivos IoT.
- Interface `ISensor` com métodos `Ativar()` e `Desativar()`
- Implementações em `SensorTemperatura` e `SensorPresenca`
- Garantia de comportamento padronizado entre diferentes hardwares

---

### ▶️ **GestaoServicos**
Padronização de prestação de serviços.
- Interface `IServico` definindo o contrato de execução
- Classes `Consultoria` e `Manutencao` implementando a interface
- Foco em polimorfismo de comportamento

---

### ▶️ **RegistroClientes**
Diferenciação de níveis de acesso de clientes.
- Hierarquia entre `Pessoa` e `ClienteVIP`
- Atribuição de benefícios específicos para a classe derivada

---

### ▶️ **DadosPassageiros**
Modelagem para sistemas de transporte.
- Herança simples de `Pessoa` para `Passageiro`
- Organização de dados de viagem vinculados à entidade

---

### ▶️ **MontagemComputadores**
Representação de hardware e componentes.
- Modelagem de peças como `Processador` e `PlacaMae`
- Herança de propriedades técnicas de componentes eletrônicos

---

### ▶️ **Veiculos**
Controle básico de frota.
- Classe base para veículos e suas propriedades fundamentais
- Estruturação para expansão de novos modelos

---

## 🔗 Links

- Curso: https://cursos.alura.com.br/course/praticando-csharp-orientacao-objetos-heranca
- Plataforma Alura: https://www.alura.com.br/