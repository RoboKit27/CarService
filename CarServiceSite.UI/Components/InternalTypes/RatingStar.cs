namespace CarServiceSite.UI.Components.InternalTypes
{
    public class RatingStar
    {
        public int Id { get; set; } = -1;
        public bool IsActive { get; set; } = false;

        public string GetCurrentImage()
        {
            switch (this.IsActive)
            {
                case true: return "images/active-star.png";
                case false: return "images/disable-star.png";
            }
        }
    }
}
