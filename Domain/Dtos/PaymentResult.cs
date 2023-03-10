using System;
namespace Domain.Dtos
{
	public class PaymentResult
	{
        public PaymentResult()
        {

        }
        public PaymentResult(string status, string errorCode, string errorGroup, string errorMessage)
        {
            Status = status;
            ErrorCode = errorCode;
            ErrorGroup = errorGroup;
            ErrorMessage = errorMessage;
        }
        public string Status { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorGroup { get; set; }
        public string ErrorMessage { get; set; }
    }
}

