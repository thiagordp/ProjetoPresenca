USE [ListaPresenca]

/****** Object:  Table [dbo].[Aluno]    Script Date: 12/03/2016 13:45:50 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[Aluno](
	[CODIGO_ALUNO] [int] NOT NULL,
	[NOME_ALUNO] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[CODIGO_ALUNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[AlunoTurma]    Script Date: 12/03/2016 13:45:50 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[AlunoTurma](
	[SEQ_DISCIPLINA_TURMA] [int] NOT NULL,
	[CODIGO_ALUNO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SEQ_DISCIPLINA_TURMA] ASC,
	[CODIGO_ALUNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Datahora]    Script Date: 12/03/2016 13:45:50 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Datahora](
	[DIA] [int] NOT NULL,
	[HORA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DIA] ASC,
	[HORA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Disciplina]    Script Date: 12/03/2016 13:45:50 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[Disciplina](
	[CODIGO_DISCIPLINA] [int] NOT NULL,
	[NOME_DISCIPLINA] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[CODIGO_DISCIPLINA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[DisciplinaTurma]    Script Date: 12/03/2016 13:45:50 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[DisciplinaTurma](
	[SEQ_DISCIPLINA_TURMA] [int] NOT NULL,
	[CODIGO_DISCIPLINA] [int] NULL,
	[CODIGO_TURMA] [varchar](6) NULL,
	[CODIGO_SEMESTRE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SEQ_DISCIPLINA_TURMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[Semestre]    Script Date: 12/03/2016 13:45:50 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Semestre](
	[CODIGO_SEMESTRE] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODIGO_SEMESTRE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Turma]    Script Date: 12/03/2016 13:45:50 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[Turma](
	[CODIGO_TURMA] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODIGO_TURMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[TurmaHora]    Script Date: 12/03/2016 13:45:50 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[TurmaHora](
	[SEQ_DISCIPLINA_TURMA] [int] NOT NULL,
	[DIA] [int] NOT NULL,
	[HORA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SEQ_DISCIPLINA_TURMA] ASC,
	[DIA] ASC,
	[HORA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[AlunoTurma]  WITH CHECK ADD FOREIGN KEY([CODIGO_ALUNO])
REFERENCES [dbo].[Aluno] ([CODIGO_ALUNO])

ALTER TABLE [dbo].[AlunoTurma]  WITH CHECK ADD FOREIGN KEY([SEQ_DISCIPLINA_TURMA])
REFERENCES [dbo].[DisciplinaTurma] ([SEQ_DISCIPLINA_TURMA])

ALTER TABLE [dbo].[DisciplinaTurma]  WITH CHECK ADD FOREIGN KEY([CODIGO_DISCIPLINA])
REFERENCES [dbo].[Disciplina] ([CODIGO_DISCIPLINA])

ALTER TABLE [dbo].[DisciplinaTurma]  WITH CHECK ADD FOREIGN KEY([CODIGO_TURMA])
REFERENCES [dbo].[Turma] ([CODIGO_TURMA])

ALTER TABLE [dbo].[DisciplinaTurma]  WITH CHECK ADD FOREIGN KEY([CODIGO_SEMESTRE])
REFERENCES [dbo].[Semestre] ([CODIGO_SEMESTRE])

ALTER TABLE [dbo].[TurmaHora]  WITH CHECK ADD FOREIGN KEY([DIA], [HORA])
REFERENCES [dbo].[Datahora] ([DIA], [HORA])

ALTER TABLE [dbo].[TurmaHora]  WITH CHECK ADD FOREIGN KEY([SEQ_DISCIPLINA_TURMA])
REFERENCES [dbo].[DisciplinaTurma] ([SEQ_DISCIPLINA_TURMA])

USE [master]

ALTER DATABASE [ListaPresenca] SET  READ_WRITE 
