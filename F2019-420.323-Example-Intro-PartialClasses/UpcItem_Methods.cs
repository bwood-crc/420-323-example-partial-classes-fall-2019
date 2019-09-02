using System;

namespace F2019_420._323_Example_Intro_PartialClasses
{
    partial class UpcItem
    {
        /// <summary>
        /// Get info on item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("UPC: {0}, Desc: {1}", this.UpcCode, this.ProductName);
        }
    }
}
