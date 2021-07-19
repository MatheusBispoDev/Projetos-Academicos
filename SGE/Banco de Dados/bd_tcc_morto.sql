-- Banco tcc Morto

use bd_tcc

create table tb_usuario_morto(
	id_usu int primary key,
	id_tipo_usu int references tb_tipo_usuario(id_tipo_usu),
	usuario varchar(50),
	senha varchar(25)
)

create table tb_curso_morto(
	id_curso int primary key,
	curso varchar(50) not null,
	modulo_serie varchar(25) not null,
	periodo_curso varchar(25) not null
)

create table tb_disciplina_morto(
	id_disc int primary key,
	disciplina varchar(50) not null,
	carga_horaria varchar(25) not null
)

create table tb_disciplina_curso_morto(
	id_disc_curso int primary key,
	id_disc int references tb_disciplina(id_disc),
	id_curso int references tb_curso(id_curso)
)

create table tb_classe_morto(
	id_classe int primary key,
	id_curso int references tb_curso(id_curso),
	classe varchar(20) not null
)

create table tb_aluno_morto(
	id_aluno int primary key,
	nome_aluno varchar(100),
	sexo_aluno varchar(9),
	data_nascimento_aluno varchar(10),
	logra_aluno varchar(100),
	bairro_aluno varchar(50),
	cidade_aluno varchar(50),
	comp_logra_aluno varchar(50),
	numero_casa_aluno varchar(4) ,
	uf_aluno varchar(2),
	rg_aluno varchar(12) ,
	cpf_aluno varchar(14) ,
	tel_aluno varchar(13),
	cel_aluno varchar(14),
	email_aluno varchar(50),
	foto_aluno varchar(100),
	nome_resp_um varchar(100),
	tel_resp_um varchar(13),
	cel_resp_um varchar(14),
	email_resp_um varchar(100),
	rg_resp_um varchar(12),
	cpf_resp_um varchar(14),
	hist_aluno varchar(100)
)

create table tb_classe_aluno_morto(
	id_classe_aluno int primary key,
	id_classe int references tb_classe(id_classe),
	id_aluno int references tb_aluno(id_aluno)
)

create table tb_funcionario_morto(
	id_func int primary key,
	nome_func varchar(100),
	sexo_func varchar(9),
	data_nascimento_func varchar(10),
	logra_func varchar(100),
	bairro_func varchar(50),
	cidade_func varchar(50),
	uf_func varchar(2),
	comp_logra_func varchar(50),
	numero_casa_func varchar(4),		
	rg_func varchar(12),
	cpf_func varchar(14),
	tel_func varchar(13),
	cel_func varchar(14),
	email_func varchar(50),
	foto_func varchar(100),
	curriculum_func varchar(100),
	data_admissao_func varchar(10)
)

create table tb_professor_morto(
	id_prof int primary key,
	nome_prof varchar(50),
	sexo_prof varchar(9),
	data_nascimento_prof varchar(10),
	logra_prof varchar(100),
	bairro_prof varchar(50),
	cidade_prof varchar(50),
	uf_prof varchar(2),
	comp_logra_prof varchar(50),
	numero_casa_prof varchar(4),
	rg_prof varchar(12),
	cpf_prof varchar(14),
	tel_prof varchar(13),
	cel_prof varchar(14),
	email_prof varchar(50),
	foto_prof varchar(100),
	curriculum_prof varchar(100),
	data_admissao_prof varchar(10)
)

create table tb_professor_curso_morto(
	id_prof_curso int primary key,
	id_prof int references tb_professor(id_prof),
	id_disc_curso int references tb_disciplina_curso (id_disc_curso)
)

