namespace F2019_420._323_Example_Intro_PartialClasses
{
    partial class UpcItem
    {
        /// <summary>
        /// UPC Code
        /// </summary>
        public string UpcCode { get; set; }

        /// <summary>
        /// Name of catalog item.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="upcCode">UPC Code</param>
        /// <param name="productName">Product Name</param>
        public UpcItem(string upcCode, string productName)
        {
            this.UpcCode = upcCode;
            this.ProductName = productName;
        }

    }
}
