set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprTipoProdutoCRUD
--
-- Descrição : CRUD do objeto tblTipoProduto
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
-- 04/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblTipoProduto
--**************************************************************************

CREATE PROCEDURE [sprTipoProdutoCRUD]
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdTipoProduto		int,
 @sprstrNome				varchar(60)
 
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_TipoProduto)+1,1)
 FROM tblTipoProduto

 INSERT INTO tblTipoProduto (id_TipoProduto, strNome)
 VALUES (@strCodigo, @sprstrNome)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_TipoProduto
       FROM tblTipoProduto
       WHERE id_TipoProduto = @sprintIdTipoProduto)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_TipoProduto, strNome
   FROM tblTipoProduto
   WHERE id_TipoProduto = @sprintIdTipoProduto

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_TipoProduto, strNome
    FROM tblTipoProduto
   
	--ELSE IF @sprintEspecificoR = 3   
	--SELECT intLogin, intFuncionario, strLogin, strSenha, bitIsAdmin, bitIsManager
	--FROM tblLogin
	--WHERE strLogin = @sprstrLogin AND strSenha = @sprstrSenha

   --ELSE IF @sprintEspecificoR = 3   
    --SELECT intPessoa, cd_colabr, strLogin, strSenha, intCurriculoSituacao, cd_colabr_Situacao, strObservacao, cd_colabr_Observacao, dteAtualizacao
    --FROM tblPessoa
    --WHERE strLogin = @sprstrLogin
   
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

   UPDATE tblTipoProduto
   SET	strNome    = @sprstrNome 
   WHERE id_TipoProduto = @sprintIdTipoProduto
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblTipoProduto
  WHERE id_TipoProduto = @sprintIdTipoProduto
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprTipoProdutoCRUD TO sge