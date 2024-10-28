-- Criação do Banco de Dados
CREATE DATABASE IF NOT EXISTS EmpresaCosmeticos;
USE EmpresaCosmeticos;

-- Tabela de Usuários (para o sistema de login)
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Senha VARCHAR(255) NOT NULL,
    Perfil ENUM('admin', 'vendedor', 'estoquista') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

Insert Into Usuarios (UsuarioID, Nome, Senha, Perfil) values
                                                          (1, "Marcos", 12345678, 'admin');
SELECT * FROM Usuarios;

-- Tabela de Produtos
CREATE TABLE Produtos (
    ProdutoID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Descricao TEXT,
    Preco DECIMAL(10, 2) NOT NULL,
    QuantidadeEstoque INT NOT NULL,
    Categoria VARCHAR(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabela de Vendas
CREATE TABLE Vendas (
    VendaID INT AUTO_INCREMENT PRIMARY KEY,
    UsuarioID INT NOT NULL,
    DataVenda DATETIME NOT NULL,
    TotalVenda DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabela de Itens de Venda
CREATE TABLE ItensVenda (
    ItemVendaID INT AUTO_INCREMENT PRIMARY KEY,
    VendaID INT NOT NULL,
    ProdutoID INT NOT NULL,
    Quantidade INT NOT NULL,
    PrecoUnitario DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (VendaID) REFERENCES Vendas(VendaID),
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabela de Fornecedores
CREATE TABLE Fornecedores (
    FornecedorID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    CNPJ VARCHAR(18) NOT NULL UNIQUE,
    Telefone VARCHAR(15),
    Email VARCHAR(255)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabela de Compras
CREATE TABLE Compras (
    CompraID INT AUTO_INCREMENT PRIMARY KEY,
    FornecedorID INT NOT NULL,
    DataCompra DATETIME NOT NULL,
    TotalCompra DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (FornecedorID) REFERENCES Fornecedores(FornecedorID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabela de Itens de Compra
CREATE TABLE ItensCompra (
    ItemCompraID INT AUTO_INCREMENT PRIMARY KEY,
    CompraID INT NOT NULL,
    ProdutoID INT NOT NULL,
    Quantidade INT NOT NULL,
    PrecoUnitario DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CompraID) REFERENCES Compras(CompraID),
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabela de Relatórios Financeiros
CREATE TABLE RelatoriosFinanceiros (
    RelatorioID INT AUTO_INCREMENT PRIMARY KEY,
    DataRelatorio DATETIME NOT NULL,
    Descricao TEXT,
    Valor DECIMAL(10, 2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;