------------------------------CONSULTAR-------------------------------
use ProyectoHotel
go


------------------------------CONSULTAR HUESPED-------------------------------

create procedure ListarHuesped
as
Begin
select Hu.Identidad as 'Identidad', CONCAT(Hu.Nombre,' ',Hu.Apellido) as 'Nombre Completo',Hu.Telefono, Hu.CorreoElectronico as'Correo Electr�nico',Hu.RTN  From Huesped as Hu
END
go
create procedure consultarHuesped(@Identidad varchar(15))
as
Begin
select Hu.Identidad as 'Identidad', CONCAT(Hu.Nombre,' ',Hu.Apellido) as 'Nombre Completo',Hu.Telefono, Hu.CorreoElectronico as'Correo Electr�nico',Hu.RTN  From Huesped as Hu
Where @Identidad = Hu.Identidad and Hu.Estado = 'Activo'
END
go
------------------------------CONSULTAR EMPLEADOS-------------------------------
Create procedure ListarEmpleados
as
Begin

select Em.Identidad as 'Identidad', CONCAT(Em.Nombre,' ',Em.Apellido) as 'Nombre Completo',Em.Telefono, Em.CorreoElectronico as'Correo Electr�nico',Em.RTN, Tp.Puesto as 'Cargo',Tp.Sueldo,HR.Horarios as 'Jornada' 
From Empleados as Em
inner join TipoEmpleado as Tp on Em.IdTipoElmpleado = Tp.IdTipoEmpleado
inner Join Horarios as HR on em.Identidad = HR.idHorarios
END



Create procedure ConsultarEmpleados(@Identidad varchar(15))
as
Begin

select Em.Identidad as 'Identidad', CONCAT(Em.Nombre,' ',Em.Apellido) as 'Nombre Completo',Em.Telefono, Em.CorreoElectronico as'Correo Electr�nico',Em.RTN, Tp.Puesto as 'Cargo',Tp.Sueldo,HR.Horarios as 'Jornada' 
From Empleados as Em
inner join TipoEmpleado as Tp on Em.IdTipoElmpleado = Tp.IdTipoEmpleado
inner Join Horarios as HR on em.Identidad = HR.idHorarios
Where @Identidad = Em.Identidad and Em.Estado = 'Activo'
END


------------------------------CONSULTAR HABITACIONES-------------------------------
Create Procedure ListarHabitaciones
as
Begin
Select Hab.IdHabitacion as 'Numero de Habitaci�n', TpH.Nombre as 'Tipo Habitaci�n',TpH.capacidad,Hab.Precio, Hab.Estado From habitaciones as Hab
inner Join tipoHabitaciones as TpH on Hab.IdTipoHabitacion = TpH.IdTipoHabitaciones
ENd 
Create Procedure ConsultarHabitaciones(@IdHabitacion int)
as
Begin
Select Hab.IdHabitacion as 'Numero de Habitaci�n', TpH.Nombre as 'Tipo Habitaci�n',TpH.capacidad,Hab.Precio, Hab.Estado From habitaciones as Hab
inner Join tipoHabitaciones as TpH on Hab.IdTipoHabitacion = TpH.IdTipoHabitaciones
Where Hab.IdHabitacion = @IdHabitacion
END 
------------------------------CONSULTAR TIPO HABITACIONES-------------------------------
create procedure ConsultarTipoHabitaciones
as 
Begin
select TpH.IdTipoHabitaciones as 'C�digo',TpH.Nombre as 'Tipo Habitaci�n',TpH.capacidad from tipoHabitaciones as TpH
end 

------------------------------CONSULTAR TIPO EMPLEADOS-------------------------------
create procedure ConsultarTipoEmpleados
as 
Begin
select Em.IdTipoEmpleado as 'C�digo',Em.Puesto,Em.Sueldo from TipoEmpleado as Em
end 

------------------------------LISTAR USUARIOS-------------------------------
create procedure ListarUsuarios
as 
Begin
select Us.UserName as 'Usuario',CONCAT( Em.Nombre ,' ', Em.Apellido) as 'Nombre Completo' from Usuarios as Us
inner Join Empleados as Em on Em.Identidad = Us.Identidad
end 
create procedure ConsultarUsuario(@UserName varchar(45))
as 
Begin
select Us.UserName as 'Usuario',CONCAT( Em.Nombre ,' ', Em.Apellido) as 'Nombre Completo' from Usuarios as Us
inner Join Empleados as Em on Em.Identidad = Us.Identidad where Us.UserName = @UserName
end 