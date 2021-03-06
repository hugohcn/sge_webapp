set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
--**************************************************************************
--
-- procedure : sprItemCarrinhoCRUD
--
-- Descrição : CRUD do objeto tblItemCarrinho
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
-- 04/05/2009 Hugo Carvalho Betelhost	SPCRUD do objeto tblItemCarrinho
--**************************************************************************

CREATE PROCEDURE [dbo].[sprItemCarrinhoCRUD]
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdItemCarrinho		int,
 @sprintIdProduto			varchar(50),
 @sprintQuantidade			int,
 @sprintIdVenda				int
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_itemCarrinho)+1,1)
 FROM tblItemCarrinho

 INSERT INTO tblItemCarrinho (id_ItemCarrinho, id_Produto, intQuantidade, id_venda)
 VALUES (@strCodigo, @sprintIdProduto, @sprintQuantidade, @sprintIdVenda)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_itemCarrinho
       FROM tblItemCarrinho
       WHERE id_itemCarrinho = @sprintIdItemCarrinho)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_ItemCarrinho, id_Produto, intQuantidade, id_venda
   FROM tblItemCarrinho
   WHERE id_itemCarrinho = @sprintIdItemCarrinho

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_ItemCarrinho, id_Produto, intQuantidade, id_venda
    FROM tblItemCarrinho
   
	ELSE IF @sprintEspecificoR = 3   
	SELECT id_ItemCarrinho, id_Produto, intQuantidade, id_venda
	FROM tblItemCarrinho
	WHERE id_Venda = @sprintIdVenda

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

   UPDATE tblItemCarrinho
   SET	id_Produto    = @sprintIdProduto,
		intQuantidade    = @sprintQuantidade,
		id_venda = @sprintIdVenda
   WHERE id_ItemCarrinho = @sprintIdItemCarrinho
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblItemCarrinho
  WHERE id_ItemCarrinho = @sprintIdItemCarrinho
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprItemCarrinhoCRUD TO sge



