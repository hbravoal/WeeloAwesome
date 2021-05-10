using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;
using Weelo.Domain.Entities;

namespace Weelo.Application.Features.Owners.Commands.Create
{
    public partial class CreateOwnerCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }

    }
    public class CreateOwnerCommandHandler : IRequestHandler<CreateOwnerCommand, Response<int>>
    {
        private readonly IOwnerRepositoryAsync _repository;
        private readonly IMapper _mapper;
        public CreateOwnerCommandHandler(IOwnerRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateOwnerCommand request, CancellationToken cancellationToken)
        {
            var resultMap = _mapper.Map<Owner>(request);
            await _repository.AddAsync(resultMap);
            return new Response<int>(resultMap.Id);
        }
    }
}
