create table Produtos
(
    ProdutoID         int auto_increment
        primary key,
    Nome              varchar(255)   not null,
    Descricao         text           null,
    Preco             decimal(10, 2) not null,
    QuantidadeEstoque int            not null,
    Categoria         varchar(255)   not null
);

