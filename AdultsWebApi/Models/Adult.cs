using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Models {
public class Adult : Person {
     public Job JobTitle { get; set; }
    
    public override string ToString() {
        return JsonSerializer.Serialize(this);
    }
}
}