using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CorePractise01.Contracts.Services;
using CorePractise01.Contracts.ViewModels;
using CorePractise01.Contracts.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace CorePractise01.Webapp.Controllers
{
    [Authorize]
    public class FeedController : Controller
    {
        private readonly IFeedService _feedService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FeedController(IFeedService feedService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _feedService = feedService;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Feed
        public ActionResult Index()
        {
            IList<FeedDto> viewModel = _feedService.GetFeedsWithinDateRange(DateTime.UtcNow.AddDays(-7), DateTime.UtcNow);
            return View(viewModel);
        }

        // GET: Feed/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Feed/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Feed/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateFeedViewModel viewModel)
        {
            if (viewModel == null)
            {
                return BadRequest();
            }

            try
            {
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

                var newFeedDto = _mapper.Map<FeedDto>(viewModel);
                newFeedDto.UserId = userId;
                _feedService.AddNewFeed(newFeedDto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("1", "Error adding feed");
                return View(viewModel);
            }
        }

        // GET: Feed/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Feed/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Feed/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Feed/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}