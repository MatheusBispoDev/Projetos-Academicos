-- Banco tcc Procedures

use bd_tcc

create procedure sp_usuario_generico
	@acao int,
	@id_usu int,
	@id_tipo_usu int,
	@usuario varchar(50),
	@senha varchar(25)
as begin
if(@acao=1)
begin
	insert into tb_usuario values (@id_tipo_usu,@usuario,@senha)
	select * from tb_usuario
end
if(@acao=2)
begin
	select * from tb_usuario where id_usu=@id_usu
	update usuario set id_tipo_usu=@id_tipo_usu, usuario=@usuario, senha=@senha
	where id_usu=@id_usu
	select * from tb_usuario where id_usu=@id_usu
end
if(@acao=3)
begin	
	delete from tb_usuario where id_usu=@id_usu
	select * from tb_usuario
end
end

create procedure sp_curso_generico
	@acao int,
	@id_curso int,
	@curso varchar(50),
	@modulo_serie varchar(25),
	@periodo_curso varchar(25)
as begin
if(@acao=1)
begin
	insert into tb_curso values (@curso,@modulo_serie,@periodo_curso)
	select * from tb_curso
end
if(@acao=2)
begin
	update tb_curso set curso=@curso, modulo_serie=@modulo_serie, periodo_curso=@periodo_curso 
	where id_curso=@id_curso
	select * from tb_curso where id_curso=@id_curso
end
if(@acao=3)
begin
	delete from tb_curso where id_curso=@id_curso
	select * from tb_curso
end
end

create procedure sp_disciplina_generico
	@acao int,
	@id_disc int,
	@disciplina varchar(50),
	@carga_horaria varchar(25)
as begin
if(@acao=1)
begin
	insert into tb_disciplina values (@disciplina,@carga_horaria)
	select * from tb_disciplina
end
if(@acao=2)
begin
	update tb_disciplina set disciplina=@disciplina, carga_horaria=@carga_horaria
	where id_disc=@id_disc
	select * from tb_disciplina where id_disc=@id_disc
end
if(@acao=3)
begin
	delete from tb_disciplina where id_disc=@id_disc	
	select * from tb_disciplina
end
end

exec sp_classe_generico 1,null,5,'Turma A'

create procedure sp_classe_generico
	@acao int,
	@id_classe int,
	@id_curso int,
	@classe varchar(20)
as begin
if(@acao=1)
begin
	insert into tb_classe values (@id_curso,@classe)
	select * from tb_classe
end
if(@acao=2)
begin
	update tb_classe set id_curso = @id_curso, classe=@classe
	where id_classe=@id_classe
	select * from tb_classe where id_classe=@id_classe
end
if(@acao=3)
begin
	delete from tb_classe where id_classe=@id_classe
	select * from tb_classe
end
end

create procedure sp_aluno_generico
	@acao int,
	@id_aluno int,
	@nome_aluno varchar(50),
	@sexo varchar(9),
	@data_nascimento_aluno varchar(10),
	@logra_aluno varchar(100),
	@bairro_aluno varchar(50),
	@cidade_aluno varchar(50),
	@comp_logra_aluno varchar(50),
	@numero_casa_aluno varchar(4),
	@uf_aluno varchar(2),
	@rg_aluno varchar(12),
	@cpf_aluno varchar(14),
	@tel_aluno varchar(13),
	@cel_aluno varchar(14),
	@email_aluno varchar(50),
	@foto_aluno varchar(100),
	@nome_resp_um varchar(100),
	@tel_resp_um varchar(13),
	@cel_resp_um varchar(14),
	@email_resp_um varchar(100),
	@rg_resp_um varchar(12),
	@cpf_resp_um varchar(14),
	@hist_aluno varchar(100)
as
begin
if(@acao=1)begin
	insert into tb_aluno values (@nome_aluno,
		 @sexo,
		 @data_nascimento_aluno,
		 @logra_aluno,
		 @bairro_aluno,
		 @cidade_aluno,
		 @comp_logra_aluno,
		 @numero_casa_aluno,
		 @uf_aluno,
		 @rg_aluno,
		 @cpf_aluno,
		 @tel_aluno,
		 @cel_aluno,
		 @email_aluno,
		 @foto_aluno,
		 @nome_resp_um,
		 @tel_resp_um,
		 @cel_resp_um,
		 @email_resp_um,
		 @rg_resp_um,
		 @cpf_resp_um,
		 @hist_aluno)
	select * from tb_aluno
end
if(@acao=2)
begin
	update tb_aluno set nome_aluno=@nome_aluno, 
		sexo_aluno=@sexo,
		data_nascimento_aluno=@data_nascimento_aluno, 
		logra_aluno=@logra_aluno,
		bairro_aluno=@bairro_aluno, 
		cidade_aluno=@cidade_aluno, 
		comp_logra_aluno=@comp_logra_aluno, 
		numero_casa_aluno=@numero_casa_aluno,
		uf_aluno=@uf_aluno, 
		cpf_aluno=@cpf_aluno, 
		tel_aluno=@tel_aluno, 
		cel_aluno=@cel_aluno, 
		email_aluno=@email_aluno, 
		foto_aluno=@foto_aluno,
		nome_resp_um=@nome_resp_um,
		tel_resp_um=@tel_resp_um,
		cel_resp_um=@cel_resp_um, 
		email_resp_um=@email_resp_um, 
		rg_resp_um=@rg_resp_um, 
		cpf_resp_um=@cpf_resp_um,
		hist_aluno=@hist_aluno
	where id_aluno=@id_aluno
	select * from tb_aluno where id_aluno=@id_aluno
end
if(@acao=3)
begin
	delete from tb_aluno where id_aluno=@id_aluno
	select * from tb_aluno
end
end

create procedure sp_funcionario_generico
	@acao int,
	@id_func int,
	@nome_func varchar(100),
	@sexo_func varchar(9),
	@data_nascimento_func varchar(10),
	@logra_func varchar(100),
	@bairro_func varchar(50),
	@cidade_func varchar(50),
	@uf_func varchar(2),
	@comp_logra_func varchar(50),
	@numero_casa_func varchar(4),
	@rg_func varchar(12),
	@cpf_func varchar(14),
	@tel_func varchar(13),
	@cel_func varchar(14),
	@email_func varchar(50),
	@foto_func varchar(100),
	@curriculum_func varchar (100),
	@admissao_func varchar(10)
as begin
if(@acao=1)
begin
	insert into tb_funcionario values (@nome_func,
		@sexo_func,
	    @data_nascimento_func,
		@logra_func,
		@bairro_func,
		@cidade_func,
		@uf_func,
		@comp_logra_func,
	    @numero_casa_func,
		@rg_func,
	    @cpf_func,
	    @tel_func,
		@cel_func,
		@email_func,
		@foto_func,
		@curriculum_func,
	    @admissao_func)
	select * from tb_funcionario
end
if(@acao=2)
begin
	update tb_funcionario set nome_func=@nome_func, 
		   sexo_func=@sexo_func,
		   data_nascimento_func=@data_nascimento_func,
		   logra_func=@logra_func,
		   bairro_func=@bairro_func,
		   cidade_func=@cidade_func,
		   uf_func=@uf_func,
		   comp_logra_func=@comp_logra_func,
		   numero_casa_func=@numero_casa_func,
		   rg_func=@rg_func,
		   cpf_func=@cpf_func,
		   tel_func=@tel_func,
		   cel_func=@cel_func,
		   email_func=@email_func,
		   foto_func=@foto_func,
		   curriculum_func=@curriculum_func,
		   data_admissao_func=@admissao_func
	where id_func=@id_func
	select * from tb_funcionario where id_func=@id_func
end
if(@acao=3)
begin
	delete from tb_funcionario where id_func=@id_func
	select * from tb_funcionario
end
end

create procedure sp_professor_generico
	@acao int,
	@id_prof int,
	@nome_prof varchar(50),
	@sexo_prof varchar(9),
	@data_nascimento_prof varchar(10),
	@logra_prof varchar(100),
	@bairro_prof varchar(50),
	@cidade_prof varchar(50),
	@uf_prof varchar (2),
	@comp_logra_prof varchar(50),
	@numero_casa_prof varchar(4),
	@rg_prof varchar(12),
	@cpf_prof  varchar(14),
	@tel_prof varchar(14),
	@cel_prof varchar(13),
	@email_prof varchar(50),
	@foto_prof varchar(100),
	@curriculum_prof varchar(100),
	@data_admissao_prof varchar(10)
as begin
if(@acao=1)
begin
	insert into tb_professor values (@nome_prof,
			@sexo_prof,
			@data_nascimento_prof,
			@logra_prof,
			@bairro_prof,
			@cidade_prof,
			@uf_prof,
			@comp_logra_prof,
			@numero_casa_prof,
			@rg_prof,
			@cpf_prof,
			@tel_prof,
			@cel_prof,
			@email_prof,
			@foto_prof,
			@curriculum_prof,
			@data_admissao_prof
			)
	select * from tb_professor
end
if(@acao=2)
begin
	update tb_professor set nome_prof = @nome_prof,
	sexo_prof = @sexo_prof,
	data_nascimento_prof = @data_nascimento_prof,
	logra_prof = @logra_prof,
	bairro_prof = @bairro_prof,
	cidade_prof = @cidade_prof,
	uf_prof = @uf_prof,
	comp_logra_prof = @comp_logra_prof,
	numero_casa_prof = @numero_casa_prof,
	rg_prof = @rg_prof,
	cpf_prof = @cpf_prof,
	tel_prof = @tel_prof,
	cel_prof = @cel_prof,
	email_prof = @email_prof,
	foto_prof = @foto_prof,
	curriculum_prof = @curriculum_prof,
	data_admissao_prof = @data_admissao_prof
	where id_prof=@id_prof
	select * from tb_professor where id_prof=@id_prof
end
if(@acao=3)
begin
	delete from tb_professor where id_prof=@id_prof
	select * from tb_professor
end
end

select * from tb_usuario 