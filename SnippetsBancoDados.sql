CREATE DATABASE db_Venda;

USE db_Venda;

CREATE TABLE cliente (
    idCliente INT IDENTITY, --AUTO INCREMENTO
	nome VARCHAR(90) NOT NULL,
	email VARCHAR(90) NOT NULL,
	telefone VARCHAR(90) NOT NULL,
	estado VARCHAR(90) NOT NULL,
	cpf varchar(14) NOT NULL,
	PRIMARY KEY(idCliente)
);

CREATE TABLE produto (
    idProduto INT IDENTITY, --AUTO INCREMENTO
	codProduto VARCHAR(90) NOT NULL,
	nomeProduto VARCHAR(90) NOT NULL,
	preco decimal(15,2) NOT NULL,
	estoque INT NOT NULL,
	marca VARCHAR(50) NOT NULL,
	PRIMARY KEY(idProduto)
);

CREATE TABLE venda (
    idVenda INT IDENTITY, --AUTO INCREMENTO
    idCliente INT,
	valotTotal decimal(15,2) NOT NULL,
	PRIMARY KEY(idVenda),
    CONSTRAINT fk_Cliente FOREIGN KEY (idCliente) REFERENCES cliente (idCliente)
);


CREATE TABLE itemVenda(
    idItemVenda INT IDENTITY, --AUTO INCREMENTO
	idProduto INT NOT NULL,
	idVenda INT NOT NULL,
	quantidade INT NOT NULL,
	valorUnitario decimal(15,2) NOT NULL,
	valorTotal decimal(15,2) NOT NULL,
	PRIMARY KEY (idItemVenda),
	CONSTRAINT fk_Produto FOREIGN KEY (idProduto) REFERENCES produto (idProduto),
	CONSTRAINT fk_Venda FOREIGN KEY (idVenda) REFERENCES venda (idVenda)
);

--update produto set estoque = 100 where idProduto = 104
--select * from produto


-- Geração de dados com https://www.mockaroo.com/

insert into cliente (nome, email, telefone, estado, cpf) values ('Win Villaron', 'wvillaron0@yellowpages.com', '419-859-8533', 'Zooxo', '386-56-1612');
insert into cliente (nome, email, telefone, estado, cpf) values ('Myriam Munslow', 'mmunslow1@umich.edu', '217-205-6063', 'Latz', '828-21-1161');
insert into cliente (nome, email, telefone, estado, cpf) values ('Georg Troucher', 'gtroucher2@msn.com', '508-648-0001', 'Quinu', '112-96-4561');
insert into cliente (nome, email, telefone, estado, cpf) values ('Yolanda Segot', 'ysegot3@marketwatch.com', '864-103-1528', 'Jaxworks', '398-44-8739');


insert into produto (codProduto, nomeProduto, preco, estoque, marca) values ('52584-795', 'Pasta - Detalini, White, Fresh', 583.28, 929, 'Ardea cinerea');
insert into produto (codProduto, nomeProduto, preco, estoque, marca) values ('49288-0367', 'Stainless Steel Cleaner Vision', 798.28, 611, 'Lamprotornis sp.');
insert into produto (codProduto, nomeProduto, preco, estoque, marca) values ('36987-2176', 'Crackers - Soda / Saltins', 61.07, 518, 'Haliaetus vocifer');
insert into produto (codProduto, nomeProduto, preco, estoque, marca) values ('62175-114', 'Tart - Lemon', 732.02, 329, 'Vombatus ursinus');
insert into produto (codProduto, nomeProduto, preco, estoque, marca) values ('63941-218', 'Wine - Zinfandel Rosenblum', 674.45, 306, 'Perameles nasuta');
insert into produto (codProduto, nomeProduto, preco, estoque, marca) values ('0064-1011', 'Brocolinni - Gaylan, Chinese', 165.35, 853, 'Coracias caudata');