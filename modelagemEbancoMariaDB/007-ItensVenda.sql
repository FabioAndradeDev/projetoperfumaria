create table ItensVenda
(
    ItemVendaID   int auto_increment
        primary key,
    VendaID       int            not null,
    ProdutoID     int            not null,
    Quantidade    int            not null,
    PrecoUnitario decimal(10, 2) not null,
    constraint ItensVenda_ibfk_1
        foreign key (VendaID) references Vendas (VendaID),
    constraint ItensVenda_ibfk_2
        foreign key (ProdutoID) references Produtos (ProdutoID)
);

create index ProdutoID
    on ItensVenda (ProdutoID);

create index VendaID
    on ItensVenda (VendaID);

