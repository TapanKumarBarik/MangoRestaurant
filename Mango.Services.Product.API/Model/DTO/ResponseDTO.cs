namespace Mango.Services.Product.API.Model.DTO
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; } = true;
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessage { get; set; }
        public object Result { get; set; }
    }
}
