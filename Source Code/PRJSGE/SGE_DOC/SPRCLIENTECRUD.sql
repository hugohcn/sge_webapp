set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

--**************************************************************************
--
-- procedure : sprClienteCRUD
--
-- Descrição : CRUD do objeto tblCliente
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
-- 12/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblCliente
--**************************************************************************

CREATE PROCEDURE [sprClienteCRUD]
(
 @sprstrOperacao     nchar(1),
 @sprintEspecificoR    smallint,
 @sprintIdCliente	int,
 @sprstrNome		varchar(70),
 @sprstrEndereco	varchar(70),
 @sprintNumero		int,
 @sprstrBairro		varchar(40),
 @sprstrCidade		varchar(40),
 @sprstrEstado		varchar(40),
 @sprstrCep			varchar(10),
 @sprstrTelefone	varchar(14),
 @sprstrCelular		varchar(14),
 @sprstrFax			varchar(14),
 @sprstrEmail		varchar(90)
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(ID_CLIENTE)+1,1)
 FROM tblCliente

 INSERT INTO tblCliente (id_Cliente, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strEmail, strTelefone, strCelular, strFax)
 VALUES (@strCodigo, @sprstrNome, @sprstrEndereco, @sprintNumero, @sprstrBairro, @sprstrCidade, @sprstrEstado, @sprstrCep, @sprstrTelefone, @sprstrCelular, @sprstrFax, @sprstrEmail)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Cliente
       FROM tblCliente
       WHERE id_Cliente = @sprintIdCliente)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Cliente, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strEmail, strTelefone, strCelular, strFax
   FROM tblCliente
   WHERE id_Cliente = @sprintIdCliente

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Cliente, strNome, strEndereco, intNumero, strBairro, strCidade, strEstado, strCep, strEmail, strTelefone, strCelular, strFax
    FROM tblCliente
   
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
   UPDATE tblCliente
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
		strEmail = @sprstrEmail
   WHERE id_Cliente = @sprintIdCliente
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblCliente
  WHERE id_Cliente = @sprintIdCliente
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprClienteCRUD TO sge


;