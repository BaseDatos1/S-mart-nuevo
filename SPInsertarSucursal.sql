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
CREATE PROCEDURE InsertarSucursal 	
	@ID_Sucursal int,
	@Nombre_Sucursal varchar(20),
	@Coordenadas varchar(30),
	@Direccion varchar(60),
	@Cedula_AdminSucursal varchar(15)	
	
AS
BEGIN
	INSERT INTO Sucursal(Id_Sucursal,Nom_Sucursal,Coordenadas,Direccion,Cédula_AdminSucursal)
	VALUES(@ID_Sucursal, @Nombre_Sucursal, @Coordenadas, @Direccion, @Cedula_AdminSucursal);
END
GO
