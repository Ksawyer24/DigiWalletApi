using AutoMapper;
using DigiWalletApi.Dto;
using DigiWalletApi.Models;

namespace DigiWalletApi.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<Wallet, WalletDto>().ReverseMap();
            CreateMap<AddWalletDto, Wallet>().ReverseMap();
            CreateMap<UpdateWalletDto, Wallet>().ReverseMap();


            CreateMap<Transaction, TransactionDto>().ReverseMap();
            CreateMap<AddTransactionDto, Transaction>().ReverseMap();
           
        }
    }
}
