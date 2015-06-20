CREATE DATABASE PROYECTOIPC2J2015

USE PROYECTOIPC2J2015 

CREATE TABLE Sucursal(
Id_Sucursal INT IDENTITY(1,1) PRIMARY KEY,
Pais VARCHAR(MAX) NOT NULL,
Direccion VARCHAR(MAX) NOT NULL,
Telefono Bigint NOT NULL,
Capacidad_empleados INT NOT NULL
)

CREATE TABLE Departamento(
Id_Departamento INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Descripcion VARCHAR(MAX) NOT NULL
)

CREATE TABLE Asignacion_departamento(
Numero_asignacion INT IDENTITY(1,1) PRIMARY KEY,
Id_Sucursal INT NOT NULL,
Id_Departamento INT NOT NULL
FOREIGN KEY (Id_Sucursal) REFERENCES Sucursal(Id_Sucursal),
FOREIGN KEY (Id_Departamento) REFERENCES Departamento(Id_Departamento)
)

CREATE TABLE Director(
Numero_de_identificacion INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Apellido VARCHAR(MAX) NOT NULL,
Telefono BIGINT NOT NULL,
Sueldo FLOAT NOT NULL,
Direccion VARCHAR(MAX) NOT NULL,
Id_Departamento INT NOT NULL,
FOREIGN KEY (Id_Departamento) REFERENCES Departamento(Id_Departamento)
)

CREATE TABLE Comision(
Id_Comision INT IDENTITY(1,1) PRIMARY KEY,
Porcentaje_Comision FLOAT NOT NULL,
Id_Director INT NOT NULL,
)

CREATE TABLE Empleado(
Numero_de_identificacion INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Apellido VARCHAR(MAX) NOT NULL,
Usuario VARCHAR(15) NOT NULL,
Contraseña VARCHAR(15) NOT NULL,
Telefono BIGINT NOT NULL,
Sueldo FLOAT NOT NULL,
Direccion VARCHAR(MAX),
Id_Departamento INT NOT NULL,
Id_Director INT NOT NULL,
FOREIGN KEY (Id_Departamento) REFERENCES Departamento(Id_Departamento),
FOREIGN KEY (Id_Director) REFERENCES Director(Numero_de_identificacion)
)