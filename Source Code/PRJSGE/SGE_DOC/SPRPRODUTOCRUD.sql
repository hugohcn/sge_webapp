set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprProdutoCRUD
--
-- Descrição : CRUD do objeto tblProduto
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
-- 04/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblProduto
--**************************************************************************

CREATE PROCEDURE [sprProdutoCRUD]
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdProduto			varchar(50),
 @sprintIdTipoProduto		int,
 @sprintIdRevendedor		int,
 @sprstrNome				varchar(40),
 @sprdteCadastro			datetime,
 @sprfltValor				float
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN

 INSERT INTO tblProduto (id_Produto, id_TipoProduto, id_Revendedor, strNome, dteCadastro, fltValor)
 VALUES (@sprintIdProduto, @sprintIdTipoProduto, @sprintIdRevendedor, @sprstrNome, @sprdteCadastro, @sprfltValor)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Produto
       FROM tblProduto
       WHERE id_Produto = @sprintIdProduto)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Produto, id_TipoProduto, id_Revendedor, strNome, dteCadastro, fltValor
   FROM tblProduto
   WHERE id_Produto = @sprintIdProduto

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Produto, id_TipoProduto, id_Revendedor, strNome, dteCadastro, fltValor
    FROM tblProduto
   
	ELSE IF @sprintEspecificoR = 3   
	SELECT id_Produto, id_TipoProduto, id_Revendedor, strNome, dteCadastro, fltValor
   FROM tblProduto
   WHERE id_TipoProduto = @sprintIdTipoProduto

   ELSE IF @sprintEspecificoR = 4   
    SELECT id_Produto, id_TipoProduto, id_Revendedor, strNome, dteCadastro, fltValor
   FROM tblProduto
    WHERE id_Revendedor = @sprintIdRevendedor
   
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

   UPDATE tblProduto
   SET	id_TipoProduto    = @sprintIdTipoProduto, 
		id_Revendedor = @sprintIdRevendedor,
		strNome = @sprstrNome,
		dteCadastro = @sprdteCadastro,
		fltValor = @sprfltValor
   WHERE id_Produto = @sprintIdProduto
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblProduto
  WHERE id_Produto = @sprintIdProduto
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprProdutoCRUD TO sge