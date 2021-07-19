-- Banco tcc

create database bd_tcc

use bd_tcc

insert into tb_tipo_usuario values (1,'Secretaria')
insert into tb_tipo_usuario values (2,'Coordenação')
insert into tb_tipo_usuario values (3,'Professor')

create table tb_tipo_usuario(
	id_tipo_usu int primary key,
	tipo_usu varchar(25) not null
)

create table tb_usuario(
	id_usu int primary key identity(1,1),
	id_tipo_usu int references tb_tipo_usuario(id_tipo_usu),
	usuario varchar(50) not null,
	senha varchar(25) not null
)

create table tb_curso(
	id_curso int primary key identity(1,1),
	curso varchar(50) not null,
	modulo_serie varchar(25) not null,
	periodo_curso varchar(25) not null
)

create table tb_disciplina(
	id_disc int primary key identity(1,1),
	disciplina varchar(50) not null,
	carga_horaria varchar(25) not null,
)

create table tb_disciplina_curso(
	id_disc_curso int primary key identity(1,1),
	id_disc int references tb_disciplina(id_disc),
	id_curso int references tb_curso(id_curso)
)

create table tb_classe(
	id_classe int primary key identity(1,1),
	id_curso int references tb_curso(id_curso),
	classe varchar(20) not null,
)

create table tb_aluno(
	id_aluno int primary key identity(1,1),
	nome_aluno varchar(100) not null,
	sexo_aluno varchar(9) not null,
	data_nascimento_aluno varchar(10) not null,
	logra_aluno varchar(100) not null,
	bairro_aluno varchar(50) not null,
	cidade_aluno varchar(50) not null,
	comp_logra_aluno varchar(50),
	numero_casa_aluno varchar(4) not null,
	uf_aluno varchar(2) not null,
	rg_aluno varchar(12) not null,
	cpf_aluno varchar(14) not null,
	tel_aluno varchar(13),
	cel_aluno varchar(14) not null,
	email_aluno varchar(50),
	foto_aluno varchar(100),
	nome_resp_um varchar(100) not null,
	tel_resp_um varchar(13),
	cel_resp_um varchar(14) not null,
	email_resp_um varchar(100),
	rg_resp_um varchar(12) not null,
	cpf_resp_um varchar(14) not null,
	hist_aluno varchar(100)
) 

create table tb_classe_aluno(
	id_classe_aluno int primary key identity(1,1),
	id_classe int references tb_classe(id_classe),
	id_aluno int references tb_aluno(id_aluno)
)

create table tb_funcionario(
	id_func int primary key identity(1,1),
	nome_func varchar(100) not null,
	sexo_func varchar(9) not null,
	data_nascimento_func varchar(10) not null,
	logra_func varchar(100) not null,
	bairro_func varchar(50) not null,
	cidade_func varchar(50) not null,
	uf_func varchar(2) not null,
	comp_logra_func varchar(50),
	numero_casa_func varchar(4) not null,
	rg_func varchar(12) not null,
	cpf_func varchar(14) not null,
	tel_func varchar(13),
	cel_func varchar(14) not null,
	email_func varchar(50),
	foto_func varchar(100),
	curriculum_func varchar(100),
	data_admissao_func varchar(10) not null
)

create table tb_professor(
	id_prof int primary key identity(1,1),
	nome_prof varchar(50) not null,
	sexo_prof varchar(9) not null,
	data_nascimento_prof varchar(10) not null,
	logra_prof varchar(100) not null,
	bairro_prof varchar(50) not null,
	cidade_prof varchar(50) not null,
	uf_prof varchar(2) not null,
	comp_logra_prof varchar(50),
	numero_casa_prof varchar(4) not null,
	rg_prof varchar(12) not null,
	cpf_prof varchar(14) not null,
	tel_prof varchar(13),
	cel_prof varchar(14) not null,
	email_prof varchar(50),
	foto_prof varchar(100),
	curriculum_prof varchar(100),
	data_admissao_prof varchar(10) not null
)

create table tb_professor_curso(
	id_prof_curso int primary key identity(1,1),
	id_prof int references tb_professor(id_prof),
	id_disc_curso int references tb_disciplina_curso (id_disc_curso)
)

create table tb_chamada(
	id_chamada_aluno int primary key identity(1,1),	
	id_classe_aluno int references tb_classe_aluno (id_classe_aluno),
	id_aluno int references tb_aluno (id_aluno),
	chamada char,
	dia varchar(10)
)

create table tb_mencao_aluno(
	id_mencao_aluno int primary key identity(1,1),
	id_classe_curso int references tb_classe_aluno(id_classe_aluno),
	id_aluno int references tb_aluno(id_aluno),
	id_prof_curso int references tb_professor_curso(id_prof_curso),
	mencao varchar(2),
	dia varchar(10)
	)

create table chamada(
	id_cham int primary key identity(1,1),
	id_curso int references tb_curso(id_curso),
	id_classe_aluno int references tb_classe_aluno(id_classe_aluno),
	id_disc int references tb_disciplina(id_disc),
	id_prof int references tb_professor(id_prof),
	data_cham smalldatetime not null,
	presenca varchar(20) not null
)

create table mencao(
	id_mencao int primary key identity(1,1),
	data date not null,
	id_curso int references tb_curso(id_curso),
	id_classe_aluno int references tb_classe_aluno(id_classe_aluno),
	id_disc int references tb_disciplina(id_disc),
	id_prof int references tb_professor(id_prof),
	mencao varchar(2) not null
)


select
	curso.curso,
	disciplina.disciplina
from disciplina_curso
	join curso on disciplina_curso.id_curso=curso.id_curso
	join disciplina on disciplina_curso.id_disc=disciplina.id_disc

SELECT
	curso.curso,curso.modulo_serie,curso.periodo_curso,
	disciplina.disciplina
FROM disciplina_curso
	JOIN curso on disciplina_curso.id_curso=curso.id_curso
	JOIN disciplina on disciplina_curso.id_disc=disciplina.id_disc
select 
	classe.classe,		
	aluno.nome_aluno,	
	aluno.rg_aluno,	
	curso.curso,			
	curso.modulo_serie, 
	curso.periodo_curso
from
	classe_aluno
	join classe on classe_aluno.id_classe = classe.id_classe
	join aluno  on classe_aluno.id_aluno  = aluno.id_aluno
	join curso  on classe.id_curso		  = curso.id_curso

SELECT
	professor.nome_prof			as Professor,
	professor.rg_prof			as RG,
	disciplina.disciplina		as Disciplina,
	curso.curso					as Curso,
	curso.modulo_serie			as modulo,
	curso.periodo_curso			as Periodo
FROM
		professor_curso
	join professor			on professor_curso.id_prof		 = professor.id_prof
	join disciplina_curso	on professor_curso.id_disc_curso = disciplina_curso.id_disc_curso
	join disciplina			on disciplina_curso.id_disc		 = disciplina.id_disc
	join curso				on disciplina_curso.id_curso	 = curso.id_curso

select usuario from usuario where usuario = 'Admin'

select * from disciplina

update disciplina set disciplina = 'matheus', carga_horaria = '150' where id_disc = 4;





