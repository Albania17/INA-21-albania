using System;
using System.Collections.Generic;
using System.Text;

namespace Utilidades.InterFace
{
    public interface IServices<entity>
    {
        entity save(entity entity);
        IEnumerable<entity> getAll();
        entity getById(int id);
        bool delete(entity entity);
        entity update(entity entity);

    }
}
