using System.ComponentModel.DataAnnotations;

namespace datatable_test.Models;

public class User {
  public string Name { get; set; }
  [Display(Name = "This is short")]
  public string Alias { get; set; }

  public User(string name, string alias) 
  {
    this.Name = name;
    this.Alias = alias;
  }
}
