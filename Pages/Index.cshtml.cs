using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Zodiac.Pages;
using Zodiac.Models;

public class IndexModel : PageModel
{
    public string zodiacSign { get; set; }
    [BindProperty]
    public int year { get; set;}

    public string zodiacImage { get; set; }
    public void OnGet()
        {
            // Initialize the ZodiacSign property to an empty string when the page is first loaded.
            zodiacSign = string.Empty;
        }

        public void OnPost()
        {
            // Handle form submission when the user submits a year.
            if(year > 1900 && year < (DateTime.Now.Year + 1)) {
                zodiacSign = "Your zodiac is " + Utils.GetZodiac(year);
                zodiacImage = "/images/" + Utils.GetZodiac(year) + ".png";
            } else {
                zodiacSign = "The year must be between 1900 and next year. Please try again.";
            } 
        }
    
}
