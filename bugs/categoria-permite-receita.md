# Bug: Categoria de Despesa permite transação de Receita

## Descrição

Uma categoria cuja finalidade é **Despesa** não deveria permitir
transações do tipo **Receita**.

Porém, ao validar a regra atual da aplicação, o sistema permite
essa combinação.

## Regra esperada

Categorias devem respeitar sua finalidade:

| Finalidade | Tipos permitidos  |
| ---------- | ----------------- |
| Despesa    | Apenas Despesa    |
| Receita    | Apenas Receita    |
| Ambas      | Receita e Despesa |

## Comportamento atual

A lógica atual permite:

Categoria: Despesa  
Transação: Receita

## Teste que demonstra o problema

Arquivo:
CategoriaTests.cs

Teste:
CategoriaDespesa_NaoDevePermitirReceita

Resultado do teste:
Expected: False
Actual: True

## Impacto

Esse comportamento pode permitir registros financeiros inconsistentes.

Exemplo:

Categoria: "Supermercado" (Despesa)
Transação registrada como: Receita

## Sugestão

Validar o tipo de transação com base na finalidade da categoria antes de permitir o registro.
