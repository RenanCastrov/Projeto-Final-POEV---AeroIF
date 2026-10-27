O AeroIF é uma aplicação desenvolvida como trabalho final da disciplina de POEV (Programação Orientada a Eventos) no curso de Engenharia de Computação do IFSP Campus Birigui.

O software é basicamente um sistema de gerenciamento aéreo, onde se pode gerenciar pilotos, aeronaves, aeroportos e voos. O sistema foi todo desenvolvido utilizando o padrão de projeto DDD (Domain-Driven Design).

A solução (AeroIF.sln) está organizada em camadas, cada uma em um projeto separado, o que facilita a manutenção e os testes:
- AeroIF.App -> Telas e interação com o usuário. Consome a camada de serviço.
- AeroIF.Service -> Regras de negócio e validações. Intermedia a interface e os dados.
- AeroIF.Repository -> Persistência e consultas ao banco de dados.
- AeroIF.Domain -> Classes que representam as entidades do sistema.
- AeroIF.Test -> Testes das regras e do comportamento do sistema.
