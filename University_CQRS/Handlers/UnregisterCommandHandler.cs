﻿
using MediatR;
using University_CQRS.Commands;
using University_CQRS.Dtos;
using University_CQRS.Persistance.Entities.Students;
using University_CQRS.Persistance.Repositories;

namespace University_CQRS.Handlers
{
    public class UnregisterCommandHandler : IRequestHandler<UnregisterCommand, ResultDto>
    {
        private readonly StudentRepository _studentRepository;

        public UnregisterCommandHandler(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<ResultDto> Handle(UnregisterCommand request, CancellationToken cancellationToken)
        {
            Student student = _studentRepository.GetById(request.Id);
            if (student == null)
                throw new Exception($"No student found for Id {request.Id}");

            _studentRepository.Delete(student);

            return new ResultDto(request.Id, true);
        }
    }
}