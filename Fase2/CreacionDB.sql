
CREATE DATABASE PROYECTOIPC2J2015

USE PROYECTOIPC2J2015 

CREATE TABLE Sede(
Id_Sede	INT IDENTITY(1,1) PRIMARY KEY,
Nombre_pais VARCHAR(MAX) NOT NULL,
Comision FLOAT NOT NULL
)

CREATE TABLE Sucursal(
Id_sucursal INT IDENTITY(1,1) PRIMARY KEY,
Id_sede INT NOT NULL,
Direccion VARCHAR(MAX) NOT NULL,
Telefono BIGINT NOT NULL,
Capacidad_empleado INT NOT NULL,
FOREIGN KEY (Id_sede) REFERENCES Sede(Id_Sede)
)

CREATE TABLE Departamento(
Id_Departamento INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Descripcion VARCHAR(MAX) NOT NULL
)

CREATE TABLE Asignacion_departamento(
Numero_asignacion INT IDENTITY(1,1) PRIMARY KEY,
Id_sucursal INT NOT NULL,
Id_departamento INT NOT NULL,
FOREIGN KEY (Id_sucursal) REFERENCES Sucursal(Id_sucursal),
FOREIGN KEY (Id_departamento) REFERENCES Departamento(Id_Departamento)
)

CREATE TABLE Empleado(
Numero_de_identificacion INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Apelllido VARCHAR(MAX) NOT NULL,
Telefono BIGINT NOT NULL,
Sueldo FLOAT NOT NULL,
Direccion VARCHAR(MAX) NOT NULL,
Id_departamento INT NOT NULL,
Rol VARCHAR(13) NOT NULL,
Id_sucursal INT NOT NULL,
Usuario VARCHAR(MAX) NOT NULL,
Contraseña VARCHAR(15) NOT NULL
FOREIGN KEY (Id_departamento) REFERENCES Departamento(Id_Departamento),
FOREIGN KEY (Id_sucursal) REFERENCES Sucursal(Id_sucursal)
)

CREATE TABLE Categoria(
Id_Categoria INT IDENTITY(1,1) PRIMARY KEY,
Nombre_categoria VARCHAR(MAX) NOT NULL,
Valor_Impuesto FLOAT NOT NULL
)

CREATE TABLE Producto(
Id_producto INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Descripcion VARCHAR(MAX) NOT NULL,
Id_Categoria INT NOT NULL,
Precio FLOAT NOT NULL,
Peso INT NOT NULL,
Estado INT NOT NULL
FOREIGN KEY (Id_Categoria) REFERENCES Categoria(Id_Categoria)
)

CREATE TABLE Cliente(
DPI INT PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Apellido VARCHAR(MAX) NOT NULL,
NIT BIGINT NOT NULL,
Telefono BIGINT NOT NULL,
Domicilio VARCHAR(MAX) NOT NULL,
Tarjeta BIGINT NOT NULL,
Casilla INT NOT NULL,
Id_sucursal INT NOT NULL,
Id_producto INT NOT NULL,
Usuario VARCHAR(MAX) NOT NULL,
Contraseña VARCHAR(15) NOT NULL,
Estado BIT NOT NULL,
FOREIGN KEY(Id_sucursal) REFERENCES Sucursal(Id_sucursal),
FOREIGN KEY (Id_producto) REFERENCES Producto(Id_producto)
)

CREATE TABLE Detalle(
Id_Detalle INT IDENTITY(1,1) PRIMARY KEY,
Id_producto INT NOT NULL,
Precio_total FLOAT NOT NULL,
FOREIGN KEY(Id_producto) REFERENCES Producto(Id_producto)
)

CREATE TABLE Factura(
Numero_Factura INT IDENTITY(1,1) PRIMARY KEY,
Fecha_emision DATE NOT NULL,
DPI INT NOT NULL,
Id_detalle INT NOT NULL,
FOREIGN KEY(DPI) REFERENCES Cliente(DPI),
FOREIGN KEY (Id_detalle) REFERENCES Detalle(Id_Detalle)
)