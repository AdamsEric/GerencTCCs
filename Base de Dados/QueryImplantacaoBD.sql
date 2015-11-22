CREATE DATABASE GerencTCCs

GO

USE GerencTCCs

GO



CREATE TABLE tblUnidade(

UnidadeID INT PRIMARY KEY IDENTITY(1,1),

UnidadeNome NVARCHAR(80) NOT NULL,

UnidadeCidade NVARCHAR(50) NOT NULL,

UnidadeEstado NVARCHAR(2) NOT NULL,

UnidadePais NVARCHAR(45) NOT NULL)

GO



CREATE TABLE tblSalaTipo(

SalaTipoID INT PRIMARY KEY IDENTITY(1,1),

SalaTipoTipo NVARCHAR(15) NOT NULL)

GO




CREATE TABLE tblSala(

SalaID INT PRIMARY KEY IDENTITY(1,1),

SalaNome NVARCHAR(10) NOT NULL,

SalaDescricao NVARCHAR(70) NULL,

SalaUnidadeID INT FOREIGN KEY REFERENCES tblUnidade(UnidadeID),

SalaSalaTipoID INT FOREIGN KEY REFERENCES tblSalaTipo(SalaTipoID))

GO




CREATE TABLE tblProfessor(

ProfessorID INT PRIMARY KEY IDENTITY(1,1),

ProfessorNome NVARCHAR(70) NOT NULL,

ProfessorMatricula VARCHAR(15) UNIQUE NOT NULL,

ProfessorTelefone VARCHAR(13))

GO




CREATE TABLE tblCurso(

CursoID INT PRIMARY KEY IDENTITY(1,1),

CursoNome NVARCHAR(80) NOT NULL,

CursoUnidadeID INT FOREIGN KEY REFERENCES tblUnidade(UnidadeID))

GO

CREATE TABLE tblAluno(

AlunoID INT PRIMARY KEY IDENTITY(1,1),

AlunoNome NVARCHAR(70) NOT NULL,

AlunoMatricula NVARCHAR(15) UNIQUE NOT NULL,

AlunoTelefone VARCHAR(13),

AlunoCursoID INT FOREIGN KEY REFERENCES tblCurso(CursoID))

GO 

CREATE TABLE tblTCC(

TCCID INT PRIMARY KEY IDENTITY(1,1),

TCCTitulo NVARCHAR(250) NOT NULL,

TCCGrandeArea NVARCHAR (200) NOT NULL,

TCCArea NVARCHAR (400) NOT NULL,

TCCSubarea NVARCHAR (1000) NOT NULL,

TCCEspecialidade NVARCHAR (500) NULL,

TCCResumo NVARCHAR (MAX) NULL,

TCCPaginas INT NULL,

TCCData DATETIME NULL,

TCCSalaID INT FOREIGN KEY REFERENCES tblSala(SalaID) NULL,

TCCAlunoID INT FOREIGN KEY REFERENCES tblAluno(AlunoID),

TCCOrientadorID INT FOREIGN KEY REFERENCES tblProfessor(ProfessorID))

GO

CREATE TABLE tblBanca(

BancaID INT PRIMARY KEY IDENTITY(1,1),

BancaProfessor1 INT FOREIGN KEY REFERENCES tblProfessor(ProfessorID),

BancaProfessor2 INT FOREIGN KEY REFERENCES tblProfessor(ProfessorID),

BancaProfessor3 INT FOREIGN KEY REFERENCES tblProfessor(ProfessorID),

BancaTCCID INT FOREIGN KEY REFERENCES tblTCC(TCCID))

GO

CREATE TABLE tblGrupo(

GrupoID INT PRIMARY KEY IDENTITY(1,1),

GrupoNome VARCHAR(15) NOT NULL

)

CREATE TABLE tblUsuario(

UsuarioID INT PRIMARY KEY IDENTITY(1,1),

UsuarioLogin NVARCHAR(15) NOT NULL,

UsuarioSenha  NVARCHAR(15) NOT NULL,

UsuarioNome NVARCHAR(70) NOT NULL,

UsuarioMatricula NVARCHAR(15) NULL,

UsuarioGrupoID INT FOREIGN KEY REFERENCES tblGrupo(GrupoID)

)

insert into tblGrupo (GrupoNome) values ('ADMINISTRADOR')
insert into tblGrupo (GrupoNome) values ('GERENTE')
insert into tblGrupo (GrupoNome) values ('REGISTRADOR')

insert into tblSalaTipo (SalaTipoTipo) values ('SALA')
insert into tblSalaTipo (SalaTipoTipo) values ('LABORATÓRIO')

GO