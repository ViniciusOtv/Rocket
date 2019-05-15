namespace Rocket.Report.Results
{
    public class MethodResult
    {
        public MethodResult(ResultStatusCode status)
        {
            Status = status;
        }

        public ResultStatusCode Status { get; set; }
    }

    public class MethodResult<TContent> : MethodResult
    {
        public TContent Content { get; set; }

        public MethodResult(TContent content, ResultStatusCode status)
            : base(status)
        {
            Content = content;
        }
    }

    /// <summary>
    /// Indica o resultado de um processamento realizado.
    /// </summary>
    public enum ResultStatusCode
    {
        #region 2xx Codes (Success)
        /// <summary>
        /// Operação realizada com sucesso.
        /// </summary>
        OK = 200,

        /// <summary>
        /// Recurso criado com sucesso.
        /// </summary>
        Created = 201,
        #endregion

        #region 4xx Codes (Invalid, operation aborted)
        /// <summary>
        /// Regras de validação não atendidas e/ou operação não permitida. (Operação não executada)
        /// </summary>
        BadRequest = 400,

        /// <summary>
        /// Restrição de autenticação (ex.: Autenticação necessária)
        /// </summary>
        Unauthorized = 401,

        /// <summary>
        /// Restrição de autorização (ex.: Não possui permissão para esta operação)
        /// </summary>
        Forbidden = 403,

        /// <summary>
        /// Recurso não encontrado
        /// </summary>
        NotFound = 404,

        /// <summary>
        /// Recurso ja existente 
        /// </summary>
        Conflict = 409,
        #endregion

        #region 5xx Codes (Error, server fault)
        /// <summary>
        /// Erro durante o processamento ou exceção não tratada. (Falha)
        /// </summary>
        InternalServerError = 500
        #endregion
    }

}
