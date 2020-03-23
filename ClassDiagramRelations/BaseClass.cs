using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramRelations
{
    /// <summary>
    /// Composition Relationship: ComposedClass is a nested class of BaseClass.
    /// If BaseClass is deleted composed class is deleted as well.
    /// </summary>
    public class BaseClass
    {
        private List<ComposedClass> composedClass;
        public List<ComposedClass> Composed
        {
            get { return composedClass; }
            set { composedClass = value; }
        }
        public class ComposedClass
        {
        }
    }
}
