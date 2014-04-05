CREATE TABLE TBLCAIXA (
DTECAIXA             DATETIME             NOT NULL,
FLTVALORABERTURA     FLOAT                NOT NULL,
FLTVALORFECHAMENTO   FLOAT                NULL,
FLTVALORTRANSICAO    FLOAT                NOT NULL
CONSTRAINT PK_TBLCAIXA PRIMARY KEY  (DTECAIXA)
)
go
CREATE  CLUSTERED INDEX IN_DTECAIXA ON TBLCAIXA (
DTECAIXA
)
go
CREATE TABLE TBLCARTEIRA (
ID_CARTEIRA          	INT                  NOT NULL,
ID_CLIENTE            INT                  NOT NULL,
FLTVALORTOTAL        	FLOAT                NOT NULL,
DTEDATAPAGAMENTO     	DATETIME             NOT NULL,
FLTVALORCREDITO      	FLOAT                NOT NULL,
BITSTATUSCARTEIRA    	BIT                  NOT NULL
CONSTRAINT PK_TBLCARTEIRA PRIMARY KEY  (ID_CARTEIRA)
)
go

CREATE  CLUSTERED INDEX IN_IDCARTEIRA ON TBLCARTEIRA (
ID_CARTEIRA
)
go

CREATE UNIQUE  INDEX IN_DTEDATAPAGAMENTO ON TBLCARTEIRA (
DTEDATAPAGAMENTO
)
go

CREATE TABLE TBLCLIENTE (
ID_CLIENTE          INT                 NOT NULL,
STRNOME             VARCHAR(70)         NOT NULL,
STRENDERECO         VARCHAR(60)         NOT NULL,
INTNUMERO           INT                 NOT NULL,
STRBAIRRO           VARCHAR(40)         NOT NULL,
STRCIDADE           VARCHAR(40)         NOT NULL,
STRESTADO           VARCHAR(40)         NOT NULL,
STRCEP              VARCHAR(10)         NULL,
STREMAIL            VARCHAR(90)         NOT NULL,
STRTELEFONE			VARCHAR(14)			NULL,
STRCELULAR			VARCHAR(14)			NULL,
STRFAX				VARCHAR(14)			NULL
CONSTRAINT PK_TBLCLIENTE PRIMARY KEY  (ID_CLIENTE)
)
go

CREATE  CLUSTERED INDEX IN_IDCLIENTE ON TBLCLIENTE (
ID_CLIENTE
)
go

CREATE UNIQUE  INDEX IN_STRNOME ON TBLCLIENTE (
STRNOME
)
go

CREATE TABLE TBLCUSTO (
ID_CUSTO             INT                  NOT NULL,
ID_TIPOCUSTO         INT                  NULL,
STRDESCRICAO         VARCHAR(100)         NOT NULL,
DTECUSTO             DATETIME             NOT NULL,
FLTVALORCUSTO        FLOAT                NOT NULL
CONSTRAINT PK_TBLCUSTO PRIMARY KEY  (ID_CUSTO)
)
go


/*==============================================================*/
/* Index: IN_IDCUSTO                                            */
/*==============================================================*/
CREATE  CLUSTERED INDEX IN_IDCUSTO ON TBLCUSTO (
ID_CUSTO
)
go


/*==============================================================*/
/* Index: IN_DTECUSTO                                           */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_DTECUSTO ON TBLCUSTO (
DTECUSTO
)
go


/*==============================================================*/
/* Index: FLTVALORCUSTO                                         */
/*==============================================================*/
CREATE   INDEX FLTVALORCUSTO ON TBLCUSTO (
FLTVALORCUSTO
)
go


/*==============================================================*/
/* Table: TBLESTOQUE                                            */
/*==============================================================*/
CREATE TABLE TBLESTOQUE (
ID_PRODUTO            INT                  NOT NULL,
DTEENTRADA           DATETIME             NOT NULL,
INTQUANTIDADEENTRADA INT                  NOT NULL,
INTQUANTIDADEATUAL   INT                  NOT NULL,
INTQUANTIDADEVENDIDA INT                  NOT NULL,
FLTVALORCUSTOUNITARIO FLOAT                NOT NULL,
FLTVALORVENDAUNITARIO FLOAT                NOT NULL
CONSTRAINT PK_TBLESTOQUE PRIMARY KEY  (ID_PRODUTO)
)
go


/*==============================================================*/
/* Index: IN_DTEREGISTRO                                        */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_DTEREGISTRO ON TBLESTOQUE (
DTEENTRADA
)
go


/*==============================================================*/
/* Table: TBLFUNCIONARIO                                        */
/*==============================================================*/
CREATE TABLE TBLFUNCIONARIO (
ID_FUNCIONARIO        INT                  NOT NULL,
STRNOME              VARCHAR(70)          NOT NULL,
STRENDERECO          VARCHAR(60)          NOT NULL,
INTNUMERO            INT                  NOT NULL,
STRBAIRRO            VARCHAR(40)          NOT NULL,
STRCIDADE            VARCHAR(40)          NOT NULL,
STRESTADO            VARCHAR(40)          NOT NULL,
STRCEP               VARCHAR(10)          NULL,
STREMAIL             VARCHAR(90)          NOT NULL,
STRCARTEIRATRABALHO  VARCHAR(10)          NOT NULL,
STRSERIECT           VARCHAR(10)          NOT NULL,
STRUFCT              VARCHAR(2)           NOT NULL
CONSTRAINT PK_TBLFUNCIONARIO PRIMARY KEY  (ID_FUNCIONARIO)
)
go


/*==============================================================*/
/* Index: IN_IDFUNCIONARIO                                      */
/*==============================================================*/
CREATE  CLUSTERED INDEX IN_IDFUNCIONARIO ON TBLFUNCIONARIO (
ID_FUNCIONARIO
)
go


/*==============================================================*/
/* Index: IN_STRNOME                                            */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_STRNOME ON TBLFUNCIONARIO (
STRNOME
)
go


/*==============================================================*/
/* Index: IN_STRCT                                              */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_STRCT ON TBLFUNCIONARIO (
STRCARTEIRATRABALHO
)
go


/*==============================================================*/
/* Table: TBLITEMCARRINHO                                       */
/*==============================================================*/
CREATE TABLE TBLITEMCARRINHO (
ID_ITEMCARRINHO      	INT                  NOT NULL,
ID_PRODUTO            INT                  NOT NULL,
INTQUANTIDADE        	INT                  NOT NULL
CONSTRAINT PK_TBLITEMCARRINHO PRIMARY KEY  (ID_ITEMCARRINHO)
)
go


/*==============================================================*/
/* Index: IN_IDCARRINHO                                         */
/*==============================================================*/
CREATE  CLUSTERED INDEX IN_IDCARRINHO ON TBLITEMCARRINHO (
ID_ITEMCARRINHO
)
go


/*==============================================================*/
/* Table: TBLLOGIN                                              */
/*==============================================================*/
CREATE TABLE TBLLOGIN (
ID_LOGIN              INT                  NOT NULL,
ID_FUNCIONARIO        INT                  NOT NULL,
ISADMIN              BIT                  NOT NULL,
DTECADASTRO          DATETIME             NOT NULL,
STRLOGIN             VARCHAR(20)          NOT NULL,
STRSENHA             VARCHAR(10)          NOT NULL
CONSTRAINT PK_TBLLOGIN PRIMARY KEY  (ID_LOGIN)
)
go


/*==============================================================*/
/* Index: IN_IDLOGIN                                            */
/*==============================================================*/
CREATE  CLUSTERED INDEX IN_IDLOGIN ON TBLLOGIN (
ID_LOGIN
)
go


/*==============================================================*/
/* Index: IN_IDFUNCIONARIO                                      */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_IDFUNCIONARIO ON TBLLOGIN (
ID_FUNCIONARIO
)
go


/*==============================================================*/
/* Table: TBLPRODUTO                                            */
/*==============================================================*/
CREATE TABLE TBLPRODUTO (
ID_PRODUTO            INT                  NOT NULL,
ID_TIPOPRODUTO        INT                  NOT NULL,
ID_REVENDEDOR         INT                  NOT NULL,
STRNOME              VARCHAR(40)          NOT NULL,
DTECADASTRO          DATETIME             NOT NULL,
FLTVALOR             FLOAT                NOT NULL
CONSTRAINT PK_TBLPRODUTO PRIMARY KEY  (ID_PRODUTO)
)
go


/*==============================================================*/
/* Index: IN_IDPRODUTO                                          */
/*==============================================================*/
CREATE  CLUSTERED INDEX IN_IDPRODUTO ON TBLPRODUTO (
ID_PRODUTO
)
go


/*==============================================================*/
/* Index: IN_DTECADASTRO                                        */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_DTECADASTRO ON TBLPRODUTO (
DTECADASTRO
)
go


/*==============================================================*/
/* Table: TBLREVENDEDOR                                         */
/*==============================================================*/
CREATE TABLE TBLREVENDEDOR (
ID_REVENDEDOR         INT                  NOT NULL,
STRNOME              VARCHAR(70)          NOT NULL,
STRENDERECO          VARCHAR(60)          NOT NULL,
INTNUMERO            INT                  NOT NULL,
STRBAIRRO            VARCHAR(40)          NOT NULL,
STRCIDADE            VARCHAR(40)          NOT NULL,
STRESTADO            VARCHAR(40)          NOT NULL,
STRCEP               VARCHAR(10)          NULL,
STRTELEFONE          VARCHAR(14)          NOT NULL,
STRCELULAR           VARCHAR(14)          NULL,
STRFAX               VARCHAR(14)          NULL
CONSTRAINT PK_TBLREVENDEDOR PRIMARY KEY  (ID_REVENDEDOR)
)
go


/*==============================================================*/
/* Table: TBLSALDOCARTEIRA                                      */
/*==============================================================*/
CREATE TABLE TBLSALDOCARTEIRA (
ID_SALDO              INT                  NOT NULL,
ID_CARTEIRA          INT                  NOT NULL,
DTEBAIXA             DATETIME             NOT NULL,
FLTVALORPAGO         FLOAT                NOT NULL
CONSTRAINT PK_TBLSALDOCARTEIRA PRIMARY KEY  (ID_SALDO)
)
go


/*==============================================================*/
/* Index: PK_IDSALDO                                            */
/*==============================================================*/
CREATE  CLUSTERED INDEX PK_IDSALDO ON TBLSALDOCARTEIRA (
ID_SALDO
)
go


/*==============================================================*/
/* Table: TBLTIPOCUSTO                                          */
/*==============================================================*/
CREATE TABLE TBLTIPOCUSTO (
ID_TIPOCUSTO          INT                  NOT NULL,
STRNOME              	VARCHAR(50)          NOT NULL
CONSTRAINT PK_TBLTIPOCUSTO PRIMARY KEY  (ID_TIPOCUSTO)
)
go


/*==============================================================*/
/* Index: PK_IDCUSTO                                            */
/*==============================================================*/
CREATE   INDEX PK_IDCUSTO ON TBLTIPOCUSTO (
ID_TIPOCUSTO
)
go


/*==============================================================*/
/* Index: IN_STRNOME                                            */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_STRNOME ON TBLTIPOCUSTO (
STRNOME
)
go


/*==============================================================*/
/* Table: TBLTIPOPAGAMENTO                                      */
/*==============================================================*/
CREATE TABLE TBLTIPOPAGAMENTO (
ID_TIPOPAGAMENTO      INT                  NOT NULL,
STRNOME              	VARCHAR(50)          NOT NULL
CONSTRAINT PK_TBLTIPOPAGAMENTO PRIMARY KEY  (ID_TIPOPAGAMENTO)
)
go


/*==============================================================*/
/* Index: IN_IDTIPOPAGAMENTO                                    */
/*==============================================================*/
CREATE  CLUSTERED INDEX IN_IDTIPOPAGAMENTO ON TBLTIPOPAGAMENTO (
ID_TIPOPAGAMENTO
)
go


/*==============================================================*/
/* Index: IN_STRNOME                                            */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_STRNOME ON TBLTIPOPAGAMENTO (
STRNOME
)
go


/*==============================================================*/
/* Table: TBLTIPOPRODUTO                                        */
/*==============================================================*/
CREATE TABLE TBLTIPOPRODUTO (
ID_TIPOPRODUTO        INT                  NOT NULL,
STRNOME              VARCHAR(60)          NOT NULL
CONSTRAINT PK_TBLTIPOPRODUTO PRIMARY KEY  (ID_TIPOPRODUTO)
)
go


/*==============================================================*/
/* Index: IN_IDTIPOPRODUTO                                      */
/*==============================================================*/
CREATE  CLUSTERED INDEX IN_IDTIPOPRODUTO ON TBLTIPOPRODUTO (
ID_TIPOPRODUTO
)
go


/*==============================================================*/
/* Index: IN_STRNOME                                            */
/*==============================================================*/
CREATE UNIQUE  INDEX IN_STRNOME ON TBLTIPOPRODUTO (
STRNOME
)
go


/*==============================================================*/
/* Table: TBLVENDA                                              */
/*==============================================================*/
CREATE TABLE TBLVENDA (
ID_VENDA              INT                  NOT NULL,
ID_ITEMCARRINHO      	INT                  NULL,
ID_TIPOPAGAMENTO      	INT                  NULL,
FLTVALORDESCONTO     	FLOAT                NOT NULL,
FLTVALORTOTAL        	FLOAT                NOT NULL,
BITSTATUSVENDA       	BIT                  NOT NULL
CONSTRAINT PK_TBLVENDA PRIMARY KEY  (ID_VENDA)
)
go


/*==============================================================*/
/* Index: IN_IDVENDA                                            */
/*==============================================================*/
CREATE  CLUSTERED INDEX IN_IDVENDA ON TBLVENDA (
ID_VENDA
)
go


ALTER TABLE TBLCARTEIRA
   ADD CONSTRAINT FK_TBLCARTEIRA_TBLCLIENTE FOREIGN KEY (ID_CLIENTE)
      REFERENCES TBLCLIENTE (ID_CLIENTE)
go


ALTER TABLE TBLCUSTO
   ADD CONSTRAINT FK_TBLCUSTO_TBLTIPOCUSTO FOREIGN KEY (ID_TIPOCUSTO)
      REFERENCES TBLTIPOCUSTO (ID_TIPOCUSTO)
go


ALTER TABLE TBLESTOQUE
   ADD CONSTRAINT FK_TBLESTOQUE_TBLPRODUTO FOREIGN KEY (ID_PRODUTO)
      REFERENCES TBLPRODUTO (ID_PRODUTO)
go


ALTER TABLE TBLITEMCARRINHO
   ADD CONSTRAINT FK_TBLITEMCARRINHO_TBLPRODUTO FOREIGN KEY (ID_PRODUTO)
      REFERENCES TBLPRODUTO (ID_PRODUTO)
go


ALTER TABLE TBLLOGIN
   ADD CONSTRAINT FK_TBLLOGIN_TBLFUNCIONARIO FOREIGN KEY (ID_FUNCIONARIO)
      REFERENCES TBLFUNCIONARIO (ID_FUNCIONARIO)
go


ALTER TABLE TBLPRODUTO
   ADD CONSTRAINT FK_TBLPRODUTO_TBLREVENDEDOR FOREIGN KEY (ID_REVENDEDOR)
      REFERENCES TBLREVENDEDOR (ID_REVENDEDOR)
go


ALTER TABLE TBLPRODUTO
   ADD CONSTRAINT FK_TBLPRODUTO_TBLTIPOPRODUTO FOREIGN KEY (ID_TIPOPRODUTO)
      REFERENCES TBLTIPOPRODUTO (ID_TIPOPRODUTO)
go


ALTER TABLE TBLSALDOCARTEIRA
   ADD CONSTRAINT FK_TBLSALDOCARTEIRA_TBLCARTEIRA FOREIGN KEY (ID_CARTEIRA)
      REFERENCES TBLCARTEIRA (ID_CARTEIRA)
go


ALTER TABLE TBLVENDA
   ADD CONSTRAINT FK_TBLCARRINHO_TBLITEMCARRINHO FOREIGN KEY (ID_ITEMCARRINHO)
      REFERENCES TBLITEMCARRINHO (ID_ITEMCARRINHO)
go


ALTER TABLE TBLVENDA
   ADD CONSTRAINT FK_TBLCARRINHO_TBLTIPOPAGAMENTO FOREIGN KEY (ID_TIPOPAGAMENTO)
      REFERENCES TBLTIPOPAGAMENTO (ID_TIPOPAGAMENTO)
go