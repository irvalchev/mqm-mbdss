namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ExistenceAssignment
    {
        #region Properties

        public string Description { get; set; }
        public bool Exists { get; set; }
        public int Id { get; set; }
        public IStructuralElementDefinition Element { get; set; }

        #endregion Properties
    }
}