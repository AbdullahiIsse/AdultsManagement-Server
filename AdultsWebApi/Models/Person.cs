using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Models {
public class Person {
    
    public int Id { get; set; }
    
    [Required,NotNull] public string FirstName { get; set; }
    [Required,NotNull] public string LastName { get; set; }
    [Required,NotNull] public string HairColor { get; set; }
    [Required,NotNull] public string EyeColor { get; set; }
    [Range(17, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]public int Age { get; set; }
    [Range(1, float.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")] [Required] public float Weight { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")][Required] public int Height { get; set; }
    [Required,NotNull] public string Sex { get; set; }
    
}


}