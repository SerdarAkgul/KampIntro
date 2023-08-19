using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Kampanya: IEntity
    {
        public int Id { get; set; }
        public string KampanyaAdi { get; set; }
        public string IndırımOranı { get; set; }
    }
}
