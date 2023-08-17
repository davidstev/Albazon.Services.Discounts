using Albazon.Services.Discounts.Api.Data;
using Albazon.Services.Discounts.Api.Models;
using Albazon.Services.Discounts.Api.Models.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Albazon.Services.Discounts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<DiscountController> _logger;
        private readonly DiscountsDbContext _context;
        private ResponseDto _responseDto;

        public DiscountController(ILogger<DiscountController> logger, IMapper mapper, DiscountsDbContext context, ResponseDto responseDto)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
            _responseDto = responseDto;
        }


        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                _responseDto.Response = _mapper.Map<IEnumerable<DiscountDto>>(
                    _context.Discounts.ToList()
                    ) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed To Retrieve Discounts");
                throw;
            }

            return _responseDto;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                _responseDto.Response = _mapper.Map<DiscountDto>(
                    _context.Discounts.First(d => d.Id == id)
                    );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed To Retrieve Discount With Id {id}", id);
                throw;
            }

            return _responseDto;
        }
    }
}
