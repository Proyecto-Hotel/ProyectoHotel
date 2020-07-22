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
@Apellido varchar,
@Telefono int,
@CorreoElectronico Varchar(45),
@RTN Varchar(16),
@idTipoEmpleado int,
@idHorario int,
@Estado varchar(15))
as begin
if Exists (Select Identidad from Empleados where Identidad = @Identidad)
raiserror('¡Error! Este numero de Identidad ya se ha registrado con un Empleado, Verifique su Informacion', 16, 1) 
else
insert into Empleados(Identidad, Nombre, Apellido, Telefono, CorreoElectronico, RTN, IdTipoElmpleado,
IdHorarios, Estado)
values(@Identidad, @Nombre, @Apellido, @Telefono, @CorreoElectronico, @RTN, @idTipoEmpleado,
@idHorario, @Estado)
End
go
-----------------------HABITACION-------------------------
create procedure insertarHabitacion
-- Definicion de alias
(@idHabitacion int,
@idTipoHabitacion int,
@Precio int,
@Estado varchar(15))
as begin
if Exists (Select idHabitacion from habitaciones where IdHabitacion = @idHabitacion)
raiserror('¡Error! Este Id ya asigno a una habitacion, Por favor intente con uno diferente', 16, 1) 
else
insert into habitaciones(IdHabitacion, IdTipoHabitacion, Precio, Estado)
values(@idHabitacion ,@idTipoHabitacion, @Precio, @Estado)
End
go
-------------------RESERVACION---------------------------
Create procedure InsertarReservacion
--Definicion de alias--
(@IdReservacion int,
@FechaReservacion dateTime,
@CantidadDias int,
@NumTarjeta Varchar(16),
@IdHuesped varchar(15),
@IdHabitacion int)
As Begin
if exists (Select IdReservacion from Reservacion where IdReservacion = @IdReservacion )
raiserror('¡Error! La reservación ya existe, intente con otro Id', 16, 1)
else
Insert into Reservacion(IdReservacion, FechaReservacion, CantidadDias, NumTarjeta, IdHuesped,IdHabitacion )
Values (@IdReservacion, @FechaReservacion, @CantidadDias, @NumTarjeta, @IdHuesped, @IdHabitacion)
end
go
------------------USUARIO--------------------
Create procedure InsertarUsuario
--Definicion de alias--
(@UserName Varchar(45),
@Psw Varchar(45),
@Identidad  varchar(15))
As Begin
If exists(Select Identidad from Usuarios where Identidad = @Identidad )
raiserror('¡Error! El usuario ya existe, Intente con otro Nombre de Usuario', 16, 1)
Else
Insert Into Usuarios(UserName, Psw, Identidad)
Values (@UserName, @Psw, @Identidad)
end 


