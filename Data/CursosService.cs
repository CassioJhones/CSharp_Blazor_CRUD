using CassioJhones.Data;
using System.Collections.Generic;
using System.Linq;
namespace CassioJhones.Data
{
    public class CursosService
    {
        private readonly AppDBContext _db;
        public CursosService(AppDBContext db)
        {
            _db = db;
        }
        // Operações CRUD (Create, Read, Update e Delete)
        // Obter todos os Curso
        public List<Curso> GetCurso()
        {
            var cursoList = _db.Cursos.ToList();
            return cursoList;
        }
        // Inserir um Curso
        public string Create(Curso objCurso)
        {
            _db.Cursos.Add(objCurso);
            _db.SaveChanges();
            return "Curso salvo com sucesso";
        }
        // Obter um Curso pelo Id
        public Curso GetCursoById(int id)
        {
            Curso objCurso = _db.Cursos.FirstOrDefault(a => a.Id == id);
            return objCurso;
        }
        // Atualizar um Curso
        public string UpdateCurso(Curso objCurso)
        {
            _db.Cursos.Update(objCurso);
            _db.SaveChanges();
            return "Curso atualizado com sucesso";
        }
        // Remover um Curso
        public string DeleteCurso(Curso objCurso)
        {
            _db.Cursos.Remove(objCurso);
            _db.SaveChanges();
            return "Curso removido com sucesso";
        }
    }
}
