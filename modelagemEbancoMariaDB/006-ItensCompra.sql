create table ItensCompra
(
    ItemCompraID  int auto_increment
        primary key,
    CompraID      int            not null,
    ProdutoID     int            not null,
    Quantidade    int            not null,
    PrecoUnitario decimal(10, 2) not null,
    constraint ItensCompra_ibfk_1
        foreign key (CompraID) references Compras (CompraID),
    constraint ItensCompra_ibfk_2
        foreign key (ProdutoID) references Produtos (ProdutoID)
);

create index CompraID
    on ItensCompra (CompraID);

create index ProdutoID
    on ItensCompra (ProdutoID);

