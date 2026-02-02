using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Lab.Pages
{
    public class IndexModel : PageModel
    {
        public int HungerLevel { get; set; }
        public string HungerMessage { get; set; } = string.Empty;
        public string Recommendation { get; set; } = string.Empty;
        public string EncouragementMessage { get; set; } = string.Empty;
        public bool ShowResults { get; set; } = false;

        public void OnGet()
        {
            // This runs when the page first loads
            // We don't need to do anything here for this app
        }

        public void OnPost(int hungerLevel)
        {
            // This runs when the form is submitted
            HungerLevel = hungerLevel;
            ShowResults = true;

            // If-else statement for hunger message
            if (HungerLevel >= 8)
            {
                HungerMessage = "You're super hungry! Order both tacos and burritos.";
            }
            else if (HungerLevel >= 5)
            {
                HungerMessage = "You're moderately hungry. Go for tacos!";
            }
            else
            {
                HungerMessage = "You're not that hungry. Opt for a burrito.";
            }

            // Ternary operator for recommendation
            Recommendation = (HungerLevel >= 5) ? "Tacos" : "Burrito";

            // Switch statement for encouragement
            switch (HungerLevel)
            {
                case 10:
                    EncouragementMessage = "You're a taco and burrito champion!";
                    break;
                case 7:
                case 8:
                case 9:
                    EncouragementMessage = "Taco time!";
                    break;
                case 4:
                case 5:
                case 6:
                    EncouragementMessage = "Burrito it is!";
                    break;
                default:
                    EncouragementMessage = "Maybe just grab a snack.";
                    break;
            }
        }
    }
}