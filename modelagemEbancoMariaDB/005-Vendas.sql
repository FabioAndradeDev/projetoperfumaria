create table Vendas
(
    VendaID    int auto_increment
        primary key,
    UsuarioID  int            not null,
    DataVenda  datetime       not null,
    TotalVenda decimal(10, 2) not null,
    constraint Vendas_ibfk_1
        foreign key (UsuarioID) references Usuarios (UsuarioID)
);

create index UsuarioID
    on Vendas (UsuarioID);

