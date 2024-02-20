CREATE TABLE [Termekek](
	[Megnevezes] NVARCHAR(80) NOT NULL,
	[Db] INT NOT NULL,
	[Ar] INT NOT NULL, 
	[Cikkszam] VARCHAR(25) NOT NULL,
	PRIMARY KEY([Cikkszam])
);

CREATE TABLE[Frissaru](
	[Tipus] TINYINT,
	[Suly] INT,
	[Cikkszam] VARCHAR(25) NOT NULL,
	[SzavIdo] DATETIME,
	PRIMARY KEY([Cikkszam]),
	CONSTRAINT [FrissaruTermek_FK] FOREIGN KEY ([Cikkszam]) REFERENCES[Termekek]([Cikkszam])
);

CREATE TABLE[Melyhutott](
	[Tipus] TINYINT,
	[Cikkszam] VARCHAR(25) NOT NULL,
	[SzavIdo] DATETIME,
	PRIMARY KEY([Cikkszam]),
	CONSTRAINT [MelyhutottTermek_FK] FOREIGN KEY ([Cikkszam]) REFERENCES[Termekek]([Cikkszam])
);

CREATE TABLE[Tejtermek](
	[Tipus] TINYINT,
	[Liter] INT, 
	[Cikkszam] VARCHAR(25) NOT NULL,
	[SzavIdo] DATETIME,
	PRIMARY KEY([Cikkszam]),
	CONSTRAINT [TejtermekTermek_FK] FOREIGN KEY ([Cikkszam]) REFERENCES[Termekek]([Cikkszam])
);

CREATE TABLE[Szarazaru](
	[Tipus] TINYINT,
	[Suly] INT,
	[Cikkszam] VARCHAR(25) NOT NULL,
	[SzavIdo] DATETIME,
	PRIMARY KEY([Cikkszam]),
	CONSTRAINT [SzarazaruTermek_FK] FOREIGN KEY ([Cikkszam]) REFERENCES[Termekek]([Cikkszam])
);

CREATE TABLE[Muszaki](
	[Tipus] TINYINT,
	[Besorolas] TINYINT,
	[Cikkszam] VARCHAR(25) NOT NULL,
	PRIMARY KEY([Cikkszam]),
	CONSTRAINT [MuszakiTermek_FK] FOREIGN KEY ([Cikkszam]) REFERENCES[Termekek]([Cikkszam])
);

