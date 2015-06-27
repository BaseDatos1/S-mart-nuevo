-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE InsertarProducto 
	@codigoExterno varchar(30),
	@codigoInterno varchar(30),
	@fechaVenc date,
	@alto int,
	@largo int,
	@ancho int,
	@volumen int,
	@peso float,
	@costo int,
	@precio int, 
	@desLarga varchar(100),
	@descCorta varchar(30),
	@marca varchar(20)
AS
BEGIN
	INSERT INTO Producto (CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca)
	VALUES(@codigoExterno, @codigoInterno, @fechaVenc, @alto, @largo, @ancho, @volumen, @peso, @costo, @precio, @desLarga, @descCorta, @marca);
END
GO
