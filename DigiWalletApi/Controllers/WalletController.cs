using AutoMapper;
using DigiWalletApi.Data;
using DigiWalletApi.Dto;
using DigiWalletApi.Models;
using DigiWalletApi.Repos.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigiWalletApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class WalletController : ControllerBase
    {
        private readonly DigiContext digiContext;
        private readonly IWalletRepo walletRepo;
        private readonly IMapper mapper;

        public WalletController(DigiContext digiContext, IWalletRepo walletRepo, IMapper mapper)
        {
            this.digiContext = digiContext;
            this.walletRepo = walletRepo;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetWallet()
        {
            var ret = await walletRepo.GetAllWalletsAsync();

            var retdto = mapper.Map<List<WalletDto>>(ret);

            return Ok(retdto);

        }

        [HttpGet]
        [Route("{id:long}")]

        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {



            var eco = await walletRepo.GetWalletIdAsync(id);

            if (eco == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WalletDto>(eco));

        }




        [HttpPost]
        public async Task<IActionResult> AddWallet(AddWalletDto addWalletDto)
        {
            var addmod = mapper.Map<Wallet>(addWalletDto);

            addmod = await walletRepo.CreateAsync(addmod);  

            var ecdto = mapper.Map<WalletDto>(addmod); 

            return CreatedAtAction(nameof(GetById), new {id = ecdto.Id}, ecdto);

        }



    }
}
