using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramRelations
{
    /// <summary>
    /// Aggregation Relationship : class People contains list of class Car. 
    /// If class People is deleted, class Car still remains.
    /// </summary>
    public class People
    {
        private List<Car> classCar;
        public String Name { get; set; }
        public List<Car> Cars
        {
            get { return classCar; }
            set { classCar = value; }
        }
    }
}
