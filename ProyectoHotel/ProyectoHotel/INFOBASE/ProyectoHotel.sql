create database ProyectoHotel
go
use ProyectoHotel
go

create table Empleados(
Identidad varchar(15) Primary key not null,
Nombre Varchar(45) not null,
Apellido varchar(45) not null,
Telefono int,
CorreoElectronico Varchar(45) not null,
RTN Varchar(16)
)
go 

alter table Empleados
add IdTipoElmpleado int foreign key references TipoEmpleado(IdTipoEmpleado) not null
alter table Empleados
add IdHorarios int foreign key references Horarios(IdHorarios) not null
go
alter table Empleados 
add Estado varchar(15) Null DEFAULT 'Activo'


create table TipoEmpleado(
IdTipoEmpleado int primary key identity(1,1),
Puesto Varchar(45) not null,
Sueldo Int not null
)
go
alter table TipoEmpleado
add unique(Puesto)

alter table TipoEmpleado 
add Estado varchar(15) Null DEFAULT 'Activo'
go
create table Usuarios(
UserName Varchar(45) primary Key not null,
Psw Varchar(45) not null,
)
go
alter table Usuarios 
add Estado varchar(15) Null DEFAULT 'Activo'
alter table usuarios
add Identidad  varchar(15) foreign key references Empleados(Identidad)
alter table usuarios
add TipoEmpleado  int foreign key references TipoEmpleado(IdTipoEmpleado) not null

create table Horarios(
idHorarios int primary Key identity (1,1),
Horarios Varchar(45) not null,
Descripcion Varchar(45)
)
go

create table Huesped(
Identidad Varchar(15) primary Key  not null,
Nombre Varchar(45) not null,
Apellido Varchar(45) not null,
Telefono Int not null,
CorreoElectronico Varchar(45) not null,
RTN Varchar(16)
)

alter table Huesped 
add Estado varchar(15) Null DEFAULT 'Activo'
go

create table Reservacion(
IdReservacion int Primary Key identity (1,1),
FechaReservacion dateTime not null,
CantidadDias int not null,
NumTarjeta Varchar(16) not null,
)
go 
alter table Reservacion
add IdHuesped varchar(15) foreign Key references Huesped(Identidad) not null
alter table Reservacion
add IdHabitacion int foreign Key references habitaciones(IdHabitacion) not null
go 
alter table Reservacion
add Estado varchar(15) not null default 'Activo'

Create table habitaciones(
IdHabitacion int Primary key,
Precio int not null,
)
Alter table habitaciones 
add Estado varchar(15) not null --Reservada o Libre--
go
alter table habitaciones
add IdTipoHabitacion int foreign key references tipoHabitaciones(IdTipoHabitaciones)
go
alter table Habitaciones
add Estado varchar(15) not null default 'Disponible'

create table tipoHabitaciones(
IdTipoHabitaciones int primary key identity (1,1),
Nombre varchar(45) not null,
capacidad int not null
)
go
create table Extras(
IdExtras int Primary Key Identity (1,1),
nombre varchar(45) not null,
Precio int 
)
go
Alter table Extras
add Unique(Nombre)


alter table TipoHabitaciones
add Estado varchar(15) not null default 'Activo'
go
create table DetalleFactura(
idDetalle int identity (1,1) primary Key,
NumeroFactura int not null,
FKreservacion int foreign Key references Reservacion(IdReservacion),
FKHabitaciones int foreign Key references habitaciones(IdHabitacion),
FKExtras int foreign Key references Extras(idExtras)
)
go
alter table detalleFactura
add FkDetalleFactura int Foreign Key references DetalleFactura(idDetalle)


create table factura(
idFactura int primary key Identity (1,1),
Fechafactura DateTime null Default GetDate(),
FkUsuarios varchar(45) Foreign key references usuarios(UserName),
FkHuesped varchar(15) Foreign key references Huesped(Identidad),
FkDetalleFactura int Foreign Key References DetalleFactura(idDetalle)
)