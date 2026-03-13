# Bug: Sistema permite cadastro de CPF duplicado

## Descrição

O sistema não impede o cadastro de duas pessoas
com o mesmo CPF.

## Comportamento esperado

O CPF deve ser único no sistema.

## Comportamento atual

É possível registrar duas pessoas com o mesmo CPF.

## Teste que demonstra o problema

Arquivo:

PessoaTests.cs

Teste:

NaoDevePermitirCpfDuplicado

Resultado:

Expected: False  
Actual: True

## Impacto

Pode gerar inconsistência nos dados de usuários.
