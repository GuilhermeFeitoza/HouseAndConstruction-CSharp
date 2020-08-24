DROP DATABASE LojaDeMateriaisParaConstrucao
CREATE  database LojaDeMateriaisParaConstrucao
go
Use LojaDeMateriaisParaConstrucao

---CADASTROS---
CREATE TABLE tbusuario 
(
CodigoUsuario int identity primary key not null ,
NomeUsuario varchar(50),
SenhaUsuario varchar(20),
StatusUsuario int ,
DataAcessoUsuario datetime , 
DataCadastroUsuario datetime ,
CodigoNivelAcesso int
)
CREATE TABLE tbNivelAcesso(
	CodigoNivelAcesso int identity primary key,
	NomeNivelAcesso varchar(30) not null,
	Abreviacao varchar(10) not null,
	Descricao varchar(200),
	Permissao_Usuarios bit ,
	Permissao_Clientes bit ,
	Permissao_Funcionarios bit, 
	Permissao_Fornecedores bit ,
	Permissao_Produtos bit,
	Permissao_Contas bit ,
	Permissao_Vender bit ,
	Permissao_Orcamento bit,
	StatusNivel bit 
	)
	
CREATE table tbCliente(
CodigoCliente  int identity primary key ,--0
Nome varchar (70) not null ,
DataNascimento datetime not null ,
Endereco varchar (100) not null ,
Bairro varchar (50) not null ,
Cidade varchar (50) not null ,
Complemento varchar (50),
Numero int,
UF char (2),
CEP varchar(15),
Rg varchar (20) unique not null , 
Cpf varchar (20) not null ,
Sexo varchar (1) not null ,
Telefone varchar (20) not null ,
Email varchar (50)not null,
StatusCliente int
 )
CREATE TABLE tbFornecedores(
	CodigoFornecedor int identity primary key,
	NomeFantasia varchar(60) not null,
	RazaoSocial varchar(60),
	CNPJ varchar (20),
	CEP varchar(15),
	Complemento varchar (50),
	Numero int,
	Tel varchar(20)not null,
	Email varchar(50)not null,
	StatusFornecedor int 
)
CREATE TABLE tbCargo
(
  CodigoCargo    INT IDENTITY PRIMARY KEY,
  NomeCargo      VARCHAR(50) NOT NULL,
  Abreviacao varchar(10) not null,
  DescricaoCargo varchar(200),
  StatusCargo int

)
CREATE TABLE tbFuncionario
(
 CodigoFuncionario  INT IDENTITY PRIMARY KEY,
  Nome      VARCHAR(100) NOT NULL,
  Sexo      CHAR(1)       NOT NULL,
  DataNascimento  DATEtime          NOT NULL,
  CPF      CHAR(20)      NOT NULL,
  RG		VARCHAR(20)      NOT NULL,
  CEP		VARCHAR(20)	NOT NULL,
  Numero	int      NOT NULL,
  Complemento VARCHAR(50)      ,
  Email     VARCHAR(100) NULL,
  Telefone  VARCHAR(20)  NOT NULL,
  Foto      VARCHAR(1000),
  Salario decimal(15,2),
  CodigoCargo   INT,
  DataAdmissao datetime,
  StatusFuncionario BIT 

  CONSTRAINT FK_idCargoFunc FOREIGN KEY (CodigoCargo) REFERENCES tbCargo (CodigoCargo)
)

---VENDAS---
CREATE TABLE tbUnidadeVenda(
	CodigoUnidadeVenda int identity primary key,
	NomeUnidadeVenda varchar(30) not null,
	Abreviacao char(5) not null
)
CREATE TABLE tbCategoria(
	CodigoCategoria int identity primary key,
	NomeCategoria varchar(40) not null,
	DescricaoCategoria varchar(200)
)
CREATE TABLE tbProduto(
	CodigoProduto int identity primary key,
	Nome VARCHAR(50),
	Descricao VARCHAR(100) not null,
	CodigoUnidadeVenda INT,
	CodigoBarra Varchar(1000),
	
	EstoqueMinimo int ,
	EstoqueMaximo int ,
	CodigoFornecedor int,
	CodigoCategoria int ,
	DataEntrada DATETIME,
	Marca VARCHAR (100)  ,
	Imagem varchar(300),
	StatusProduto BIT,
	ValorUnit decimal(15,2)
	constraint fk_forn_prod foreign key (CodigoFornecedor) references tbFornecedores (CodigoFornecedor),
	constraint fk_UnidVenda foreign key (CodigoUnidadeVenda) references tbUnidadeVenda (CodigoUnidadeVenda),
	constraint fk_cat_Prod foreign key (CodigoCategoria) references tbCategoria (CodigoCategoria)
)

CREATE TABLE tbEstoque(
CodigoEstoque int primary key  identity ,
CodigoProduto int, 
QuantidadeAtual int,
constraint fk_prod_est foreign key (CodigoProduto) references tbProduto(CodigoProduto)
)

CREATE TABLE tbLog_Entrada_Produto(
CodigoEntrada int primary key identity , 
CodigoProduto int ,
Quantidade int ,
DataEntrada datetime 
constraint fk_prod_entr foreign key (CodigoProduto) references tbProduto(CodigoProduto)

)

CREATE TABLE tbLog_Saida_Produto(
CodigoSaida int primary key identity , 
CodigoProduto int ,
Quantidade int ,
DataSaida datetime 
constraint fk_prod_sai foreign key (CodigoProduto) references tbProduto(CodigoProduto)

)
CREATE TABLE tbFormaPgto(
CodigoFormaPgto int primary key identity ,
Nome varchar(50)
)

CREATE TABLE tbVenda(
	CodigoVenda int identity primary key,
	CodigoCliente int,
	CodigoFuncionario int,
	DataVenda datetime ,
	ValorTotal decimal(10,2),
	 
	)
CREATE TABLE tbPgto_Venda(
CodigoPgto_Venda int primary key identity,
CodigoFormaPgto int, 
CodigoVenda int,
ValorForma decimal (10,2) 

constraint fk_pgto_venda foreign key (CodigoFormaPgto) references tbFormaPgto(CodigoFormaPgto)
)

CREATE TABLE tbItem_Venda(
CodigoItem_Venda int identity ,
CodigoVenda int, 
CodigoProduto int ,




)



--CONTAS A PAGAR--

CREATE TABLE tbLancamento(
CodigoLancamento  int identity not null ,
CodigoTitulo int not null,
DataVencimento datetime not null, 
ValorTitulo decimal(7,2) ,
StatusPagTitulo bit ,
DataPagamento datetime ,
ValorPagamento decimal (7,2),
CodigoUsuario int )

CREATE TABLE tbPeriodo(

CodigoPeriodo int identity , 
DescricaoPeriodo varchar(90) , 
ValorPeriodo int null,  
SinalPeriodo varchar ,
StatusPeriodo bit 

)

CREATE TABLE tbTipoTitulo(

CodigoTitulo  int identity, 
DescricaoTitulo varchar(100),
StatusTitulo bit 
)

CREATE TABLE tbOrcamento(
	CodigoOrcamento int identity primary key,
	CodigoCliente int,
	CodigoFuncionario int,
	DataOrcamento datetime ,
	ValorTotal decimal(10,2),
	constraint fk_cli_orcamento foreign key (CodigoCliente) references tbCliente (CodigoCliente),
	constraint fk_func_orcamento foreign key (CodigoFuncionario) references tbFuncionario (CodigoFuncionario)
		)
CREATE TABLE tbItem_Orcamento(
CodigoItem_Orcamento int identity ,
CodigoOrcamento int, 
CodigoProduto int ,

	constraint fk_orc_itemOrc foreign key (CodigoOrcamento) references tbOrcamento (CodigoOrcamento),
	constraint fk_prod_itemOrc foreign key (CodigoProduto) references tbProduto (CodigoProduto)


)
CREATE TABLE tbPedido(
CodigoPedido int identity primary key ,
CodigoCliente int ,
CodigoFuncionario int , 
DataPedido datetime , 
DataEntrega datetime,
ValorTotalPedido money ,
CodigoDestinatario int ,
StatusPedido bit 

)


CREATE TABLE tbDestinatario(
 CodigoDestinatario int identity primary key ,
 NomeDestinatario varchar(100),
 EnderecoDestinatario varchar(200),
 BairroDestinatario varchar(60),
 CidadeDestinatario varchar(70),
 UFDestinatario char(2),
 CEPDestinatario varchar (8),
 NumeroDestinatario int ,
 ComplementoDestinatario varchar (50),
 TelDestinatario varchar(15),
 StatusDestinatario bit  
 
 )


CREATE TABLE tbItem_Pedido(
CodigoItem_Pedido int identity ,
CodigoPedido int, 
CodigoProduto int ,

	constraint fk_ped_itemPed foreign key (CodigoPedido) references tbPedido (CodigoPedido),
	constraint fk_prod_itemPed foreign key (CodigoProduto) references tbProduto (CodigoProduto)


)
CREATE TABLE tbPgto_Pedido(
CodigoPgto_Pedido int identity,
CodigoFormaPgto int, 
CodigoPedido int,
ValorForma decimal (10,2) 
	constraint fk_orc_pgtoPedido foreign key (CodigoFormaPgto) references tbFormaPgto(CodigoFormaPgto)
)



