namespace datatable_test.Models.Interface;

public interface IEntity : IId {
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public int ModifiedById { get; set; }
}
