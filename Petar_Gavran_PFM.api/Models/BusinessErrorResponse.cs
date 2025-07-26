namespace Petar_Gavran_PFM.api.Models
{
    public class BusinessErrorResponse
    {
        /// <summary>
        /// Explanation of business rule that rejected request
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Unique literal that identifies specific problem.
        /// Example: "task-already-claimed"
        /// </summary>
        public string Problem { get; set; }

        /// <summary>
        /// Message explaining the situation and optionally remedies
        /// Example: "Task already claimed"
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Optional details supplied for troubleshooting
        /// Example: "User john.doe has claimed the task"
        /// </summary>
        public string Details { get; set; }
    }

}
