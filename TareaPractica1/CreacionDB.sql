CREATE DATABASE TareaPractica1

USE TareaPractica1

CREATE TABLE Cliente(
Numero_cliente  INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
DPI BIGINT NOT NULL,
Direccion VARCHAR(MAX) NOT NULL,
Telefono BIGINT NOT NULL
)

CREATE TABLE Libro(
Id_Libro INT IDENTITY (1,1) PRIMARY KEY,
Nombre_libro VARCHAR(MAX) NOT NULL,
Num_Existencias INT NOT NULL,
Num_Paginas INT NOT NULL,
Autor_libro VARCHAR(MAX) NOT NULL,
Tema_libro VARCHAR(MAX) NOT NULL
)

CREATE TABLE Prestamo(
Id_Prestamo INT IDENTITY (1,1) PRIMARY KEY,
IdCliente INT NOT NULL,
Id_Asignacionestado INT NOT NULL,
FOREIGN KEY (IdCliente) REFERENCES Cliente(Numero_cliente),
FOREIGN KEY (Id_Asignacionestado) REFERENCES Asignacion_estado(Id_Asign)
)

CREATE TABLE Estado(
Id_Estado INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR(MAX)
)
 
CREATE TABLE Asignacion_estado(
Id_Asign INT IDENTITY (1,1) PRIMARY KEY,
Id_Estado INT NOT NULL,
Id_Libro INT NOT NULL,
FOREIGN KEY (Id_Estado) REFERENCES Estado(Id_Estado),
FOREIGN KEY (Id_Libro) REFERENCES Libro(Id_Libro)
)
