

use ProyectoHotel
go
------------------------------INSERTAR-------------------------------
---------------------------------TIPO EMPLEADO--------------------------------------
create procedure InsertarTipoEmpleado(
@Puesto varchar(45),
@Sueldo Int
)
as
Begin
if exists (select Puesto from TipoEmpleado where puesto=@Puesto)raiserror('Error!! Este puesto ya existe, utiliza otro por favor', 16, 1)else
insert into TipoEmpleado(Puesto,Sueldo) values (@Puesto,@Sueldo)
End
go
exec InsertarTipoEmpleado 'Gerente General', 15000
select * from TipoEmpleado

----------------------------------TIPO HABITACION-------------------------------------
create procedure IngresarTipoHabitacion(
@Nombre varchar(45),
@Capacidad int 
)
as
Begin
if exists (select Nombre from tipoHabitaciones where Nombre=@Nombre)raiserror('Error!! Este tipo de Habitación ya existe, utiliza otro por favor', 16, 1)else
insert into tipoHabitaciones(Nombre,capacidad) values (@Nombre,@Capacidad)
End
go
exec IngresarTipoHabitacion 
select * from TipoHabitaciones
-------------------------------------HUESPED----------------------------------
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
if exists (select Identidad from Huesped where Identidad=@Identidad)raiserror('Error!! Este Huesped ya existe, Revisa el numero de Identidad', 16, 1)else
insert into Huesped(Identidad,Nombre,Apellido,Telefono,CorreoElectronico,RTN) 
values (@Identidad,@Nombre,@Apellido,@Telefono,@Correo,@RTN)
End
go
-------------------------------HORARIOS------------------------------------------
create procedure InsertarHorarios
-- Definicion de alias
(@Horarios Varchar(45),
@DEscripcion Varchar(45))
as Begin
if Exists (Select Horarios from Horarios where Horarios = @Horarios)
raiserror('¡Error! Este Horario ya esta establecido, Por favor Revise la Informacion', 16, 1) 
else
insert into Horarios(Horarios, Descripcion)
values(@Horarios, @DEscripcion)
End
go

-------------------------EMPLEADO--------------------
create procedure insertarEmpleados
-- Definicion de alias
(@Identidad varchar(15),
@Nombre varchar(45),
@Apellido varchar(45),
@Telefono int,
@CorreoElectronico Varchar(45),
@RTN Varchar(16),
@idTipoEmpleado int,
@idHorario int
)
as
begin
if Exists (Select Identidad from Empleados where Identidad = @Identidad)
raiserror('¡Error! Este numero de Identidad ya se ha registrado con un Empleado, Verifique su Informacion', 16, 1) 
else
insert into Empleados(Identidad, Nombre, Apellido, Telefono, CorreoElectronico, RTN, IdTipoElmpleado,
IdHorarios)
values(@Identidad, @Nombre, @Apellido, @Telefono, @CorreoElectronico, @RTN, @idTipoEmpleado,
@idHorario)
End
go

-----------------------HABITACION-------------------------
create procedure insertarHabitacion
-- Definicion de alias
(@idHabitacion int,
@idTipoHabitacion int,
@Precio int
)
as begin
if Exists (Select idHabitacion from habitaciones where IdHabitacion = @idHabitacion)
raiserror('¡Error! Este Id ya asigno a una habitacion, Por favor intente con uno diferente', 16, 1) 
else
insert into habitaciones(IdHabitacion, IdTipoHabitacion, Precio)
values(@idHabitacion ,@idTipoHabitacion, @Precio)
End
go
-------------------RESERVACION---------------------------
-------------------Pendiente---------------------------
create procedure InsertarReservacion(
--Definicion de alias--
@FechaReservacion dateTime,
@CantidadDias int,
@NumTarjeta Varchar(16),
@IdHuesped varchar(15),
@IdHabitacion int)
As Begin
if exists (Select IdHabitacion from habitaciones where IdHabitacion = @IdHabitacion and estado = 'Reservado' )
raiserror('¡Error! La Habitación ya esta Reservada, intente con otro Id', 16, 1)
else
Insert into Reservacion(IdReservacion, FechaReservacion, CantidadDias, NumTarjeta, IdHuesped,IdHabitacion )
Values (@IdReservacion, @FechaReservacion, @CantidadDias, @NumTarjeta, @IdHuesped, @IdHabitacion)

end
go

--exec InsertarReservacion 1,'2020-10-31 22:19:00',3,
------------------USUARIO--------------------
create procedure InsertarUsuario
--Definicion de alias--
(@UserName Varchar(45),
@Psw Varchar(45),
@Identidad  varchar(15),
@Tipo int)
As Begin
If exists(Select Identidad, UserName from Usuarios where Identidad = @Identidad and UserName = @UserName)
raiserror('¡Error! El usuario ya existe, Intente con otro Nombre de Usuario u otro Numero de Identidad', 16, 1)

Else if Exists(Select Identidad from Empleados where Identidad <> @Identidad)
raiserror('¡Error! El Empleado No existe, Verifique El numero de Identidad', 16, 1)
else
Insert Into Usuarios(UserName, Psw, Identidad,TipoEmpleado)
Values (@UserName, @Psw, @Identidad,@Tipo)
END
go
------------------USUARIO--------------------
create procedure InsertarExtras(
@Nombre varchar(45),
@Precio int
)
as 
Begin
If exists(Select nombre from Extras where nombre = @Nombre)
raiserror('¡Error! El nombre de Extra ya existe, Intente con otro Nombre', 16, 1)
else 
insert into Extras(nombre, Precio)
values (@Nombre, @Precio)
END
go
exec InsertarExtras 'Jacuzzi',130
select * from Extras
go
exec 