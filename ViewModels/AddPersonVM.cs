using System.ComponentModel.DataAnnotations;

namespace DominikO_Tree.ViewModels
{
    public class AddPersonVM
    {
        [Required(ErrorMessage = "Imie i nazwisko wymagane")]
        [RegularExpression("^[a-zA-Z]+(\\s+[a-zA-Z]+)*$", ErrorMessage = "W imieniu i nazwisku mogą być tylko litery")]
        [MinLength(5, ErrorMessage = "Minimum 5 liter")]
        [MaxLength(20, ErrorMessage = "Maksymalnie 50 liter")]
        public string Name { get; set; }
        
        public int ParentId { get; set; }
    }
}