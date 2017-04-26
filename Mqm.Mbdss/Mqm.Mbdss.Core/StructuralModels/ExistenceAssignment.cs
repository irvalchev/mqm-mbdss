namespace Mqm.Mbdss.Core
{
    public class ExistenceAssignment
    {
        #region Properties

        public string Description { get; set; }
        public bool Exists { get; set; }
        public int Id { get; set; }
        public IStructuralElement StructuralElement { get; set; }

        #endregion Properties
    }
}