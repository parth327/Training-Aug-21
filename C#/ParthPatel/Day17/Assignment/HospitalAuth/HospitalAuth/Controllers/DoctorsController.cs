using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HospitalAuth.Authentication;
using HospitalAuth.Respository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HospitalAuth.Models;

namespace HospitalAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly IHospitalRepository _hospitalRepository;
        private readonly IMapper _mapper;

        public DoctorsController(IHospitalRepository hospitalRepository, IMapper mapper)
        {
            _hospitalRepository = hospitalRepository ??
                throw new ArgumentNullException(nameof(hospitalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Doctor>> GetDoctors()
        {
            var DoctorsFromRepo = _hospitalRepository.GetDoctors();

            return Ok(DoctorsFromRepo);
        }

        [HttpGet("{doctorId}", Name = "GetDoctor")]
        public ActionResult<Doctor> GetDoctor(int doctorId)
        {
            var doctorFromRepo = _hospitalRepository.GetDoctor(doctorId);

            if (doctorFromRepo == null)
            {
                return NotFound();
            }

            return Ok(doctorFromRepo);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult<Doctor> AddDoctor(DoctorForCreationDto doctor)
        {
            var doctorEntity = _mapper.Map<Models.Doctor>(doctor);
            _hospitalRepository.AddDoctor(doctorEntity);
            _hospitalRepository.Save();

            return CreatedAtRoute("GetDoctor", new { doctorId = doctorEntity.DoctorId }, doctorEntity);
        }

        [HttpDelete("{doctorId}")]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult DeleteDoctor(int doctorId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var DoctorToDelete = _hospitalRepository.GetDoctor(doctorId);
            _hospitalRepository.DeleteDoctor(DoctorToDelete);

            return Ok(DoctorToDelete);
        }

    }
}



