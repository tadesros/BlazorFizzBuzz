using System.ComponentModel.DataAnnotations;

//models

namespace BlazorFizzBuzz.Models
{
    public class FizzBuzzModel
    {
        [Required(ErrorMessage = "Please enter a Fizz Value")]
        [Range(1, 100, ErrorMessage = "Value must be between 1 and 100")]
        public int FizzValue { get; set; } = 3;


        [Required(ErrorMessage = "Please enter a Buzz Value")]
        [Range(1, 100, ErrorMessage = "Value must be between 1 and 100")]
        public int BuzzValue { get; set; } = 5;


        [Required(ErrorMessage = "Please enter a Buzz Value")]
        [Range(1, 1000, ErrorMessage = "Value must be between 1 and 1000")]
        public int StopValue { get; set; } = 100;

    }
}
