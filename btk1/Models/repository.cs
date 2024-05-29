namespace btk1.Models
{
    public class repository
    {
        private static List<candidate> application = new();
        public static IEnumerable<candidate> Application => application;

        public static void add(candidate candidate)
        {
            application.Add(candidate);
        }
    }
}

