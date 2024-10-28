create table Compras
(
    CompraID     int auto_increment
        primary key,
    FornecedorID int            not null,
    DataCompra   datetime       not null,
    TotalCompra  decimal(10, 2) not null,
    constraint Compras_ibfk_1
        foreign key (FornecedorID) references Fornecedores (FornecedorID)
);

create index FornecedorID
    on Compras (FornecedorID);

