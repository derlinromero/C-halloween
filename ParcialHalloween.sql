CREATE TABLE Usuarios (
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(100) NOT NULL,
	nombreDeUsuario NVARCHAR(100) UNIQUE NOT NULL,
	contraseña NVARCHAR(100) NOT NULL,
	rol NVARCHAR(50) CHECK (rol IN ('Participante', 'Administrador')),
	disfraz NVARCHAR(200),
	codigo_inv NVARCHAR(20) UNIQUE,
	foto NVARCHAR(MAX)
);

CREATE TABLE ParadasDulces (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    cantidadIni INT CHECK(cantidadIni >= 0),
    cantidadAct INT CHECK(cantidadAct >= 0),
    TipoDulces NVARCHAR(50)
);

CREATE TABLE Puntuaciones (
	id INT PRIMARY KEY IDENTITY(1,1),
	puntos INT CHECK (puntos BETWEEN 1 AND 10),
	usuarioID INT NOT NULL,
	usuarioCalificadorID INT NOT NULL,
	FOREIGN KEY (usuarioID) REFERENCES Usuarios(id),
	FOREIGN KEY (usuarioCalificadorID) REFERENCES Usuarios(id)
);

CREATE PROCEDURE AgregarUsuario
    @nombre NVARCHAR(100),
    @nombreDeUsuario NVARCHAR(100),
    @contraseña NVARCHAR(100),
    @rol NVARCHAR(50),
    @disfraz NVARCHAR(200),
    @codigoInv NVARCHAR(20),
    @foto NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Usuarios (nombre, nombreDeUsuario, contraseña, rol, disfraz, codigo_inv, foto)
    VALUES (@nombre, @nombreDeUsuario, @contraseña, @rol, @disfraz, @codigoInv, @foto);
END;

CREATE PROCEDURE ActualizarUsuario
    @id INT,
    @nombre NVARCHAR(100),
    @nombreDeUsuario NVARCHAR(100),
    @contraseña NVARCHAR(100),
    @rol NVARCHAR(50),
    @disfraz NVARCHAR(200),
    @codigoInv NVARCHAR(20),
    @foto NVARCHAR(MAX)
AS
BEGIN
    UPDATE Usuarios
    SET
        nombre = @nombre,
        nombreDeUsuario = @nombreDeUsuario,
        contraseña = @contraseña,
        rol = @rol,
        disfraz = @disfraz,
        codigo_inv = @codigoInv,
        foto = @foto
    WHERE id = @id;
END

CREATE PROCEDURE TablaDePuntajes
AS
BEGIN
	SELECT u.nombre, SUM(p.puntos) AS 'puntos' 
	FROM Usuarios AS u 
	JOIN Puntuaciones AS p ON u.id = p.usuarioID WHERE u.rol = 'Participante' 
	GROUP BY u.nombre ORDER BY SUM(p.puntos) DESC, u.nombre
END;

CREATE PROCEDURE RankingDisfraces
AS
BEGIN
	SELECT TOP 3 u.nombre, SUM(p.puntos) AS 'puntos', u.disfraz, u.foto
	FROM Usuarios AS u 
	JOIN Puntuaciones AS p ON u.id = p.usuarioID WHERE u.rol = 'Participante' 
	GROUP BY u.nombre, u.disfraz, u.foto ORDER BY SUM(p.puntos) DESC, u.nombre
END;

/*CREATE TRIGGER trg_uppercase_codigo_inv
ON Usuarios
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE u
    SET u.codigo_inv = UPPER(i.codigo_inv)
    FROM Usuarios u
    INNER JOIN inserted i ON u.id = i.id;
END;*/

INSERT INTO Usuarios (nombre, nombreDeUsuario, contraseña, rol, disfraz, codigo_inv, foto)
VALUES ('John Doe', 'johndoe', 'password123', 'Participante', 'Vampiro', 'INV123', 'C:\Users\derli\Pictures\Cara Youtuber.jpg');

INSERT INTO Usuarios (nombre, nombreDeUsuario, contraseña, rol, disfraz, codigo_inv, foto)
VALUES('Juanito Alimaña', 'juanali', '123password', 'Participante', 'Bob Esponja', 'QWD42R', 'C:\Users\derli\Pictures\SAJ.jpg')

INSERT INTO Usuarios (nombre, nombreDeUsuario, contraseña, rol, disfraz, codigo_inv, foto)
VALUES ('Jane Smith', 'janesmith', 'securepass', 'Administrador', NULL, NULL, NULL);

INSERT INTO ParadasDulces (nombre, cantidadIni, cantidadAct, TipoDulces)
VALUES 
('Casa 666', 100, 100, 'Caramelos'),
('El Cementerio', 200, 200, 'Gomitas'),
('Casa Embrujada', 150, 150, 'Chocolates');

INSERT INTO Puntuaciones (puntos, usuarioID, usuarioCalificadorID)
VALUES
(8, 1, 4),
(9, 1, 4),
(7, 4, 1),
(10, 4, 1),
(2, 4, 1);

INSERT INTO Puntuaciones (puntos, usuarioID, usuarioCalificadorID)
VALUES
(10, 5, 1),
(10, 5, 1);

ALTER TABLE Usuarios
ADD CONSTRAINT chk_codigo_inv CHECK (LEN(codigo_inv) = 6);

-- DE AQUI PARA ABAJO NO ES NECESARIO

SELECT * FROM Usuarios
SELECT * FROM Puntuaciones
SELECT * FROM ParadasDulces

UPDATE Usuarios SET nombre = 'Luis ' WHERE id = 4

DELETE FROM Puntuaciones