namespace ProductLibrary.Models
{
    public class ProductCommonOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "Id";
            string name = "Product Name";
            string description = "Description";
            string price = "Price";
            string heading = $"{id.PadRight(6)}\t{name.PadRight(15)}\t{description.PadRight(30)}\t{price}";
            return heading;
        }
        private static string GetUnderlineForHeading(string heading)
        {
            return new string('_', heading.Length -1);
        }
        public static string GetApplicationHeading()
        {
            string heading = "Product CRUD Application";
            //string underline = GetUnderlineForHeading(heading);
            return $"{heading}\n";
        }
        public static string GetInstructions()
        {
            return "[C] Create, [R] Read, [U] Update, [D] Delete, Press any key to end";
        }
    }
}
