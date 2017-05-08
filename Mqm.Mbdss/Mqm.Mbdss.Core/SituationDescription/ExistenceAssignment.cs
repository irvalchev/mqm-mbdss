namespace Mqm.Mbdss.Core.SituationDescription
{
    public class ExistenceAssignment
    {
        #region Properties

        public string Description { get; set; }
        public bool Exists { get; set; }
        public int Id { get; set; }
        public IStructuralElement Element { get; set; }

        #endregion Properties
    }
}