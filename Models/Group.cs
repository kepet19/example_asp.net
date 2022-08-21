using datatable_test.Models.Interface;

namespace datatable_test.Models;

public class Group : IEntity {
  public string Name { get; set; }
  public int Id { get; set; }
  public Type Type { get; set; }
  public DateTime Created { get; set; }
  public DateTime Edited { get; set; }
  public int ModifiedById { get; set; }
  int IId.Id { get; set; }

  public Group(string name, Type type) {
    this.Name = name;
    this.Type = type;
  }

  override public string ToString() { return $"{Id}, {Name}, {Type}"; }
}

public enum Type { Role = 0, Security = 1 }
