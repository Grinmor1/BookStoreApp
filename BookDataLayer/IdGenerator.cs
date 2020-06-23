namespace BookDataLayer
{
    public static class IdGenerator
    {
        private static int Id { get; set; }

        public static int GenerateId()
        {
            return Id++;
        }
    }
}