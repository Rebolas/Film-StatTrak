namespace Film_StatTrak.Models
{
    public class ErrorViewModel
    {

        /// <summary>
        /// hhf
        /// </summary>
        public int Id { get; set; }


        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}