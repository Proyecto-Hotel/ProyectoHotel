use ProyectoHotel
go
------------------------------INSERTAR-------------------------------
-----------------------------------------------------------------------
create procedure InsertarTipoEmpleado(
@Puesto varchar(45),
@Sueldo Int
)
as
Begin
if exists (select Puesto from TipoEmpleado where puesto=@Puesto)raiserror('Error!! Este puesto ya existe, utiliza otro por favor', 16, 1)else
insert into TipoEmpleado(Puesto,Sueldo) values (@Puesto,@Sueldo)
End
go
-----------------------------------------------------------------------
create procedure IngresarTipoHabitacion(
@Nombre varchar(45),
@Capacidad int 
)
as
Begin
if exists (select Nombre from tipoHabitaciones where Nombre=@Nombre)raiserror('Error!! Este tipo de Habitación ya existe, utiliza otro por favor', 16, 1)else
insert into tipoHabitaciones(Nombre,capacidad) values (@Nombre,@Capacidad)
End
go
-----------------------------------------------------------------------
create procedure  IngresarHuesped(
@Identidad varchar(15),
@Nombre varchar(45),
@Apellido varchar(45),
@Telefono Int,
@Correo varchar(45),
@RTN varchar(16) 
)
as
Begin
if exists (select Identidad from Huesped where Identidad=@Identidad)raiserror('Error!! Este Huesped ya existe, Revisa el numero de Identidad', 16, 1)else
insert into Huesped(Identidad,Nombre,Apellido,Telefono,CorreoElectronico,RTN) 
values (@Identidad,@Nombre,@Apellido,@Telefono,@Correo,@RTN)
End
go

create procedure InsertarHorarios(
@Horarios Varchar(45),
@DEscripcion Varchar(45)
)as
Begin
if Exists (Select Horarios from Horarios where Horarios = @Horarios)
raiserror('Error')
End