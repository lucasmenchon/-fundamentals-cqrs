<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>FUNDAMENTALS CQRS</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
            color: #333;
        }
        .container {
            width: 80%;
            margin: 20px auto;
            padding: 20px;
            background: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        h1, h2 {
            color: #0056b3;
        }
        p {
            line-height: 1.6;
        }
        .section {
            margin-bottom: 40px;
        }
        .section-title {
            border-bottom: 2px solid #0056b3;
            padding-bottom: 5px;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>CQRS (Command and Query Responsibility Segregation)</h1>

        <div class="section">
            <h2 class="section-title">English</h2>
            <p>
                CQRS (Command and Query Responsibility Segregation) is an architectural pattern that proposes to separate the responsibilities of queries (Query) and commands (Command).
            </p>
            <p>
                <strong>Queries</strong> are intended to retrieve data without updating the system state. On the other hand, <strong>commands</strong> update the system state.
            </p>
            <p>
                It is possible to use either one database for both operations to work, or one for each, resulting in two separate data models.
            </p>
        </div>

        <div class="section">
            <h2 class="section-title">Português</h2>
            <p>
                CQRS (Segregação de Responsabilidade de Comando e Consulta) é um padrão arquitetural que tem como proposta separar as responsabilidades de consulta (Query) e comandos (Command).
            </p>
            <p>
                <strong>Consultas</strong> visam buscar dados, não atualizando o estado do sistema. Por outro lado, <strong>comandos</strong> atualizam o estado do sistema.
            </p>
            <p>
                É possível utilizar tanto um banco de dados para ambas as operações trabalharem, ou um para cada, resultando em dois modelos de dados separados.
            </p>
        </div>
    </div>
</body>
</html>
