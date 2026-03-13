# Bug: Sistema permite transação com valor zero

## Descrição

O sistema permite registrar transações com valor igual a zero.

## Comportamento esperado

Transações devem possuir valor maior que zero.

Valor esperado:

valor > 0

## Comportamento atual

O sistema aceita transações com valor igual a zero.

Exemplo:

valor = 0

## Teste que demonstra o problema

Arquivo:

TransacaoTests.cs

Teste:

NaoDevePermitirValorZero

Resultado:

Expected: True  
Actual: False

## Impacto

Transações com valor zero não representam movimentação financeira válida e podem afetar relatórios e análises.
