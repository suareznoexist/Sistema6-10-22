/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      diagramaInventario.DM1
 *
 * Date Created : Wednesday, October 05, 2022 21:32:56
 * Target DBMS : Microsoft SQL Server 2019
 */
 create  database BDInventario 
USE BDInventario
go
/* 
 * TABLE: Case 
 */

CREATE TABLE Cases(
    idCase              numeric(10, 0)    NOT NULL,
    FechaCompra         date         NOT NULL,
    FechaFabricacion    date    NOT NULL,
    Estado              varchar(10)       NOT NULL,
    RAM                 numeric(10, 0)    NOT NULL,
    Procesador          varchar(50)       NOT NULL,
    Velocidad           varchar(50)       NOT NULL,
    Almacenamiento      numeric(10, 0)    NOT NULL,
    idSistemaOper       numeric(10, 0)    NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idCase)
)

go


IF OBJECT_ID('Cases') IS NOT NULL
    PRINT '<<< CREATED TABLE Case >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Case >>>'
go

/* 
 * TABLE: Computadores 
 */

CREATE TABLE Computadores(
    IdComputadores    numeric(10, 0)    NOT NULL,
    idCase            numeric(10, 0)    NULL,
    idMouse           numeric(10, 0)    NULL,
    idTeclado         numeric(10, 0)    NULL,
    IdMonitor         numeric(10, 0)    NULL,
    idLaboratorio     numeric(10, 0)    NULL,
    CONSTRAINT PK11 PRIMARY KEY NONCLUSTERED (IdComputadores)
)

go


IF OBJECT_ID('Computadores') IS NOT NULL
    PRINT '<<< CREATED TABLE Computadores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Computadores >>>'
go

/* 
 * TABLE: Equipos 
 */

CREATE TABLE Equipos(
    idescritorios    numeric(10, 0)    NOT NULL,
    Tipo             char(10)          NULL,
    idLaboratorio    numeric(10, 0)    NULL,
    NumeroModelo     varchar(30)       NOT NULL,
    idMarca          numeric(10, 0)    NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (idescritorios)
)

go


IF OBJECT_ID('Equipos') IS NOT NULL
    PRINT '<<< CREATED TABLE Equipos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Equipos >>>'
go

/* 
 * TABLE: Laboratorios 
 */

CREATE TABLE Laboratorios(
    idLaboratorio    numeric(10, 0)    NOT NULL,
    Laboratorio      varchar(20)       NOT NULL,
    iduser           numeric(10, 0)    NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (idLaboratorio)
)

go


IF OBJECT_ID('Laboratorios') IS NOT NULL
    PRINT '<<< CREATED TABLE Laboratorios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Laboratorios >>>'
go

/* 
 * TABLE: Marcas 
 */

CREATE TABLE Marcas(
    idMarca    numeric(10, 0)    NOT NULL,
    Marca      varchar(10)       NOT NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (idMarca)
)

go


IF OBJECT_ID('Marcas') IS NOT NULL
    PRINT '<<< CREATED TABLE Marcas >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Marcas >>>'
go

/* 
 * TABLE: Monitores 
 */

CREATE TABLE Monitores(
    IdMonitor    numeric(10, 0)    NOT NULL,
    Estado       varchar(10)       NULL,
    NumModelo    varchar(10)       NOT NULL,
    idMarca      numeric(10, 0)    NULL,
    CONSTRAINT PK8 PRIMARY KEY NONCLUSTERED (IdMonitor)
)

go


IF OBJECT_ID('Monitores') IS NOT NULL
    PRINT '<<< CREATED TABLE Monitores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Monitores >>>'
go

/* 
 * TABLE: Mouses 
 */

CREATE TABLE Mouses(
    idMouse        numeric(10, 0)    NOT NULL,
    Estado         varchar(10)       NOT NULL,
    NumModeloMo    varchar(10)       NULL,
    idMarca        numeric(10, 0)    NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (idMouse)
)

go


IF OBJECT_ID('Mouses') IS NOT NULL
    PRINT '<<< CREATED TABLE Mouses >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Mouses >>>'
go

/* 
 * TABLE: Registro 
 */

CREATE TABLE Registro(
    Idregistro        numeric(10, 0)    NOT NULL,
    Descripcion       varchar(200)      NOT NULL,
    IdComputadores    numeric(10, 0)    NULL,
    CONSTRAINT PK13 PRIMARY KEY NONCLUSTERED (Idregistro)
)

go


IF OBJECT_ID('Registro') IS NOT NULL
    PRINT '<<< CREATED TABLE Registro >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Registro >>>'
go

/* 
 * TABLE: SistemaOperativo 
 */

CREATE TABLE SistemaOperativo(
    idSistemaOper    numeric(10, 0)    NOT NULL,
    SistemaOp        varchar(10)       NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (idSistemaOper)
)

go


IF OBJECT_ID('SistemaOperativo') IS NOT NULL
    PRINT '<<< CREATED TABLE SistemaOperativo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE SistemaOperativo >>>'
go

/* 
 * TABLE: Teclados 
 */

CREATE TABLE Teclados(
    idTeclado    numeric(10, 0)    NOT NULL,
    Estado       varchar(10)       NOT NULL,
    Modelo       varchar(40)       NOT NULL,
    idMarca      numeric(10, 0)    NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (idTeclado)
)

go


IF OBJECT_ID('Teclados') IS NOT NULL
    PRINT '<<< CREATED TABLE Teclados >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Teclados >>>'
go

/* 
 * TABLE: user 
 */

CREATE TABLE users(
    iduser     numeric(10, 0)    NOT NULL,
    Usuario    varchar(30)       NOT NULL,
    CONSTRAINT PK12 PRIMARY KEY NONCLUSTERED (iduser)
)

go


IF OBJECT_ID('user') IS NOT NULL
    PRINT '<<< CREATED TABLE user >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE user >>>'
go

/* 
 * TABLE: Case 
 */

ALTER TABLE Cases ADD CONSTRAINT RefSistemaOperativo30 
    FOREIGN KEY (idSistemaOper)
    REFERENCES SistemaOperativo(idSistemaOper)
go


/* 
 * TABLE: Computadores 
 */

ALTER TABLE Computadores ADD CONSTRAINT RefLaboratorios40 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorios(idLaboratorio)
go

ALTER TABLE Computadores ADD CONSTRAINT RefCase35 
    FOREIGN KEY (idCase)
    REFERENCES Cases(idCase)
go

ALTER TABLE Computadores ADD CONSTRAINT RefMouses36 
    FOREIGN KEY (idMouse)
    REFERENCES Mouses(idMouse)
go

ALTER TABLE Computadores ADD CONSTRAINT RefTeclados37 
    FOREIGN KEY (idTeclado)
    REFERENCES Teclados(idTeclado)
go

ALTER TABLE Computadores ADD CONSTRAINT RefMonitores38 
    FOREIGN KEY (IdMonitor)
    REFERENCES Monitores(IdMonitor)
go


/* 
 * TABLE: Equipos 
 */

ALTER TABLE Equipos ADD CONSTRAINT RefLaboratorios31 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorios(idLaboratorio)
go

ALTER TABLE Equipos ADD CONSTRAINT RefMarcas39 
    FOREIGN KEY (idMarca)
    REFERENCES Marcas(idMarca)
go


/* 
 * TABLE: Laboratorios 
 */

ALTER TABLE Laboratorios ADD CONSTRAINT Refuser42 
    FOREIGN KEY (iduser)
    REFERENCES users(iduser)
go


/* 
 * TABLE: Monitores 
 */

ALTER TABLE Monitores ADD CONSTRAINT RefMarcas32 
    FOREIGN KEY (idMarca)
    REFERENCES Marcas(idMarca)
go


/* 
 * TABLE: Mouses 
 */

ALTER TABLE Mouses ADD CONSTRAINT RefMarcas34 
    FOREIGN KEY (idMarca)
    REFERENCES Marcas(idMarca)
go


/* 
 * TABLE: Registro 
 */

ALTER TABLE Registro ADD CONSTRAINT RefComputadores41 
    FOREIGN KEY (IdComputadores)
    REFERENCES Computadores(IdComputadores)
go


/* 
 * TABLE: Teclados 
 */

ALTER TABLE Teclados ADD CONSTRAINT RefMarcas33 
    FOREIGN KEY (idMarca)
    REFERENCES Marcas(idMarca)
go


