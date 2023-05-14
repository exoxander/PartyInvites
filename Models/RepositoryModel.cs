namespace PartyInvites.Models
{
    public class RepositoryModel
    {
        public static List<GuestResponseModel> responses = new();
        public static IEnumerable<GuestResponseModel> Responses => responses;
        public static void AddResponse(GuestResponseModel response)
        {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}
