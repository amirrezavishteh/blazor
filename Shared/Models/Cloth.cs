using System.ComponentModel.DataAnnotations;

namespace P8.Shared
{
    public class Clothe
    {
        [Required]

        public int Price {get; set;}
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string Name{get; set;}
        [Required]

        public string discription{get;set;}
        public int Id {get; set;}
        [Required]

        public string Color {get; set;}
        public int Number;
        public int n;
        
        [Required]
        public int leftint{get; set;}
        [Required]
        public string addressaImage{get;set;}
        public override string ToString()
        {
            return $"{this.Name}, {this.Price}, {this.Id}, {this.Color}";
        }
        public override bool Equals(object obj)
        {
            var other = obj as Clothe;
            return (ReferenceEquals(other, null) ? false : other.Id == this.Id);
        }
        public override int GetHashCode()
        {
            return this.Id;
        }
        public void SetValue(Clothe other ){
            this.leftint=other.leftint;
            this.Id=other.Id;

        }
    }
}