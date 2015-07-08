CREATE TYPE ListaTelefonosUsuario AS
  VARRAY(4) OF VARCHAR2 (9);
  
  
CREATE TYPE Usuario AS OBJECT(
  Cedula VARCHAR2(15),
  Nombre VARCHAR2(15),
  Apellido1 VARCHAR2(20),
  Apellido2 VARCHAR2(20),
  Telefonos ListaTelefonosUsuario,
  Email VARCHAR2(30),
  Contraseña VARCHAR2(100),
  ORDER MEMBER FUNCTION ordenarPorNombre(U Usuario) RETURN INTEGER  
) NOT FINAL;

CREATE OR REPLACE TYPE BODY Usuario AS

  ORDER MEMBER FUNCTION ordenarPorNombre(U Usuario)
  RETURN INTEGER IS
  BEGIN
    IF Nombre < U.Nombre THEN
      RETURN -1;
    ELSIF Nombre > U.Nombre THEN
      RETURN 1;
    ELSE
      RETURN 0;
    END IF;        
  END ordenarPorNombre;
END;

/*Coleccion de tabla anidada Punto 2*/
CREATE TYPE Producto AS OBJECT(
  CBExterno VARCHAR2(30),
  CBInterno VARCHAR2(30),
  Fecha date,
  Alto INTEGER,
  Largo INTEGER, 
  Ancho INTEGER,
  Volumen INTEGER,
  Peso float,
  Costo INTEGER,
  Precio INTEGER,
  Desc_larga VARCHAR2(100),
  Desc_corta VARCHAR2(30),
  Marca VARCHAR2(20)
);


CREATE TYPE TablaProductos AS 
TABLE OF Producto;

/*Punto 4 tipo de objeto sucursal*/
CREATE TYPE Sucursal AS OBJECT(
  IdSuc INTEGER, 
  NombreSuc VARCHAR2(20),
  Coordenadas VARCHAR2(30),
  Direccion VARCHAR2(60),
  Administrador REF Usuario,
  Productos TablaProductos,
  MEMBER FUNCTION getDireccion RETURN VARCHAR2,
  MAP MEMBER FUNCTION ordenarSucursales RETURN INTEGER
);


CREATE OR REPLACE TYPE BODY Sucursal AS
  MEMBER FUNCTION getDireccion
  RETURN VARCHAR2 IS
  BEGIN
    RETURN Direccion;
  END getDireccion;

  MAP MEMBER FUNCTION ordenarSucursales RETURN INTEGER IS
  BEGIN
   RETURN IdSuc;
  END ordenarSucursales;
END;

CREATE TABLE Empleado OF Usuario
(Cedula PRIMARY KEY)
OBJECT IDENTIFIER PRIMARY KEY

CREATE TABLE Establecimiento OF Sucursal
(IdSuc PRIMARY KEY, Administrador SCOPE IS Empleado)
NESTED TABLE Productos STORE AS
ListaProductos(
(PRIMARY KEY(Nested_Table_Id, CBExterno))
ORGANIZATION INDEX COMPRESS)
RETURN AS LOCATOR; 

CREATE TYPE Cliente UNDER Usuario(
  numTarjeta VARCHAR(15),
  MEMBER FUNCTION getTarjeta RETURN VARCHAR2 
);

CREATE OR REPLACE TYPE BODY Cliente AS
  MEMBER FUNCTION getTarjeta
  RETURN VARCHAR2 IS
  BEGIN
    RETURN numTarjeta;
  END getTarjeta;
END;

INSERT INTO Empleado VALUES('116020879', 'Eduardo', 'Picado', 'Salas', ListaTelefonosUsuario('89076412', '22409715'), 'eduardo@gmail.com', '1234');
INSERT INTO Empleado VALUES('115940096', 'Larissa', 'Arroyo', 'Castillo', ListaTelefonosUsuario('87640123', '22369021'), 'lari24@gmail.com', 'hola');
INSERT INTO Empleado VALUES('115650402', 'Gaudy', 'Blanco', 'Meneses', ListaTelefonosUsuario('831254672', '22360981'), 'gbm1231@gmail.com', 'gaudy');


INSERT INTO Establecimiento VALUES(1, 'Paso Ancho', 'SE20', 'Monte Azul, Paso Ancho', (SELECT REF(e) FROM Empleado e WHERE e.Cedula = '116020879' ), TablaProductos());
INSERT INTO TABLE (SELECT e.Productos
                   FROM Establecimiento e
                   WHERE e.IdSuc = 1)
VALUES('128502','111502','20-Nov-2016', 10, 10, 10, 1000, 6.9, 2500, 2700, 'Pasta de Dientes Colgate', 'Pasta de Dientes', 'Colgate');

INSERT INTO TABLE (SELECT e.Productos
                   FROM Establecimiento e
                   WHERE e.IdSuc = 1)
VALUES('123456','111456','20-Oct-2016', 5, 5, 5, 125, 3.1, 800, 1000, 'Shampoo Dove para cabello teñido', 'Shampoo', 'Dove');


INSERT INTO Establecimiento VALUES(2, 'Tibas', 'SO30', 'Frente al parque de Tibas', (SELECT REF(e) FROM Empleado e WHERE e.Cedula = '115940096' ), TablaProductos());
INSERT INTO TABLE (SELECT e.Productos
                   FROM Establecimiento e
                   WHERE e.IdSuc = 2)
VALUES('123456','111456','20-Oct-2016', 5, 5, 5, 125, 3.1, 800, 1000, 'Shampoo Dove para cabello teñido', 'Shampoo', 'Dove');



INSERT INTO Empleado VALUES(Cliente('118907421', 'Laura', 'Solis', 'Gutierrez',  ListaTelefonosUsuario('88912431', '22291903'), 'laurita@hotmail.com', 'holaAdios', '118907421'));

INSERT INTO Empleado VALUES(Cliente('114754236', 'Sonia', 'Meneses', 'Arroyo',  ListaTelefonosUsuario('22135907', '89955127'), 'soniama@gmail.com', '123456', '114754236'));

/*Se obtienen los teléfonos del empleado cuya Cedula es: 116020879 */
SELECT e.Nombre, e.Telefonos
FROM Empleado e,
TABLE (e.Telefonos) t
where e.Cedula = '116020879' 

/*Se obtiene el id del establecimiento, junto con los productos (el código externo, el código interno y la descripción del producto) que se encuentran en este establecimiento */
SELECT es.IdSuc, p.CBExterno, p.CBInterno, p. Desc_larga
FROM Establecimiento es,
TABLE (es.Productos) p
where es.IdSuc = 1

/*Se utiliza la desreferencia para conocer el nombre y la cedula del administrador del establecimiento 1 */
SELECT es.IdSuc, DEREF(es.Administrador).Nombre, DEREF(es.Administrador).Cedula
FROM Establecimiento es  WHERE es.IdSuc= 1;

/*Se obtiene el atributo (número de tarjeta) del cliente */
SELECT E.Nombre, TREAT(VALUE(E) AS Cliente).numTarjeta
FROM Empleado E

/*Se obtiene el numero de tarjeta de los usuarios que pertenecen a la categoría de Clientes*/
Select E.nombre,
TREAT(VALUE(E) AS Cliente).numTarjeta
from Empleado E
WHERE VALUE(E)  IS OF (Cliente);

/*Se verifica el metodo order el cual ordena por nombre a los usuarios*/
SELECT e.Nombre
FROM Empleado e
ORDER BY VALUE(e);

/*Se verifica el metodo map el cual ordena por el id del establecimiento */
SELECT es.IdSuc, es.NombreSuc
FROM Establecimiento es
ORDER BY VALUE(es); 

/*Se utiliza el método de getDireccion para conocer la direccion del establecimiento */
SELECT es.IdSuc, es.NombreSuc, es.getDireccion()
from Establecimiento es 
where es.IdSuc = 2;,l










