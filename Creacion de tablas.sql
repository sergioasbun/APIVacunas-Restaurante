﻿CREATE TABLE Usuarios(
	carnet VARCHAR(30) PRIMARY KEY,
	nombreCompleto VARCHAR(50) NOT NULL
);

CREATE TABLE Vacunas(
	id INT PRIMARY KEY IDENTITY(1,1),
	carnet VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Usuarios(carnet),
	tipo VARCHAR(30) NOT NULL,
	dosis VARCHAR(30) NOT NULL,
	FechaDeVacunacion DATE NOT NULL,
);