# Aluguel de Roupas Juninas

Aplicação desktop em C# (Windows Forms) para gestão de aluguel de roupas típicas de festa
junina: catálogo de peças, controle de disponibilidade por data e caixa.

## Funcionalidades
- **Catálogo de roupas**: cadastro, remoção e ajuste de valor de cada peça (nome, tamanho,
  categoria, imagem).
- **Disponibilidade por data**: cada peça guarda as datas em que já está reservada
  (`DatasIndisponiveis`), então o sistema sabe quando ela foi alugada e quando estará livre
  de novo.
- **Registro de aluguel**: cliente, data de retirada, data de devolução, valor e forma de
  pagamento (dinheiro, PIX, cartão de crédito/débito).
- **Caixa**: soma automaticamente o total recebido, separado por forma de pagamento e no
  total geral, a partir dos aluguéis registrados. Não processa pagamento (sem gateway),
  é só o controle/registro.
- Calendário próprio pra visualizar a disponibilidade das peças (`FormCalendario`).

## Stack
`C#` `.NET` `Windows Forms` `SQLite`

## Estrutura
```
AluguelRoupasJuninas/
├── Libs/
│   ├── Roupas.cs         Modelo de peça de roupa (catálogo + disponibilidade)
│   ├── Aluguel.cs        Modelo de aluguel (cliente, datas, valor, pagamento)
│   ├── Gerenciador.cs    Acesso ao banco (SQLite) e regras de negócio
│   ├── FormPrincipal.*   Janela principal
│   ├── FormAlugar.*      Tela de registrar aluguel
│   ├── FormAdicionar.*   Tela de cadastro de peça
│   ├── FormCalendario.*  Calendário de disponibilidade
│   └── FormCaixa.*       Tela de caixa (totais por forma de pagamento)
└── Resources/            Ícones e imagens da interface
```

## Como executar
Abra `AluguelRoupasJuninas.sln` no Visual Studio e rode com `F5`, ou:
```
dotnet build AluguelRoupasJuninas.sln
```

---
Ver [LICENSE](LICENSE).
