using System.Collections.Generic;

namespace InwentaryzacjaIT.Interfaces
{
    // interfejs repozytorium do operacji CRUD
    public interface IRepository<T>
    {
        // Pobiera wszystkie rekordy z bazy
        List<T> GetAll();       

        // Pobiera konkretny rekord po jego ID
        T GetById(int id);      

        // Dodaje nowy rekord i zwraca jego nowe ID
        int Add(T entity);      

        // Aktualizuje dane istniejącego rekordu
        void Update(T entity);  

        // Usuwa rekord o podanym ID
        void Delete(int id);    
    }
}