namespace Data;

using System.Collections.Generic;

public interface IRepositorio<T>
{
    void Guardar(T entidad);
    List<T> ObtenerTodos();
}