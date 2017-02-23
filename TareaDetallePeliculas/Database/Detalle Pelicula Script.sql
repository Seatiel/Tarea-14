create table Peliculas(
PeliculaId int identity(1,1) primary key,
Estrenos varchar(80),
Descripcion varchar(120),
Fecha date,
ActorId int
);

create table Actores(
ActorId int identity(1,1) primary key,
ActorNombres varchar(80)
);

create table PeliculasActores(
PeliculasActoresId int identity(1,1) primary key,
PeliculaId int,
ActorId int
);