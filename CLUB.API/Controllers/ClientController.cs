using AutoMapper;
using CLUB.API.Models;
using CLUB.API.ModelsRequest;
using CLUB.SERVICES.CONTRACTS.Interface;
using CLUB.SERVICES.CONTRACTS.ModelRequest;
using Microsoft.AspNetCore.Mvc;

namespace CLUB.API.Controllers
{
    /// <summary>
    /// CRUD ���������� �� ������ � ������� �������
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = "Client")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService �lientService;
        private readonly IMapper mapper;

        /// <summary>
        /// �������������� ����� ��������� <see cref="ClientController"/>
        /// </summary>
        public ClientController(IClientService clientsService,
            IMapper mapper)
        {
            this.�lientService = clientsService;
            this.mapper = mapper;
        }

        /// <summary>
        /// �������� ������ ���� ��������
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await �lientService.GetAllAsync(cancellationToken);
            return Ok(mapper.Map<IEnumerable<ClientResp>>(result));
        }

        /// <summary>
        /// �������� ������ ������� �� Id
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await �lientService.GetByIdAsync(id, cancellationToken);
            if (item == null) return NotFound($"�� ������� ����� ���� � ��������������� {id}");
            return Ok(mapper.Map<ClientResp>(item));
        }

        /// <summary>
        /// ������ ������ �������
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create(ClientReqCreate request, CancellationToken cancellationToken)
        {

            var ClientReqModel = mapper.Map<ClientReq>(request);
            var result = await �lientService.AddAsync(ClientReqModel, cancellationToken);
            return Ok(mapper.Map<ClientResp>(result));
        }
        /// <summary>
        /// ����������� ������������� �������
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> Edit(ClientReqEdit request, CancellationToken cancellationToken)
        {
            var model = mapper.Map<ClientReq>(request);
            var result = await �lientService.EditAsync(model, cancellationToken);
            return Ok(mapper.Map<ClientResp>(result));
        }


        /// <summary>
        /// ������� ������������� �������
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await �lientService.DeleteAsync(id, cancellationToken);
            return Ok();
        }
    }
}
