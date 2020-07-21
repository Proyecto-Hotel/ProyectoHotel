create database ProyectoHotel
go
use ProyectoHotel
go

create table Empleados(
Identidad varchar(15) Primary key not null,
Nombre Varchar(45) not null,
Apellido varchar not null,
Telefono int,
CorreoElectronico Varchar(45) not null,
RTN Varchar(16),
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

create table Usuarios(
UserName Varchar(45) primary Key not null,
Psw Varchar(45) not null,
)
go
alter table usuarios
add Identidad  varchar(15) foreign key references Empleados(Identidad)

create table Horarios(
idHorarios int primary Key identity (1,1),
Horarios Varchar(45) not null,
Descripcion Varchar(45) not null,
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

Create table habitaciones(
IdHabitacion int Primary key,
Precio int not null,
)
Alter table habitaciones 
add Estado varchar(15) not null
go
alter table habitaciones
add IdTipoHabitacion int foreign key references tipoHabitaciones(IdTipoHabitaciones)
go

create table tipoHabitaciones(
IdTipoHabitaciones int primary key identity (1,1),
Nombre varchar(45) not null,
capacidad int not null
)
go

------------------------------CONSULTAR-------------------------------



------------------------------CONSULTAR HUESPED-------------------------------

create procedure ListarHuesped
as
Begin
select Hu.Identidad as 'Identidad', CONCAT(Hu.Nombre,' ',Hu.Apellido) as 'Nombre Completo',Hu.Telefono, Hu.CorreoElectronico as'Correo Electrónico',Hu.RTN  From Huesped as Hu
END
go
create procedure consultarHuesped(@Identidad varchar(15))
as
Begin
select Hu.Identidad as 'Identidad', CONCAT(Hu.Nombre,' ',Hu.Apellido) as 'Nombre Completo',Hu.Telefono, Hu.CorreoElectronico as'Correo Electrónico',Hu.RTN  From Huesped as Hu
Where @Identidad = Hu.Identidad and Hu.Estado = 'Activo'
END
go
------------------------------CONSULTAR EMPLEADOS-------------------------------
Create procedure ListarEmpleados
as
Begin

select Em.Identidad as 'Identidad', CONCAT(Em.Nombre,' ',Em.Apellido) as 'Nombre Completo',Em.Telefono, Em.CorreoElectronico as'Correo Electrónico',Em.RTN, Tp.Puesto as 'Cargo',Tp.Sueldo,HR.Horarios as 'Jornada' 
From Empleados as Em
inner join TipoEmpleado as Tp on Em.IdTipoElmpleado = Tp.IdTipoEmpleado
inner Join Horarios as HR on em.Identidad = HR.idHorarios
END



Create procedure onsultarEmpleados(@Identidad varchar(15))
as
Begin

select Em.Identidad as 'Identidad', CONCAT(Em.Nombre,' ',Em.Apellido) as 'Nombre Completo',Em.Telefono, Em.CorreoElectronico as'Correo Electrónico',Em.RTN, Tp.Puesto as 'Cargo',Tp.Sueldo,HR.Horarios as 'Jornada' 
From Empleados as Em
inner join TipoEmpleado as Tp on Em.IdTipoElmpleado = Tp.IdTipoEmpleado
inner Join Horarios as HR on em.Identidad = HR.idHorarios
Where @Identidad = Em.Identidad and Em.Estado = 'Activo'
END


------------------------------CONSULTAR HABITACIONES-------------------------------
Create Procedure ListarHabitaciones
as
Begin
Select Hab.IdHabitacion as 'Numero de Habitación', TpH.Nombre as 'Tipo Habitación',TpH.capacidad,Hab.Precio, Hab.Estado From habitaciones as Hab
inner Join tipoHabitaciones as TpH on Hab.IdTipoHabitacion = TpH.IdTipoHabitaciones
ENd 
Create Procedure ConsultarHabitaciones(@IdHabitacion int)
as
Begin
Select Hab.IdHabitacion as 'Numero de Habitación', TpH.Nombre as 'Tipo Habitación',TpH.capacidad,Hab.Precio, Hab.Estado From habitaciones as Hab
inner Join tipoHabitaciones as TpH on Hab.IdTipoHabitacion = TpH.IdTipoHabitaciones
Where Hab.IdHabitacion = @IdHabitacion
ENd 
------------------------------CONSULTAR HABITACIONES-------------------------------
create procedure ConsultarTipoHabitaciones
as 
Begin
select TpH.IdTipoHabitaciones as 'Código',TpH.Nombre as 'Tipo Habitación',TpH.capacidad from tipoHabitaciones as TpH
end 
