﻿using Microsoft.AspNet.Identity;
using MovieRater.Models;
using MovieRater.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRater.Controllers
{
    [Authorize]
    public class MovieController : ApiController
    {
        private MovieService CreateMovieService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var movieService = new MovieService(userId);
            return movieService;
        }

        public IHttpActionResult Post(MovieCreate movie)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateMovieService();

            if (!service.CreateMovie(movie))
                return InternalServerError();

            return Ok();

        }
    }
}
