namespace ExampleForm.FakestoreApi.Mock
{
    public static class MockValues
    {
        /// <summary>
        /// Devuelve una lista mock de las categorias disponbiles
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> GetMockCategories()
        {
            return
            [
                new KeyValuePair<string, string>("1", "Clothing"),
                new KeyValuePair<string, string>("2", "Shoes"),
                new KeyValuePair<string, string>("3", "Consumer Electronics"),
                new KeyValuePair<string, string>("4", "Books"),
                new KeyValuePair<string, string>("5", "Movies"),
                new KeyValuePair<string, string>("6", "Music"),
                new KeyValuePair<string, string>("7", "Games"),
                new KeyValuePair<string, string>("8", "Personal Care and Beauty"),
                new KeyValuePair<string, string>("9", "Food and Beverage"),
            ];
        }
    }
}
