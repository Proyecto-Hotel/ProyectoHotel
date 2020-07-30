
  alter table dbo.Reservacion
  drop column FechaReservacion
  go
  alter table dbo.Reservacion
  add FechaF date not null
  go
  alter table dbo.Reservacion
  add FechaI date not null

  create procedure InsertarReservacion(
--Definicion de alias--
@IdReservacion int,
@FechaI date,
@FechaF date,
@CantidadDias int,
@NumTarjeta Varchar(16),
@IdHuesped varchar(15),
@IdHabitacion int)
As Begin
if exists (SELECT * FROM Reservacion where IdReservacion= @IdReservacion or IdHabitacion = @IdHabitacion and @FechaI between FechaI and FechaF and Estado = 'Reservado' or IdHabitacion =@IdHabitacion and @FechaF between FechaI and FechaF and Estado = 'Reservado')
raiserror('¡Error! La Habitación ya esta Reservada', 16, 1)
else
Insert into Reservacion(IdReservacion, FechaI, FechaF, CantidadDias, NumTarjeta, IdHuesped,IdHabitacion )
Values (@IdReservacion, @FechaI, @FechaF, @CantidadDias, @NumTarjeta, @IdHuesped, @IdHabitacion)

end
  

  alter procedure actualizarReservacion(
	@IdReservacion int,
	@FechaI date,
	@FechaF date,
	@CantidadDias int,
	@NumTarjeta Varchar(16),
	@IdHuesped varchar(15),
	@IdHabitacion int)

as begin
	if exists(select @IdReservacion from Reservacion where IdReservacion=@IdReservacion)
		update Reservacion
		set FechaI=@FechaI,FechaF=@FechaF,CantidadDias=@CantidadDias,NumTarjeta=@NumTarjeta,IdHuesped=@IdHuesped,IdHabitacion=@IdHabitacion
		where IdReservacion=@IdReservacion
	else
		raiserror('La reservacion no puede ser modificada, Ingrese otra Reservacion',16,1)
end
go



