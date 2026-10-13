# 📦 Sistema de Gestão de Produtos

> Trabalho Prático 03 desenvolvido para a disciplina de **CBTSWE2 - ADS**. 
> Uma aplicação web estruturada para gerenciamento de produtos utilizando ASP.NET MVC, Entity Framework Core e banco de dados SQLite.

---

## 👨‍💻 Autores

| Nome | Prontuário |
| :--- | :--- |
| **ADRIANO JÚNIOR DE SOUZA ALMEIDA** | CB3030644 |
| **ARTHUR LANZILOTTI FARJANES** | CB3031306 |

---

## ✨ Funcionalidades

- [x] **Listagem de Produtos:** Tabela interativa com formatação de valores monetários e indicadores visuais (badges) para o status do estoque.
- [x] **Cadastro de Produtos:** Formulário com validações via Data Annotations (campos obrigatórios, limites de texto, valores positivos).
- [x] **Edição e Atualização:** Alteração dinâmica de registros já existentes no banco de dados.
- [x] **Ficha Técnica (Detalhes):** Visualização isolada e detalhada de todos os atributos de um item.
- [x] **Exclusão Segura:** Tela de confirmação com o resumo dos dados antes de deletar o produto permanentemente.

---

## 🛠️ Tecnologias Utilizadas

- **Framework:** ASP.NET Core MVC (.NET)
- **Linguagem:** C#
- **ORM:** Entity Framework Core
- **Banco de Dados:** SQLite
- **Interface e Layout:** HTML, CSS, Bootstrap 5 e Razor Views

---

## 🚀 Como Executar Localmente

1. Clone este repositório em sua máquina local.
2. Abra a solução/projeto no **Visual Studio 2022**.
3. No menu superior, vá em **Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes**.
4. Execute o comando `Update-Database` para criar o banco de dados SQLite localmente com base nas Migrations.
5. Pressione **Executar (F5)** para iniciar a aplicação e abrir no navegador.