-- Banco tcc Triggers

use bd_tcc

create trigger tgr_usuario_morto
	on tb_usuario
	after delete
as
begin
	insert into tb_usuario_morto
	select * from deleted
end

create trigger tgr_curso_morto
	on tb_curso
	after delete
as
begin
	insert into tb_curso_morto
	select * from deleted
end

create trigger tgr_disciplina_morto
	on tb_disciplina
	after delete
as
begin
	insert into tb_disciplina_morto
	select * from deleted
end

create trigger tgr_disciplina_curso_morto
	on tb_disciplina_curso
	after delete
as
begin
	insert into tb_disciplina_curso_morto
	select * from deleted
end

create trigger tgr_classe_morto
	on tb_classe
	after delete
as 
begin
	insert into tb_classe_morto
	select * from deleted
end

create trigger tgr_aluno_morto
	on tb_aluno
	after delete
as
begin
	insert into tb_aluno_morto
	select * from deleted

end

create trigger tgr_classe_aluno
	on tb_classe_aluno
	after delete
as
begin
	insert into tb_classe_aluno_morto
	select * from deleted
end

create trigger tgr_funcionario_morto
	on tb_funcionario
	after delete
as
begin
	insert into tb_funcionario_morto
	select * from deleted
end

create trigger tgr_professor_morto
	on tb_professor
	after delete
as 
begin
	insert into tb_professor_morto
	select* from deleted
end

create trigger tgr_professor_curso
	on tb_professor_curso
	after delete
as
begin
	insert into tb_professor_curso_morto
	select * from deleted
end

