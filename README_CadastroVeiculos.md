
# Sistema de Cadastro de Veículos - ASP.NET Core Razor Pages

Este projeto é uma aplicação web desenvolvida com **ASP.NET Core** usando **Razor Pages**, com foco em gerenciar o cadastro de veículos. Ele manipula arquivos de texto `.txt` para armazenar os dados, além de permitir upload e exibição de imagens.

---

## 🧩 Funcionalidades

- Cadastrar novos veículos
- Listar veículos cadastrados
- Visualizar detalhes de um veículo
- Editar dados de um veículo
- Excluir veículos do sistema
- Upload de foto do veículo (opcional)
- Navegação entre páginas com layout responsivo

---

## 📂 Estrutura dos Dados

Os veículos são armazenados em um arquivo de texto chamado `veiculos.txt`, localizado na pasta `App_Data`. Cada linha do arquivo representa um veículo, com os campos separados por ponto e vírgula (`;`).

**Formato:**
```
Nome;Modelo;Marca;Renavam;AnoFabricacao;AnoModelo;FotoPath
```

---

## 🗂️ Estrutura do Projeto

- `Models/Veiculo.cs`: classe que representa os dados de um veículo.
- `Data/VeiculoRepository.cs`: leitura, gravação, edição e exclusão no arquivo `.txt`.
- `Pages/Veiculos`: contém todas as Razor Pages (`Index`, `Create`, `Edit`, `Details`, `Delete`).
- `wwwroot/uploads`: onde as imagens dos veículos são salvas.

---

## 🌐 Navegação

A interface conta com um menu superior (navbar) com os seguintes links:

- **Veículos**: redireciona para a listagem (`/Veiculos/Index`)
- **Cadastrar**: abre o formulário para novo cadastro (`/Veiculos/Create`)

Todas as páginas herdam o layout padrão definido em `_Layout.cshtml`.

---

## 💡 Como Executar

1. Abra o projeto no **Microsoft Visual Studio**.
2. Compile a solução (`Ctrl + Shift + B`).
3. Execute a aplicação (`F5` ou botão de play).
4. A página inicial redireciona automaticamente para `/Veiculos/Index`.

⚠️ Caso a pasta `App_Data` não exista, ela será criada automaticamente ao cadastrar o primeiro veículo.

---

## 📌 Requisitos

- .NET 6 ou superior
- Visual Studio 2022 ou superior

---

## 📝 Observações

- As imagens dos veículos são salvas em `wwwroot/uploads` e exibidas nas páginas de detalhes e listagem.
- O sistema usa apenas arquivos texto (`.txt`) para persistência — nenhum banco de dados é necessário.

---

## © Desenvolvedor

Criado como projeto acadêmico demonstrando o uso de Razor Pages com manipulação de arquivos.
