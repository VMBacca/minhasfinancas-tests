# Bug: Sistema permite transação com data futura

## Descrição

O sistema permite registrar transações com datas no futuro.

## Comportamento esperado

Transações devem possuir data menor ou igual à data atual.

Regra esperada:

dataTransacao <= dataAtual

## Comportamento atual

O sistema aceita datas futuras.

Exemplo:

data = hoje + 5 dias

## Teste que demonstra o problema

Arquivo:

TransacaoTests.cs

Teste:

NaoDevePermitirDataFutura

Resultado:

Expected: True  
Actual: False

## Impacto

Permitir datas futuras pode gerar inconsistências em relatórios financeiros e projeções.
