using Microsoft.AspNetCore.Mvc;
using WebAppFinal.Models;
using WebAppFinal.Repositories;

namespace WebAppFinal.Controllers;

public class HobbyController : Controller
{
    private readonly IDirtBikeRepository _dirtBikeRepository;
    private readonly IDistanceRunningRepository _distanceRunningRepository;
    private readonly IVideoGameRepository _videoGameRepository;

    public HobbyController(IDirtBikeRepository dirtBikeRepository, IDistanceRunningRepository distanceRunningRepository, IVideoGameRepository videoGameRepository)
    {
        _dirtBikeRepository = dirtBikeRepository;
        _distanceRunningRepository = distanceRunningRepository;
        _videoGameRepository = videoGameRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult DirtBikes()
    {
        var dirtBikes = _dirtBikeRepository.GetAll();
        return View(dirtBikes);
    }

    public IActionResult DirtBikeDetails(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var dirtBike = _dirtBikeRepository.GetById(id.Value);
        if (dirtBike == null)
        {
            return NotFound();
        }

        return View(dirtBike);
    }

    public IActionResult DistanceRuns()
    {
        var distanceRuns = _distanceRunningRepository.GetAll();
        return View(distanceRuns);
    }

    public IActionResult DistanceRunDetails(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var distanceRun = _distanceRunningRepository.GetById(id.Value);
        if (distanceRun == null)
        {
            return NotFound();
        }

        return View(distanceRun);
    }

    public IActionResult VideoGames()
    {
        var videoGames = _videoGameRepository.GetAll();
        return View(videoGames);
    }

    public IActionResult VideoGamesDetails(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var videoGames = _videoGameRepository.GetById(id.Value);
        if (videoGames == null)
        {
            return NotFound();
        }

        return View(videoGames);
    }
}
