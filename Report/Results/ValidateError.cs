namespace Rocket.Report.Results
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidationError
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public ValidationError(string code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
