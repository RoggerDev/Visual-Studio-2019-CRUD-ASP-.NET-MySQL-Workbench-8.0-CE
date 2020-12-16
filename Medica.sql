create database if not exists Medica;
use Medica;

create table if not exists Receta(
    Receta_id integer unsigned primary key not null auto_increment,
    Paciente_id int(2) not null,
    Nombre_pac varchar(20) not null,
    Apellido_pact varchar(20) not null,
    Apellido_pacm varchar(20) not null,
    Edad_pac int(2) not null,
    Medico_id int(2) not null,
    Nombre_doc varchar(20) not null,
    Apellido_doct varchar(20) not null,
    Apellido_docm varchar(20) not null,
    Cédula_Profesional int(8) not null,
    Especialidad enum('Nutriología','Optometría','Odontología') not null,
    Observaciones varchar(100) not null
)charset=utf8mb4;

create table if not exists Medico (
    Doctor_id integer unsigned primary key not null auto_increment,
    Nombres varchar(15) not null,
    Apellido_Paterno varchar(15) not null,
    Apellido_Materno varchar(15) not null,
    Cedula_Profesional integer(8) not null,
    Especialidad enum('Nutriología','Optometría','Odontología') not null,
    Telefono integer(12) not null,
    CURP varchar(18) not null,
    RFC varchar(13) not null,
    Género enum('Hombre', 'Mujer') not null,
    Contraseña varchar(20) not null
)  charset=utf8mb4;

create table if not exists Paciente (
    Paciente_id integer unsigned primary key not null auto_increment,
    Nombres varchar(15) not null,
    Apellido_Paterno varchar(15) not null,
    Apellido_Materno varchar(15) not null,
    Tipo_Paciente enum('Estudiante','Profesor','Personal de apoyo') not null,
    Edad integer(2) not null,
    Telefono varchar(11) not null,
    CURP varchar(18) not null,
    NNS integer(11) not null,
    Género enum('Hombre', 'Mujer') not null
)  charset=utf8mb4;


Select * from Medico;
Insert into Medico (`Doctor_id`, `Nombres`, `Apellido_Paterno`, `Apellido_Materno`, `Cedula_Profesional`,  `Especialidad`, `Telefono`, `CURP`, `RFC`, `Género`, `Contraseña`) VALUES
(1, 'Luis', 'Gabriel', 'Rey', 27635261, 'Optometría', 2017289918, 'FGST783762FHSGTE01', 'AFD0111923U', 'Hombre', 'CONTRASEÑA');