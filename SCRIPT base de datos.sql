create database coperexprueba
go
use coperexprueba
go

CREATE TABLE Producto (
	Id int IDENTITY (10000,1) primary  key,
	Nombre nvarchar (150) not null,
	Descripcion nvarchar (150) not null,
	Stock int not null,
	Precio float not null
)

INSERT INTO Producto VALUES ('Camiseta', 'Camiseta de algodón de manga corta', 20, 15.99);
INSERT INTO Producto VALUES ('Zapatos', 'Zapatos de cuero para hombres', 10, 59.99);
INSERT INTO Producto VALUES ('Pantalones', 'Pantalones vaqueros para mujeres', 15, 29.99);
INSERT INTO Producto VALUES ('Teléfono móvil', 'Teléfono inteligente con pantalla táctil', 5, 499.99);
INSERT INTO Producto VALUES ('Bolígrafo', 'Bolígrafo de tinta azul', 50, 1.99);
INSERT INTO Producto VALUES ('Portátil', 'Ordenador portátil con procesador i5', 8, 899.99);
INSERT INTO Producto VALUES ('Cámara', 'Cámara digital de 20 megapíxeles', 12, 299.99);
INSERT INTO Producto VALUES ('Reloj', 'Reloj de pulsera resistente al agua', 18, 79.99);
INSERT INTO Producto VALUES ('Gafas de sol', 'Gafas de sol con protección UV', 7, 39.99);
INSERT INTO Producto VALUES ('Perfume', 'Fragancia floral para mujeres', 30, 49.99);
INSERT INTO Producto VALUES ('Bolsa de deporte', 'Bolsa de deporte resistente con múltiples compartimentos', 25, 24.99);
INSERT INTO Producto VALUES ('Guitarra', 'Guitarra acústica de madera maciza', 3, 199.99);
INSERT INTO Producto VALUES ('Maleta', 'Maleta rígida con ruedas giratorias', 20, 79.99);
INSERT INTO Producto VALUES ('Cepillo de dientes', 'Cepillo de dientes eléctrico con temporizador', 40, 29.99);
INSERT INTO Producto VALUES ('Auriculares', 'Auriculares inalámbricos con cancelación de ruido', 15, 149.99);

CREATE TABLE Inventario (
    Id int IDENTITY(10000, 1) PRIMARY KEY,
    ProductoId int FOREIGN KEY REFERENCES Producto(Id) ON DELETE CASCADE,
    FechaHora datetime,
    Movimiento varchar(50),
    Cantidad int,
    CONSTRAINT FK_Inventario_Producto FOREIGN KEY (ProductoId) REFERENCES Producto(Id)
);

--TRIGGER PARA ACTUALIZAR STOCK EN PRODUCTO
GO
CREATE TRIGGER ActualizarStock
ON Inventario
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Producto
    SET Stock = Stock + CASE WHEN i.Movimiento = 'entrada' THEN i.Cantidad ELSE -i.Cantidad END
    FROM Producto p
    INNER JOIN inserted i ON p.Id = i.ProductoId
    WHERE i.Movimiento IN ('entrada', 'salida')
END
GO


INSERT INTO Inventario VALUES (10001, GETDATE(), 'Entrada', 50);
INSERT INTO Inventario VALUES (10002, GETDATE(), 'Salida', 20);
INSERT INTO Inventario VALUES (10003, GETDATE(), 'Entrada', 30);
INSERT INTO Inventario VALUES (10001, GETDATE(), 'Salida', 10);
INSERT INTO Inventario VALUES (10004, GETDATE(), 'Entrada', 15);
INSERT INTO Inventario VALUES (10005, GETDATE(), 'Entrada', 25);
INSERT INTO Inventario VALUES (10006, GETDATE(), 'Entrada', 40);
INSERT INTO Inventario VALUES (10002, GETDATE(), 'Salida', 5);
INSERT INTO Inventario VALUES (10003, GETDATE(), 'Salida', 15);
INSERT INTO Inventario VALUES (10007, GETDATE(), 'Entrada', 20);

select * from Inventario order by Id desc;

SELECT 
    i.FechaHora,
    p.Nombre,
    p.Descripcion,
	CASE WHEN i.Movimiento = 'Entrada' THEN p.Stock - i.Cantidad ELSE p.Stock + i.Cantidad END AS [Inv. Inicial],
	p.Precio AS [Costo Unitario],
	CASE WHEN i.Movimiento = 'Entrada' THEN i.Cantidad ELSE 0 END AS Entrada,
    CASE WHEN i.Movimiento = 'Salida' THEN i.Cantidad ELSE 0 END AS Salida,
	p.Stock as [Inv. Final]
FROM 
    Inventario i
    INNER JOIN Producto p ON i.ProductoId = p.Id;