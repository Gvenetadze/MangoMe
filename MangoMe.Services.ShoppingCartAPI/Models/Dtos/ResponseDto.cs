namespace MangoMe.Services.ShoppingCartAPI.Models.Dto;

public class ResponseDto
{
    public object? Result { get; set; }
    public bool isSucces { get; set; } = true;
    public string Message { get; set; } = "";
}
