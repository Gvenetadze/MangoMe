﻿namespace MangoMe.Services.OrderAPI.Models.Dto;

public class ResponseDto
{
    public object? Result { get; set; }
    public bool isSucces { get; set; } = true;
    public string Message { get; set; } = "";
}
