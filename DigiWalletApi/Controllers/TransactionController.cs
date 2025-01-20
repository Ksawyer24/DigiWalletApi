using AutoMapper;
using DigiWalletApi.Data;
using DigiWalletApi.Dto;
using DigiWalletApi.Repos;
using DigiWalletApi.Repos.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigiWalletApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly DigiContext digiContext;
        private readonly ITransactionRepo transactionRepo;
        private readonly IMapper mapper;

        public TransactionController(DigiContext digiContext,ITransactionRepo transactionRepo,IMapper mapper)
        {
            this.digiContext = digiContext;
            this.transactionRepo = transactionRepo;
            this.mapper = mapper;
        }




        [HttpGet]
        public async Task<IActionResult> GetWallet()
        {
            var ret = await transactionRepo.GetAllTransactionAsync();

            var retdto = mapper.Map<List<TransactionDto>>(ret);

            return Ok(retdto);

        }

        [HttpGet]
        [Route("{id:long}")]

        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {

            var eco = await transactionRepo.GetTransactionIdAsync(id);

            if (eco == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<TransactionDto>(eco));

        }
    }
}
