using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PosterTask.Models;
using PosterTask.ViewModels;

namespace PosterTask.Controllers
{
	public class PostController : Controller
	{
		private readonly PosterDbContext context;

		public PostController(PosterDbContext _context)
        {
			this.context = _context;
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Post post)
		{
			Post postToAdd = new Post()
			{
				Title = post.Title,
				Category = post.Category,
				Body = post.Body,
				Likes = post.Likes,
				Share = post.Share,
				UserId = post.UserId,

			};
			context.Posts.Add(postToAdd);
			context.SaveChanges();
			return RedirectToAction(nameof(GetAll));
		}
		// Read All
		[HttpGet]
        public IActionResult GetAll()
		{
			var posts = context.Posts.Include(u => u.User).ToList();
			return View(posts);
		}

		// Read post by id
		public IActionResult PostDetails(int id)
		{
			Post? post = context.Posts.Include(u => u.User).SingleOrDefault(p => p.Id == id);
			if (post == null) return Content("Post not found");
			return View(post);
		}


		// Update

		[HttpGet]
		public IActionResult Edit(int id)
		{
			Post post = context.Posts.Include(u => u.User).SingleOrDefault(p =>p.Id == id);
			return View(post);
		}

		[HttpPost]
		public IActionResult Edit(Post post)
		{
			Post? postToUpdate = context.Posts.SingleOrDefault(p => p.Id == post.Id);
			postToUpdate.Title = post.Title;
			postToUpdate.Category = post.Category;
			postToUpdate.Body = post.Body;
			context.SaveChanges();
			return RedirectToAction(nameof(GetAll));
		}

		//Delete
		public IActionResult Delete(int id)
		{
			Post? post = context.Posts.SingleOrDefault(p => p.Id == id);
			context.Posts.Remove(post);
			context.SaveChanges();
			return RedirectToAction(nameof(GetAll));
		}

	}
}
