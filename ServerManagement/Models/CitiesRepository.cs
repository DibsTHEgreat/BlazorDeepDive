namespace ServerManagement.Models
{
    public static class CitiesRepository
    {
        private static List<string> cities = new List<string>()
        {
            "Toronto",
            "Montreal",
            "Calgary",
            "Ottawa",
            "Halifax",
        };

        public static List<string> GetCities() => cities;
    }
}
