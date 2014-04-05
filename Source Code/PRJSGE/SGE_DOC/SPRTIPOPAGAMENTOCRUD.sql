set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprTipoPagamentoCRUD
--
-- Descrição : CRUD do objeto tblTipoPagamento
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
-- 04/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblTipoPagamento
--**************************************************************************

CREATE PROCEDURE [sprTipoPagamentoCRUD]
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdTipoPagamento		int,
 @sprstrNome				varchar(60)
 
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_TipoPagamento)+1,1)
 FROM tblTipoPagamento

 INSERT INTO tblTipoPagamento (id_TipoPagamento, strNome)
 VALUES (@strCodigo, @sprstrNome)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_TipoPagamento
       FROM tblTipoPagamento
       WHERE id_TipoPagamento = @sprintIdTipoPagamento)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_TipoPagamento, strNome
   FROM tblTipoPagamento
   WHERE id_TipoPagamento = @sprintIdTipoPagamento

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_TipoPagamento, strNome
    FROM tblTipoPagamento
   
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

   UPDATE tblTipoPagamento
   SET	strNome    = @sprstrNome 
   WHERE id_TipoPagamento = @sprintIdTipoPagamento
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblTipoPagamento
  WHERE id_TipoPagamento = @sprintIdTipoPagamento
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprTipoPagamentoCRUD TO sge