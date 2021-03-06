set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
--**************************************************************************
--
-- procedure : sprEstoqueCRUD
--
-- Descrição : CRUD do objeto tblEstoque
--
-- Argumentos:
--
--
--**************************************************************************
--
-- Manutenção
--
--   Data     Autor   Empresa   Descrição
-- ---------- ------------- --------------- ---------------------------
-- 12/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblEstoque
-- 27/06/2009 Hugo Carvalho	Betelhost	Adicionadas colunas de ValorTotalCusto e ValorTotalVenda
--**************************************************************************

CREATE PROCEDURE [dbo].[sprEstoqueCRUD]
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdProduto			varchar(50),
 @sprdteEntrada				datetime,
 @sprintQuantidadeEntrada	int,
 @sprintQuantidadeVendida	int,
 @sprfltValorCustoUnitario	numeric(9,2),
 @sprfltValorVendaUnitario	numeric(9,2),
 @sprfltValorTotalCusto		numeric(9,2),
 @sprfltValorTotalVenda		numeric(9,2)
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN

 INSERT INTO tblEstoque (id_Produto, dteEntrada, intQuantidadeEntrada, intQuantidadeVendida, fltValorCustoUnitario, fltValorVendaUnitario, valorTotalCusto, valorTotalVenda)
 VALUES (@sprintIdProduto, @sprdteEntrada, @sprintQuantidadeEntrada, @sprintQuantidadeVendida, @sprfltValorCustoUnitario, @sprfltValorVendaUnitario, @sprfltValorTotalCusto, @sprfltValorTotalVenda)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Produto
       FROM tblEstoque
       WHERE id_Produto = @sprintIdProduto)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Produto, dteEntrada, intQuantidadeEntrada, intQuantidadeVendida, fltValorCustoUnitario, fltValorVendaUnitario, valorTotalCusto, valorTotalVenda
   FROM tblEstoque
   WHERE id_Produto = @sprintIdProduto

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Produto, dteEntrada, intQuantidadeEntrada, intQuantidadeVendida, fltValorCustoUnitario, fltValorVendaUnitario, valorTotalCusto, valorTotalVenda
    FROM tblEstoque
   
   ELSE IF @sprintEspecificoR = 3   
   SELECT id_Produto, dteEntrada, intQuantidadeEntrada, intQuantidadeVendida, fltValorCustoUnitario, fltValorVendaUnitario, valorTotalCusto, valorTotalVenda
   FROM tblEstoque
   WHERE dteEntrada = @sprdteEntrada
   
   --ELSE IF @sprintEspecificoR = 4
    --SELECT intPessoa, cd_colabr, strLogin, strSenha, intCurriculoSituacao, cd_colabr_Situacao, strObservacao, cd_colabr_Observacao, dteAtualizacao
    --FROM tblPessoa
    --WHERE intCurriculoSituacao = @sprintCurriculoSituacao

   --ELSE IF @sprintEspecificoR = 5
    --SELECT intPessoa, cd_colabr, strLogin, strSenha, intCurriculoSituacao, cd_colabr_Situacao, strObservacao, cd_colabr_Observacao, dteAtualizacao
    --FROM tblPessoa
    --WHERE cd_colabr = @sprstrColaborador
  END
ELSE 

IF @sprstrOperacao = 'U'
   UPDATE tblEstoque
   SET	
		dteEntrada = @sprdteEntrada,
		intQuantidadeEntrada = @sprintQuantidadeEntrada,
		intQuantidadeVendida = @sprintQuantidadeVendida, 
		fltValorCustoUnitario = @sprfltValorCustoUnitario, 
		fltValorVendaUnitario = @sprfltValorVendaUnitario,
		valorTotalCusto = @sprfltValorTotalCusto,
		valorTotalVenda = @sprfltValorTotalVenda
   WHERE id_Produto = @sprintIdProduto
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblEstoque
  WHERE id_Produto = @sprintIdProduto
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprEstoqueCRUD TO sge
