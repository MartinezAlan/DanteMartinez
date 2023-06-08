USE [SistemaGestion]


-- Actividades Clase 10

-- 1

SELECT	 Id,
		 Nombre,
		 Apellido,
		 NombreUsuario,
		 Contraseña,
		 Mail

FROM Usuario

WHERE NombreUsuario LIKE 'tcasazza'
-- 2 

SELECT Id,
       Nombre,
	   Apellido,
	   NombreUsuario,
	   Contraseña,
	   Mail
FROM Usuario
WHERE Apellido LIKE 'c%' 


SELECT Id,
       Nombre,
	   Apellido,
	   NombreUsuario,
	   Contraseña,
	   Mail
FROM Usuario
WHERE Contraseña LIKE 'c%' 

--3

SELECT  Descripciones
FROM	Producto
WHERE	IdUsuario = 1

-- 4

INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES ('Juan', 'Perez', 'JPerez', 'SoyJuanPerez', 'Juanperez@gmail.com')

-- 5

INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES ('Shorts', 200, 400, 10, 1)

-- Actividades Clase 11

-- 1

UPDATE Usuario
SET Contraseña = 'Tobiascoder'
WHERE Nombre = 'Tobias'

-- 2

DELETE FROM Usuario
WHERE Apellido = 'Perez'

-- 3

UPDATE Producto
SET Stock = '0'
WHERE Descripciones = 'Buzo'

-- 4

DELETE FROM Producto
WHERE Descripciones = 'Musculosa'

--5

SELECT Usuario.Nombre, Usuario.Apellido
FROM Usuario
INNER JOIN Producto ON Usuario.Id = Producto.IdUsuario


-----------------------------DESAFIO CODER-----------------------------

-- Actividad 1
SELECT pv.Id, pv.Stock, p.Descripciones, v.Comentarios
FROM ProductoVendido pv
INNER JOIN Producto p ON pv.IdProducto = p.Id
INNER JOIN Venta v ON pv.IdVenta = v.Id;

-- Actividad 2
SELECT p.Descripciones, v.Comentarios
FROM ProductoVendido pv
INNER JOIN Producto p ON pv.IdProducto = p.Id
INNER JOIN Venta v ON pv.IdVenta = v.Id
WHERE p.Descripciones LIKE '%ina' AND p.PrecioVenta > 10000;

-- Actividad 3
INSERT INTO Venta (Comentarios) VALUES ('');
INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES ('Aceite de Girasol Cocinera', 350, 500, 20, 1)
INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta) VALUES (20, 7, 1);