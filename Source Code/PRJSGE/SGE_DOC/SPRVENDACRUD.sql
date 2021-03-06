set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
--**************************************************************************
--
-- procedure : sprVendaCRUD
--
-- Descrição : CRUD do objeto tblVenda
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
-- 04/05/2009 Hugo Carvalho Betelhost		SPCRUD do objeto tblVenda
-- 30/06/2009 Hugo Carvalho	Betelhost		Adicionada coluna de data da venda.
--**************************************************************************

CREATE PROCEDURE [dbo].[sprVendaCRUD]
(
 @sprstrOperacao			nchar(1),
 @sprintEspecificoR			smallint,
 @sprintIdVenda				int,
 @sprintIdItemCarrinho		int,
 @sprintIdTipoPagamento		int,
 @sprfltValorDesconto		float,
 @sprfltValorTotal			float,
 @sprbitStatusVenda			bit,
 @sprdteVenda				datetime
)
AS

DECLARE
@strExiste       nchar(1),
@strCodigo       int

SET NOCOUNT OFF

IF @sprstrOperacao = 'C'
BEGIN
 SELECT @strCodigo = ISNULL(MAX(id_Venda)+1,1)
 FROM tblVenda

 INSERT INTO tblVenda (id_Venda, id_TipoPagamento, fltValorDesconto, fltValorTotal, bitStatusVenda, dteVenda)
 VALUES (@strCodigo, @sprintIdTipoPagamento, @sprfltValorDesconto, @sprfltValorTotal, @sprbitStatusVenda, @sprdteVenda)

END
ELSE 

IF @sprstrOperacao = 'R'

 IF @sprintEspecificoR = 1
 BEGIN
  IF NOT EXISTS(SELECT id_Venda
       FROM tblVenda
       WHERE id_Venda = @sprintIdVenda)

    SELECT @strExiste = 'N'
  ELSE
  BEGIN
   SELECT id_Venda, id_TipoPagamento, fltValorDesconto, fltValorTotal, bitStatusVenda, dteVenda
   FROM tblVenda
   WHERE id_Venda = @sprintIdVenda

   SELECT @strExiste = 'S'
  END
 END 
 ELSE 
  BEGIN    
   IF @sprintEspecificoR = 2   
    SELECT id_Venda, id_TipoPagamento, fltValorDesconto, fltValorTotal, bitStatusVenda, dteVenda
    FROM tblVenda
   
	ELSE IF @sprintEspecificoR = 3   
	SELECT MAX(id_Venda) FROM tblVenda

   ELSE IF @sprintEspecificoR = 3   
   SELECT id_Venda, id_TipoPagamento, fltValorDesconto, fltValorTotal, bitStatusVenda, dteVenda
    FROM tblVenda
   WHERE dteVenda = @sprdteVenda
   
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

   UPDATE tblVenda
   SET	id_TipoPagamento    = @sprintIdTipoPagamento,
		fltValorDesconto = @sprfltValorDesconto,
		fltValorTotal = @sprfltValorTotal,
		bitStatusVenda = @sprbitStatusVenda,
		dteVenda	=	@sprdteVenda
   WHERE id_Venda = @sprintIdVenda
ELSE 

IF @sprstrOperacao = 'D'
  DELETE FROM tblVenda
  WHERE id_Venda = @sprintIdVenda
ELSE RETURN -1

RETURN 0

GRANT EXECUTE ON sprVendaCRUD TO sge

