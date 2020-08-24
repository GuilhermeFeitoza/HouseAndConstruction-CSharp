



INSERT INTO tbNivelAcesso values(
    	'Administrador',
    	'Adm',
    	'esse usuario poderá acessar todos os recursos do sistema',
    	1,
    	1,
    	1,
    	1,
		1,
		1,
		1,
		1,
		1    	
)
INSERT INTO tbNivelAcesso values(
	'Vendedor',
	'Vend',
	'Esse usuário poderá acessar todos os recursos que necessitam para a venda do produto',
	0,
	1,
	0,
	1,
	1,
	0,
	1,
	1,
	1
)
INSERT INTO tbNivelAcesso values(
	'Supervisor',
	'Superv',
	'Esse usuario poderá acessar os recursos de acompanhamento do trabalho',
	0,
	1,
	1,
	1,
	1,
	1,
	1,
	1,
	1
)


INSERT INTO tbusuario values('admin','123',1,'23/10/2018','23/10/2018',1)
INSERT INTO tbusuario values('Guilherme','123',1,'23/10/2018','23/10/2018',1)
INSERT INTO tbusuario values('Fellipe','123',1,'23/10/2018','23/10/2018',1)
INSERT INTO tbusuario values('Gabriel','123',1,'23/10/2018','23/10/2018',1)
INSERT INTO tbusuario values('Lucas','123',1,'23/10/2018','23/10/2018',1)
INSERT INTO tbusuario values('GuilhermeP','123',1,'23/10/2018','23/10/2018',1)
INSERT INTO tbusuario values('Amanda','1234',1,'27/10/2018','23/10/2018',2)
INSERT INTO tbusuario values('Kevin','1234',1,'27/10/2018','23/10/2018',2)
INSERT INTO tbusuario values('Yuri','12345',1,'27/10/2018','23/10/2018',3)
INSERT INTO tbusuario values('Isabella','12345',1,'05/11/2018','23/10/2018',3)
INSERT INTO tbusuario values('Gustavo','123456',1,'08/11/2018','23/10/2018',4)
INSERT INTO tbusuario values('Yasmin','123123',1,'01/12/2018','23/10/2018',4)
INSERT INTO tbusuario values('José','123321',1,'07/12/2018','23/10/2018',4)
INSERT INTO tbUsuario values('Eduardo','321123',1,'05/01/2019','23/10/2018',5)



INSERT INTO tbCliente values(
	'Renato Almeida da Silva',
	'03/05/1985',
	'Rua das Adalias',
	'Jardim Florida',
	'Barueri',
	NULL,
	'120',
	'SP',
	'06407170',
	'345484427',
	'35421854175',
	'M',
	'11942847456',
	'renato.85@gmail.com',
	1
)
INSERT INTO tbCliente values(
	'Yago Jesus de Oliveira',
	'05/08/1987',
	'Rua Augusta',
	'Consolação',
	'Sao Paulo',
	NULL,
	'255',
	'SP',
	'01305901',
	'364574589',
	'32157254774',
	'M',
	'11948523657',
	'yagojesus1987@hotmail.com',
	1

)
INSERT INTO tbCliente values(
	'Patricia Almeida Santos',
	'08/10/1975',
	'Rua Tuiuti',
	'Tatuapé',
	'Sao Paulo',
	'travessa 02',
	'580',
	'SP',
	'03081003',
	'314587414',
	'45578686799',
	'F',
	'11945752187',
	'pat.almeida44@hotmail.com',
	1
)
INSERT INTO tbCliente values(
	'Rodrigo Pereira Ramos',
	'01/02/1992',
	'Rua Treze de maio',
	'Bela Vista',
	'Sao Paulo',
	NULL,
	'1925',
	'SP',
	'01327900',
	'325478512',
	'65865655668',
	'M',
	'11942481872',
	'rodrigoramos92@gmail.com',
	0
)
INSERT INTO tbCliente values(
	'Agatha Fraga da Silva',
	'07/04/1995',
	'Rua Tiradentes',
	'Santa Terezinha',
	'Sao Paulo',
	null,
	'1834',
	'SP',
	'09780900',
	'544243536',
	'34543546543',
	'F',
	'11935434646',
	'agatha95@hotmail.com',
	1
)
INSERT INTO tbCliente values(
	'Leandro da Silva Cardoso',
	'08/06/1986',
	'Rua Monte Alegre',
	'Perdizes',
	'Sao Paulo',
	null,
	'990',
	'SP',
	'05014901',
	'354973725',
	'52427453732',
	'M',
	'11935354468',
	'silva.c1986@bol.com',
	1
)
INSERT INTO tbCliente values(
	'Joao Lima Araujo',
	'28/03/1990',
	'Rua Campos Sales',
	'Centro',
	'Barueri',
	null,
	'775',
	'SP',
	'06401000',
	'384171658',
	'54863121542',
	'M',
	'11934565744',
	'Jlima.araujo@hotmail.com',
	0
)

INSERT INTO tbCliente values(
	'Silvio Cruz dos Santos',
	'06/07/1972',
	'Rua Tutoia',
	'Vila Mariana',
	'Sao Paulo',
	null,
	'1148',
	'SP',
	'04007900',
	'324575761',
	'29546437388',
	'M',
	'11985376735',
	'silviocruz6772@gmail.com',
	1
)
INSERT INTO tbCliente values(
	'Ana Carolina da Silva',
	'01/09/1999',
	'Rua Santo Antonio',
	'Bela Vista',
	'Sao Paulo',
	null,
	'850',
	'SP',
	'01314001',
	'351577868',
	'37543247465',
	'F',
	'11987573845',
	'carol.silva99@hotmail.com',
	1
)
INSERT INTO tbCliente values(
	'Antonio Almeida Mendonça',
	'06/12/1970',
	'Rua Florida',
	'Cidade Moncoes',
	'Sao Paulo',
	null,
	'1971',
	'SP',
	'04565905',
	'351574675',
	'65797644753',
	'M',
	'11935738976',
	'antoniomend1970@hotmail.com',
	1
)







INSERT INTO tbFornecedores values(
	'Concrenasa',
	'Concrenasa Comércio e Indústria de Matrial para Construção',
	'55961510000117',
	'14095280',
	null,
	'1166',
	'1640093440',
	'concrenasaconstrucao@gmail.com',
	1
)
INSERT INTO tbFornecedores values(
	'DTMB',
	'DTMB Distribuidor e Transporte de Materiais Básicos',
	'51247524520154',
	'15474620',
	null,
	'254',
	'1142012569',
	'dtmbdistribuidora@gmail.com',
	1
)
INSERT INTO tbFornecedores values(
	'Artesana',
	'Artesana Divisórias e Forros Ltda',
	'51574255734548',
	'17371660',
	null,
	'1542',
	'1645681457',
	'artesanafornecedora@gmail.com',
	1
)
INSERT INTO tbFornecedores values(
	'Pro Eletro',
	'Pró Eletro Soluções em Equipamentos Ltda',
	'51254876323562',
	'15676300',
	null,
	'150',
	'1148531485',
	'eletropro@gmail.com',
	1
)





INSERT INTO tbCargo values(
	'Administrador',
	'Adm',
	'Administra',
	1
)
INSERT INTO tbCargo values(
	'Vendedor',
	'Vend',
	'Vende',
	1
)
INSERT INTO tbCargo values(
	'Supervisor',
	'Supv',
	'Irá supervisionar todas as operações que acontecem na empresa',
	1
)





INSERT INTO tbFuncionario values(
	'Guilherme Dionizio Feitoza',
	'M',
	'03/06/1991',
	'51676457874',
	'354854217',
	'15478415',
	'157',
	null,
	'guilherme.feitoza01@hotmail.com',
	'11972152356',
	null,
	4000.00,
	1,
	'18/10/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Felipe Strombeck da Silva',
	'M',
	'11/12/1995',
	'54864345447',
	'345527574',
	'06417000',
	'1155',
	null,
	'felipe.strombeck@hotmail.com',
	'11954871248',
	null,
	3500.00,
	1,
	'20/10/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Gabriel Alves Oliveira',
	'M',
	'21/01/1998',
	'54345765467',
	'354516527',
	'06726100',
	'1165',
	null,
	'gabriel.oliveira@hotmail.com',
	'11985434872',
	null,
	3500.00,
	1,
	'20/10/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Lucas Silva Rocha',
	'M',
	'21/10/2018',
	'51875497975',
	'354853266',
	'15776800',
	'1578',
	null,
	'lucassilva@gmail.com',
	'11985241752',
	null,
	3200.00,
	1,
	'21/10/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Guilherme Pereira Araujo',
	'M',
	'02/05/1992',
	'51627548776',
	'395842147',
	'06857000',
	'1166',
	'travessa 03',
	'guilherme.pereira@gmail.com',
	'11977358147',
	null,
	5000.00,
	1,
	'23/10/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Amanda Ribeiro Lima',
	'F',
	'05/08/2000',
	'54857654875',
	'345424554',
	'06478102',
	'164',
	null,
	'limaamanda.00@hotmail.com',
	'11985741721',
	null,
	2000.00,
	2,
	'24/10/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Kevin Balbino da Silva',
	'M',
	'24/06/1999',
	'51746765755',
	'355457568',
	'06418000',
	'1547',
	null,
	'balbuino.silva@gmail.com',
	'11987875642',
	null,
	2000.00,
	2,
	'25/10/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Yuri Mendonça dos Santos',
	'M',
	'05/11/1997',
	'25465767645',
	'321847657',
	'03451100',
	'112',
	null,
	'yuritrabalho@gmail.com',
	'11986762482',
	null,
	1500.00,
	2,
	'27/10/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Isabella Gomes da Silva',
	'F',
	'01/04/1993',
	'35457487564',
	'345575742',
	'15743709',
	'167',
	null,
	'isagomes93@hotmail.com',
	'11943257523',
	null,
	1500.00,
	2,
	'02/11/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Gustavo Rodrigues Araujo',
	'M',
	'06/07/1989',
	'27465746741',
	'389137572',
	'20467000',
	'1122',
	null,
	'gustavorod@bol.com',
	'11985742436',
	null,
	1400.00,
	2,
	'05/11/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Yasmin Moreira da Silva',
	'F',
	'22/09/1996',
	'51574743741',
	'385755227',
	'16877802',
	'65',
	null,
	'yassilva@gmail.com',
	'11975162378',
	null,
	1398.00,
	2,
	'28/11/2018',
	1
	
)
INSERT INTO tbFuncionario values(
	'Jose Jesus Santos Araujo',
	'M',
	'18/03/1985',
	'29554874575',
	'325752574',
	'15832900',
	'197',
	null,
	'josesantos85@bol.com',
	'11983242742',
	null,
	1350.50,
	2,
	'06/12/2018',
	1
)
INSERT INTO tbFuncionario values(
	'Eduardo Lima Mendonça',
	'M',
	'11/08/1994',
	'34587541512',
	'348574565',
	'06475000',
	'2642',
	null,
	'dudulima@gmail.com',
	'11986521578',
	null,
	1287.30,
	2,
	'03/01/2019',
	1
)




--VENDAS--


INSERT INTO tbUnidadeVenda values('Unidade','UNID')
INSERT INTO tbUnidadeVenda values('Metros²','M²')
INSERT INTO tbUnidadeVenda values('Metros³','M³')
INSERT INTO tbUnidadeVenda values('Pacote','PCT')






INSERT INTO tbCategoria values('Pisos e revestimentos','')
INSERT INTO tbCategoria values('Portas e  Janelas','')
INSERT INTO tbCategoria values('Area Externa','')
INSERT INTO tbCategoria values('Segurança e Comunicaçao','')
INSERT INTO tbCategoria values('Climatizaçao','')
INSERT INTO tbCategoria values('Organização da Casa','')
INSERT INTO tbCategoria values('Iluminação','')
INSERT INTO tbCategoria values('Banheiro','')
INSERT INTO tbCategoria values('Cozinha e Lavanderia','')
INSERT INTO tbCategoria values('Elétrica','')
INSERT INTO tbCategoria values('Ferramentas','')
INSERT INTO tbCategoria values('Hidráulica','')
INSERT INTO tbCategoria values('Tintas','')
INSERT INTO tbCategoria values('Materiais de Construção','')
INSERT INTO tbCategoria values('Ferragens','')
INSERT INTO tbCategoria values('Decoração','')



INSERT INTO tbProduto values(
	'Furadeira',
	'Furadeira elétrica de impacto TB550BR 127V 550W 3/8',
	2,
	'785753502493',
	'10',
	'100',
	3,
	11,
	'06/11/2018',
	'Black Decker',
	'furadeira.jpg',
	1,
	105.00
)
INSERT INTO tbProduto values(
	'Cimento',
	'Cimento Todas As Obras 50kgs CPII Z 32R',
	3,
	'78654542152415',
	'200',
	'10',
	2,
	14,
	'28/10/2018',
	'Votoran',
	'cimentovotoran.jpg',
	1,
	20.40
)
INSERT INTO tbProduto values(
	'Dobradiça',
	'Dobradiça Pino Reversível De Ferro Galvanizado Linha Leve 1840 3',
	1,
	'23453256542',
	'150',
	'15',
	4,
	15,
	'11/12/2018',
	'Pagé',
	'dobradicapage.jpg',
	1,
	10.00
)
INSERT INTO tbProduto values(
	'Argamassa',
	'Argamassa Cozinha E Banheiro 20kg Cinza ',
	1,
	'74151938748',
	
	'20',
	'250',
	2,
	1,
	'20/12/2018',
	'Quartzolit',
	'argamassaquart.jpg',
	1,
	14.30
)
INSERT INTO tbProduto values(
	'Espelho',
	'Espelho Retangular Emoldurado NMP 32x72cm',
	4,
	'8754574896549',
	
	'5',
	'100',
	2,
	16,
	'10/01/2019',
	'Euroquadros',
	'espelhoeuro.jpg',
	1,
	50.00
)
INSERT INTO tbProduto values(
	'Alarme',
	'Alarme Magnético Para Porta E Janela 6002',
	1,
	'5464764665469',

	'8',
	'50',
	3,
	4,
	'05/02/2019',
	'Key West',
	'keywestalarme.jpg',
	1,
	25.90
)
INSERT INTO tbProduto values(
	'Caixa Dágua',
	'Caixa Dágua Com Tampa 500 Litros Polietileno',
	1,
	'54765456415',

	'14',
	'110',
	4,
	12,
	'29/01/2019',
	'Fortlev',
	'caixadaguafortlev.jpg',
	1,
	199.50
)
INSERT INTO tbProduto values(
	'Ventilador de mesa',
	'Ventilador De Mesa 30cm Azul E Branco 127V',
	1,
	'3578518214654',

	'12',
	'120',
	1,
	5,
	'18/02/2019',
	'Mondial',
	'ventiladormondial.jpg',
	1,
	92.90
)
INSERT INTO tbProduto values(
	'Chuveiro Elétrico',
	'Chuveiro Elétrico Super Quattro 220V 6800W Branco',
	1,
	'524354352165',

	'20',
	'170',
	3,
	8,
	'15/02/2019',
	'Fame',
	'chuveirofame.jpg',
	1,
	50.26
)
INSERT INTO tbProduto values(
	'Martelo',
	'Martelo De Unha 20mm Aço Temperado Cinza',
	1,
	'5248548455465',

	'100',
	'300',
	2,
	11,
	'02/03/2019',
	'Tramontina',
	'matelotramontina.jpg',
	1,
	20.90
)
INSERT INTO tbProduto values(
	'Tomada',
	'Tomada 2PT T 10A 250V 57115030 Branca ',
	1,
	'5145053789213',

	'20',
	'220',
	3,
	10,
	'15/03/2019',
	'Tramontina',
	'tomadatramontina.jpg',
	1,
	3.99
)
INSERT INTO tbProduto values(
    'Janela',
    'Janela De Correr 4 Folhas 100x120x8cm Com Bascula Cinza',
    1,
    '25197658396838',

    '10',
    '120',
    1,
    2,
    '06/03/2019',
    'Lucasa',
    'janelalucasa.jpg',
    1,
    329.90
)
INSERT INTO tbProduto values(
    'Piscina',
    'Piscina Easy Set 28121 3853 Litros Azul',
    1,
    '46785345679875',

    '5',
    '40',
    3,
    3,
    '08/03/2019',
    'Intex',
    'intexpiscina.jpg',
    1,
    427.40
)
INSERT INTO tbProduto values(
    'Lixeira',
    'Lixeira De Inox Com Pedal 3 Litros',
    1,
    '3644524857655',
  
    '10',
    '60',
    4,
    6,
    '08/03/2019',
    'Coisas e Coisinhas',
    'lixeira.jpg',
    1,
    30.30
)
INSERT INTO tbProduto values(
    'Luminaria',
    'Luminária Versaty De Aço E27 40W Branca',
    1,
    '2415421183659',
  
    '5',
    '40',
    1,
    7,
    '10/03/2019',
    'Bronzearte',
    'luminario.png',
    1,
    40.76
)
INSERT INTO tbProduto values(
    'Armario para Banheiro Versatil',
    'Ármario Para Banheiro Versatil 30x37x11cm Sobrepor Branco',
    1,
    '387219730975',

    '5',
    '25',
    3,
    8,
    '12/03/2019',
    'Astra',
    'armariobanheiro.png',
    1,
    55.00
)
INSERT INTO tbProduto values(
    'Arame Galvanizado',
    'Arame Galvanizado BWG 124 18 1kg ',
    1,
    '254872319761',
  
    '5',
    '50',
    4,
    14,
    '15/03/2019',
    'Gerdau',
    'aramegerdau.png',
    1,
    20.00
)
INSERT INTO tbProduto values(
    'Jogo de Chaves Hexagonal',
    'Jogo De Chaves Hexagonal 2 - 10mm 8 Peças',
    1,
    '76598163498',

    '10',
    '40',
    2,
    11,
    '17/03/2019',
    'Prosteel',
    'projogochave.jpg',
    1,
    14.00
)


INSERT INTO tbEstoque Values (1,20)
INSERT INTO tbEstoque Values (2,2)
INSERT INTO tbEstoque Values (3,30)
INSERT INTO tbEstoque Values (4,45)
INSERT INTO tbEstoque Values (5,12)
INSERT INTO tbEstoque Values (6,10)
INSERT INTO tbEstoque Values (7,28)
INSERT INTO tbEstoque Values (8,11)
INSERT INTO tbEstoque Values (9,23)
INSERT INTO tbEstoque Values (10,25)
INSERT INTO tbEstoque Values (11,17)
INSERT INTO tbEstoque Values (12,13)
INSERT INTO tbEstoque Values (13,20)
INSERT INTO tbEstoque Values (14,20)
INSERT INTO tbEstoque Values (15,20)
INSERT INTO tbEstoque Values (16,20)
INSERT INTO tbEstoque Values (17,20)
INSERT INTO tbEstoque Values (18,20)

INSERT INTO tbLog_Entrada_Produto Values (1,
20,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (2,2,'16/04/2019' )
INSERT INTO tbLog_Entrada_Produto Values (3,30,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (4,45,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (5,12,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (6,10,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (7,28,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (8,11,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (9,23,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (10,25,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (11,17,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (12,13,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (13,20,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (14,20,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (15,20,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (16,20,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (17,20,'16/04/2019')
INSERT INTO tbLog_Entrada_Produto Values (18,20,'16/04/2019')






INSERT INTO tbFormaPgto values('Dinheiro')
INSERT INTO tbFormaPgto values('Cartao')
INSERT INTO tbFormaPgto values('Boleto')
INSERT INTO tbFormaPgto values('Cheque')


 

INSERT INTO tbVenda values(6,7,'16/02/2019',199.5)
INSERT INTO tbVenda values(1,6,'19/02/2019',61.20)
INSERT INTO tbVenda values(7,7,'20/02/2019',5.90)
INSERT INTO tbVenda values(2,7,'21/02/2019',30.00)
INSERT INTO tbVenda values(8,6,'21/02/2019',20.90)
INSERT INTO tbVenda values(3,6,'25/02/2019',50.00)
INSERT INTO tbVenda values(9,6,'26/02/2019',105.00)
INSERT INTO tbVenda values(4,7,'26/02/2019',39.90)
INSERT INTO tbVenda values(5,7,'27/02/2019',81.60)





INSERT INTO tbPgto_Venda values(2,1,199.50)
INSERT INTO tbPgto_Venda values(1,2,61.20)
INSERT INTO tbPgto_Venda values(3,3,25.90)
INSERT INTO tbPgto_Venda values(1,4,30.00)
INSERT INTO tbPgto_Venda values(4,5,20.90)
INSERT INTO tbPgto_Venda values(2,6,50.00)
INSERT INTO tbPgto_Venda values(2,7,105.00)
INSERT INTO tbPgto_Venda values(1,8,39.90)
INSERT INTO tbPgto_Venda values(2,9,81.60)





INSERT INTO tbItem_Venda values(1,1)
INSERT INTO tbItem_Venda values(1,2)
INSERT INTO tbItem_Venda values(1,3)
INSERT INTO tbItem_Venda values(1,4)
INSERT INTO tbItem_Venda values(2,2)
INSERT INTO tbItem_Venda values(3,6)
INSERT INTO tbItem_Venda values(4,3)
INSERT INTO tbItem_Venda values(5,10)
INSERT INTO tbItem_Venda values(6,5)
INSERT INTO tbItem_Venda values(7,1)
INSERT INTO tbItem_Venda values(8,11)
INSERT INTO tbItem_Venda values(9,2)









--Contas a pagar--


INSERT INTO tbLancamento values(1,'23/02/2019',101.80,0,'20/02/2019',101.80,8)
INSERT INTO tbLancamento values(2,'25/02/2019',87.52,0,'20/02/2019',87.52,8)
INSERT INTO tbLancamento values(3,'26/02/2019',200.90,0,'20/02/2019',200.90,8)
INSERT INTO tbLancamento values(1,'23/03/2019',103.45,1,null,103.45,null)
INSERT INTO tbLancamento values(2,'25/03/2019',82.58,1,null,82.58,null)
INSERT INTO tbLancamento values(3,'26/03/2019',205.80,1,null,205.80,null)




INSERT INTO tbPeriodo values('Trimestral',3,'+',1)
INSERT INTO tbPeriodo values('Anual',12,'+',1)
INSERT INTO tbPeriodo values('Mensal',1,'+',1)


INSERT INTO tbTipoTitulo values('Conta de Luz',1)
INSERT INTO tbTipoTitulo values('Conta de agua',1)
INSERT INTO tbTipoTitulo values('Internet',1)