CREATE PROCEDURE uspUnidadeInserir
	@UnidadeNome nvarchar(80),
	@UnidadeCidade nvarchar(50),
	@UnidadeEstado nvarchar(2),
	@UnidadePais nvarchar(45)
AS
BEGIN
	INSERT INTO tblUnidade
	(
		UnidadeNome,
		UnidadeCidade,
		UnidadeEstado,
		UnidadePais
	)
	VALUES
	(
		@UnidadeNome,
		@UnidadeCidade,
		@UnidadeEstado,
		@UnidadePais
	)
	SELECT @@IDENTITY AS RETORNO
END




CREATE PROCEDURE uspUnidadeAlterar
	@UnidadeID int,
	@UnidadeNome nvarchar(80),
	@UnidadeCidade nvarchar(50),
	@UnidadeEstado nvarchar(2),
	@UnidadePais nvarchar(45)
AS
BEGIN
	UPDATE tblUnidade
	SET
		UnidadeNome = @UnidadeNome,
		UnidadeCidade = @UnidadeCidade,
		UnidadeEstado = @UnidadeEstado,
		UnidadePais = @UnidadePais
	WHERE
		UnidadeID = @UnidadeID

	SELECT @UnidadeID AS RETORNO
END




CREATE PROCEDURE uspUnidadeExcluir
	@UnidadeID int
AS
BEGIN
	DELETE FROM tblUnidade
	WHERE
		UnidadeID = @UnidadeID

	SELECT @UnidadeID AS RETORNO
END



CREATE PROCEDURE uspUnidadeConsultarPorNome
	@UnidadeNome nvarchar(80)
AS
BEGIN

	SELECT
		UnidadeID,
		UnidadeNome,
		UnidadeCidade,
		UnidadeEstado,
		UnidadePais
	FROM
		tblUnidade
	WHERE
		UnidadeNome LIKE '%' + @UnidadeNome + '%'

END