-- SELECT GRANDE DO USUARIO RELACIONADO COM O TIPO_USUARIO
select tb_usuario.id_usu,tb_usuario.usuario,tb_usuario.senha,tb_usuario.id_tipo_usu,tb_tipo_usuario.tipo_usu
from tb_usuario
join tb_tipo_usuario on tb_usuario.id_tipo_usu= tb_tipo_usuario.id_tipo_usu

-- SELECT GRANDE DA CLASSE RELACIONADO COM O CURSO
select tb_classe.id_classe,tb_classe.classe,tb_classe.id_curso,tb_curso.curso
from tb_classe
join tb_curso on tb_classe.id_curso = tb_curso.id_curso

-- SELECT GRANDE DA DISCIPLINA_CURSO RELACIONANDO COM DISCIPLINAS E CURSO
select tb_disciplina_curso.id_disc_curso,tb_disciplina.disciplina,tb_curso.curso
from tb_disciplina_curso
inner join tb_disciplina on tb_disciplina_curso.id_disc = tb_disciplina.id_disc
inner join tb_curso on tb_disciplina_curso.id_curso = tb_curso.id_curso

-- SELECT GRANDE DO PROFESSOR_CURSO RELACIONANDO COM DISCIPLINA_CURSO, DISCIPLINA E CURSO
select tb_professor_curso.id_prof_curso,tb_professor.id_prof,tb_professor.nome_prof,tb_disciplina_curso.id_disc_curso,tb_curso.curso,tb_disciplina.disciplina
from tb_professor_curso
inner join tb_professor on tb_professor_curso.id_prof = tb_professor.id_prof
inner join tb_disciplina_curso on tb_professor_curso.id_disc_curso = tb_disciplina_curso.id_disc_curso
inner join tb_disciplina on tb_disciplina_curso.id_disc = tb_disciplina.id_disc
inner join tb_curso on tb_disciplina_curso.id_curso = tb_curso.id_curso

-- SELECT GRANDE DO CLASSE_ALUNO RELACIONANDO COM CLASSE E ALUNO
select tb_classe_aluno.id_classe_aluno,tb_classe.id_classe,tb_classe.classe,tb_aluno.id_aluno,tb_aluno.nome_aluno
from tb_classe_aluno
inner join tb_classe on tb_classe_aluno.id_classe = tb_classe.id_classe
inner join tb_aluno on tb_classe_aluno.id_aluno = tb_aluno.id_aluno
