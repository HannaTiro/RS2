﻿using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Korisnik;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _service;

        public KorisnikController(IKorisnikService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Data.Model.Korisnik>> Get([FromQuery] KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Data.Model.Korisnik> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public ActionResult<Data.Model.Korisnik> Insert(KorisnikUpsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public ActionResult<Data.Model.Korisnik> Update(int id, [FromBody] KorisnikUpsert request)
        {
            return _service.Update(id, request);
        }

    }
}