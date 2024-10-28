create table Usuarios
(
    UsuarioID int auto_increment
        primary key,
    Nome      varchar(255)                             not null,
    Senha     varchar(255)                             not null,
    Perfil    enum ('admin', 'vendedor', 'estoquista') not null
);

