create table Fornecedores
(
    FornecedorID int auto_increment
        primary key,
    Nome         varchar(255) not null,
    CNPJ         varchar(18)  not null,
    Telefone     varchar(15)  null,
    Email        varchar(255) null,
    constraint CNPJ
        unique (CNPJ)
);

