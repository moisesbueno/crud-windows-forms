CREATE TABLE `tb_lancamentos` (
	`Id`	INTEGER,
	`Data`	DateTime,
	`Hora`	TEXT,
	`Terminal`	TEXT,
	`Controle`	TEXT,
	`ContaCreditada`	TEXT,
	`Nome`	TEXT,
	`Valor`	decimal(10,2),
	`NumeroEnvelope`	TEXT,
	`NumeroControle`	TEXT,
	PRIMARY KEY(`Id`)
)