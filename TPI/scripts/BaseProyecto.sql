drop database if exists Proyecto;
create database Proyecto;
use Proyecto;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(26,'admin','123456',120)


create table socio(
NumCarnet int,
Nombre varchar(30),
Apellido varchar(20),
TipoDoc varchar(20),
Documento int,
Direccion varchar(20),
FechaInscripcion date,
carnet boolean,

constraint pk_socio primary key(NumCarnet)
);

create table cuota(
	IdCuota int,
    NumCarnet int,
    Monto float,
    Tipo varchar(10),
    FechaPago date,
    FechaVencimiento date,
    Estado boolean,
    constraint pk_cuota primary key(IdCuota),
    constraint fk_cuota foreign key(NumCarnet) references socio(NumCarnet)
);

create table noSocio(
	IdNoSocio int primary key,
	Nombre varchar(30),
	Apellido varchar(20),
    TipoDoc varchar(20),
	Documento int,
	Direccion varchar(20)
);

create table actividad(
	IdActividad int auto_increment,
    NombreActividad varchar(15),
    Horario time,
	constraint pk_actividad primary key(IdActividad)
);

create table pagoDiario(
	IdPagoDiario int auto_increment,
    IdNoSocio int,
    IdActividad int,
    Monto float,
    Tipo varchar(10),
    FechaPago date,
    Estado boolean,
    constraint pk_pagoDiario primary key(IdPagoDiario),
    constraint fk_pagoDiario_noSocio foreign key(IdNoSocio) references noSocio(IdNoSocio),
    constraint fk_pagoDiario_actividad foreign key(IdActividad) references actividad(IdActividad)

);
