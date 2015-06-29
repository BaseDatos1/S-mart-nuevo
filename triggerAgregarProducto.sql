SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER ProductoComprado
   ON  Posee
  INSTEAD OF Insert
AS 
DECLARE @id_compra varchar(30),  @productoComprado varchar(15), @precioProducto int, @precioActual int,
@precioActualizado int, @cantidadProductoActual int, @prueba varchar(15),  @pesoCompra float, @pesoProducto float, @cantidad int
select @id_compra = i.Id_compra, @productoComprado = i.CBEXTERNO_Producto, @precioActual = i.Precio,
@cantidadProductoActual = i.cantidad
from inserted i;

	if((select CBExterno_Producto 
	from Posee where CBExterno_Producto =  @productoComprado AND ID_Compra =  @id_compra) IS NOT NULL )
	BEGIN
		set @precioProducto = (select precio
		from Producto 
		where CBExterno = @productoComprado)
	
		set @precioActual = (select Precio
		from Posee
		where CBExterno_Producto =  @productoComprado AND ID_Compra = @id_compra  ) 
		set @cantidadProductoActual = (select Cantidad
		from Posee
		where CBExterno_Producto =  @productoComprado  AND ID_Compra = @id_compra)
	
		set  @pesoProducto = (select Peso from Producto where CBExterno = @productoComprado)

		set @cantidad = (select Vende.cantidad from Vende WHERE Vende.CBExterno_Producto = @productoComprado and Vende.ID_Sucursal = (select Cajero.ID_Sucursal from Cajero WHERE Cajero.Cedula = (select Compra.Cédula_Cajero from Compra WHERE Compra.Id_compra = @id_compra)))
		
		set @precioActualizado = @precioActual  + @precioProducto;
		set @cantidadProductoActual = @cantidadProductoActual + 1;
		set @pesoCompra = @pesoCompra + @pesoProducto
	
		UPDATE Posee
		set Precio = @precioActualizado, Cantidad = @cantidadProductoActual
		where CBExterno_Producto =  @productoComprado AND ID_Compra = @id_compra
	
		UPDATE Compra
		set Peso = @pesoCompra where Id_compra = @id_compra 

		UPDATE Vende
		set cantidad = @cantidad - 1 where CBExterno_Producto = @productoComprado AND  ID_Sucursal = (select Cajero.ID_Sucursal from Cajero WHERE Cajero.Cedula = (select Compra.Cédula_Cajero from Compra WHERE Compra.Id_compra = @id_compra)) 
	END
	ELSE BEGIN
		insert into Posee(ID_Compra, CBExterno_Producto, Precio, Cantidad)
		values( @id_compra, @productoComprado, @precioActual, @cantidadProductoActual)	

		set @cantidad = (select Vende.cantidad from Vende WHERE Vende.CBExterno_Producto = @productoComprado and Vende.ID_Sucursal = (select Cajero.ID_Sucursal from Cajero WHERE Cajero.Cedula = (select Compra.Cédula_Cajero from Compra WHERE Compra.Id_compra = @id_compra)))
		UPDATE Vende
		set cantidad = @cantidad - 1 where CBExterno_Producto = @productoComprado AND  ID_Sucursal = (select Cajero.ID_Sucursal from Cajero WHERE Cajero.Cedula = (select Compra.Cédula_Cajero from Compra WHERE Compra.Id_compra = @id_compra)) 
	END
GO