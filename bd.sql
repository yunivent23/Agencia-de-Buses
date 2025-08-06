USE [AgenciaBuses]
GO
/****** Object:  Table [dbo].[Asientos]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asientos](
	[Id_Asiento] [varchar](15) NOT NULL,
	[Numero] [int] NOT NULL,
	[Id_Bus] [int] NOT NULL,
	[Tipo] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Asiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Asiento_UnicoPorBus] UNIQUE NONCLUSTERED 
(
	[Id_Bus] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asignaciones]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaciones](
	[Id_Asignacion] [int] IDENTITY(1,1) NOT NULL,
	[Id_Conductor] [int] NOT NULL,
	[Id_Bus] [int] NOT NULL,
	[Fecha_Asignacion] [date] NOT NULL,
	[Turno] [varchar](20) NOT NULL,
	[Observaciones] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Conductor_Bus_Fecha] UNIQUE NONCLUSTERED 
(
	[Id_Conductor] ASC,
	[Id_Bus] ASC,
	[Fecha_Asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Boletos]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boletos](
	[Id_Boleto] [varchar](15) NOT NULL,
	[Id_Viaje] [int] NOT NULL,
	[Id_Pasajero] [int] NOT NULL,
	[Id_Asiento] [varchar](15) NOT NULL,
	[Precio] [decimal](6, 2) NOT NULL,
	[Fecha_Compra] [date] NOT NULL,
	[Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Boleto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_AsientoPorViaje] UNIQUE NONCLUSTERED 
(
	[Id_Viaje] ASC,
	[Id_Asiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buses]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buses](
	[Id_Bus] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [varchar](6) NOT NULL,
	[Marca] [varchar](30) NOT NULL,
	[Modelo] [varchar](30) NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Bus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conductores]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conductores](
	[Id_Conductor] [int] IDENTITY(1,1) NOT NULL,
	[Documento_Identidad] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Telefono] [varchar](9) NOT NULL,
	[Licencia] [varchar](20) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Conductor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Documento_Identidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mantenimientos]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mantenimientos](
	[Id_Mantenimiento] [int] IDENTITY(1,1) NOT NULL,
	[Id_Bus] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Descripcion] [text] NOT NULL,
	[Costo] [decimal](8, 2) NOT NULL,
	[EmpresaResponsable] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Mantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pasajeros]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajeros](
	[Id_Pasajero] [int] IDENTITY(1,1) NOT NULL,
	[Documento_Identidad] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pasajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Documento_Identidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rutas]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutas](
	[Id_Ruta] [int] IDENTITY(1,1) NOT NULL,
	[Origen] [varchar](100) NOT NULL,
	[Destino] [varchar](100) NOT NULL,
	[Distancia_Km] [decimal](6, 2) NOT NULL,
	[Duracion_Estimada] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Ruta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viajes]    Script Date: 5/08/2025 18:08:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viajes](
	[Id_Viaje] [int] IDENTITY(1,1) NOT NULL,
	[Id_Bus] [int] NOT NULL,
	[Id_Conductor] [int] NOT NULL,
	[Id_Ruta] [int] NOT NULL,
	[Estado] [varchar](20) NULL,
	[Fecha_Salida] [date] NULL,
	[Fecha_LLegada] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asientos]  WITH CHECK ADD FOREIGN KEY([Id_Bus])
REFERENCES [dbo].[Buses] ([Id_Bus])
GO
ALTER TABLE [dbo].[Asientos]  WITH CHECK ADD FOREIGN KEY([Id_Bus])
REFERENCES [dbo].[Buses] ([Id_Bus])
GO
ALTER TABLE [dbo].[Asignaciones]  WITH CHECK ADD FOREIGN KEY([Id_Bus])
REFERENCES [dbo].[Buses] ([Id_Bus])
GO
ALTER TABLE [dbo].[Asignaciones]  WITH CHECK ADD FOREIGN KEY([Id_Bus])
REFERENCES [dbo].[Buses] ([Id_Bus])
GO
ALTER TABLE [dbo].[Asignaciones]  WITH CHECK ADD FOREIGN KEY([Id_Conductor])
REFERENCES [dbo].[Conductores] ([Id_Conductor])
GO
ALTER TABLE [dbo].[Asignaciones]  WITH CHECK ADD FOREIGN KEY([Id_Conductor])
REFERENCES [dbo].[Conductores] ([Id_Conductor])
GO
ALTER TABLE [dbo].[Boletos]  WITH CHECK ADD FOREIGN KEY([Id_Asiento])
REFERENCES [dbo].[Asientos] ([Id_Asiento])
GO
ALTER TABLE [dbo].[Boletos]  WITH CHECK ADD FOREIGN KEY([Id_Asiento])
REFERENCES [dbo].[Asientos] ([Id_Asiento])
GO
ALTER TABLE [dbo].[Boletos]  WITH CHECK ADD FOREIGN KEY([Id_Pasajero])
REFERENCES [dbo].[Pasajeros] ([Id_Pasajero])
GO
ALTER TABLE [dbo].[Boletos]  WITH CHECK ADD FOREIGN KEY([Id_Pasajero])
REFERENCES [dbo].[Pasajeros] ([Id_Pasajero])
GO
ALTER TABLE [dbo].[Boletos]  WITH CHECK ADD FOREIGN KEY([Id_Viaje])
REFERENCES [dbo].[Viajes] ([Id_Viaje])
GO
ALTER TABLE [dbo].[Boletos]  WITH CHECK ADD FOREIGN KEY([Id_Viaje])
REFERENCES [dbo].[Viajes] ([Id_Viaje])
GO
ALTER TABLE [dbo].[Mantenimientos]  WITH CHECK ADD FOREIGN KEY([Id_Bus])
REFERENCES [dbo].[Buses] ([Id_Bus])
GO
ALTER TABLE [dbo].[Mantenimientos]  WITH CHECK ADD FOREIGN KEY([Id_Bus])
REFERENCES [dbo].[Buses] ([Id_Bus])
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD FOREIGN KEY([Id_Bus])
REFERENCES [dbo].[Buses] ([Id_Bus])
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD FOREIGN KEY([Id_Bus])
REFERENCES [dbo].[Buses] ([Id_Bus])
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD FOREIGN KEY([Id_Conductor])
REFERENCES [dbo].[Conductores] ([Id_Conductor])
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD FOREIGN KEY([Id_Conductor])
REFERENCES [dbo].[Conductores] ([Id_Conductor])
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD FOREIGN KEY([Id_Ruta])
REFERENCES [dbo].[Rutas] ([Id_Ruta])
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD FOREIGN KEY([Id_Ruta])
REFERENCES [dbo].[Rutas] ([Id_Ruta])
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD CHECK  (([Capacidad]>(0)))
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD CHECK  (([Capacidad]>(0)))
GO
