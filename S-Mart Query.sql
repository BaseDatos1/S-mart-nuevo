USE Supermercado_inteligente

CREATE TABLE Categoria(
	Id_cat int PRIMARY KEY, 
	Nombre varchar(30),
	Descripción varchar(50)
);


CREATE TABLE Marca(
	Nombre_marca varchar(20) PRIMARY KEY,
	Nombre_dist varchar(20)
);

CREATE TABLE Producto(
	CBExterno varchar(30) PRIMARY KEY,
	CBinterno varchar(30),
	Fecha date,
	Alto int check(Alto > 0),
	Largo int check(Largo > 0),
	Ancho int check(Ancho > 0),
	Volumen int check(Volumen > 0),
	Peso float check(Peso > 0),
	Costo int check(Costo > 0),
	Precio int check(Precio > 0), 
	Desc_Larga varchar(100),
	Desc_Corta varchar(30),
	Id_marca varchar(20) FOREIGN KEY REFERENCES Marca(Nombre_marca)
);

CREATE TABLE Persona(
	
	Cedula varchar(15) PRIMARY KEY,
	Nombre varchar(15),
	Apellido1 varchar(20),
	Apellido2 varchar(20),
	Teléfono varchar(9),
	Email varchar(30),
	Contraseña varchar(100)
);


INSERT INTO PERSONA (Cedula, Nombre, Apellido1, Apellido2, Teléfono, Email, Contraseña)
VALUES ('0000000000', 'Dummy', 'Dummy', 'Dummy', '00000000', 'dummy', 'dummy');

CREATE TABLE Admin_Sucursal(

	Cedula varchar(15) FOREIGN KEY REFERENCES Persona(Cedula),

	PRIMARY KEY (Cedula)
);


CREATE TABLE Cliente(

	Cedula varchar(15) FOREIGN KEY REFERENCES Persona(Cedula),
	PRIMARY KEY (Cedula)
);

INSERT INTO Cliente
VALUES ('0000000000');


CREATE TABLE Lista_De_Compras (

	ID_Lista int PRIMARY KEY,
	Nombre_Lista varchar(20),
	Fecha datetime,
	Monto int,
	Cedula_Cliente varchar(15) FOREIGN KEY REFERENCES Cliente(Cedula)
	ON DELETE CASCADE
);

CREATE TABLE Sucursal(
	Id_Sucursal int PRIMARY KEY,
	Nom_Sucursal varchar(20),
	Coordenadas varchar(30),
	Direccion varchar(60),
	Cédula_AdminSucursal varchar(15) FOREIGN KEY REFERENCES Admin_Sucursal(Cedula)
	ON DELETE NO ACTION
);

CREATE TABLE Telefono(
	Id_Sucursal int FOREIGN KEY REFERENCES Sucursal(Id_Sucursal),
	Teléfono varchar(9),
	PRIMARY KEY(Id_Sucursal, Teléfono) 
);


CREATE TABLE Cajero(
	
	Cedula varchar(15) FOREIGN KEY REFERENCES Persona(Cedula),
	ID_Sucursal int FOREIGN KEY REFERENCES Sucursal(Id_Sucursal),

	PRIMARY KEY (Cedula)		
);


CREATE TABLE Compra(
	Id_compra int PRIMARY KEY,
	Num_caja int check(Num_caja > 0),
	Fecha datetime,
	Peso int check(Peso > 0),
	Monto int check(Monto > 0),
	Modo_Pago varchar(20) not null,
	Cédula_Cliente varchar(15) not null default '0000000000' FOREIGN KEY REFERENCES Cliente(Cedula)
	ON DELETE CASCADE,
	Cédula_Cajero varchar(15) FOREIGN KEY REFERENCES Cajero(Cedula),
	Id_Sucursal int FOREIGN KEY REFERENCES Sucursal(Id_Sucursal)
);

CREATE TABLE Encargado_De_Inventario(

	Cedula varchar(15) FOREIGN KEY REFERENCES Persona(Cedula),
	ID_Sucursal int FOREIGN KEY REFERENCES Sucursal(Id_Sucursal),

	PRIMARY KEY (Cedula)
);


CREATE TABLE Tarjeta(
	
	Cedula_Cliente varchar(15) FOREIGN KEY REFERENCES Cliente(Cedula)
	ON DELETE CASCADE,
	Puntos int,

	PRIMARY KEY(Cedula_Cliente)
);


CREATE TABLE Guarda(
	Cedula_EncargadoDeInventario varchar (15) FOREIGN KEY REFERENCES Encargado_De_Inventario(Cedula),
	CBExterno_Producto varchar(30) FOREIGN KEY REFERENCES Producto(CBExterno)
	ON DELETE NO ACTION
	PRIMARY KEY (Cedula_EncargadoDeInventario,CBExterno_Producto)
);


CREATE TABLE Posee(
	ID_Compra int FOREIGN KEY REFERENCES Compra(ID_Compra),
	CBExterno_Producto varchar(30) FOREIGN KEY REFERENCES Producto(CBExterno)
	ON DELETE NO ACTION,
	Precio int check(Precio > 0),
	Cantidad int check(Cantidad > 0),

	PRIMARY KEY (ID_Compra, CBExterno_Producto)	
);


CREATE TABLE Vende(
	cantidad int,
	ID_Sucursal int FOREIGN KEY REFERENCES Sucursal(Id_Sucursal),
	CBExterno_Producto varchar(30) FOREIGN KEY REFERENCES Producto(CBExterno)
	ON DELETE NO ACTION,

	PRIMARY KEY (ID_Sucursal, CBExterno_Producto)
);


CREATE TABLE Asignado(

	ID_Categoria int FOREIGN KEY REFERENCES Categoria(Id_cat),
	CBExterno_Producto varchar(30) FOREIGN KEY REFERENCES Producto(CBExterno)
	ON DELETE NO ACTION,

	PRIMARY KEY (ID_Categoria,CBExterno_Producto)
);


CREATE TABLE Contiene(

	CBExterno_Producto varchar(30) FOREIGN KEY REFERENCES Producto(CBExterno)
	ON DELETE NO ACTION,

	ID_ListaCompras int FOREIGN KEY REFERENCES Lista_De_Compras(ID_Lista),

	Cantidad int check(Cantidad > 0),

	PRIMARY KEY (CBExterno_Producto, ID_ListaCompras)
)