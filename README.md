# Sistema de Biblioteca (Exercício de Fixação)

Este é um projeto de console simples desenvolvido em **C#** com **.NET** para consolidar os fundamentos de **Programação Orientada a Objetos (POO)**. O sistema simula o funcionamento básico de uma biblioteca, permitindo o cadastro de livros, usuários e a gestão de empréstimos.
Feito em aula da CodeRDiversity.

# Estrutura das Classes

O projeto foi estruturado em três pilares principais para demonstrar a interação entre objetos:

### 1. Livro
* **Papel:** Representar o item físico do acervo.
* **Propriedades Comuns:** `Id`, `Titulo`, `Disponivel`.
* **Métodos:** Funções para alterar o status de disponibilidade.

### 2. Pessoa
* **Papel:** Representar o usuário que interage com a biblioteca.
* **Propriedades Comuns:** `Nome`, `Id` e uma `List<Livro>` para rastrear os livros em posse do usuário.

### 3. Biblioteca
* **Papel:** Atuar como a classe controladora (Manager).
* **Responsabilidades:**  Armazenar o acervo total.
    * Lógica para **Emprestar** (verificar disponibilidade e associar à Pessoa).
    * Lógica para **Devolver** (liberar o livro e remover da lista da Pessoa).
