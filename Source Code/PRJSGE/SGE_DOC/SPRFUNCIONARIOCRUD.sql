set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprFuncionarioCRUD
--
-- Descrição : CRUD do objeto tblFuncionario
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
-- 12/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblFuncionario
--**************************************************************************

CREATE PROCEDURE [sprFuncionarioCRUD]
(
 @sprstrOperacao		nchar(1),
 @sprintEspecificoR		smallint,
 @sprintIdFuncionario	int,
 @sprstrNome			varchar(70),
 @sprstrEndereco		varchar(70),
 @sprintNumero			int,
 @sprstrBairro			varchar(40),
 @sprstrCidade			varchar(40),
 @sprstrEstado			varchar(40),
 @sprstrCep				varchar(10),
 @sprstrTelefone		varchar(14),
 @sprstrCelular			varchar(14),
 @sprstrFax				varchar(14),
 @sprstrEmail			varchar(90),
 @sprstrCarteiraTrabalho	varchar(10),
 @sprstrSerieCt			varchar(10),
 @sprstrUfCt			varchar(2)
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_Funcionario)+1,1)
 FROM tblFuncionario

 INSERT INTO tblFuncionario (id_Funcionario, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strTelefone, strCelular, strFax, strEmail,
						 strCarteiraTrabalho, strSerieCt, strUfCt)
 VALUES (@strCodigo, @sprstrNome, @sprstrEndereco, @sprintNumero, @sprstrBairro, @sprstrCidade, @sprstrEstado, @sprstrCep, @sprstrTelefone, @sprstrCelular, @sprstrFax, @sprstrEmail,
		 		@sprstrCarteiraTrabalho, @sprstrSerieCt, @sprstrUfCt)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Funcionario
       FROM tblFuncionario
       WHERE id_Funcionario = @sprintIdFuncionario)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Funcionario, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strTelefone, strCelular, strFax, strEmail,
		  strCarteiraTrabalho, strSerieCt, strUfCt
   FROM tblFuncionario
   WHERE id_Funcionario = @sprintIdFuncionario

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Funcionario, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strTelefone, strCelular, strFax, strEmail,
		  strCarteiraTrabalho, strSerieCt, strUfCt
    FROM tblFuncionario
   
   --ELSE IF @sprintEspecificoR = 3   
   --SELECT id_Carteira, idCliente, fltValorTotal, dteDataPagamento, fltValorCredito, bitStatusCarteira
   --FROM tblCarteira
   --WHERE idCliente = @sprintIdCliente
   
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
   UPDATE tblFuncionario
   SET	strNome = @sprstrNome,
		strEndereco = @sprstrEndereco,
		intNumero = @sprintNumero,
		strBairro = @sprstrBairro,
		strCidade = @sprstrCidade,
		strEstado = @sprstrEstado,
		strCep = @sprstrCep,
		strTelefone = @sprstrTelefone,
		strCelular = @sprstrCelular,
		strFax = @sprstrFax,
		strEmail = @sprstrEmail,
		strCarteiraTrabalho = @sprstrCarteiraTrabalho,  
		strSerieCt = @sprstrSerieCt,
		strUfCt = @sprstrUfCt
   WHERE id_Funcionario = @sprintIdFuncionario
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblFuncionario
  WHERE id_Funcionario = @sprintIdFuncionario
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprFuncionarioCRUD TO sge