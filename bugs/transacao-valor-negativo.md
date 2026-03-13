# Bug: Sistema permite transação com valor negativo

## Descrição

O sistema permite registrar uma transação com valor negativo.

## Comportamento esperado

Transações devem possuir valor maior que zero.

Valor esperado:

valor > 0

## Comportamento atual

O sistema aceita valores negativos.

Exemplo:

valor = -100

## Teste que demonstra o problema

Arquivo:

TransacaoTests.cs

Teste:

NaoDevePermitirValorNegativo

Resultado:

Expected: True  
Actual: False

## Impacto

Permitir valores negativos pode gerar inconsistências financeiras e cálculos incorretos no sistema.
