# Bug: API não responde no teste de integração

## Descrição

O teste de integração responsável por validar se a API está respondendo
retorna erro de conexão.

## Comportamento esperado

A API deveria responder com status HTTP 200 (OK)
quando acessada no endpoint principal.

## Comportamento atual

O teste falha ao tentar acessar a API.

Erro retornado:

No connection could be made because the target machine actively refused it (localhost:5000)

## Teste que demonstra o problema

Arquivo:

ApiTests.cs

Teste:

Api_DeveResponderStatusOK

Resultado:

System.Net.Http.HttpRequestException

## Possível causa

A aplicação backend pode não estar sendo executada
quando o teste de integração é iniciado.

## Impacto

Os testes de integração não conseguem validar
o comportamento da API.
