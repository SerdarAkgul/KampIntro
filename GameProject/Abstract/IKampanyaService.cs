using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IKampanyaService
    {
        void Add(Kampanya kampanya);
        void Delete(Kampanya kampanya);
        void Update(Kampanya kampanya);
        List<Kampanya> GetAll();
    }
}
