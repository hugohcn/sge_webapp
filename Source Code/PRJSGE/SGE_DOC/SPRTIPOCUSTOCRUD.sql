set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprTipoCusto
--
-- Descrição : CRUD do objeto sprTipoCusto
--
-- Argumentos:
--
--
--**************************************************************************
--
-- Manutenção
--
-- Data		  Autor			Empresa			Descrição
-- ---------- ------------- --------------- ---------------------------
-- 04/05/2009 Hugo Carvalho Betelhost		SPCRUD do objeto tblTipoCusto
-- 31/10/2009 Hugo Carvalho Betelhost		Altualização da estrutura de dados para melhor consistência das informações.
--**************************************************************************

CREATE PROCEDURE sprTipoCusto
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdTipoCusto			smallint,
 @sprstrNome				varchar(50)
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_TipoCusto)+1,1)
 FROM tblTipoCusto

 INSERT INTO tblTipoCusto (id_TipoCusto, strNome)
 VALUES (@strCodigo, @sprstrNome)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_TipoCusto
       FROM tblTipoCusto
       WHERE id_TipoCusto = @sprintIdTipoCusto)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_TipoCusto, strNome
   FROM tblTipoCusto
   WHERE id_TipoCusto = @sprintIdTipoCusto

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_TipoCusto, strNome
    FROM tblTipoCusto
   
	--ELSE IF @sprintEspecificoR = 3  
	--SELECT idLogin, idFuncionario, isAdmin, dteCadastro, strLogin, strSenha
	--FROM tblLogin
	--WHERE strLogin = @sprstrLogin AND strSenha = @sprstrSenha

    --ELSE IF @sprintEspecificoR = 4   
	--SELECT idLogin, idFuncionario, isAdmin, dteCadastro, strLogin, strSenha
	--FROM tblLogin
	--WHERE isAdmin = 1
   
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

   UPDATE tblTipoCusto
   SET	strNome = @sprstrNome 
   WHERE id_TipoCusto = @sprintIdTipoCusto
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblTipoCusto
  WHERE id_TipoCusto = @sprintIdTipoCusto
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprTipoCustoCRUD TO sge