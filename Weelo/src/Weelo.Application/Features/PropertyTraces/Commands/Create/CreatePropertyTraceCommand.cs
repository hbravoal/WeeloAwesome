using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;
using Weelo.Domain.Entities;

namespace Weelo.Application.Features.PropertyTraces.Commands.Create
{
    public partial class CreatePropertyTraceCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public decimal Tax { get; set; }
        public DateTime DateSale { get; set; }
        public bool Enabled { get; set; }

    }
    public class CreatePropertyTraceCommandHandler : IRequestHandler<CreatePropertyTraceCommand, Response<int>>
    {
        private readonly IPropertyTraceRepositoryAsync _repository;
        private readonly IMapper _mapper;
        public CreatePropertyTraceCommandHandler(IPropertyTraceRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreatePropertyTraceCommand request, CancellationToken cancellationToken)
        {
            var resultMap = _mapper.Map<PropertyTrace>(request);
            await _repository.AddAsync(resultMap);
            return new Response<int>(resultMap.Id);
        }
    }
}
