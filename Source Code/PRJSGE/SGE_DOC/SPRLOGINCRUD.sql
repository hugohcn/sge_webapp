set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprLoginCRUD
--
-- Descrição : CRUD do objeto tblLogin
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
-- 04/05/2009 Hugo Carvalho Betelhost		SPCRUD do objeto tblLogin
-- 31/10/2009 Hugo Carvalho	Betelhost		Alteração da estrutura de dados para melhor consistência de informações.
--**************************************************************************

CREATE PROCEDURE sprLoginCRUD
(
	 @sprstrOperacao			nchar(1),
	 @sprintEspecificoR			smallint,
	 @sprintIdLogin				int,
	 @sprintIdFuncionario		int,
	 @sprbitIsAdmin				bit,
	 @sprdteDataCadastro		datetime,
	 @sprstrLogin				varchar(20),
	 @sprstrSenha				varchar(10)
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_Login)+1,1)
 FROM tblLogin

 INSERT INTO tblLogin (id_Login, id_Funcionario, isAdmin, dteCadastro, strLogin, strSenha)
 VALUES (@strCodigo, @sprintIdFuncionario, @sprbitIsAdmin, @sprdteDataCadastro, @sprstrLogin, @sprstrSenha)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Login
       FROM tblLogin
       WHERE id_Login = @sprintIdLogin)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Login, id_Funcionario, isAdmin, dteCadastro, strLogin, strSenha
   FROM tblLogin
   WHERE id_Login = @sprintIdLogin

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Login, id_Funcionario, isAdmin, dteCadastro, strLogin, strSenha
    FROM tblLogin
   
	ELSE IF @sprintEspecificoR = 3  
	SELECT id_Login, id_Funcionario, isAdmin, dteCadastro, strLogin, strSenha
	FROM tblLogin
	WHERE strLogin = @sprstrLogin AND strSenha = @sprstrSenha

   ELSE IF @sprintEspecificoR = 4   
	SELECT id_Login, id_Funcionario, isAdmin, dteCadastro, strLogin, strSenha
	FROM tblLogin
	WHERE isAdmin = 1
   
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

   UPDATE tblLogin
   SET	id_Funcionario    = @sprintIdFuncionario, 
		isAdmin = @sprbitIsAdmin,
		dteCadastro = @sprdteDataCadastro,
		strLogin = @sprstrLogin,
		strSenha = @sprstrSenha
   WHERE id_Login = @sprintIdLogin
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblLogin
  WHERE id_Login = @sprintIdLogin
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprLoginCRUD TO sge