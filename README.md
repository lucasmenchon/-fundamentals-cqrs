# CQRS (Command and Query Responsibility Segregation)

## English

CQRS (Command and Query Responsibility Segregation) is an architectural pattern that proposes to separate the responsibilities of queries (Query) and commands (Command).

**Queries** are intended to retrieve data without updating the system state. On the other hand, **commands** update the system state.

It is possible to use either one database for both operations to work, or one for each, resulting in two separate data models.

---

## Português

CQRS (Segregação de Responsabilidade de Comando e Consulta) é um padrão arquitetural que tem como proposta separar as responsabilidades de consulta (Query) e comandos (Command).

**Consultas** visam buscar dados, não atualizando o estado do sistema. Por outro lado, **comandos** atualizam o estado do sistema.

É possível utilizar tanto um banco de dados para ambas as operações trabalharem, ou um para cada, resultando em dois modelos de dados separados.
